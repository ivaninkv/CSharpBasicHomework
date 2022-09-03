namespace ExceptionHandling.App;

internal static class ExceptionHandlers
{
    internal static void HandleDivideByZeroException()
    {
        Console.BackgroundColor = ConsoleColor.DarkMagenta;
        Console.Write("Деление на ноль");
        Console.ResetColor();
        Console.WriteLine();
    }

    internal static void HandleResult13Exception()
    {
        Console.BackgroundColor = ConsoleColor.Green;
        Console.Write("Вы получили ответ 13!");
        Console.ResetColor();
        Console.WriteLine();
    }

    internal static void HandleUnknownOperatorException(UnknownOperatorException e)
    {
        object? mathOperator = null;
        if (e.Data.Count == 1) mathOperator = e.Data["operator"];

        Console.BackgroundColor = ConsoleColor.Green;
        Console.Write($"Я пока не умею работать с оператором {mathOperator}");
        Console.ResetColor();
        Console.WriteLine();
    }


    internal static void HandleIncorrectUserInputException()
    {
        var textLines = new List<string>
        {
            "Выражение некорректное, попробуйте написать в формате",
            "a + b",
            "a - b",
            "a * b",
            "a / b"
        };
        foreach (var line in textLines)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(line);
            Console.ResetColor();
            Console.WriteLine();
        }
    }

    internal static void HandleMissingOperatorException()
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Write("Укажите в выражении оператор: +, -, *, /");
        Console.ResetColor();
        Console.WriteLine();
    }

    internal static void HandleOperandIsNotNumberException(OperandIsNotNumberException e)
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Write($"Операнд {e.Number} не является числом");
        Console.ResetColor();
        Console.WriteLine();
    }

    internal static void HandleOverflowException()
    {
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.Write("Результат выражения вышел за границы int");
        Console.ResetColor();
        Console.WriteLine();
    }
}