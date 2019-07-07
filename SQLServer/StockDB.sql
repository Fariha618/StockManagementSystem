------STOCK MANAGEMENT SYSTEM APP-------

CREATE DATABASE StockDB

USE StockDB

-- Category Setup Table -- 

CREATE TABLE Category
(
ID int IDENTITY(1,1),
Name VARCHAR(300)
)

SELECT * FROM Category

-- Company Setup Table -- 

CREATE TABLE Company
(
ID int IDENTITY(1,1),
Name VARCHAR(300)
)

SELECT * FROM Company

-- Item Setup Table --

CREATE TABLE Item
(
ID int IDENTITY(1,1),
Name VARCHAR(300),
category_ID int,
company_ID int,
reorder_level int
)

SELECT * FROM Item

CREATE VIEW ItemView
AS
SELECT i.Name, co.Name as Company, ca.Name as Category, reorder_level FROM Item As i
LEFT JOIN Company AS co ON co.ID = i.company_ID 
LEFT JOIN Category AS ca ON ca.ID = i.category_ID

SELECT * FROM ItemView


-- Stock In Table --


CREATE TABLE StockIn
(
ID int IDENTITY(1,1),
item_ID int,
available_quantity int,
stockin_quantity int,
Date VARCHAR(100)
)

SELECT * FROM StockIn

INSERT INTO StockIn (item_ID, stockin_quantity,Date) 
VALUES (1,120, CONVERT(VARCHAR(10), getdate(), 103))


SELECT Name AS Item, Date, stockin_quantity FROM StockIn  As s
LEFT JOIN Item AS i ON i.ID = s.item_ID ORDER BY s.ID DESC



-- Stock Out Table --

CREATE TABLE StockOut
(
ID int IDENTITY(1,1),
item_ID int,
stockout_quantity int,
stockout_type int,
Date VARCHAR(300)

)

SELECT * FROM StockOut


INSERT INTO StockOut (item_ID, stockout_quantity, stockout_type) 
VALUES (1, 60, 0)



---Available Quantity --

SELECT ISNULL((SELECT SUM(stockin_quantity) FROM StockIn WHERE item_ID = 2),0) - ISNULL((SELECT stockout_quantity FROM StockOut WHERE item_ID = 2),0) 


----Item Summary Table -----

SELECT * FROM Item
SELECT * FROM Company
SELECT * FROM Category

SELECT c.Name FROM Item AS i LEFT JOIN Company AS c ON c.ID = i.company_ID WHERE i.category_ID = 2 

SELECT c.Name FROM Item AS i LEFT JOIN Category AS c ON c.ID = i.category_ID WHERE i.company_ID = 2

DROP VIEW ItemSearch
SELECT * FROM Item
SELECT * FROM Company
SELECT * FROM Category
SELECT * FROM StockIn

SELECT DISTINCT i.Name AS Item, co.Name AS Company, ca.Name AS Category, reorder_level FROM Item AS i
LEFT JOIN Company AS co ON co.ID = i.company_ID 
LEFT JOIN Category AS ca ON ca.ID = i.category_ID
WHERE co.ID = 5 AND ca.ID = 2


----View Between Two Dates Report -----

SELECT i.Name AS Item, co.Name AS Company, stockout_quantity FROM StockOut AS s
LEFT JOIN Item AS i ON i.ID = s.item_ID
LEFT JOIN Company AS co ON co.ID = i.company_ID
WHERE s.Date BETWEEN '05/07/2019' AND '06/07/2019' AND s.stockout_type = 0 ORDER BY s.Date DESC