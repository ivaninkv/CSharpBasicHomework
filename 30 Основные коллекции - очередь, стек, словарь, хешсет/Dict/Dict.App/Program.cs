namespace Dict.App;

public static class Program
{
    public static void Main(string[] args)
    {
        var d = new OtusDictionary();
        d.Add(1, "One");
        d.Add(2, "Two");
        d.Add(3, "Three");

        Console.WriteLine(d.Get(1));
        Console.WriteLine(d.Get(2));
        Console.WriteLine(d.Get(3));
        Console.WriteLine(d.Get(4));
        Console.WriteLine(d[1]);
        d[1] = "111";
        Console.WriteLine(d[1]);

        Console.ReadKey();
    }
}
