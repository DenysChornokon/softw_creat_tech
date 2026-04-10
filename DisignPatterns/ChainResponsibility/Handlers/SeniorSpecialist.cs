using SupportChainTask.Models;

namespace SupportChainTask.Handlers;

public class SeniorSpecialist : SupportHandler
{
    public override void HandleRequest(SupportRequest request)
    {
        if (request.Severity == RequestSeverity.Complex)
        {
            Console.WriteLine($"[Старший спеціаліст] Вирішив запит #{request.Id}: '{request.Description}'. (Дія: переписав половину БД)");
        }
        else
        {
            Console.WriteLine($"[Старший спеціаліст] Запит #{request.Id} ({request.Severity}) - вирішити не вдалося. Моліться.");
            base.HandleRequest(request);
        }
    }
}