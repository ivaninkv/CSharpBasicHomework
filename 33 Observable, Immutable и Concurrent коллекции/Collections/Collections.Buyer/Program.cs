namespace Collections.Buyer;

public static class Program
{
    public static void Main(string[] args)
    {
        var customer = new Customer();
        var shop = new Shop();

        customer.Subscribe(shop);

        Console.WriteLine("Управляющие команды:");
        Console.WriteLine("A - добавить товар");
        Console.WriteLine("D - удалить товар");
        Console.WriteLine("X - выйти из программы");

        while (true)
        {
            var key = Console.ReadKey();
            Console.WriteLine();
            switch (key.Key)
            {
                case ConsoleKey.A:
                    shop.Add($"Товар от {DateTime.Now}");
                    break;
                case ConsoleKey.D:
                    Console.Write("Введите Id товара для удаления: ");
                    if (int.TryParse(Console.ReadLine(), out var idForDelete))
                    {
                        shop.Remove(idForDelete);
                    }
                    else
                    {
                        Console.WriteLine("Некорректный Id для удаления");
                    }

                    break;
                case ConsoleKey.X:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
