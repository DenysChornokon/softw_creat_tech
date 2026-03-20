using WebProxyTask.Interfaces;

namespace WebProxyTask.Services;

public class RealPageDownloader : IPageDownloader
{
    public string GetPage(string url)
    {
        Console.WriteLine($"[Мережа] Встановлення з'єднання з {url}...");

        // Імітація затримку мережі 
        Thread.Sleep(2000);

        return $"<html><body>Вміст сторінки {url}</body></html>";
    }
}