using System.Collections.Immutable;

namespace Collections.Jack;

public static class Program
{
    private static readonly ImmutableList<string> JackPoem = ImmutableList.Create<string>();

    public static void Main(string[] args)
    {
        var p1 = new Part1();
        var p2 = new Part2();
        var p3 = new Part3();
        var p4 = new Part4();
        var p5 = new Part5();
        var p6 = new Part6();
        var p7 = new Part7();
        var p8 = new Part8();
        var p9 = new Part9();


        var finalPoem =
            p9.AddPart(p8.AddPart(
                p7.AddPart(p6.AddPart(
                    p5.AddPart(p4.AddPart(
                        p3.AddPart(p2.AddPart(
                            p1.AddPart(JackPoem)))))))));

        Console.WriteLine("==========Part1==========");
        PrintImmutableList(p1.Poem);
        Console.WriteLine("==========Part2==========");
        PrintImmutableList(p2.Poem);
        Console.WriteLine("==========Part3==========");
        PrintImmutableList(p3.Poem);
        Console.WriteLine("==========Part4==========");
        PrintImmutableList(p4.Poem);
        Console.WriteLine("==========Part5==========");
        PrintImmutableList(p5.Poem);
        Console.WriteLine("==========Part6==========");
        PrintImmutableList(p6.Poem);
        Console.WriteLine("==========Part7==========");
        PrintImmutableList(p7.Poem);
        Console.WriteLine("==========Part8==========");
        PrintImmutableList(p8.Poem);
        Console.WriteLine("==========Part9==========");
        PrintImmutableList(p9.Poem);
        Console.WriteLine("==========Final==========");
        PrintImmutableList(finalPoem);
    }

    private static void PrintImmutableList(ImmutableList<string> immutableList)
    {
        immutableList.ForEach(Console.WriteLine);
    }
}
