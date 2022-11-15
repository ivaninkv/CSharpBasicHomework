namespace Program2;

public class CatalogPlanet
{
    private readonly List<Planet> _listOfPlanet = new();
    private int _counter;

    public CatalogPlanet(params Planet[] planet)
    {
        _listOfPlanet.Add(new Planet("Венера", 2, 38025, null));
        _listOfPlanet.Add(new Planet("Земля", 3, 40075, _listOfPlanet.Last()));
        _listOfPlanet.Add(new Planet("Марс", 4, 21344, _listOfPlanet.Last()));
        _listOfPlanet.AddRange(planet);
    }

    public (int numberFromSun, int equatorLength, string message) GetPlanet(string planetName)
    {
        _counter++;
        if (_counter % 3 == 0)
        {
            return (0, 0, "Вы спрашиваете слишком часто");
        }

        foreach (var planet in _listOfPlanet.Where(planet => planet.Name.Equals(planetName)))
        {
            return (planet.NumberFromSun, planet.EquatorLength, "");
        }


        return (0, 0, "Не удалось найти планету");
    }
}
