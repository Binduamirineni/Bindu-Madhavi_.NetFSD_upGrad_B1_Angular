CREATE DATABASE Assignment2DB;
USE Assignment2DB;

CREATE TABLE customers (
customer_id INT PRIMARY KEY,
first_name VARCHAR(50),
last_name VARCHAR(50)
);

CREATE TABLE orders (
order_id INT PRIMARY KEY,
customer_id INT,
order_date DATE,
order_status INT,
store_id INT,
FOREIGN KEY (customer_id) REFERENCES customers(customer_id)
);

CREATE TABLE brands (
brand_id INT PRIMARY KEY,
brand_name VARCHAR(50)
);

CREATE TABLE categories (
category_id INT PRIMARY KEY,
category_name VARCHAR(50)
);

CREATE TABLE products (
product_id INT PRIMARY KEY,
product_name VARCHAR(100),
brand_id INT,
category_id INT,
model_year INT,
list_price DECIMAL(10,2),
FOREIGN KEY (brand_id) REFERENCES brands(brand_id),
FOREIGN KEY (category_id) REFERENCES categories(category_id)
);

CREATE TABLE stores (
store_id INT PRIMARY KEY,
store_name VARCHAR(100)
);

CREATE TABLE order_items (
order_id INT,
product_id INT,
quantity INT,
list_price DECIMAL(10,2),
discount DECIMAL(4,2)
);

CREATE TABLE stocks (
store_id INT,
product_id INT,
quantity INT
);

INSERT INTO customers VALUES
(1,'Ravi','Kumar'),
(2,'Priya','Sharma'),
(3,'Amit','Verma');

INSERT INTO stores VALUES
(1,'Hyderabad Store'),
(2,'Mumbai Store');

INSERT INTO orders VALUES
(101,1,'2024-01-10',1,1),
(102,2,'2024-02-15',4,2),
(103,3,'2024-03-12',4,1);

INSERT INTO brands VALUES
(1,'Nike'),
(2,'Adidas');

INSERT INTO categories VALUES
(1,'Shoes'),
(2,'Clothing');

INSERT INTO products VALUES
(1,'Running Shoes',1,1,2023,800),
(2,'Sports T-Shirt',2,2,2022,400),
(3,'Sneakers',1,1,2023,1200);

INSERT INTO order_items VALUES
(101,1,2,800,0.10),
(102,3,1,1200,0.05),
(103,1,3,800,0.00);

INSERT INTO stocks VALUES
(1,1,50),
(1,3,20),
(2,2,30);
