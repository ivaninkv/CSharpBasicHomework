using System.Diagnostics;

namespace CollectionsCompare;

public static class ListMgt
{
    private static void FillList(List<int> list, int numberOfElements)
    {
        for (var i = 0; i < numberOfElements; i++) list.Add(i + 1);
    }

    private static int GetElementByIndex(List<int> list, int indexOfElement)
    {
        return list[indexOfElement];
    }

    private static void PrintCleanDivisionElements(List<int> list, int divider)
    {
        foreach (var elem in list)
            if (elem % divider == 0)
                Console.Write(elem + ",");
        Console.WriteLine();
    }

    public static string[] RunBenchmark(List<int> list, int numberOfElements, int indexOfElement, int divider)
    {
        var result = new string[3];
        var stopWatch = Stopwatch.StartNew();
        FillList(list, numberOfElements);
        stopWatch.Stop();
        result[0] = $"Fill elapsed time: {stopWatch.Elapsed}";

        stopWatch.Restart();
        GetElementByIndex(list, indexOfElement);
        stopWatch.Stop();
        result[1] = $"Get element by index elapsed time: {stopWatch.Elapsed}";

        stopWatch.Restart();
        PrintCleanDivisionElements(list, divider);
        stopWatch.Stop();
        result[2] = $"Print clean division elements elapsed time: {stopWatch.Elapsed}";

        return result;
    }
}