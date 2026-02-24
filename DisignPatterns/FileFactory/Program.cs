using FileFactory.Factories;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("=== Патерн Factory Method ===");
Console.WriteLine("Оберіть тип файлу для створення:");
Console.WriteLine("1 - Текстовий файл (.txt)");
Console.WriteLine("2 - Графічний файл (.png)");
Console.Write("Ваш вибір: ");

string? choice = Console.ReadLine();

Console.Write("Введіть назву файлу (без розширення): ");
string fileName = Console.ReadLine() ?? "default_name";

FileCreator creator = choice switch
{
    "1" => new TextFileCreator(),
    "2" => new GraphicFileCreator(),
    _ => throw new ArgumentException("Невідомий тип файлу.")
};

Console.WriteLine("\n--- Результат роботи ---");
// Використання фабрики
creator.WorkWithFile(fileName);

Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
Console.ReadKey();