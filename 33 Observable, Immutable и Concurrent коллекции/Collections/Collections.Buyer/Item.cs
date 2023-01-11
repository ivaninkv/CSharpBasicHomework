namespace Collections.Buyer;

public class Item
{
    public Item(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public int Id { get; }
    public string Name { get; }
}
