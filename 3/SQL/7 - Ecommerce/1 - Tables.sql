-- Database Creation and usage
CREATE DATABASE  ecommerce;
use ecommerce;



-- this table will hold all the registered customers
create table customers
(
    [id] int IDENTITY(1,1) primary key,
    [name] varchar(255),
    [email] varchar(255),
    [phone] varchar(255),
    [address] varchar(255),
    [city] varchar(255),
    [state] varchar(255),
    [country] varchar(255),
    [zipcode] varchar(255)
);


-- This table will hold all the available products
create table products
(
    [id] int IDENTITY(1,1) primary key,
    [name] varchar(255),
    [description] varchar(255),
    [price] varchar(255),
    [category] varchar(255),
    [availability] varchar(255) DEFAULT('available')
);

-- This table will hold all the orders
create table orders
(
    [id] int IDENTITY(1,1) primary key,
    [customer_id] int,
    [product_id] int,
    [order_date] date,
    [order_status] varchar(255),
    Foreign Key ([customer_id]) REFERENCES customers([id]),
    Foreign Key ([product_id]) REFERENCES products([id])
);






-- This table will hold all the delivered orders
create table delievered_orders(
    [id] int IDENTITY(1,1) primary key,
    [customer_id] int,
    [product_id] int,
    [order_date] date,
    [order_status] varchar(255),
    Foreign Key ([customer_id]) REFERENCES customers([id]),
    Foreign Key ([product_id]) REFERENCES products([id])
);