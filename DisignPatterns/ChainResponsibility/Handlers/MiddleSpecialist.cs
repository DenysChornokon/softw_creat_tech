using SupportChainTask.Models;

namespace SupportChainTask.Handlers;

public class MiddleSpecialist : SupportHandler
{
    public override void HandleRequest(SupportRequest request)
    {
        if (request.Severity == RequestSeverity.Medium)
        {
            Console.WriteLine($"[Середній спеціаліст] Вирішив запит #{request.Id}: '{request.Description}'. (Порада: очистіть кеш)");
        }
        else
        {
            Console.WriteLine($"[Середній спеціаліст] Запит #{request.Id} вимагає доступу до БД. Передаю на 3-тю лінію...");
            base.HandleRequest(request);
        }
    }
}