namespace ExceptionHandling.App;

public static class Program
{
    private static readonly char[] KnownOperators = { '+', '-', '*', '/' };

    private static void Main(string[] args)
    {
        try
        {
            Calculate();
        }
        catch (Exception e)
        {
            Console.WriteLine($"В калькуляторе произошла ошибка: {e.Message}");
        }
    }

    private static void Calculate()
    {
        while (true)
        {
            var inputString = Console.ReadLine() ?? string.Empty;
            if (inputString.ToLower().Equals("стоп"))
                break;
            var userInput = ParseInputString(inputString);
            if (userInput == Array.Empty<string>())
                continue;

            try
            {
                switch (userInput[1])
                {
                    case "+":
                        Sum(int.Parse(userInput[0]), int.Parse(userInput[2]));
                        break;
                    case "-":
                        Sub(int.Parse(userInput[0]), int.Parse(userInput[2]));
                        break;
                    case "*":
                        Mul(int.Parse(userInput[0]), int.Parse(userInput[2]));
                        break;
                    case "/":
                        Div(int.Parse(userInput[0]), int.Parse(userInput[2]));
                        break;
                }
            }
            catch (OverflowException)
            {
                ExceptionHandlers.HandleOverflowException();
            }
            catch (DivideByZeroException)
            {
                ExceptionHandlers.HandleDivideByZeroException();
            }
            catch (Result13Exception)
            {
                ExceptionHandlers.HandleResult13Exception();
            }
        }
    }

    public static string[] ParseInputString(string inputString)
    {
        string[] result;
        try
        {
            result = inputString.Split();
            CheckOperator(result);
            CheckOperands(result);
        }
        catch (OperandIsNotNumberException e)
        {
            ExceptionHandlers.HandleOperandIsNotNumberException(e);
            result = Array.Empty<string>();
        }
        catch (MissingOperatorException)
        {
            ExceptionHandlers.HandleMissingOperatorException();
            result = Array.Empty<string>();
        }
        catch (UnknownOperatorException e)
        {
            ExceptionHandlers.HandleUnknownOperatorException(e);
            result = Array.Empty<string>();
        }
        catch (IncorrectUserInputException)
        {
            ExceptionHandlers.HandleIncorrectUserInputException();
            result = Array.Empty<string>();
        }
        catch (Exception)
        {
            Console.WriteLine("Я не смог обработать ошибку");
            throw;
        }

        return result;
    }

    private static void CheckOperands(string[] userInput)
    {
        if (userInput.Length != 3)
            throw new IncorrectUserInputException();
        if (!userInput[0].All(char.IsDigit))
        {
            var ex = new OperandIsNotNumberException(userInput[0]);
            throw ex;
        }

        if (!userInput[2].All(char.IsDigit))
        {
            var ex = new OperandIsNotNumberException(userInput[2]);
            throw ex;
        }
    }

    private static void CheckOperator(string[] userInput)
    {
        if (userInput.Length > 3)
            throw new IncorrectUserInputException();
        if (userInput.Length < 2 || !char.TryParse(userInput[1], out var mathOperator))
            throw new IncorrectUserInputException();
        if (char.IsNumber(mathOperator))
            throw new MissingOperatorException();
        if (!KnownOperators.Contains(mathOperator))
        {
            var ex = new UnknownOperatorException();
            ex.Data.Add("operator", mathOperator);
            throw ex;
        }
    }


    public static void Sum(int a, int b)
    {
        var result = checked(a + b);
        Console.WriteLine($"Ответ: {result}");
        if (result == 13) throw new Result13Exception();
    }

    public static void Sub(int a, int b)
    {
        var result = checked(a - b);
        Console.WriteLine($"Ответ: {result}");
        if (result == 13) throw new Result13Exception();
    }

    public static void Mul(int a, int b)
    {
        var result = checked(a * b);
        Console.WriteLine($"Ответ: {result}");
        if (result == 13) throw new Result13Exception();
    }

    public static void Div(int a, int b)
    {
        var result = a / b;
        Console.WriteLine($"Ответ: {result}");
        if (result == 13) throw new Result13Exception();
    }
}