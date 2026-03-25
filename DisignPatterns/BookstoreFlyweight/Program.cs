using BookstoreFlyweightTask.Factories;
using BookstoreFlyweightTask.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("=== Патерн Flyweight ===\n");

BookFactory factory = new BookFactory();
List<Book> storeInventory = new List<Book>();

var kingFlyweight = factory.GetBookFlyweight("Інститут", "Стівен Кінг");

storeInventory.Add(new Book("BC-10001", 650.00m, kingFlyweight));
storeInventory.Add(new Book("BC-10002", 650.00m, kingFlyweight));
storeInventory.Add(new Book("BC-10003", 600.00m, kingFlyweight));


var orwellFlyweight = factory.GetBookFlyweight("1984", "Джордж Орвелл");
storeInventory.Add(new Book("BC-20001", 350.00m, orwellFlyweight));


var kingFlyweightAgain = factory.GetBookFlyweight("Інститут", "Стівен Кінг");
storeInventory.Add(new Book("BC-10004", 650.00m, kingFlyweightAgain));

Console.WriteLine("\n------");
foreach (var book in storeInventory)
{
    book.Show();
}

Console.WriteLine("\n--- Статистика пам'яті ---");
Console.WriteLine($"Всього фізичних примірників книг у магазині: {storeInventory.Count}");
Console.WriteLine($"Створено унікальних об'єктів Flyweight у пам'яті: {factory.GetTotalFlyweightsCount()}");

Console.ReadKey();