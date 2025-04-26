USE master;
GO
IF EXISTS (SELECT * FROM sys.server_principals WHERE name = 'test_user')
BEGIN
    DROP LOGIN [test_user];
END;
GO

USE ConvStore_DB;
GO

IF EXISTS (SELECT * FROM sys.database_principals WHERE name = 'test_user')
BEGIN
    DROP USER [test_user];
END;
GO

-- Test user creation and role assignment
DECLARE @error NVARCHAR(MAX);
DECLARE @testUserID INT;

-- Add a test user
EXEC usp_AddUser
    @username = 'test_user',
    @password = 'Test@1234',
    @role = 'Staff',
    @storeBranch = 'Test Branch',
    @permission = 'ReadOnly',
    @executedByUserID = 1, -- Manager
    @errorMessage = @error OUTPUT;
SELECT @error AS Result;

-- Retrieve the UserID of the test user
SET @testUserID = (SELECT UserID FROM [User] WHERE Username = 'test_user');

-- Test granting specific permission
EXEC usp_GrantSpecificPermission
    @userID = @testUserID,
    @tableName = 'Inventory',
    @permission = 'SELECT',
    @executedByUserID = 1,
    @errorMessage = @error OUTPUT;
SELECT @error AS Result;

-- Test revoking role
EXEC usp_RevokeUserRole
    @userID = @testUserID,
    @executedByUserID = 1,
    @errorMessage = @error OUTPUT;
SELECT @error AS Result;

--Test deleting the test user
EXEC usp_DeleteUser
    @userID = @testUserID,
    @executedByUserID = 1,
    @errorMessage = @error OUTPUT;
SELECT @error AS Result;