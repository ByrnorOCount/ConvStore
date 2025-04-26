USE master;
GO

-- Drop the server login if it exists
IF EXISTS (SELECT * FROM sys.server_principals WHERE name = 'admin')
BEGIN
    DROP LOGIN [admin];
END;

USE ConvStore_DB;
GO

-- Drop the database user if it exists
IF EXISTS (SELECT * FROM sys.database_principals WHERE name = 'admin')
BEGIN
    DROP USER [admin];
END;

-- Insert Users
INSERT INTO [User] (Username, Password, Role, StoreBranch, Permission)
VALUES 
('admin', 'Admin@1234', 'Manager', 'Main Branch', 'FullAccess'),
('john_doe', 'JohnDoe@1234', 'Manager', 'East Branch', 'FullAccess'),
('jane_smith', 'JaneSmith@1234', 'Staff', 'West Branch', 'ReadOnly'),
('sarah_connor', 'SarahC@5678', 'Manager', 'North Branch', 'FullAccess'),
('mike_tyson', 'MikeT@9012', 'Staff', 'South Branch', 'ReadOnly'),
('lisa_brown', 'LisaB@3456', 'Staff', 'Main Branch', 'ReadOnly'),
('david_wilson', 'DavidW@7890', 'Manager', 'West Branch', 'FullAccess'),
('emma_davis', 'EmmaD@1234', 'Staff', 'East Branch', 'ReadOnly'),
('chris_evans', 'ChrisE@5678', 'Manager', 'North Branch', 'FullAccess'),
('olivia_jones', 'OliviaJ@9012', 'Staff', 'South Branch', 'ReadOnly'),
('noah_martin', 'NoahM@3456', 'Staff', 'Main Branch', 'ReadOnly'),
('ava_thomas', 'AvaT@7890', 'Manager', 'West Branch', 'FullAccess'),
('liam_moore', 'LiamM@1234', 'Staff', 'East Branch', 'ReadOnly');

-- Insert Suppliers
INSERT INTO Supplier (Name, Email, Code, PhoneNumber, IsActive)
VALUES 
('FreshFarm Ltd.', 'contact@freshfarm.com', 'SUP001', '123-456-7890', 1),
('OrganicFoods Inc.', 'info@organicfoods.com', 'SUP002', '987-654-3210', 1),
('GreenValley Co.', 'sales@greenvalley.com', 'SUP003', '555-123-4567', 1),
('PureJuice Ltd.', 'contact@purejuice.com', 'SUP004', '555-987-6543', 1),
('MeatMasters', 'info@meatmasters.com', 'SUP005', '555-456-7890', 1),
('GrainGrowers', 'support@graingrowers.com', 'SUP006', '555-321-6547', 1),
('SeaFresh Foods', 'orders@seafresh.com', 'SUP007', '555-789-1234', 1),
('BakeWell Inc.', 'hello@bakewell.com', 'SUP008', '555-654-9876', 1),
('FruitHaven', 'contact@fruithaven.com', 'SUP009', '555-147-2583', 0),
('SpiceWorld', 'sales@spiceworld.com', 'SUP010', '555-369-7412', 1);

-- Insert Orders
INSERT INTO [Order] (UserID, SupplierID, DeliveryTime, Status, Quantity, Price, TypeOfGoods)
VALUES 
(1, 1, '2025-03-20 10:00:00', 'Pending', 100, 5000.00, 'Vegetables'),
(2, 2, '2025-03-22 14:00:00', 'Shipped', 50, 2500.00, 'Dairy Products'),
(3, 3, '2025-03-25 09:00:00', 'Pending', 150, 7500.00, 'Fruits'),
(4, 4, '2025-03-26 11:30:00', 'Delivered', 80, 3200.00, 'Beverages'),
(5, 5, '2025-03-27 13:00:00', 'Shipped', 200, 10000.00, 'Meat'),
(6, 6, '2025-03-28 10:00:00', 'Pending', 120, 4800.00, 'Grains'),
(7, 7, '2025-03-29 15:00:00', 'Cancelled', 90, 3600.00, 'Seafood'),
(8, 8, '2025-03-30 12:00:00', 'Delivered', 110, 5500.00, 'Bakery'),
(9, 1, '2025-04-01 08:00:00', 'Shipped', 300, 15000.00, 'Vegetables'),
(10, 2, '2025-04-02 14:00:00', 'Pending', 70, 2800.00, 'Dairy Products'),
(1, 3, '2025-04-03 10:30:00', 'Delivered', 250, 12500.00, 'Fruits'),
(2, 4, '2025-04-04 09:00:00', 'Shipped', 60, 2400.00, 'Beverages'),
(3, 5, '2025-04-05 11:00:00', 'Pending', 180, 9000.00, 'Meat'),
(4, 6, '2025-04-06 13:30:00', 'Delivered', 100, 4000.00, 'Grains');

