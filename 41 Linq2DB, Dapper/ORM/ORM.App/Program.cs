using ORM.App.Repositories;

namespace ORM.App;

public static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("==================Customers==================");
        var custRepo = new CustomerRepository();
        var customers = custRepo.GetCustomers();
        customers.ForEach(Console.WriteLine);
        Console.WriteLine(custRepo.GetCustomerById(1));

        Console.WriteLine("==================Orders==================");
        var orderRepo = new OrderRepository();
        var orders = orderRepo.GetOrders();
        orders.ForEach(Console.WriteLine);
        Console.WriteLine(orderRepo.GetOrderById(1));

        Console.WriteLine("==================Products==================");
        var productRepo = new ProductRepository();
        var products = productRepo.GetProducts();
        products.ForEach(Console.WriteLine);
        Console.WriteLine(productRepo.GetProductById(1));
    }
}
