using System.Diagnostics;

namespace LoopRecursion.App;

public static class Program
{
    private static Dictionary<ulong, ulong> _cache = new()
    {
        { 1, 0 },
        { 2, 1 }
    };

    public static void Main(string[] args)
    {
        var numbers = new List<ulong>()
        {
            5, 10, 20, 30, 40, 45, 50
        };

        foreach (var number in numbers)
        {
            _cache = new Dictionary<ulong, ulong>()
            {
                { 1, 0 },
                { 2, 1 }
            };
            PrintResults(number);
        }
    }

    private static void PrintResults(ulong number)
    {
        Console.WriteLine($"============================= number={number} =============================");
        var stopwatch = new Stopwatch();
        stopwatch.Start();
        var result = FiboLoop(number);
        stopwatch.Stop();
        Console.WriteLine($"FiboLoop - number {number}, result = {result}, time = {stopwatch.Elapsed}");

        stopwatch.Restart();
        result = FiboRecursion(number);
        stopwatch.Stop();
        Console.WriteLine($"FiboRecursion - number {number}, result = {result}, time = {stopwatch.Elapsed}");

        stopwatch.Restart();
        result = FiboCachedRecursion(number);
        stopwatch.Stop();
        Console.WriteLine($"FiboCachedRecursion - number {number}, result = {result}, time = {stopwatch.Elapsed}");

        Console.WriteLine();
    }

    public static ulong FiboLoop(ulong num)
    {
        switch (num)
        {
            case <= 0:
                throw new ArgumentException("Argument must be positive number");
            case 1:
                return 0;
            case 2:
                return 1;
            default:
            {
                ulong num1 = 0;
                ulong num2 = 1;
                ulong result = 0;
                for (ulong i = 3; i <= num; i++)
                {
                    result = num1 + num2;
                    num1 = num2;
                    num2 = result;
                }

                return result;
            }
        }
    }

    public static ulong FiboRecursion(ulong num)
    {
        return num switch
        {
            <= 0 => throw new ArgumentException("Argument must be positive number"),
            1 => 0,
            2 => 1,
            _ => FiboRecursion(num - 1) + FiboRecursion(num - 2)
        };
    }

    public static ulong FiboCachedRecursion(ulong num)
    {
        if (_cache.ContainsKey(num))
        {
            return _cache[num];
        }

        switch (num)
        {
            case <= 0:
                throw new ArgumentException("Argument must be positive number");
            case 1:
                return 0;
            case 2:
                return 1;
            default:
                var result = FiboCachedRecursion(num - 1) + FiboCachedRecursion(num - 2);
                _cache[num] = result;
                return result;
        }
    }
}
