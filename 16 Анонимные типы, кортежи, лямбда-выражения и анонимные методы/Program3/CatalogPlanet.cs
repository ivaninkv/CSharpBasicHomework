namespace Program3;

public class CatalogPlanet
{
    private readonly List<Planet> _listOfPlanet = new();

    public CatalogPlanet(params Planet[] planet)
    {
        _listOfPlanet.Add(new Planet("Венера", 2, 38025, null));
        _listOfPlanet.Add(new Planet("Земля", 3, 40075, _listOfPlanet.Last()));
        _listOfPlanet.Add(new Planet("Марс", 4, 21344, _listOfPlanet.Last()));
        _listOfPlanet.AddRange(planet);
    }

    public (int numberFromSun, int equatorLength, string message) GetPlanet(string planetName,
        Func<string, string?> validator)
    {
        var text = validator(planetName);
        if (!string.IsNullOrEmpty(text))
        {
            return (0, 0, text);
        }

        foreach (var planet in _listOfPlanet.Where(planet => planet.Name.Equals(planetName)))
        {
            return (planet.NumberFromSun, planet.EquatorLength, "");
        }

        return (0, 0, "Не удалось найти планету");
    }
}