-- Insert Products
INSERT INTO Product (Name, ExpiryDate, ProductionDate, Origin, Status, Ingredients, ImportTime, ImportLocation, Code, Price, Certification, Preservation)
VALUES 
('Organic Carrots', '2025-06-10', '2025-03-01', 'USA', 'Available', 'Carrots', '2025-03-05 08:00:00', 'Main Warehouse', 'P001', 50.00, 'USDA Organic', 'Cold Storage'),
('Whole Milk', '2025-04-15', '2025-02-28', 'Canada', 'Available', 'Milk', '2025-03-06 09:30:00', 'East Warehouse', 'P002', 40.00, 'Dairy Certified', 'Refrigerated'),
('Beef Steak', '2025-04-30', '2025-03-15', 'Argentina', 'Available', 'Beef', '2025-03-18 08:30:00', 'West Warehouse', 'P005', 150.00, 'Grass-Fed', 'Frozen'),
('Brown Rice', '2026-03-01', '2025-03-01', 'India', 'Available', 'Rice', '2025-03-10 09:00:00', 'South Warehouse', 'P006', 25.00, 'Organic', 'Dry Storage'),
('Salmon Fillet', '2025-04-25', '2025-03-12', 'Norway', 'Available', 'Salmon', '2025-03-15 07:30:00', 'North Warehouse', 'P007', 200.00, 'MSC Certified', 'Frozen'),
('Croissants', '2025-04-10', '2025-03-20', 'France', 'Available', 'Flour, Butter', '2025-03-22 08:00:00', 'Main Warehouse', 'P008', 45.00, 'Artisan', 'Room Temperature'),
('Spinach', '2025-04-05', '2025-03-25', 'USA', 'Available', 'Spinach', '2025-03-27 09:00:00', 'East Warehouse', 'P009', 35.00, 'USDA Organic', 'Cold Storage'),
('Cheddar Cheese', '2025-06-30', '2025-03-10', 'UK', 'Available', 'Milk, Salt', '2025-03-15 10:30:00', 'West Warehouse', 'P010', 80.00, 'Dairy Certified', 'Refrigerated'),
('Bananas', '2025-04-15', '2025-03-20', 'Ecuador', 'Available', 'Bananas', '2025-03-25 08:00:00', 'South Warehouse', 'P011', 20.00, 'Fair Trade', 'Room Temperature'),
('Almond Milk', '2025-05-10', '2025-03-15', 'USA', 'Available', 'Almonds, Water', '2025-03-20 09:30:00', 'North Warehouse', 'P012', 50.00, 'Non-GMO', 'Refrigerated'),
('Chicken Breast', '2025-04-20', '2025-03-18', 'USA', 'Available', 'Chicken', '2025-03-22 07:00:00', 'Main Warehouse', 'P013', 120.00, 'Free-Range', 'Frozen'),
('Quinoa', '2026-02-01', '2025-03-05', 'Peru', 'Available', 'Quinoa', '2025-03-10 08:00:00', 'East Warehouse', 'P014', 70.00, 'Organic', 'Dry Storage');

-- Insert OrderProducts
INSERT INTO OrderProducts (OrderID, ProductID, Quantity)
VALUES 
(1, 1, 50), 
(2, 2, 100),
(3, 3, 300),
(4, 4, 150),
(5, 5, 400),
(6, 6, 200),
(7, 7, 180),
(8, 8, 250),
(9, 9, 500),
(10, 10, 120),
(11, 11, 350),
(12, 12, 100),
(13, 5, 320),
(14, 6, 180);

-- Insert Inventory
INSERT INTO Inventory (ProductID, StorageLocation, Quantity, Category, Status)
VALUES 
(1, 'Main Warehouse - A1', 500, 'Vegetables', 'In Stock'),
(2, 'East Warehouse - B2', 200, 'Dairy', 'Low Stock'),
(3, 'Main Warehouse - A2', 800, 'Fruits', 'In Stock'),
(4, 'East Warehouse - B3', 300, 'Beverages', 'In Stock'),
(5, 'West Warehouse - C1', 600, 'Meat', 'In Stock'),
(6, 'South Warehouse - D1', 1000, 'Grains', 'In Stock'),
(7, 'North Warehouse - E1', 400, 'Seafood', 'Low Stock'),
(8, 'Main Warehouse - A3', 500, 'Bakery', 'In Stock'),
(9, 'East Warehouse - B4', 700, 'Vegetables', 'In Stock'),
(10, 'West Warehouse - C2', 250, 'Dairy', 'Low Stock'),
(11, 'South Warehouse - D2', 900, 'Fruits', 'In Stock'),
(12, 'North Warehouse - E2', 350, 'Beverages', 'In Stock');

