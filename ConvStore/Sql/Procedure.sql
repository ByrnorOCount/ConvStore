USE ConvStore_DB;
GO

IF OBJECT_ID('usp_GetAllUsers', 'P') IS NOT NULL
    DROP PROCEDURE usp_GetAllUsers;
GO

IF OBJECT_ID('usp_GetAllOrders', 'P') IS NOT NULL
    DROP PROCEDURE usp_GetAllOrders;
GO

IF OBJECT_ID('usp_GetUser', 'P') IS NOT NULL
    DROP PROCEDURE usp_GetUser;
GO

IF OBJECT_ID('usp_LoadNotifications', 'P') IS NOT NULL
    DROP PROCEDURE usp_LoadNotifications;
GO

IF OBJECT_ID('usp_LoadSupplier', 'P') IS NOT NULL
    DROP PROCEDURE usp_LoadSupplier;
GO

IF OBJECT_ID('usp_LoadOrder', 'P') IS NOT NULL
    DROP PROCEDURE usp_LoadOrder;
GO

IF OBJECT_ID('usp_LoadOrderProducts', 'P') IS NOT NULL
    DROP PROCEDURE usp_LoadOrderProducts;
GO

IF OBJECT_ID('usp_LoadInventory', 'P') IS NOT NULL
    DROP PROCEDURE usp_LoadInventory;
GO

IF OBJECT_ID('usp_LoadProducts', 'P') IS NOT NULL
    DROP PROCEDURE usp_LoadProducts;
GO

IF OBJECT_ID('usp_LoadChangeLogs', 'P') IS NOT NULL
    DROP PROCEDURE usp_LoadChangeLogs;
GO

IF OBJECT_ID('usp_AddNewOrder', 'P') IS NOT NULL
    DROP PROCEDURE usp_AddNewOrder;
GO

IF OBJECT_ID('usp_UpdateInventoryQuantity', 'P') IS NOT NULL
    DROP PROCEDURE usp_UpdateInventoryQuantity;
GO

--No parameters
CREATE PROCEDURE usp_GetAllUsers
AS
BEGIN
    SELECT UserID, Username, Role, StoreBranch, Permission FROM [User];
END;
GO

CREATE PROCEDURE usp_LoadSupplier
AS
BEGIN
    SELECT SupplierID, Name, Email, Code, PhoneNumber
    FROM Supplier
END;
GO

CREATE PROCEDURE usp_LoadOrder
AS
BEGIN
    SELECT 
        o.OrderID,
        u.Username AS OrdererName,
        s.Name AS SupplierName,
        o.DeliveryTime,
        o.Status,
        o.Quantity,
        o.Price,
        o.TypeOfGoods
    FROM [Order] o
    LEFT JOIN [User] u ON o.UserID = u.UserID
    LEFT JOIN Supplier s ON o.SupplierID = s.SupplierID
END;
GO

CREATE PROCEDURE usp_LoadInventory
AS
BEGIN
    SELECT
        i.InventoryID,
        p.Name AS ProductName,
        i.StorageLocation,
        i.Quantity,
        i.Category,
        i.Status,
        AVG(p.Price) AS AveragePrice,
        (SELECT COUNT(*) FROM OrderProducts op WHERE op.ProductID = i.ProductID) AS TotalOrders
    FROM Inventory i
    LEFT JOIN Product p ON i.ProductID = p.ProductID
    GROUP BY 
        i.InventoryID,
        p.Name,
        i.StorageLocation,
        i.Quantity,
        i.Category,
        i.Status,
        i.ProductID
END;
GO

CREATE PROCEDURE usp_LoadChangeLogs
AS
BEGIN
    SELECT 
        c.LogID,
        u.Username AS UserName,
        p.Name AS ProductName,
        c.ChangedData,
        c.Timestamp,
        c.PaymentAmount,
        c.Invoice
    FROM Changelog c
    LEFT JOIN [User] u ON c.UserID = u.UserID
    LEFT JOIN Product p ON c.ProductID = p.ProductID
END;
GO

--With parameters
CREATE PROCEDURE usp_GetUser
    @Username VARCHAR(50),
    @Password VARCHAR(200)
AS
BEGIN
    SELECT UserID, Username, Role, StoreBranch, Permission
    FROM [User]
    WHERE Username = @Username AND Password = @Password;
END;
GO

CREATE PROCEDURE usp_LoadNotifications
    @UserID INT
AS
BEGIN
    SELECT 
        n.NotificationID,
        o.OrderID,
        s.Name AS SupplierName,
        n.Time AS NotificationTime,
        n.Message
    FROM Notification n
    LEFT JOIN [Order] o ON n.OrderID = o.OrderID
    LEFT JOIN Supplier s ON n.SupplierID = s.SupplierID
    WHERE n.UserID = @UserID
END;
GO

CREATE PROCEDURE usp_LoadOrderProducts
    @OrderID INT
AS
BEGIN
    SELECT 
        op.ProductID,
        p.Name AS ProductName,
        p.Price,
        p.Origin,
        p.Status
    FROM OrderProducts op
    LEFT JOIN Product p ON op.ProductID = p.ProductID
    WHERE op.OrderID = @OrderID
END;
GO

CREATE PROCEDURE usp_LoadProducts
    @InventoryID INT
AS
BEGIN
    SELECT 
        p.ProductID,
        p.Name AS ProductName,
        p.ExpiryDate,
        p.ProductionDate,
        p.Origin,
        p.Status,
        p.Ingredients,
        p.ImportTime,
        p.ImportLocation,
        p.Code,
        p.Price,
        p.Certification,
        p.Preservation
    FROM Product p
    INNER JOIN Inventory i ON i.ProductID = p.ProductID
    WHERE i.InventoryID = @InventoryID
END;
GO

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