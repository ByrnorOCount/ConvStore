USE ConvStore_DB;
GO

-- Insert Users
INSERT INTO [User] (Username, Password, Role, StoreBranch, Permission)
VALUES 
('admin', 'Admin@1234', 'Manager', 'Main Branch', 'FullAccess'),
('john_doe', 'JohnDoe@1234', 'Manager', 'East Branch', 'FullAccess'),
('jane_smith', 'JaneSmith@1234', 'Staff', 'West Branch', 'ReadOnly');

-- Insert Suppliers
INSERT INTO Supplier (Name, Email, Code, PhoneNumber, IsActive)
VALUES 
('FreshFarm Ltd.', 'contact@freshfarm.com', 'SUP001', '123-456-7890', 1),
('OrganicFoods Inc.', 'info@organicfoods.com', 'SUP002', '987-654-3210', 1);

-- Insert Orders
INSERT INTO [Order] (UserID, SupplierID, DeliveryTime, Status, Quantity, Price, TypeOfGoods)
VALUES 
(1, 1, '2025-03-20 10:00:00', 'Pending', 100, 5000.00, 'Vegetables'),
(2, 2, '2025-03-22 14:00:00', 'Shipped', 50, 2500.00, 'Dairy Products');

-- Insert Products
INSERT INTO Product (Name, ExpiryDate, ProductionDate, Origin, Status, Ingredients, ImportTime, ImportLocation, Code, Price, Certification, Preservation)
VALUES 
('Organic Carrots', '2025-06-10', '2025-03-01', 'USA', 'Available', 'Carrots', '2025-03-05 08:00:00', 'Main Warehouse', 'P001', 50.00, 'USDA Organic', 'Cold Storage'),
('Whole Milk', '2025-04-15', '2025-02-28', 'Canada', 'Available', 'Milk', '2025-03-06 09:30:00', 'East Warehouse', 'P002', 40.00, 'Dairy Certified', 'Refrigerated');

-- Insert OrderProducts
INSERT INTO OrderProducts (OrderID, ProductID, Quantity)
VALUES 
(1, 1, 200), 
(2, 2, 200);

-- Insert Inventory
INSERT INTO Inventory (ProductID, StorageLocation, Quantity, Category, Status)
VALUES 
(1, 'Main Warehouse - A1', 500, 'Vegetables', 'In Stock'),
(2, 'East Warehouse - B2', 200, 'Dairy', 'Low Stock');

-- Insert Notifications
INSERT INTO Notification (UserID, OrderID, SupplierID, Time, Message)
VALUES 
(1, 1, 1, GETDATE(), 'New order placed for Organic Carrots.'),
(2, 2, 2, GETDATE(), 'Your order for Whole Milk has been shipped.');

-- Insert Changelog
INSERT INTO Changelog (UserID, ProductID, ChangedData, Timestamp, PaymentAmount, Invoice)
VALUES 
(1, 1, 'Price updated from 45.00 to 50.00', GETDATE(), 50.00, NULL),
(2, 2, 'Stock updated from 250 to 200', GETDATE(), 0.00, NULL);
