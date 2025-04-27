USE ConvStore_DB;
GO

-- Create SQL Server roles
CREATE ROLE Staff;
CREATE ROLE Manager;

-- Permissions for Staff Role (limited access)
GRANT SELECT, REFERENCES ON [User] TO Staff;
GRANT SELECT, REFERENCES ON Supplier TO Staff;
GRANT SELECT, INSERT, UPDATE, REFERENCES ON [Order] TO Staff;
GRANT SELECT, REFERENCES ON Product TO Staff;
GRANT SELECT, INSERT, UPDATE, REFERENCES ON OrderProducts TO Staff;
GRANT SELECT, REFERENCES ON Inventory TO Staff;
GRANT SELECT, INSERT, REFERENCES ON Notification TO Staff;
GRANT SELECT, REFERENCES ON Changelog TO Staff;
DENY INSERT, UPDATE, DELETE ON [User] TO Staff;
GRANT EXECUTE TO Staff;
DENY EXECUTE ON usp_AssignUserRole TO Staff;
DENY EXECUTE ON usp_AddUser TO Staff;
DENY EXECUTE ON usp_UpdateUser TO Staff;
DENY EXECUTE ON usp_DeleteUser TO Staff;
DENY EXECUTE ON usp_RevokeUserRole TO Staff;
DENY EXECUTE ON usp_GrantSpecificPermission TO Staff;
DENY EXECUTE ON usp_RevokeSpecificPermission TO Staff;

-- Permissions for Manager Role (full access)
GRANT SELECT, INSERT, UPDATE, DELETE, REFERENCES ON [User] TO Manager;
GRANT SELECT, INSERT, UPDATE, DELETE, REFERENCES ON Supplier TO Manager;
GRANT SELECT, INSERT, UPDATE, DELETE, REFERENCES ON [Order] TO Manager;
GRANT SELECT, INSERT, UPDATE, DELETE, REFERENCES ON Product TO Manager;
GRANT SELECT, INSERT, UPDATE, DELETE, REFERENCES ON OrderProducts TO Manager;
GRANT SELECT, INSERT, UPDATE, DELETE, REFERENCES ON Inventory TO Manager;
GRANT SELECT, INSERT, UPDATE, DELETE, REFERENCES ON Notification TO Manager;
GRANT SELECT, INSERT, UPDATE, DELETE, REFERENCES ON Changelog TO Manager;
GRANT EXECUTE TO Manager;
GO


USE ConvStore_DB;
GO

-- 1. Create User
CREATE LOGIN [AshKetchum_Login] WITH PASSWORD = '1234';
CREATE USER [Ash Ketchum] FOR LOGIN [AshKetchum_Login]; -- Assuming the login exists already
GO

-- 2. Grant other necessary permissions
GRANT SELECT ON [User] TO [Ash Ketchum];
GRANT SELECT ON Supplier TO [Ash Ketchum];
-- You can grant other permissions as needed

-- 3. Revoke the permission to execute usp_AddSupplier
DENY EXECUTE ON usp_AddSupplier TO [Ash Ketchum];
GO

GRANT SELECT, REFERENCES ON [User] TO [Ash Ketchum];
GRANT SELECT, REFERENCES ON Supplier TO [Ash Ketchum];
GRANT SELECT, INSERT, UPDATE, REFERENCES ON [Order] TO [Ash Ketchum];
GRANT SELECT, REFERENCES ON Product TO [Ash Ketchum];
GRANT SELECT, INSERT, UPDATE, REFERENCES ON OrderProducts TO [Ash Ketchum];
GRANT SELECT, REFERENCES ON Inventory TO [Ash Ketchum];
GRANT SELECT, INSERT, REFERENCES ON Notification TO [Ash Ketchum];
GRANT SELECT, REFERENCES ON Changelog TO [Ash Ketchum];
DENY INSERT, UPDATE, DELETE ON [User] TO [Ash Ketchum];
GRANT EXECUTE TO [Ash Ketchum];
DENY EXECUTE ON usp_AssignUserRole TO [Ash Ketchum];
DENY EXECUTE ON usp_AddUser TO [Ash Ketchum];
DENY EXECUTE ON usp_UpdateUser TO [Ash Ketchum];
DENY EXECUTE ON usp_DeleteUser TO [Ash Ketchum];
DENY EXECUTE ON usp_RevokeUserRole TO [Ash Ketchum];
DENY EXECUTE ON usp_GrantSpecificPermission TO [Ash Ketchum];
DENY EXECUTE ON usp_RevokeSpecificPermission TO [Ash Ketchum];
