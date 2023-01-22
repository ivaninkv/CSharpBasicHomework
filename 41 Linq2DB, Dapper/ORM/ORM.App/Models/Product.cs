namespace ORM.App.Models;

public class Product
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int StockQuantity { get; set; }
    public int Price { get; set; }
    public override string ToString()
    {
        return $"ID = {ID}, Name - {Name}, {Description}, Qty = {StockQuantity}, Price = {Price}";
    }
}
