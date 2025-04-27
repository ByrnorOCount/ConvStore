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

IF OBJECT_ID('usp_RevokeUserRole', 'P') IS NOT NULL
    DROP PROCEDURE usp_RevokeUserRole;
GO

IF OBJECT_ID('usp_GrantSpecificPermission', 'P') IS NOT NULL
    DROP PROCEDURE usp_GrantSpecificPermission;
GO

IF OBJECT_ID('usp_RevokeSpecificPermission', 'P') IS NOT NULL
    DROP PROCEDURE usp_RevokeSpecificPermission;
GO

IF OBJECT_ID('usp_AddSupplier', 'P') IS NOT NULL
    DROP PROCEDURE usp_AddSupplier;
GO

IF OBJECT_ID('usp_UpdateSupplier', 'P') IS NOT NULL
    DROP PROCEDURE usp_UpdateSupplier;
GO

IF OBJECT_ID('usp_DeleteSupplier', 'P') IS NOT NULL
    DROP PROCEDURE usp_DeleteSupplier;
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
            SET @sqlString = 'ALTER SERVER ROLE Manager ADD MEMBER [' + @username + ']';
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

CREATE PROCEDURE usp_UpdateUser
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
                SET @sqlString = 'ALTER SERVER ROLE Manager DROP MEMBER [' + @currentUsername + ']';
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
            SET @sqlString = 'ALTER SERVER ROLE Manager DROP MEMBER [' + @username + ']';
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

CREATE PROCEDURE usp_RevokeUserRole
    @userID INT,
    @executedByUserID INT,
    @errorMessage NVARCHAR(MAX) OUTPUT
AS
BEGIN
    SET XACT_ABORT ON;
    BEGIN TRAN;
    BEGIN TRY
        -- Check if executedByUserID has Manager role and FullAccess permission
        IF NOT EXISTS (SELECT 1 FROM [User] WHERE UserID = @executedByUserID AND Role = 'Manager' AND Permission = 'FullAccess')
        BEGIN
            SET @errorMessage = 'Only Managers with FullAccess can revoke roles.';
            ROLLBACK;
            RETURN;
        END;

        -- Get username and role
        DECLARE @username VARCHAR(50), @role VARCHAR(50);
        SELECT @username = Username, @role = Role FROM [User] WHERE UserID = @userID;
        IF @username IS NULL
        BEGIN
            SET @errorMessage = 'User not found.';
            ROLLBACK;
            RETURN;
        END;

        -- Remove from SQL Server role
        DECLARE @sqlString NVARCHAR(1000);
        IF @role = 'Manager'
            SET @sqlString = 'ALTER SERVER ROLE Manager DROP MEMBER [' + @username + ']';
        ELSE
            SET @sqlString = 'ALTER ROLE Staff DROP MEMBER [' + @username + ']';
        EXEC (@sqlString);

        -- Update Role to a non-NULL value (e.g., 'None') instead of NULL
        UPDATE [User] SET Role = 'None' WHERE UserID = @userID;

        -- Log action in Changelog
        INSERT INTO Changelog (UserID, ChangedData, Timestamp, PaymentAmount, Invoice)
        VALUES (@executedByUserID, 'Revoked role for user: ' + @username, GETDATE(), 0, NULL);

        SET @errorMessage = 'Role revoked successfully.';
        COMMIT TRAN;
    END TRY
    BEGIN CATCH
        ROLLBACK;
        SET @errorMessage = 'Error: ' + ERROR_MESSAGE();
    END CATCH;
END;
GO

CREATE PROCEDURE usp_GrantSpecificPermission
    @userID INT,
    @tableName NVARCHAR(128),
    @permission NVARCHAR(50), -- e.g., 'SELECT', 'INSERT', 'UPDATE', 'DELETE'
    @executedByUserID INT,
    @errorMessage NVARCHAR(MAX) OUTPUT
AS
BEGIN
    SET XACT_ABORT ON; BEGIN TRAN;
    BEGIN TRY
        IF NOT EXISTS (SELECT 1 FROM [User] WHERE UserID = @executedByUserID AND Role = 'Manager' AND Permission = 'FullAccess')
        BEGIN
            SET @errorMessage = 'Only Managers with FullAccess can grant permissions.'; ROLLBACK; RETURN;
        END;
        DECLARE @username VARCHAR(50);
        SELECT @username = Username FROM [User] WHERE UserID = @userID;
        IF @username IS NULL
        BEGIN
            SET @errorMessage = 'User not found.'; ROLLBACK; RETURN;
        END;
        DECLARE @sqlString NVARCHAR(1000);
        SET @sqlString = 'GRANT ' + @permission + ' ON [' + @tableName + '] TO [' + @username + ']';
        EXEC (@sqlString);
        INSERT INTO Changelog (UserID, ChangedData, Timestamp, PaymentAmount, Invoice)
        VALUES (@executedByUserID, 'Granted ' + @permission + ' on ' + @tableName + ' to ' + @username, GETDATE(), 0, NULL);
        SET @errorMessage = 'Permission granted successfully.'; COMMIT TRAN;
    END TRY
    BEGIN CATCH
        ROLLBACK; SET @errorMessage = 'Error: ' + ERROR_MESSAGE();
    END CATCH;
