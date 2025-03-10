IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'ConvStore_DB')
BEGIN
    CREATE DATABASE ConvStore_DB;
END;
GO

USE ConvStore_DB;
GO

--Note: User and Order need to be in square brackets ([User] and [Order]) because they're hardcoded keywords in SQL Server

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