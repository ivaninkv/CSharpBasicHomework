namespace Program2;

public class Program
{
    private static readonly List<string> PlanetsForCheck = new()
    {
        "Земля",
        "Лимония",
        "Марс"
    };


    public static void Main(string[] args)
    {
        var catalogPlanet = new CatalogPlanet();
        foreach (var planet in PlanetsForCheck)
        {
            var result = catalogPlanet.GetPlanet(planet);
            PrintInfo(planet, result);
        }
    }

    private static void PrintInfo(string planetName, (int numberFromSun, int equatorLength, string message) info)
    {
        Console.WriteLine(string.IsNullOrEmpty(info.message)
            ? $"Name: {planetName}, NumberFromSun: {info.numberFromSun}, EquatorLength: {info.equatorLength}"
            : info.message);
    }
}
