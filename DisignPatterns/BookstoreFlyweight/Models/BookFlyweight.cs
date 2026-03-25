namespace BookstoreFlyweightTask.Models;

// зберігає внутрішній стан
public class BookFlyweight
{
    public string Title { get; }
    public string Author { get; }

    public BookFlyweight(string title, string author)
    {
        Title = title;
        Author = author;
    }

    // приймає зовнішній стан
    public void DisplayInfo(string barcode, decimal price)
    {
        Console.WriteLine($"[Книга] '{Title}' (Автор: {Author}) | Штрихкод: {barcode} | Ціна: {price} грн");
    }
}