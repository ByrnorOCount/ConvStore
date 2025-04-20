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