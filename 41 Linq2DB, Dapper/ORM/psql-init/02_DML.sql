insert into "Customers" ("ID", "FirstName", "LastName", "Age")
values (1, 'Ivan', 'Ivanov', 25),
       (2, 'Ivan', 'Petrov', 35),
       (3, 'Petr', 'Petrov', 30),
       (4, 'Petr', 'Ivanov', 41),
       (5, 'Anna', 'Petrova', 29),
       (6, 'Sergey', 'Sergeev', 40),
       (7, 'Yuliya', 'Kotelkina', 30),
       (8, 'Vladimir', 'Petrov', 32),
       (9, 'Stanislav', 'Semenov', 35),
       (10, 'Pavel', 'Gorshkov', 35);

insert into "Products" ("ID", "Name", "Description", "StockQuantity", "Price")
values (1, 'Pen', 'Pen description', 100, 15),
       (2, 'Pencil', 'Pencil description', 90, 16),
       (3, 'Bag', 'Pen description', 10, 150),
       (4, 'Box', 'Box description', 73, 23),
       (5, 'Phone', 'Phone description', 30, 1500),
       (6, 'Laptop', 'Laptop description', 10, 2500),
       (7, 'Monitor', 'Monitor description', 45, 250),
       (8, 'Table', 'Table description', 13, 159),
       (9, 'Chair', 'Chair description', 87, 99),
       (10, 'Book', 'Book description', 143, 23);

insert into "Orders" ("ID", "CustomerID", "ProductID", "Quantity")
values (1, 1, 1, 10),
       (2, 4, 1, 11),
       (3, 6, 1, 12),
       (4, 1, 1, 13),
       (5, 1, 1, 34),
       (6, 8, 1, 12),
       (7, 10, 1, 10),
       (9, 2, 1, 12),
       (10, 7, 3, 21),
       (11, 9, 4, 22),
       (12, 10, 5, 14),
       (13, 3, 6, 35),
       (14, 5, 7, 18),
       (15, 9, 8, 19);
