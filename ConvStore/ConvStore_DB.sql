IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'ConvStore_DB')
BEGIN
    CREATE DATABASE ConvStore_DB;
END;
GO

USE ConvStore_DB;
GO

--Note: User and Order need to be in square brackets ([User] and [Order]) because they're hardcoded keywords in SQL Server

--=======================================
--Tables
--=======================================
CREATE TABLE [User] (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    Username VARCHAR(50) UNIQUE NOT NULL,
    Password VARCHAR(255) NOT NULL CHECK (LEN(Password) >= 8),
    Role VARCHAR(50) NOT NULL,
    StoreBranch VARCHAR(50) NOT NULL,
    Permission VARCHAR(50) NOT NULL
);

CREATE TABLE Supplier (
    SupplierID INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Email VARCHAR(100) UNIQUE NOT NULL,
    Code VARCHAR(50) UNIQUE NOT NULL,
    PhoneNumber VARCHAR(20) NOT NULL
);

CREATE TABLE [Order] (
    OrderID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT NOT NULL,
    SupplierID INT NOT NULL,
    DeliveryTime DATETIME2 NOT NULL,
    Status VARCHAR(50) NOT NULL CHECK (Status IN ('Pending', 'Shipped', 'Delivered', 'Cancelled')),
    Quantity INT NOT NULL CHECK (Quantity > 0),
    Price DECIMAL(10,2) NOT NULL CHECK (Price >= 0),
    TypeOfGoods VARCHAR(100) NOT NULL,
    FOREIGN KEY (UserID) REFERENCES [User](UserID),
    FOREIGN KEY (SupplierID) REFERENCES Supplier(SupplierID)
);

CREATE TABLE Product (
    ProductID INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    ExpiryDate DATE,
    ProductionDate DATE NOT NULL,
    Origin VARCHAR(100) NOT NULL,
    Status VARCHAR(50) NOT NULL CHECK (Status IN ('Available', 'Out of Stock', 'Discontinued')),
    Ingredients VARCHAR(MAX), 
    ImportTime DATETIME2 NOT NULL,
    ImportLocation VARCHAR(100) NOT NULL,
    Code VARCHAR(50) UNIQUE NOT NULL,
    Price DECIMAL(10,2) NOT NULL CHECK (Price >= 0),
    Certification VARCHAR(100),
    Preservation VARCHAR(50) NOT NULL
);

CREATE TABLE OrderProducts (
    OrderID INT NOT NULL,
    ProductID INT NOT NULL,
    PRIMARY KEY (OrderID, ProductID),
    FOREIGN KEY (OrderID) REFERENCES [Order](OrderID) ON DELETE CASCADE,
    FOREIGN KEY (ProductID) REFERENCES Product(ProductID) ON DELETE CASCADE
);

CREATE TABLE Inventory (
    InventoryID INT IDENTITY(1,1) PRIMARY KEY,
    ProductID INT NOT NULL,
    StorageLocation VARCHAR(100) NOT NULL,
    Quantity INT NOT NULL CHECK (Quantity >= 0),
    Category VARCHAR(100) NOT NULL,
    Status VARCHAR(50) NOT NULL CHECK (Status IN ('In Stock', 'Low Stock', 'Out of Stock')),
    FOREIGN KEY (ProductID) REFERENCES Product(ProductID)
);

CREATE TABLE Notification (
    NotificationID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT NULL,
    OrderID INT NULL,
    SupplierID INT NULL,
    Time DATETIME2 DEFAULT GETDATE(),
    Message VARCHAR(MAX) NOT NULL,
    FOREIGN KEY (UserID) REFERENCES [User](UserID) ON DELETE SET NULL,
    FOREIGN KEY (OrderID) REFERENCES [Order](OrderID) ON DELETE SET NULL,
    FOREIGN KEY (SupplierID) REFERENCES Supplier(SupplierID) ON DELETE SET NULL
);

