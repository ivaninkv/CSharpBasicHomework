namespace ImageDownloader.App;

public static class Program
{
    private const string ImageUrl =
        "https://effigis.com/wp-content/uploads/2015/02/Iunctus_SPOT5_5m_8bit_RGB_DRA_torngat_mountains_national_park_8bits_1.jpg";

    public static async Task Main(string[] args)
    {
        var imageDownloader = new ImageDownloader();
        imageDownloader.ImageStarted += imageDownloader.OnImageStarted;
        imageDownloader.ImageCompleted += imageDownloader.OnImageCompleted;
        var task = imageDownloader.Download(ImageUrl);

        while (!task.IsCompleted)
        {
            Console.WriteLine("Нажмите клавишу A для выхода или любую другую клавишу для проверки статуса скачивания");
            var key = Console.ReadKey();
            Console.WriteLine();
            if (key.Key != ConsoleKey.A)
            {
                Console.WriteLine($"Картинка загружена: {task.IsCompleted}");
            }
            else
            {
                Environment.Exit(0);
            }
        }

        await task;
    }
}
