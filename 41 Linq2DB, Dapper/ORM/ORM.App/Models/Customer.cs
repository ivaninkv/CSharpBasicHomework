namespace ORM.App.Models;

public class Customer
{
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public override string ToString()
    {
        return $"Customer: {ID} - {FirstName} {LastName}, {Age}";
    }
}
