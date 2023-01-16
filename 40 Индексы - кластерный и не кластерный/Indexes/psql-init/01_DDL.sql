create table "Customers"
(
    "ID"        integer not null
        constraint "Customers_pk"
            primary key,
    "FirstName" varchar,
    "LastName"  varchar,
    "Age"       integer
);

alter table "Customers"
    owner to postgres;

create index "Customers_Age_index"
    on "Customers" ("Age") include ("FirstName", "LastName");

create table "Products"
(
    "ID"            integer not null
        constraint "Products_pk"
            primary key,
    "Name"          varchar,
    "Description"   varchar,
    "StockQuantity" integer,
    "Price"         integer
);

alter table "Products"
    owner to postgres;

create index "Products_Price_index"
    on "Products" ("Price");

create index "Products_StockQuantity_index"
    on "Products" ("StockQuantity");

create table "Orders"
(
    "ID"         integer not null
        constraint "Orders_pk"
            primary key,
    "CustomerID" integer not null
        constraint "Orders_Customers_ID_fk"
            references "Customers",
    "ProductID"  integer not null
        constraint "Orders_Products_ID_fk"
            references "Products",
    "Quantity"   integer
);

alter table "Orders"
    owner to postgres;

create index "Orders_CustomerID_index"
    on "Orders" ("CustomerID") include ("ProductID", "Quantity");

create index "Orders_ProductID_index"
    on "Orders" ("ProductID") include ("CustomerID", "Quantity");

