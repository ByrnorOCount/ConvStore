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