using System.Diagnostics;

namespace CollectionsCompare;

public static class LinkedListMgt
{
    private static void FillLinkedList(LinkedList<int> linkedList, int numberOfElements)
    {
        for (var i = 0; i < numberOfElements; i++) linkedList.AddLast(i + 1);
    }

    private static int GetElementByIndex(LinkedList<int> linkedList, int indexOfElement)
    {
        return linkedList.ElementAt(indexOfElement);
    }

    private static void PrintCleanDivisionElements(LinkedList<int> linkedList, int divider)
    {
        foreach (var elem in linkedList)
            if (elem % divider == 0)
                Console.Write(elem + ",");
        Console.WriteLine();
    }

    public static string[] RunBenchmark(LinkedList<int> linkedList, int numberOfElements, int indexOfElement,
        int divider)
    {
        var result = new string[3];
        var stopWatch = Stopwatch.StartNew();
        stopWatch.Restart();
        FillLinkedList(linkedList, numberOfElements);
        stopWatch.Stop();
        result[0] = $"Fill collection elapsed time: {stopWatch.Elapsed}";

        stopWatch.Restart();
        GetElementByIndex(linkedList, indexOfElement);
        stopWatch.Stop();
        result[1] = $"Get element by index elapsed time: {stopWatch.Elapsed}";

        stopWatch.Restart();
        PrintCleanDivisionElements(linkedList, divider);
        stopWatch.Stop();
        result[2] = $"Print clean division elements elapsed time: {stopWatch.Elapsed}";

        return result;
    }
}