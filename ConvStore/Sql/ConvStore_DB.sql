-- Begin File: Database.sql
	IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'ConvStore_DB')
	BEGIN
		CREATE DATABASE ConvStore_DB;
	END;
	GO

	USE ConvStore_DB;
	GO
-- End File: Database.sql

-- Begin File: Table.sql
USE ConvStore_DB;
GO

--Note: User and Order need to be in square brackets ([User] and [Order]) because they're hardcoded keywords in SQL Server

-- Drop foreign key constraints
IF OBJECT_ID('FK_OrderProducts_Order', 'F') IS NOT NULL
    ALTER TABLE OrderProducts DROP CONSTRAINT FK_OrderProducts_Order;
GO

IF OBJECT_ID('FK_OrderProducts_Product', 'F') IS NOT NULL
    ALTER TABLE OrderProducts DROP CONSTRAINT FK_OrderProducts_Product;
GO

IF OBJECT_ID('FK_Notification_User', 'F') IS NOT NULL
    ALTER TABLE Notification DROP CONSTRAINT FK_Notification_User;
GO

IF OBJECT_ID('FK_Notification_Order', 'F') IS NOT NULL
    ALTER TABLE Notification DROP CONSTRAINT FK_Notification_Order;
GO

IF OBJECT_ID('FK_Notification_Supplier', 'F') IS NOT NULL
    ALTER TABLE Notification DROP CONSTRAINT FK_Notification_Supplier;
GO

IF OBJECT_ID('FK_Changelog_User', 'F') IS NOT NULL
    ALTER TABLE Changelog DROP CONSTRAINT FK_Changelog_User;
GO

IF OBJECT_ID('FK_Changelog_Product', 'F') IS NOT NULL
    ALTER TABLE Changelog DROP CONSTRAINT FK_Changelog_Product;
GO

IF OBJECT_ID('FK_Inventory_Product', 'F') IS NOT NULL
    ALTER TABLE Inventory DROP CONSTRAINT FK_Inventory_Product;
GO

-- Drop tables
IF OBJECT_ID('dbo.OrderProducts', 'U') IS NOT NULL
    DROP TABLE dbo.OrderProducts;
GO

IF OBJECT_ID('dbo.Notification', 'U') IS NOT NULL
    DROP TABLE dbo.Notification;
GO

IF OBJECT_ID('dbo.Changelog', 'U') IS NOT NULL
    DROP TABLE dbo.Changelog;
GO

IF OBJECT_ID('dbo.Inventory', 'U') IS NOT NULL
    DROP TABLE dbo.Inventory;
GO

IF OBJECT_ID('dbo.Product', 'U') IS NOT NULL
    DROP TABLE dbo.Product;
GO

IF OBJECT_ID('dbo.[Order]', 'U') IS NOT NULL
    DROP TABLE dbo.[Order];
GO

IF OBJECT_ID('dbo.Supplier', 'U') IS NOT NULL
    DROP TABLE dbo.Supplier;
GO

IF OBJECT_ID('dbo.[User]', 'U') IS NOT NULL
    DROP TABLE dbo.[User];
GO

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
    PhoneNumber VARCHAR(20) NOT NULL,
    IsActive BIT NOT NULL DEFAULT 1
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
    Quantity INT NOT NULL CHECK (Quantity > 0),
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
-- End File: Table.sql

-- Begin File: Trigger.sql
USE ConvStore_DB;
GO

IF OBJECT_ID('trg_PreventOverOrder', 'TR') IS NOT NULL
    DROP TRIGGER trg_PreventOverOrder;
GO

IF OBJECT_ID('trg_AutoCreateOrderNotification', 'TR') IS NOT NULL
    DROP TRIGGER trg_AutoCreateOrderNotification;
GO

IF OBJECT_ID('trg_PreventOrderCancellation', 'TR') IS NOT NULL
    DROP TRIGGER trg_PreventOrderCancellation;
GO

IF OBJECT_ID('trg_CreateSQLAccount', 'TR') IS NOT NULL
    DROP TRIGGER trg_CreateSQLAccount;
GO

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

