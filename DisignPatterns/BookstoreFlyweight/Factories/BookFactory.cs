using BookstoreFlyweightTask.Models;

namespace BookstoreFlyweightTask.Factories;

public class BookFactory
{
    private readonly Dictionary<string, BookFlyweight> _flyweights = new();

    public BookFlyweight GetBookFlyweight(string title, string author)
    {
        // унікальний ключ для кешу
        string key = $"{title}_{author}";

        if (!_flyweights.ContainsKey(key))
        {
            _flyweights[key] = new BookFlyweight(title, author);
            Console.WriteLine($"\n[Фабрика] Створено новий спільний об'єкт (Flyweight) для: '{title}'");
        }
        else
        {
            Console.WriteLine($"\n[Фабрика] Використано існуючий Flyweight для: '{title}'");
        }

        return _flyweights[key];
    }

    public int GetTotalFlyweightsCount() => _flyweights.Count;
}