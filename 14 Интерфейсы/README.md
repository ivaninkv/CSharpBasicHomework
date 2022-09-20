# 14 Интерфейсы // ДЗ

Интерфейсы

## Цель
В этом ДЗ вы научитесь явному вызову интерфейсов, их наследованию и реализации методов по умолчанию.

## Описание/Пошаговая инструкция выполнения домашнего задания:
1. Создать интерфейс `IRobot` с публичным методами `string` `GetInfo()` и `List` `GetComponents()`, а также `string` `GetRobotType()` с дефолтной реализацией, возвращающей значение "I am a simple robot.".
1. Создать интерфейс `IChargeable` с методами `void` `Charge()` и `string` `GetInfo()`.
1. Создать интерфейс `IFlyingRobot` как наследник `IRobot` с дефолтной реализацией `GetRobotType()`, возвращающей строку "I am a flying robot.".
1. Создать класс `Quadcopter`, наследующий `IFlyingRobot` и `IChargeable`. В нём создать список компонентов `List _components = new List {"rotor1","rotor2","rotor3","rotor4"}` и возвращать его из метода `GetComponents().`
1. Реализовать метод `Charge()` должен писать в консоль "Charging..." и через 3 секунды "Charged!". Ожидание в 3 секунды реализовать через `Thread.Sleep(3000)`.
1. Реализовать все методы интерфейсов в классах. До этого пункта достаточно "`throw new NotImplementedException();`"
1. В чат напишите также время, которое вам потребовалось для реализации домашнего задания.

## Критерии оценки
* Пункт №1 - 3 балла;
* Пункт №2 - 2 балла;
* Пункт №3 - 2 балла;
* Пункт №4 - 1 балл;
* Пункт №5 - 1 балл;
* Пункт №6 - 1 балл;

Для сдачи достаточно 6 баллов.

Рекомендуем сдать до: 22.09.2022


## Решение

```cs
var quadcopter = new Quadcopter();
IFlyingRobot flyingRobot = quadcopter;
IChargeable chargeable = quadcopter;
IRobot robot = quadcopter;

Console.WriteLine("======== Quadcopter ========");
quadcopter.Charge();
Console.WriteLine(string.Join(", ", quadcopter.GetComponents().ToArray()));
Console.WriteLine();

Console.WriteLine("======== IChargeable ========");
chargeable.Charge();
Console.WriteLine(chargeable.GetInfo());
Console.WriteLine();

Console.WriteLine("======== IFlyingRobot ========");
Console.WriteLine(flyingRobot.GetRobotType());
Console.WriteLine(string.Join(", ", flyingRobot.GetComponents().ToArray()));
Console.WriteLine(flyingRobot.GetInfo());
Console.WriteLine();

Console.WriteLine("======== IRobot ========");
Console.WriteLine(robot.GetRobotType());
Console.WriteLine(string.Join(", ", robot.GetComponents().ToArray()));
Console.WriteLine(robot.GetInfo());
Console.WriteLine();
```

Вывод программы:
```
======== Quadcopter ========
Charging...
Charged!
rotor1, rotor2, rotor3, rotor4

======== IChargeable ========
Charging...
Charged!
I am IChargeable from Quadcopter

======== IFlyingRobot ========
I am a flying robot.
rotor1, rotor2, rotor3, rotor4
I am IRobot from Quadcopter

======== IRobot ========
I am a simple robot.
rotor1, rotor2, rotor3, rotor4
I am IRobot from Quadcopter
```
