namespace BookstoreFlyweightTask.Models;

public class Book
{
    public string Barcode { get; }
    public decimal Price { get; }

    private readonly BookFlyweight _flyweight;

    public Book(string barcode, decimal price, BookFlyweight flyweight)
    {
        Barcode = barcode;
        Price = price;
        _flyweight = flyweight;
    }

    public void Show()
    {
        _flyweight.DisplayInfo(Barcode, Price);
    }
}