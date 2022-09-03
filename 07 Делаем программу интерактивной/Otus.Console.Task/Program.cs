using System.Text;

namespace Otus.Console.Task
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            // Task2();
            // Task3();
            // Task4();
        }


        /// <summary>
        /// Задание 1
        /// </summary>
        static void Task1()
        {
            var line = CustomReadLine();
            Console.WriteLine($"Ваша строка: {line}");
        }


        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        static string CustomReadLine()
        {
            // Вот тут начинается ваш код
            ConsoleKeyInfo consoleKeyInfo;
            var sb = new StringBuilder();
            do
            {
                consoleKeyInfo = Console.ReadKey();
                if (consoleKeyInfo.Key != ConsoleKey.Enter)
                {
                    sb.Append(consoleKeyInfo.KeyChar);
                }
            } while (consoleKeyInfo.Key != ConsoleKey.Enter);

            return sb.ToString();
        }

        /// <summary>
        /// Задание 2
        /// </summary>
        static void Task2()
        {
            int num1, num2;
            do
            {
                Console.Write("Введите первое число: ");
            } while (!int.TryParse(Console.ReadLine(), out num1));

            do
            {
                Console.Write("Введите второе число: ");
            } while (!int.TryParse(Console.ReadLine(), out num2));

            Console.WriteLine($"Результат сложения: {num1} + {num2} = {num1 + num2}");
        }


        /// <summary>
        /// Задание 3
        /// </summary>
        /// <param name="s"></param>
        static void Task3()
        {
            // А дальше - код
            ConsoleKeyInfo consoleKeyInfo;
            Console.WriteLine();
            do
            {
                consoleKeyInfo = Console.ReadKey();
                var top = Console.GetCursorPosition().Top;
                var left = Console.GetCursorPosition().Left;
                if (left > 0 && top > 0)
                {
                    Console.SetCursorPosition(left - 1, top - 1);
                    Console.Write(char.ToUpper(consoleKeyInfo.KeyChar));
                    Console.SetCursorPosition(left, top);
                }
            } while (consoleKeyInfo.Key != ConsoleKey.Enter);
        }


        /// <summary>
        /// Задание 4
        /// </summary>
        static void Task4()
        {
            Console.Clear();

            Start();
        }


        /// <summary>
        /// Опции меню
        /// </summary>
        private static string[] options = new[]
        {
            "Новая игра",
            "Загрузить игру",
            "Сохранить Игру",
            "Настройки",
        };

        /// <summary>
        /// На одну строку вниз
        /// </summary>
        private static void SetDown()
        {
            if (selectedValue < options.Length - 1)
            {
                var oldTop = Console.GetCursorPosition().Top;
                Console.SetCursorPosition(0, oldTop - options.Length + selectedValue);
                Console.Write(" ");
                selectedValue++;
                Console.SetCursorPosition(0, oldTop - options.Length + selectedValue);
                Console.Write(">");
                Console.SetCursorPosition(0, oldTop);
            }
        }

        /// <summary>
        /// На одну строку вверх
        /// </summary>
        private static void SetUp()
        {
            if (selectedValue > 0)
            {
                var oldTop = Console.GetCursorPosition().Top;
                Console.SetCursorPosition(0, oldTop - options.Length + selectedValue);
                Console.Write(" ");
                selectedValue--;
                Console.SetCursorPosition(0, oldTop - options.Length + selectedValue);
                Console.Write(">");
                Console.SetCursorPosition(0, oldTop);
            }
        }

        /// <summary>
        /// Вывести меню (его трогать не нужно)
        /// </summary>
        private static void PrintMenu()
        {
            Console.WriteLine("Для выхода нажмие Escape");
            for (var i = 0; i < options.Length; i++)
            {
                Console.WriteLine($"{(selectedValue == i ? ">" : " ")} {i + 1}. {options[i]}");
            }
        }

        /// <summary>
        /// Исходное положение стрелки меню
        /// </summary>
        private static int selectedValue = 0;


        /// <summary>
        /// Запуск меню (его трогать не нужно)
        /// </summary>
        private static void Start()
        {
            Console.Clear();
            PrintMenu();
            ConsoleKeyInfo ki;
            do
            {
                ki = Console.ReadKey();

                switch (ki.Key)
                {
                    case ConsoleKey.UpArrow:
                        SetUp();
                        break;
                    case ConsoleKey.DownArrow:
                        SetDown();
                        break;
                }
            } while (ki.Key != ConsoleKey.Escape);
        }
    }
}