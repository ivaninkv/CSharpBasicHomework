namespace ORM.App.Models;

public class Order
{
    public int ID { get; set; }
    public int CustomerID { get; set; }
    public int ProducID { get; set; }
    public int Quantity { get; set; }

    public override string ToString()
    {
        return $"ID = {ID}, CustomerID = {CustomerID}, ProductID = {ProducID}, Quantity = {Quantity}";
    }
}
