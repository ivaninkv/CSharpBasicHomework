namespace ClassStack.App;

public static class Program
{
    public static void Main(string[] args)
    {
        var s = new Stack("12", "23", null);
        Console.WriteLine($"Size - {s.Size}");
        Console.WriteLine($"Top - {s.Top}");
        s.Add("test");
        Console.WriteLine($"Size - {s.Size}");
        Console.WriteLine($"Top - {s.Top}");
        Console.WriteLine(s.Pop());
        Console.WriteLine($"Size - {s.Size}");
        Console.WriteLine($"Top - {s.Top}");
        s = new Stack();
        Console.WriteLine($"Size - {s.Size}");
        Console.WriteLine($"Top - {s.Top}");
        // Console.WriteLine($"Pop - {s.Pop()}");
        s = new Stack(null);
        Console.WriteLine($"Size - {s.Size}");
        Console.WriteLine($"Top - {s.Top}");
        Console.WriteLine($"Pop - {s.Pop()}");
    }
}