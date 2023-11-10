CREATE TABLE products
(
    id   INT IDENTITY (1, 1) PRIMARY KEY,
    name VARCHAR(255) NOT NULL
);

CREATE TABLE categories
(
    id   INT IDENTITY (1, 1) PRIMARY KEY,
    name VARCHAR(255) NOT NULL
);

CREATE TABLE products_categories
(
    product_id  INT REFERENCES products (id),
    category_id INT REFERENCES categories (id),
    PRIMARY KEY (product_id, category_id)
);

INSERT INTO products(name)
VALUES ('OneCategoryProduct'),
       ('TwoCategoryProduct'),
       ('NoCategoryProduct');

INSERT INTO categories(name)
VALUES ('Category #1'),
       ('Category #2');

INSERT INTO products_categories(product_id, category_id)
VALUES (1, 1),
       (2, 1),
       (2, 2);

SELECT p.name AS ProductName, c.name AS CategoryName
FROM Products p
         LEFT JOIN products_categories pc ON p.id = pc.product_id
         LEFT JOIN categories c ON pc.category_id = c.Id;