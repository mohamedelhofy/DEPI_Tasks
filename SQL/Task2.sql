-- Create DataBase
CREATE DATABASE ECommerceDB;
GO
USE ECommerceDB;
Go

-- Create Tables

-- create LkpCustomers table that contain (CustomerId, Name, Email, Phone)
CREATE TABLE LkpCustomers (
    CustomerId INT PRIMARY KEY IDENTITY,
    Name VARCHAR(100),
    Email VARCHAR(100),
    Phone VARCHAR(20)
);

-- create LkpProducts table that contain (ProductId, Name,UnitPrice ,Description)
CREATE TABLE LkpProducts (
    ProductId INT PRIMARY KEY IDENTITY,
    Name VARCHAR(100),
    Description VARCHAR(100),
    UnitPrice  DECIMAL(10,2)
);

-- create TblOrders table that contain (OrderId, customer_id ,OrderDate, Total)
CREATE TABLE TblOrders (
    OrderId INT PRIMARY KEY IDENTITY,
    Customer_Id INT,
    OrderDate DATE,
    Total DECIMAL(10,2)
);

-- create TblOrderDetails that contain (OrderDetailId, OrderId, ProductId, Quantity
CREATE TABLE TblOrderDetails (
    OrderDetailId INT PRIMARY KEY IDENTITY,
    OrderId INT,
    ProductId INT,
    Quantity INT,
);
Go

-- Insert Customers
INSERT INTO LkpCustomers (Name, Email, Phone) 
VALUES ('Elhofy','alhofymohamed@gmail.com','01016571431'),
 ('Amir','amir@gmail.com','01016571431');
-- Insert Products
INSERT INTO LkpProducts (Name, UnitPrice, Description) VALUES
('Laptop', 1200.00, '15 inch high-performance laptop'),
('Mouse', 25.50, 'Wireless optical mouse'),
('Keyboard', 45.00, 'Mechanical gaming keyboard');

-- Insert Orders
INSERT INTO TblOrders (Customer_Id, OrderDate, Total) VALUES
(1, '2025-07-10', 1270.50),
(2, '2025-07-11', 70.50); 

-- Insert Order Details
INSERT INTO TblOrderDetails (OrderId, ProductId, Quantity) VALUES
(1, 1, 1), 
(1, 2, 2), 
(2, 2, 1), 
(2, 3, 1); 
Go


-- Display Tables to detect change 
SELECT * FROM LkpCustomers

SELECT * FROM LkpProducts

SELECT * FROM TblOrders

SELECT * FROM TblOrderDetails

-- Updata Customers emial 
UPDATE LkpCustomers SET Email= 'hamo@gmail.com' WHERE CustomerId = 1

-- Updata product price  
UPDATE LkpProducts SET UnitPrice= 1500 WHERE ProductId = 1

-- Update order total
UPDATE TblOrders SET Total = 1350.00 WHERE OrderId = 1;

-- Update quantity of a product in an order
UPDATE TblOrderDetails SET Quantity = 3 WHERE OrderDetailId = 2;
Go


-- Display Tables to detect change 
SELECT * FROM LkpCustomers

SELECT * FROM LkpProducts

SELECT * FROM TblOrders

SELECT * FROM TblOrderDetails


-- Delete Example
DELETE  LkpCustomers WHERE CustomerId = 2;

DELETE  LkpProducts WHERE ProductId = 2;

DELETE  TblOrders WHERE OrderId = 2;

DELETE  TblOrderDetails WHERE OrderDetailId = 4;
Go

-- Display Tables to detect change 
SELECT * FROM LkpCustomers

SELECT * FROM LkpProducts

SELECT * FROM TblOrders

SELECT * FROM TblOrderDetails