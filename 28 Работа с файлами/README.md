# 28 Работа с файлами // ДЗ

Создание консольного приложение, записывающее и считывающее информацию в\из файл(а).

## Цель
Компилирующееся без ошибок приложение, файлы по заданному пути, консоль со значениями файлов.

## Описание/Пошаговая инструкция выполнения домашнего задания:
* Создать директории `c:\Otus\TestDir1` и `c:\Otus\TestDir2` с помощью класса `DirectoryInfo`.
* В каждой директории создать несколько файлов `File1...File10` с помощью класса `File`.
* В каждый файл записать его имя в кодировке `UTF8`. Учесть, что файл может быть удален, либо отсутствовать права на запись.
* Каждый файл дополнить текущей датой (значение `DateTime.Now`) любыми способами: синхронно и\или асинхронно.
* Прочитать все файлы и вывести на консоль: имя_файла: текст + дополнение.

## Критерии оценки:
Минимальная положительная оценка – приложение компилируется и запускается.

Рекомендуем сдать до: 30.11.2022
