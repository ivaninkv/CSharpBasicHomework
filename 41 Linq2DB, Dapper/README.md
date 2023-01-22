# 41 Linq2DB, Dapper  // ДЗ

Dapper / Linq2sql

## Цель
* Получить навык работы с БД из программы, получения выборки и последующей ее обработки.
* Получить опыт работы с ORM Dapper (Linq2Db)

## Описание/Пошаговая инструкция выполнения домашнего задания
* Определиться с ORM: Dapper / Linq2Db.
* Выбрать какую БД использовать (из задания "Sql запросы" или "Кластерный индекс"), написать строку подключения к БД и использовать ее для подключения. (опираться можно на пример из материалов)
* Создать классы, которые описывают таблицы в БД
* Используя ORM выполнить простые запросы к каждой таблице, выполнить параметризованные запросы к каждой таблице (без JOIN) - 2-3 запроса на таблицу.
* Значения параметров для фильтрации можно как задавать из консоли, так и значениями переменных в коде. (пример GetStudent)
* Выполнить все запросы, из выбранного ранее задания с передачей параметров.

## Критерии оценки
* 0-3: 9 баллов
* 4: +1 балл

Рекомендуем сдать до: 24.01.2023

## Решение
В качестве ORM будем использовать Dapper, БД - из задания "Кластерный индекс". В каталоге [ORM](ORM) подготовлен `compose.yml`, который поднимает Postgresql в докере.

Собрать и запустить приложение можно командой:
```shell
docker-compose up -d --build
```
Остановить:
```shell
docker-compose down
```
Посмотреть лог вывода приложения:
```shell
docker-compose logs app
```

Пример вывода приложения:
```
app_1       | ==================Customers==================
app_1       | Customer: 1 - Ivan Ivanov, 25
app_1       | Customer: 2 - Ivan Petrov, 35
app_1       | Customer: 3 - Petr Petrov, 30
app_1       | Customer: 4 - Petr Ivanov, 41
app_1       | Customer: 5 - Anna Petrova, 29
app_1       | Customer: 6 - Sergey Sergeev, 40
app_1       | Customer: 7 - Yuliya Kotelkina, 30
app_1       | Customer: 8 - Vladimir Petrov, 32
app_1       | Customer: 9 - Stanislav Semenov, 35
app_1       | Customer: 10 - Pavel Gorshkov, 35
app_1       | Customer: 1 - Ivan Ivanov, 25
app_1       | ==================Orders==================
app_1       | ID = 1, CustomerID = 1, ProductID = 0, Quantity = 10
app_1       | ID = 2, CustomerID = 4, ProductID = 0, Quantity = 11
app_1       | ID = 3, CustomerID = 6, ProductID = 0, Quantity = 12
app_1       | ID = 4, CustomerID = 1, ProductID = 0, Quantity = 13
app_1       | ID = 5, CustomerID = 1, ProductID = 0, Quantity = 34
app_1       | ID = 6, CustomerID = 8, ProductID = 0, Quantity = 12
app_1       | ID = 7, CustomerID = 10, ProductID = 0, Quantity = 10
app_1       | ID = 9, CustomerID = 2, ProductID = 0, Quantity = 12
app_1       | ID = 10, CustomerID = 7, ProductID = 0, Quantity = 21
app_1       | ID = 11, CustomerID = 9, ProductID = 0, Quantity = 22
app_1       | ID = 12, CustomerID = 10, ProductID = 0, Quantity = 14
app_1       | ID = 13, CustomerID = 3, ProductID = 0, Quantity = 35
app_1       | ID = 14, CustomerID = 5, ProductID = 0, Quantity = 18
app_1       | ID = 15, CustomerID = 9, ProductID = 0, Quantity = 19
app_1       | ID = 1, CustomerID = 1, ProductID = 0, Quantity = 10
app_1       | ==================Products==================
app_1       | ID = 1, Name - Pen, Pen description, Qty = 100, Price = 15
app_1       | ID = 2, Name - Pencil, Pencil description, Qty = 90, Price = 16
app_1       | ID = 3, Name - Bag, Pen description, Qty = 10, Price = 150
app_1       | ID = 4, Name - Box, Box description, Qty = 73, Price = 23
app_1       | ID = 5, Name - Phone, Phone description, Qty = 30, Price = 1500
app_1       | ID = 6, Name - Laptop, Laptop description, Qty = 10, Price = 2500
app_1       | ID = 7, Name - Monitor, Monitor description, Qty = 45, Price = 250
app_1       | ID = 8, Name - Table, Table description, Qty = 13, Price = 159
app_1       | ID = 9, Name - Chair, Chair description, Qty = 87, Price = 99
app_1       | ID = 10, Name - Book, Book description, Qty = 143, Price = 23
app_1       | ID = 1, Name - Pen, Pen description, Qty = 100, Price = 15
```