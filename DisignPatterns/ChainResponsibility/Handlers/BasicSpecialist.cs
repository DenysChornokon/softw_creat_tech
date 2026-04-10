using SupportChainTask.Models;

namespace SupportChainTask.Handlers;

public class BasicSpecialist : SupportHandler
{
    public override void HandleRequest(SupportRequest request)
    {
        if (request.Severity == RequestSeverity.Basic)
        {
            Console.WriteLine($"[Базовий спеціаліст] Вирішив запит #{request.Id}: '{request.Description}'. (Порада: спробуйте вимкнути і ввімкнути)");
        }
        else
        {
            Console.WriteLine($"[Базовий спеціаліст] Запит #{request.Id} занадто складний. Передаю на 2-гу лінію...");
            base.HandleRequest(request);
        }
    }
}