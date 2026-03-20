using WebProxyTask.Interfaces;

namespace WebProxyTask.Services;

public class ProxyPageDownloader : IPageDownloader
{
    // Посилання на реальний об'єкт 
    private readonly RealPageDownloader _realDownloader = new();

    // Словник: ключ - URL, значення - HTML
    private readonly Dictionary<string, string> _cache = new();

    public string GetPage(string url)
    {
        if (_cache.TryGetValue(url, out string? cachedPage))
        {
            Console.WriteLine($"[Проксі] Сторінку {url} знайдено в кеші. Віддаємо миттєво.");
            return cachedPage;
        }

        Console.WriteLine($"[Проксі] Кеш порожній для {url}. Звернення до реального сервера...");
        string page = _realDownloader.GetPage(url);

        _cache[url] = page;

        return page;
    }
}