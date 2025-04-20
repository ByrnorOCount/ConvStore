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