namespace TopExt.App;

public static class Program
{
    public static void Main(string[] args)
    {
        var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        var ints = list.Top(30).ToList();
        Console.WriteLine(string.Join(", ", ints));

        var people = new List<Person>()
        {
            new("Ivan", 25),
            new("Petr", 35),
            new("Semen", 45),
            new("Anna", 30)
        };
        var ppl = people.Top(30, person => person.Age).ToList();
        Console.WriteLine(string.Join(", ", ppl));
    }
}

internal class Person
{
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string Name { get; }
    public int Age { get; }

    public override string ToString()
    {
        return $"{Name} - {Age} years old";
    }
}
