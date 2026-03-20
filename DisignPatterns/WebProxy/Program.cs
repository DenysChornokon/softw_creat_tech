using WebProxyTask.Interfaces;
using WebProxyTask.Services;
using System.Diagnostics;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("=== Патерн Proxy (Кешуючий проксі-сервер) ===\n");

IPageDownloader proxyDownloader = new ProxyPageDownloader();
Stopwatch sw = new Stopwatch();

// --- Запит 1 ---
Console.WriteLine("--- Запит 1: https://knu.ua/ ---");
sw.Start();
string page1 = proxyDownloader.GetPage("https://knu.ua/");
sw.Stop();
Console.WriteLine($"[Результат] {page1}");
Console.WriteLine($"[Час виконання] {sw.ElapsedMilliseconds} мс\n");

// --- Запит 2 (Повторний) ---
Console.WriteLine("--- Запит 2: https://knu.ua/ (Повторний запит) ---");
sw.Restart();
string page2 = proxyDownloader.GetPage("https://knu.ua/");
sw.Stop();
Console.WriteLine($"[Результат] {page2}");
Console.WriteLine($"[Час виконання] {sw.ElapsedMilliseconds} мс\n"); // Тут має бути близько 0 мс!

// --- Запит 3 (Новий URL) ---
Console.WriteLine("--- Запит 3: https://github.com ---");
sw.Restart();
string page3 = proxyDownloader.GetPage("https://github.com");
sw.Stop();
Console.WriteLine($"[Результат] {page3}");
Console.WriteLine($"[Час виконання] {sw.ElapsedMilliseconds} мс\n");

Console.ReadKey();