CREATE TABLE Changelog (
    LogID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT NOT NULL,
    ProductID INT NULL,
    ChangedData VARCHAR(MAX) NOT NULL,
    Timestamp DATETIME2 DEFAULT GETDATE(),
    PaymentAmount DECIMAL(10,2) NOT NULL CHECK (PaymentAmount >= 0),
    Invoice VARCHAR(100),
    FOREIGN KEY (UserID) REFERENCES [User](UserID),
    FOREIGN KEY (ProductID) REFERENCES Product(ProductID) ON DELETE SET NULL
);
GO


--=======================================
--Triggers (trg_ prefix)
--=======================================
CREATE TRIGGER trg_PreventOverOrder
ON OrderProducts
AFTER INSERT, UPDATE
AS
BEGIN
    IF EXISTS (
        SELECT 1 
        FROM inserted i
        JOIN Inventory inv ON i.ProductID = inv.ProductID
        WHERE i.Quantity > inv.Quantity
    )
    BEGIN
        RAISERROR ('Not enough stock to fulfill the order!', 16, 1);
        ROLLBACK TRANSACTION;
    END
END;
GO

CREATE TRIGGER trg_AutoCreateOrderNotification
ON [Order]
AFTER UPDATE
AS
BEGIN
    INSERT INTO Notification (UserID, OrderID, SupplierID, Time, Message)
    SELECT i.UserID, i.OrderID, i.SupplierID, GETDATE(), 
           CONCAT('Your order #', i.OrderID, ' status changed to ', i.Status)
    FROM inserted i;
END;
GO

