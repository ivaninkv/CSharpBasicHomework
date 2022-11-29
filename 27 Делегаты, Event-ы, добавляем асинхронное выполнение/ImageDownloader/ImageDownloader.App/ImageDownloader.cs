using System.Net;

namespace ImageDownloader.App;

public class ImageDownloader
{
    public event Action? ImageStarted;
    public event Action? ImageCompleted;

    public async Task Download(string url)
    {
        var fileName = "bigimage.jpg";
        var webClient = new WebClient();
        Console.WriteLine("Качаю \"{0}\" из \"{1}\"...\n", fileName, url);
        ImageStarted?.Invoke();
        await webClient.DownloadFileTaskAsync(url, fileName);
        Console.WriteLine("Успешно скачал \"{0}\" из \"{1}\"", fileName, url);
        ImageCompleted?.Invoke();
    }

    public void OnImageStarted()
    {
        Console.WriteLine("Скачивание файла началось");
    }

    public void OnImageCompleted()
    {
        Console.WriteLine("Скачивание файла закончилось");
    }
}
