using System.Collections.Concurrent;

namespace Collections.Librarian;

public static class Program
{
    private static readonly ConcurrentDictionary<string, int> _books = new();

    public static void Main(string[] args)
    {
        Task.Run(() =>
        {
            while (true)
            {
                Thread.Sleep(TimeSpan.FromSeconds(1));

                foreach (var book in _books)
                {
                    if (book.Value < 100)
                    {
                        _books[book.Key] = book.Value + 1;
                    }
                    else
                    {
                        _books.TryRemove(book);
                    }
                }
            }
        });


        while (true)
        {
            ShowMenu();

            var userChoice = Console.ReadLine() ?? "";
            switch (userChoice)
            {
                case "1":
                    InputBook();
                    break;
                case "2":
                    PrintUnread();
                    break;
                case "3":
                    Exit();
                    break;
            }
        }
    }

    private static void Exit()
    {
        Environment.Exit(0);
    }

    private static void PrintUnread()
    {
        foreach (var book in _books)
        {
            Console.WriteLine($"{book.Key} - {book.Value}%");
        }
    }

    private static void InputBook()
    {
        Console.Write("Введите название книги: ");
        var book = Console.ReadLine();
        _books.TryAdd(book, 0);
    }

    private static void ShowMenu()
    {
        Console.WriteLine("====================================");
        Console.WriteLine("1 - добавить книгу;");
        Console.WriteLine("2 - вывести список непрочитанного;");
        Console.WriteLine("3 - выйти;");
    }
}
