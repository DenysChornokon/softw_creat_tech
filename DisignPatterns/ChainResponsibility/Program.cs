using SupportChainTask.Handlers;
using SupportChainTask.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("=== Патерн Chain of Responsibility (Служба підтримки) ===\n");

var basic = new BasicSpecialist();
var middle = new MiddleSpecialist();
var senior = new SeniorSpecialist();

// Basic -> Middle -> Senior
basic.SetNext(middle).SetNext(senior);

// пул запитів 
var requests = new List<SupportRequest>
{
    new (1, RequestSeverity.Basic, "Не можу зайти в акаунт, забув пароль"),
    new (2, RequestSeverity.Medium, "Не відображається історія замовлень у профілі"),
    new (3, RequestSeverity.Complex, "Помилка 500 при спробі оформити покупку"),
    new (4, RequestSeverity.Critical, "Хтось видалив production базу")
};

foreach (var request in requests)
{
    Console.WriteLine($"\n--- Надходження нового запиту #{request.Id} [{request.Severity}] ---");
    basic.HandleRequest(request); 
    Thread.Sleep(800); 
}

Console.ReadKey();