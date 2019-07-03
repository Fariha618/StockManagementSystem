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
