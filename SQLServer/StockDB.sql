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