END;
GO

CREATE PROCEDURE usp_RevokeSpecificPermission
    @userID INT,
    @tableName NVARCHAR(128),
    @permission NVARCHAR(50),
    @executedByUserID INT,
    @errorMessage NVARCHAR(MAX) OUTPUT
AS
BEGIN
    SET XACT_ABORT ON; BEGIN TRAN;
    BEGIN TRY
        IF NOT EXISTS (SELECT 1 FROM [User] WHERE UserID = @executedByUserID AND Role = 'Manager' AND Permission = 'FullAccess')
        BEGIN
            SET @errorMessage = 'Only Managers with FullAccess can revoke permissions.'; ROLLBACK; RETURN;
        END;
        DECLARE @username VARCHAR(50);
        SELECT @username = Username FROM [User] WHERE UserID = @userID;
        IF @username IS NULL
        BEGIN
            SET @errorMessage = 'User not found.'; ROLLBACK; RETURN;
        END;
        DECLARE @sqlString NVARCHAR(1000);
        SET @sqlString = 'REVOKE ' + @permission + ' ON [' + @tableName + '] FROM [' + @username + ']';
        EXEC (@sqlString);
        INSERT INTO Changelog (UserID, ChangedData, Timestamp, PaymentAmount, Invoice)
        VALUES (@executedByUserID, 'Revoked ' + @permission + ' on ' + @tableName + ' from ' + @username, GETDATE(), 0, NULL);
        SET @errorMessage = 'Permission revoked successfully.'; COMMIT TRAN;
    END TRY
    BEGIN CATCH
        ROLLBACK; SET @errorMessage = 'Error: ' + ERROR_MESSAGE();
    END CATCH;
END;
GO

--DECLARE @error NVARCHAR(MAX);
--EXEC DeleteUser
--    @userID = 2,
--    @executedByUserID = 1,
--    @errorMessage = @error OUTPUT;
--SELECT @error;

CREATE PROCEDURE usp_AddSupplier
    @name VARCHAR(50),
    @email VARCHAR(100),
    @code VARCHAR(50),
    @phoneNumber VARCHAR(20),
    @isActive BIT,
    @errorMessage NVARCHAR(MAX) OUTPUT
AS
BEGIN
    SET XACT_ABORT ON;
    BEGIN TRAN;
    BEGIN TRY
        -- Validate inputs
        IF LEN(@name) = 0 OR LEN(@email) = 0 OR LEN(@code) = 0 OR LEN(@phoneNumber) = 0
        BEGIN
            SET @errorMessage = 'All fields are required.';
            ROLLBACK;
            RETURN;
        END;
        -- Check if supplier code is unique
        IF EXISTS (SELECT 1 FROM Supplier WHERE Code = @code)
        BEGIN
            SET @errorMessage = 'Supplier code already exists.';
            ROLLBACK;
            RETURN;
        END;
        -- Insert supplier
        INSERT INTO Supplier (Name, Email, Code, PhoneNumber, IsActive)
        VALUES (@name, @email, @code, @phoneNumber, @isActive);
        SET @errorMessage = 'Supplier added successfully.';
        COMMIT TRAN;
    END TRY
    BEGIN CATCH
        ROLLBACK;
        SET @errorMessage = 'Error: ' + ERROR_MESSAGE();
    END CATCH;
END;
GO

CREATE PROCEDURE usp_UpdateSupplier
    @supplierID INT,
    @name VARCHAR(50),
    @email VARCHAR(100),
    @code VARCHAR(50),
    @phoneNumber VARCHAR(20),
    @isActive BIT,
    @errorMessage NVARCHAR(MAX) OUTPUT