CREATE TRIGGER trg_PreventOrderCancellation
ON [Order]
INSTEAD OF UPDATE
AS
BEGIN
    IF EXISTS (
        SELECT 1 
        FROM inserted i
        JOIN deleted d ON i.OrderID = d.OrderID
        WHERE d.Status IN ('Shipped', 'Delivered') AND i.Status = 'Cancelled'
    )
    BEGIN
        RAISERROR ('Cannot cancel an order that has already been shipped or delivered.', 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
    END
END;
GO

--=======================================
--Views (vw_ prefix)
--=======================================
CREATE VIEW vw_AllOrders AS
SELECT 
    o.OrderID, 
    u.Username AS OrderedBy, 
    s.Name AS Supplier, 
    o.DeliveryTime, 
    o.Status, 
    o.Quantity, 
    o.Price, 
    o.TypeOfGoods
FROM [Order] o
JOIN [User] u ON o.UserID = u.UserID
JOIN Supplier s ON o.SupplierID = s.SupplierID;
GO

CREATE VIEW vw_Inventory AS
SELECT 
    i.InventoryID,
    p.Name AS ProductName, 
    i.StorageLocation, 
    i.Quantity, 
    i.Status, 
    i.Category
FROM Inventory i
JOIN Product p ON i.ProductID = p.ProductID;
GO

CREATE VIEW vw_UserRolesAndPermissions AS
SELECT 
    UserID, 
    Username, 
    Role, 
    StoreBranch, 
    Permission
FROM [User];
GO

CREATE VIEW vw_Notifications AS
SELECT 
    n.NotificationID, 
    u.Username AS NotifiedUser, 
    o.OrderID, 
    s.Name AS Supplier, 
    n.Time, 
    n.Message
FROM Notification n
LEFT JOIN [User] u ON n.UserID = u.UserID
LEFT JOIN [Order] o ON n.OrderID = o.OrderID
LEFT JOIN Supplier s ON n.SupplierID = s.SupplierID;
GO

--=======================================
--Stored Procedures (usp_ prefix)
--=======================================

--No parameters
CREATE PROCEDURE usp_GetAllUsers
AS
BEGIN
    SELECT UserID, Username, Role, StoreBranch, Permission FROM [User];
END;
GO

CREATE PROCEDURE usp_GetAllOrders
AS
BEGIN
    SELECT o.OrderID, u.Username AS OrderedBy, s.Name AS Supplier, 
           o.DeliveryTime, o.Status, o.Quantity, o.Price, o.TypeOfGoods
    FROM [Order] o
    JOIN [User] u ON o.UserID = u.UserID
    JOIN Supplier s ON o.SupplierID = s.SupplierID;
END;
GO

--With parameters
CREATE PROCEDURE usp_AddNewOrder
    @UserID INT, @SupplierID INT, @DeliveryTime DATETIME2, @Status VARCHAR(50), @Quantity INT, @Price DECIMAL(10,2), @TypeOfGoods VARCHAR(100)
AS
BEGIN
    INSERT INTO [Order] (UserID, SupplierID, DeliveryTime, Status, Quantity, Price, TypeOfGoods)
    VALUES (@UserID, @SupplierID, @DeliveryTime, @Status, @Quantity, @Price, @TypeOfGoods);
END;
GO

CREATE PROCEDURE usp_UpdateInventoryQuantity
    @ProductID INT, @NewQuantity INT
AS
BEGIN
    UPDATE Inventory
    SET Quantity = @NewQuantity,
        Status = CASE 
            WHEN @NewQuantity = 0 THEN 'Out of Stock'
            WHEN @NewQuantity < 10 THEN 'Low Stock'
            ELSE 'In Stock'
        END
    WHERE ProductID = @ProductID;
END;
GO

--=======================================
--Functions
--=======================================

--Scalar value (ufn_ prefix)
CREATE FUNCTION ufn_GetOrderTotalPrice(@OrderID INT)
RETURNS DECIMAL(10,2)
AS
BEGIN
    DECLARE @TotalPrice DECIMAL(10,2);
    SELECT @TotalPrice = SUM(o.Quantity * p.Price)
    FROM [Order] o
    Join OrderProducts op ON o.OrderID = op.OrderID
    JOIN Product p ON op.ProductID = p.ProductID
    WHERE op.OrderID = @OrderID;
    RETURN ISNULL(@TotalPrice, 0);
END;
GO

CREATE FUNCTION ufn_GetUserRole(@UserID INT)
RETURNS VARCHAR(50)
AS
BEGIN
    DECLARE @Role VARCHAR(50);
    SELECT @Role = Role FROM [User] WHERE UserID = @UserID;
    RETURN @Role;
END;
GO

--Table value (tvf_ prefix)
CREATE FUNCTION tvf_GetOrdersByStatus(@Status VARCHAR(50))
RETURNS TABLE
AS
RETURN
(
    SELECT o.OrderID, u.Username AS OrderedBy, s.Name AS Supplier, 
           o.DeliveryTime, o.Quantity, o.Price, o.TypeOfGoods
    FROM [Order] o
    JOIN [User] u ON o.UserID = u.UserID
    JOIN Supplier s ON o.SupplierID = s.SupplierID
    WHERE o.Status = @Status
);
GO

CREATE FUNCTION tvf_GetLowStockProducts(@Threshold INT)
RETURNS @LowStock TABLE
(
    ProductID INT, Name VARCHAR(100), StorageLocation VARCHAR(100), Quantity INT
)
AS
BEGIN
    INSERT INTO @LowStock
    SELECT p.ProductID, p.Name, i.StorageLocation, i.Quantity
    FROM Inventory i
    JOIN Product p ON i.ProductID = p.ProductID
    WHERE i.Quantity < @Threshold;
    RETURN;
END;
GO

--=======================================
--Sample execution commands
--=======================================
EXEC usp_GetAllUsers;
GO

EXEC usp_GetAllOrders;
GO

EXEC usp_AddNewOrder 
    @UserID = 1, 
    @SupplierID = 2, 
    @DeliveryTime = '2025-04-01 10:00:00', 
    @Status = 'Pending', 
    @Quantity = 50, 
    @Price = 200.00, 
    @TypeOfGoods = 'Electronics';
GO

EXEC usp_UpdateInventoryQuantity 
    @ProductID = 3, 
    @NewQuantity = 5;
GO

SELECT dbo.ufn_GetOrderTotalPrice(1) AS TotalPrice;
GO

SELECT dbo.ufn_GetUserRole(2) AS UserRole;
GO

SELECT * FROM tvf_GetOrdersByStatus('Pending');
GO

SELECT * FROM tvf_GetLowStockProducts(10);
GO