CREATE TRIGGER trg_CreateSQLAccount
ON [User]
AFTER INSERT
AS
BEGIN
    DECLARE @username VARCHAR(50), @password VARCHAR(255);
    SELECT @username = i.Username, @password = i.Password
    FROM inserted i;

    DECLARE @sqlString NVARCHAR(2000);

    -- Create SQL Server login
    SET @sqlString = 'CREATE LOGIN [' + @username + '] WITH PASSWORD = ''' + @password + ''', ' +
                     'DEFAULT_DATABASE = [ConvStore_DB], CHECK_EXPIRATION = OFF, CHECK_POLICY = OFF';
    EXEC (@sqlString);

    -- Create SQL Server user
    SET @sqlString = 'CREATE USER [' + @username + '] FOR LOGIN [' + @username + ']';
    EXEC (@sqlString);
END;
GO
-- End File: Trigger.sql

-- Begin File: View.sql
USE ConvStore_DB;
GO

IF OBJECT_ID('vw_AllOrders', 'V') IS NOT NULL
    DROP VIEW vw_AllOrders;
GO

IF OBJECT_ID('vw_Inventory', 'V') IS NOT NULL
    DROP VIEW vw_Inventory;
GO

IF OBJECT_ID('vw_UserRolesAndPermissions', 'V') IS NOT NULL
    DROP VIEW vw_UserRolesAndPermissions;
GO

IF OBJECT_ID('vw_Notifications', 'V') IS NOT NULL
    DROP VIEW vw_Notifications;
GO

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
-- End File: View.sql

-- Begin File: Procedure.sql
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

IF OBJECT_ID('usp_AssignUserRole', 'P') IS NOT NULL
    DROP PROCEDURE usp_AssignUserRole;
GO

IF OBJECT_ID('usp_AddUser', 'P') IS NOT NULL
    DROP PROCEDURE usp_AddUser;
GO

IF OBJECT_ID('usp_UpdateUser', 'P') IS NOT NULL
    DROP PROCEDURE usp_UpdateUser;
GO

IF OBJECT_ID('usp_DeleteUser', 'P') IS NOT NULL
    DROP PROCEDURE usp_DeleteUser;
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
    SELECT SupplierID, Name, Email, Code, PhoneNumber, IsActive
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
        op.Quantity,
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

CREATE PROCEDURE usp_AssignUserRole
    @userID INT,
    @errorMessage NVARCHAR(MAX) OUTPUT
AS
BEGIN
    SET XACT_ABORT ON;
    BEGIN TRAN;
    BEGIN TRY
        DECLARE @roleName VARCHAR(50), @username VARCHAR(50);
        DECLARE @sqlString NVARCHAR(1000);

        -- Get role and username from User table
        SELECT @roleName = Role, @username = Username
        FROM [User]
        WHERE UserID = @userID;

        -- Validate user and role
        IF @username IS NULL
        BEGIN
            SET @errorMessage = 'User not found.';
            ROLLBACK;
            RETURN;
        END;

        IF @roleName IS NULL OR @roleName NOT IN ('Staff', 'Manager')
        BEGIN
            SET @errorMessage = 'Invalid or missing role. Role must be Staff or Manager.';
            ROLLBACK;
            RETURN;
        END;

        -- Assign user to SQL Server role
        IF @roleName = 'Manager'
            SET @sqlString = 'ALTER SERVER ROLE sysadmin ADD MEMBER [' + @username + ']';
        ELSE
            SET @sqlString = 'ALTER ROLE Staff ADD MEMBER [' + @username + ']';
        EXEC (@sqlString);

        SET @errorMessage = 'Role assigned successfully.';
        COMMIT TRAN;
    END TRY
    BEGIN CATCH
        ROLLBACK;
        SET @errorMessage = 'Error: ' + ERROR_MESSAGE();
    END CATCH;
END;
GO

--DECLARE @error NVARCHAR(MAX);
--EXEC AssignUserRole @userID = 1, @errorMessage = @error OUTPUT;
--SELECT @error AS ErrorMessage;

CREATE PROCEDURE usp_AddUser
    @username VARCHAR(50),
    @password VARCHAR(255),
    @role VARCHAR(50),
    @storeBranch VARCHAR(50),
    @permission VARCHAR(50),
    @executedByUserID INT, -- ID of the user executing the procedure (for permission check)
    @errorMessage NVARCHAR(MAX) OUTPUT
AS
BEGIN
    SET XACT_ABORT ON;
    BEGIN TRAN;
    BEGIN TRY
        -- Check if executedByUserID has Manager role and FullAccess permission
        IF NOT EXISTS (
            SELECT 1 FROM [User]
            WHERE UserID = @executedByUserID AND Role = 'Manager' AND Permission = 'FullAccess'
        )
        BEGIN
            SET @errorMessage = 'Only Managers with FullAccess can add users.';
            ROLLBACK;
            RETURN;
        END;

        -- Validate inputs
        IF LEN(@password) < 8
        BEGIN
            SET @errorMessage = 'Password must be at least 8 characters.';
            ROLLBACK;
            RETURN;
        END;

        IF @role NOT IN ('Staff', 'Manager')
        BEGIN
            SET @errorMessage = 'Role must be Staff or Manager.';
            ROLLBACK;
            RETURN;
        END;

        IF @permission NOT IN ('ReadOnly', 'FullAccess')
        BEGIN
            SET @errorMessage = 'Permission must be ReadOnly or FullAccess.';
            ROLLBACK;
            RETURN;
        END;

        -- Check if username is unique
        IF EXISTS (SELECT 1 FROM [User] WHERE Username = @username)
        BEGIN
            SET @errorMessage = 'Username already exists.';
            ROLLBACK;
            RETURN;
        END;

        -- Insert user (triggers CreateSQLAccount)
        INSERT INTO [User] (Username, Password, Role, StoreBranch, Permission)
        VALUES (@username, @password, @role, @storeBranch, @permission);

        DECLARE @newUserID INT = SCOPE_IDENTITY();

        -- Assign SQL Server role
        EXEC usp_AssignUserRole @userID = @newUserID, @errorMessage = @errorMessage OUTPUT;
        IF @errorMessage NOT LIKE 'Role assigned successfully.'
        BEGIN
            ROLLBACK;
            RETURN;
        END;

        -- Log action in Changelog
        INSERT INTO Changelog (UserID, ChangedData, Timestamp, PaymentAmount, Invoice)
        VALUES (
            @executedByUserID,
            'Added user: ' + @username + ' (Role: ' + @role + ', Permission: ' + @permission + ')',
            GETDATE(),
            0,
            NULL
        );

        SET @errorMessage = 'User added successfully.';
        COMMIT TRAN;
    END TRY
    BEGIN CATCH
        ROLLBACK;
        SET @errorMessage = 'Error: ' + ERROR_MESSAGE();
    END CATCH;
END;
GO

--DECLARE @error NVARCHAR(MAX);
--EXEC usp_AddUser
--    @username = 'staff2',
--    @password = 'password456',
--    @role = 'Staff',
--    @storeBranch = 'BranchB',
--    @permission = 'ReadOnly',
--    @executedByUserID = 1, -- Manager's UserID
--    @errorMessage = @error OUTPUT;
--SELECT @error;

CREATE PROCEDURE [dbo].[UpdateUser]
    @userID INT,
    @username VARCHAR(50),
    @password VARCHAR(255) = NULL, -- Optional
    @role VARCHAR(50),
    @storeBranch VARCHAR(50),
    @permission VARCHAR(50),
    @executedByUserID INT,
    @errorMessage NVARCHAR(MAX) OUTPUT
AS
BEGIN
    SET XACT_ABORT ON;
    BEGIN TRAN;
    BEGIN TRY
        -- Check if executedByUserID has Manager role and FullAccess permission
        IF NOT EXISTS (
            SELECT 1 FROM [User]
            WHERE UserID = @executedByUserID AND Role = 'Manager' AND Permission = 'FullAccess'
        )
        BEGIN
            SET @errorMessage = 'Only Managers with FullAccess can update users.';
            ROLLBACK;
            RETURN;
        END;

        -- Check if user exists
        IF NOT EXISTS (SELECT 1 FROM [User] WHERE UserID = @userID)
        BEGIN
            SET @errorMessage = 'User not found.';
            ROLLBACK;
            RETURN;
        END;

        -- Validate inputs
        IF @password IS NOT NULL AND LEN(@password) < 8
        BEGIN
            SET @errorMessage = 'Password must be at least 8 characters.';
            ROLLBACK;
            RETURN;
        END;

        IF @role NOT IN ('Staff', 'Manager')
        BEGIN
            SET @errorMessage = 'Role must be Staff or Manager.';
            ROLLBACK;
            RETURN;
        END;

        IF @permission NOT IN ('ReadOnly', 'FullAccess')
        BEGIN
            SET @errorMessage = 'Permission must be ReadOnly or FullAccess.';
            ROLLBACK;
            RETURN;
        END;

        -- Check if username is unique (if changed)
        IF EXISTS (
            SELECT 1 FROM [User]
            WHERE Username = @username AND UserID != @userID
        )
        BEGIN
            SET @errorMessage = 'Username already exists.';
            ROLLBACK;
            RETURN;
        END;

        -- Get current role for comparison
        DECLARE @currentRole VARCHAR(50);
        SELECT @currentRole = Role FROM [User] WHERE UserID = @userID;

        -- Update user
        UPDATE [User]
        SET
            Username = @username,
            Password = ISNULL(@password, Password), -- Only update if provided
            Role = @role,
            StoreBranch = @storeBranch,
            Permission = @permission
        WHERE UserID = @userID;

        -- Update SQL Server role if role changed
        IF @currentRole != @role
        BEGIN
            -- Remove from old role
            DECLARE @sqlString NVARCHAR(1000);
            DECLARE @currentUsername VARCHAR(50) = (SELECT Username FROM [User] WHERE UserID = @userID);
            IF @currentRole = 'Manager'
                SET @sqlString = 'ALTER SERVER ROLE sysadmin DROP MEMBER [' + @currentUsername + ']';
            ELSE
                SET @sqlString = 'ALTER ROLE Staff DROP MEMBER [' + @currentUsername + ']';
            EXEC (@sqlString);

            -- Assign new role
            EXEC usp_AssignUserRole @userID = @userID, @errorMessage = @errorMessage OUTPUT;
            IF @errorMessage NOT LIKE 'Role assigned successfully.'
            BEGIN
                ROLLBACK;
                RETURN;
            END;
        END;

        -- Log action in Changelog
        INSERT INTO Changelog (UserID, ChangedData, Timestamp, PaymentAmount, Invoice)
        VALUES (
            @executedByUserID,
            'Updated user: ' + @username + ' (Role: ' + @role + ', Permission: ' + @permission + ')',
            GETDATE(),
            0,
            NULL
        );

        SET @errorMessage = 'User updated successfully.';
        COMMIT TRAN;
    END TRY
    BEGIN CATCH
        ROLLBACK;
        SET @errorMessage = 'Error: ' + ERROR_MESSAGE();
    END CATCH;
END;
GO

--DECLARE @error NVARCHAR(MAX);
--EXEC UpdateUser
--    @userID = 2,
--    @username = 'staff2_updated',
--    @password = NULL, -- Keep existing password
--    @role = 'Manager',
--    @storeBranch = 'BranchC',
--    @permission = 'FullAccess',
--    @executedByUserID = 1,
--    @errorMessage = @error OUTPUT;
--SELECT @error;

CREATE PROCEDURE usp_DeleteUser
    @userID INT,
    @executedByUserID INT,
    @errorMessage NVARCHAR(MAX) OUTPUT
AS
BEGIN
    SET XACT_ABORT ON;
    BEGIN TRAN;
    BEGIN TRY
        -- Check if executedByUserID has Manager role and FullAccess permission
        IF NOT EXISTS (
            SELECT 1 FROM [User]
            WHERE UserID = @executedByUserID AND Role = 'Manager' AND Permission = 'FullAccess'
        )
        BEGIN
            SET @errorMessage = 'Only Managers with FullAccess can delete users.';
            ROLLBACK;
            RETURN;
        END;

        -- Check if user exists
        IF NOT EXISTS (SELECT 1 FROM [User] WHERE UserID = @userID)
        BEGIN
            SET @errorMessage = 'User not found.';
            ROLLBACK;
            RETURN;
        END;

        -- Get username and role for cleanup
        DECLARE @username VARCHAR(50), @role VARCHAR(50);
        SELECT @username = Username, @role = Role
        FROM [User]
        WHERE UserID = @userID;

        -- Remove from SQL Server role
        DECLARE @sqlString NVARCHAR(1000);
        IF @role = 'Manager'
            SET @sqlString = 'ALTER SERVER ROLE sysadmin DROP MEMBER [' + @username + ']';
        ELSE
            SET @sqlString = 'ALTER ROLE Staff DROP MEMBER [' + @username + ']';
        EXEC (@sqlString);

        -- Drop SQL Server user
        SET @sqlString = 'DROP USER [' + @username + ']';
        EXEC (@sqlString);

        -- Drop SQL Server login
        SET @sqlString = 'DROP LOGIN [' + @username + ']';
        EXEC (@sqlString);

        -- Delete user (foreign keys in Notification, Order, Changelog handle ON DELETE SET NULL)
        DELETE FROM [User] WHERE UserID = @userID;

        -- Log action in Changelog
        INSERT INTO Changelog (UserID, ChangedData, Timestamp, PaymentAmount, Invoice)
        VALUES (
            @executedByUserID,
            'Deleted user: ' + @username,
            GETDATE(),
            0,
            NULL
        );

        SET @errorMessage = 'User deleted successfully.';
        COMMIT TRAN;
    END TRY
    BEGIN CATCH
        ROLLBACK;
        SET @errorMessage = 'Error: ' + ERROR_MESSAGE();
    END CATCH;
END;
GO

--DECLARE @error NVARCHAR(MAX);
--EXEC DeleteUser
--    @userID = 2,
--    @executedByUserID = 1,
--    @errorMessage = @error OUTPUT;
--SELECT @error;
-- End File: Procedure.sql

-- Begin File: Function.sql
USE ConvStore_DB;
GO

IF OBJECT_ID('ufn_GetOrderTotalPrice', 'FN') IS NOT NULL
    DROP FUNCTION ufn_GetOrderTotalPrice;
GO

IF OBJECT_ID('ufn_GetUserRole', 'FN') IS NOT NULL
    DROP FUNCTION ufn_GetUserRole;
GO

IF OBJECT_ID('tvf_GetOrdersByStatus', 'FN') IS NOT NULL
    DROP FUNCTION tvf_GetOrdersByStatus;
GO

IF OBJECT_ID('tvf_GetLowStockProducts', 'FN') IS NOT NULL
    DROP FUNCTION tvf_GetLowStockProducts;
GO

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
-- End File: Function.sql

