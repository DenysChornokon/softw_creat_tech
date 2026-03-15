using SingletonTask.Services;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("=== Патерн Singleton (Сервіс) ===\n");

var service = Service.Instance;

Console.WriteLine($"Початковий статус: {service.GetStatus()}");

var workTask = Task.Run(() => service.DoWork("Обробка даних..."));

Thread.Sleep(500);

Console.WriteLine($"Статус під час роботи: {Service.Instance.GetStatus()}");

workTask.Wait();

Console.WriteLine($"Кінцевий статус: {Service.Instance.GetStatus()}");


var anotherServiceRef = Service.Instance;
bool isSameInstance = ReferenceEquals(service, anotherServiceRef);
Console.WriteLine($"\nЧи 'service' і 'anotherServiceRef' посилаються на один і той самий об'єкт в пам'яті? - {isSameInstance}");

Console.ReadKey();