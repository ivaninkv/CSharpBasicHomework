namespace ClassStack.App;

public static class Program
{
    public static void Main(string[] args)
    {
        var s1 = new Stack("a", "b");
        var s2 = new Stack("3", "3");
        var s3 = new Stack("b", "a", "4", "3");
        var res = Stack.Concat(s1, s2);
        Console.WriteLine(res.Equals(s3));
    }
}