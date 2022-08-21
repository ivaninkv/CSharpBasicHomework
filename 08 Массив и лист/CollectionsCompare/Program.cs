using System.Collections;

namespace CollectionsCompare;

internal class Program
{
    public static void Main(string[] args)
    {
        const int numberOfElements = 1_000_000;
        const int indexOfElement = 496_753;
        const int divider = 777;
        var list = new List<int>(numberOfElements);
        var arrayList = new ArrayList(numberOfElements);
        var linkedList = new LinkedList<int>();
        var listBenchmark = ListMgt.RunBenchmark(list, numberOfElements, indexOfElement, divider);
        var arrayListBenchmark = ArrayListMgt.RunBenchmark(arrayList, numberOfElements, indexOfElement, divider);
        var linkedListBenchmark = LinkedListMgt.RunBenchmark(linkedList, numberOfElements, indexOfElement, divider);

        Console.WriteLine("########### List ###########");
        Array.ForEach(listBenchmark, Console.WriteLine);
        Console.WriteLine("########### ArrayList ###########");
        Array.ForEach(arrayListBenchmark, Console.WriteLine);
        Console.WriteLine("########### LinkedList ###########");
        Array.ForEach(linkedListBenchmark, Console.WriteLine);
    }
}