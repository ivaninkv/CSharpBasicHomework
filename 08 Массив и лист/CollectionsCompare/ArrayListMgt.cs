using System.Collections;
using System.Diagnostics;

namespace CollectionsCompare;

public static class ArrayListMgt
{
    private static void FillArrayList(ArrayList arrayList, int numberOfElements)
    {
        for (var i = 0; i < numberOfElements; i++) arrayList.Add(i + 1);
    }

    private static int GetElementByIndex(ArrayList arrayList, int indexOfElement)
    {
        return (int)(arrayList[indexOfElement] ?? 0);
    }

    private static void PrintCleanDivisionElements(ArrayList arrayList, int divider)
    {
        foreach (var elem in arrayList)
            if ((int)elem % divider == 0)
                Console.Write(elem + ",");
        Console.WriteLine();
    }

    public static string[] RunBenchmark(ArrayList arrayList, int numberOfElements, int indexOfElement, int divider)
    {
        var result = new string[3];
        var stopWatch = Stopwatch.StartNew();
        stopWatch.Restart();
        FillArrayList(arrayList, numberOfElements);
        stopWatch.Stop();
        result[0] = $"Fill collection elapsed time: {stopWatch.Elapsed}";

        stopWatch.Restart();
        GetElementByIndex(arrayList, indexOfElement);
        stopWatch.Stop();
        result[1] = $"Get element by index elapsed time: {stopWatch.Elapsed}";

        stopWatch.Restart();
        PrintCleanDivisionElements(arrayList, divider);
        stopWatch.Stop();
        result[2] = $"Print clean division elements elapsed time: {stopWatch.Elapsed}";

        return result;
    }
}