AS
BEGIN
    SET XACT_ABORT ON;
    BEGIN TRAN;
    BEGIN TRY
        -- Validate inputs
        IF LEN(@name) = 0 OR LEN(@email) = 0 OR LEN(@code) = 0 OR LEN(@phoneNumber) = 0
        BEGIN
            SET @errorMessage = 'All fields are required.';
            ROLLBACK;
            RETURN;
        END;
        -- Check if supplier exists
        IF NOT EXISTS (SELECT 1 FROM Supplier WHERE SupplierID = @supplierID)
        BEGIN
            SET @errorMessage = 'Supplier not found.';
            ROLLBACK;
            RETURN;
        END;
        -- Update supplier
        UPDATE Supplier
        SET Name = @name,
            Email = @email,
            Code = @code,
            PhoneNumber = @phoneNumber,
            IsActive = @isActive
        WHERE SupplierID = @supplierID;
        SET @errorMessage = 'Supplier updated successfully.';
        COMMIT TRAN;
    END TRY
    BEGIN CATCH
        ROLLBACK;
        SET @errorMessage = 'Error: ' + ERROR_MESSAGE();
    END CATCH;
END;
GO

CREATE PROCEDURE usp_DeleteSupplier
    @supplierID INT,
    @errorMessage NVARCHAR(MAX) OUTPUT
AS
BEGIN
    SET XACT_ABORT ON;
    BEGIN TRAN;
    BEGIN TRY
        -- Check if supplier exists
        IF NOT EXISTS (SELECT 1 FROM Supplier WHERE SupplierID = @supplierID)
        BEGIN
            SET @errorMessage = 'Supplier not found.';
            ROLLBACK;
            RETURN;
        END;
        -- Delete supplier
        DELETE FROM Supplier WHERE SupplierID = @supplierID;
        SET @errorMessage = 'Supplier deleted successfully.';
        COMMIT TRAN;
    END TRY
    BEGIN CATCH
        ROLLBACK;
        SET @errorMessage = 'Error: ' + ERROR_MESSAGE();
    END CATCH;
END;
GO

-- PRODUCT
CREATE OR ALTER PROCEDURE usp_AddProductAndInventory
    @Name NVARCHAR(100),
    @Origin NVARCHAR(100),
    @Status NVARCHAR(50),
    @Price DECIMAL(10,2),
    @ImportLocation NVARCHAR(100),
    @Category NVARCHAR(100), 
    @Code NVARCHAR(50),
    @ProductionDate DATE,
    @ExpiryDate DATE,
    @ImportTime DATETIME2(7),
    @Preservation NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Product (Name, Origin, ProductionDate, ExpiryDate, Status, Price, ImportLocation, Code, ImportTime, Preservation)
    VALUES (@Name, @Origin, @ProductionDate, @ExpiryDate, @Status, @Price, @ImportLocation, @Code, @ImportTime, @Preservation);

    DECLARE @NewProductID INT = SCOPE_IDENTITY();

    INSERT INTO Inventory (ProductID, StorageLocation, Quantity, Category, Status)
    VALUES (@NewProductID, @ImportLocation, 0, @Category, 'In Stock');
END
GO

CREATE PROCEDURE usp_FindProduct
    @Supplier NVARCHAR(100) = NULL,
    @ImportDay NVARCHAR(100) = NULL,
    @ExportDay NVARCHAR(100) = NULL
AS
BEGIN
    SELECT i.InventoryID, p.Name AS ProductName, i.StorageLocation, i.Quantity, i.Category, i.Status
    FROM Inventory i
    INNER JOIN Product p ON i.ProductID = p.ProductID
    WHERE 
        (@Supplier IS NULL OR p.Origin = @Supplier)
        AND (@ImportDay IS NULL OR FORMAT(p.ImportTime, 'yyyy-MM-dd') = @ImportDay)
        AND (@ExportDay IS NULL OR FORMAT(p.ExpiryDate, 'yyyy-MM-dd') = @ExportDay)
END
GO

CREATE PROCEDURE usp_DeleteProduct
    @ProductID INT
AS
BEGIN
    DELETE FROM Product
    WHERE ProductID = @ProductID
END
GO

CREATE OR ALTER PROCEDURE usp_FindProduct
    @Supplier NVARCHAR(100) = NULL,
    @ImportDay NVARCHAR(100) = NULL,
    @ExportDay NVARCHAR(100) = NULL
AS
BEGIN
    SELECT 
        p.ProductID,
        p.Name AS ProductName,
        p.Origin AS Supplier,
        FORMAT(p.ImportTime, 'yyyy-MM-dd') AS ImportDay,
        FORMAT(p.ExpiryDate, 'yyyy-MM-dd') AS ExpiryDay,
        p.Price
    FROM Product p
    WHERE 
        (@Supplier IS NULL OR p.Origin = @Supplier)
        AND (@ImportDay IS NULL OR FORMAT(p.ImportTime, 'yyyy-MM-dd') = @ImportDay)
        AND (@ExportDay IS NULL OR FORMAT(p.ExpiryDate, 'yyyy-MM-dd') = @ExportDay)
END
GO