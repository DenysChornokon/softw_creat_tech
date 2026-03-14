using System.Text;
using MailBuilderTask.Builders;

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("=== Шаблон Builder (Ланцюжковий виклик) ===");

try
{
    // Демонстрація ланцюжкового виклику методів (Fluent Interface)
    var email = new MailMessageBuilder()
        .SetFrom("denys@test.com")
        .SetTo("professor@university.ua")
        .SetSubject("Лабораторна робота №1-2: Шаблони проектування")
        .SetBody("Доброго дня! Надсилаю виконану лабораторну роботу. Завдання з Builder реалізовано успішно.")
        .Build();

    Console.WriteLine("\nСтворено електронний лист:");
    Console.WriteLine("--------------------------------------------------");
    Console.WriteLine(email);
    Console.WriteLine("--------------------------------------------------");
}
catch (Exception ex)
{
    Console.WriteLine($"\n[Помилка створення листа]: {ex.Message}");
}

Console.WriteLine("\nНатисніть будь-яку клавішу для завершення...");
Console.ReadKey();