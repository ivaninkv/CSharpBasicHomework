namespace Program3;

public class Program
{
    private static readonly List<string> PlanetsForCheck = new()
    {
        "Земля",
        "Лимония",
        "Марс"
    };

    private static int _counter;

    public static void Main(string[] args)
    {
        var catalogPlanet = new CatalogPlanet();
        Console.WriteLine("====== Основоное задание ======");
        foreach (var planet in PlanetsForCheck)
        {
            var result = catalogPlanet.GetPlanet(planet,
                s =>
                {
                    _counter++;
                    return _counter % 3 == 0 ? "Вы спрашиваете слишком часто" : null;
                });
            PrintInfo(planet, result);
        }
        Console.WriteLine();

        // задание со *
        Console.WriteLine("====== Задание со звездочкой ======");
        foreach (var planet in PlanetsForCheck)
        {
            var result = catalogPlanet.GetPlanet(planet,
                s => s.Equals("Лимония") ? "Это запретная планета" : null);
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