-- Insert Notifications
INSERT INTO Notification (UserID, OrderID, SupplierID, Time, Message)
VALUES 
(1, 1, 1, GETDATE(), 'New order placed for Organic Carrots.'),
(2, 2, 2, GETDATE(), 'Your order for Whole Milk has been shipped.'),
(3, 3, 3, GETDATE(), 'New order placed for Green Apples.'),
(4, 4, 4, GETDATE(), 'Your order for Orange Juice has been delivered.'),
(5, 5, 5, GETDATE(), 'New order placed for Beef Steak.'),
(6, 6, 6, GETDATE(), 'New order placed for Brown Rice.'),
(7, 7, 7, GETDATE(), 'Order for Salmon Fillet has been cancelled.'),
(8, 8, 8, GETDATE(), 'Your order for Croissants has been delivered.'),
(9, 9, 1, GETDATE(), 'New order placed for Spinach.'),
(10, 10, 2, GETDATE(), 'New order placed for Cheddar Cheese.'),
(1, 11, 3, GETDATE(), 'Your order for Bananas has been delivered.'),
(2, 12, 4, GETDATE(), 'New order placed for Almond Milk.'),
(3, 13, 5, GETDATE(), 'New order placed for Chicken Breast.'),
(4, 14, 6, GETDATE(), 'Your order for Quinoa has been delivered.');

-- Insert Changelog
INSERT INTO Changelog (UserID, ProductID, ChangedData, Timestamp, PaymentAmount, Invoice)
VALUES 
(1, 1, 'Price updated from 45.00 to 50.00', GETDATE(), 50.00, NULL),
(2, 2, 'Stock updated from 250 to 200', GETDATE(), 0.00, NULL),
(1, NULL, 'Added new supplier: GreenValley Co.', GETDATE(), 0.00, NULL),
(2, NULL, 'Updated supplier email for OrganicFoods Inc. to newinfo@organicfoods.com', GETDATE(), 0.00, NULL),
(3, NULL, 'Deactivated supplier: FruitHaven', GETDATE(), 0.00, NULL),
(4, NULL, 'Added new order #3 for Green Apples', GETDATE(), 7500.00, 'INV003'),
(5, NULL, 'Updated order #4 status to Delivered', GETDATE(), 3200.00, 'INV004'),
(6, NULL, 'Cancelled order #7 for Salmon Fillet', GETDATE(), 0.00, NULL),
(7, 3, 'Added new product: Green Apples', GETDATE(), 0.00, NULL),
(8, 4, 'Updated product price for Orange Juice from 25.00 to 30.00', GETDATE(), 30.00, NULL),
(9, 5, 'Updated product status for Beef Steak to Available', GETDATE(), 0.00, NULL),
(10, 6, 'Deleted product: Brown Rice (expired batch)', GETDATE(), 0.00, NULL),
(1, 3, 'Updated inventory for Green Apples: Quantity from 700 to 800', GETDATE(), 0.00, NULL),
(2, 4, 'Added inventory for Orange Juice: 300 units', GETDATE(), 0.00, NULL),
(3, 5, 'Updated inventory status for Beef Steak to In Stock', GETDATE(), 0.00, NULL),
(4, 7, 'Removed inventory for Salmon Fillet: 50 units (spoiled)', GETDATE(), 0.00, NULL),
(5, 8, 'Added inventory for Croissants: 500 units', GETDATE(), 0.00, NULL),
(6, 9, 'Updated inventory for Spinach: Quantity from 600 to 700', GETDATE(), 0.00, NULL),
(7, NULL, 'Added new supplier: SpiceWorld', GETDATE(), 0.00, NULL),
(8, NULL, 'Added new order #9 for Spinach', GETDATE(), 15000.00, 'INV009'),
(9, 10, 'Updated product certification for Cheddar Cheese to Dairy Certified', GETDATE(), 0.00, NULL),
(10, 11, 'Added inventory for Bananas: 900 units', GETDATE(), 0.00, NULL);

-- Test user creation and role assignment
DECLARE @error NVARCHAR(MAX);
EXEC usp_AddUser
    @username = 'test_user',
    @password = 'Test@1234',
    @role = 'Staff',
    @storeBranch = 'Test Branch',
    @permission = 'ReadOnly',
    @executedByUserID = 1, -- Manager
    @errorMessage = @error OUTPUT;
SELECT @error AS Result;

-- Test granting specific permission
EXEC usp_GrantSpecificPermission
    @userID = (SELECT UserID FROM [User] WHERE Username = 'test_user'),
    @tableName = 'Inventory',
    @permission = 'SELECT',
    @executedByUserID = 1,
    @errorMessage = @error OUTPUT;
SELECT @error AS Result;

-- Test revoking role
EXEC usp_RevokeUserRole
    @userID = (SELECT UserID FROM [User] WHERE Username = 'test_user'),
    @executedByUserID = 1,
    @errorMessage = @error OUTPUT;
SELECT @error AS Result;