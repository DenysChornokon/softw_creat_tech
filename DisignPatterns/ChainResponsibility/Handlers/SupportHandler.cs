using SupportChainTask.Models;

namespace SupportChainTask.Handlers;

public abstract class SupportHandler
{
    private SupportHandler? _nextHandler;

    public SupportHandler SetNext(SupportHandler nextHandler)
    {
        _nextHandler = nextHandler;
        return nextHandler;
    }

    public virtual void HandleRequest(SupportRequest request)
    {
        if (_nextHandler != null)
        {
            _nextHandler.HandleRequest(request);
        }
        else
        {
            Console.WriteLine($"[Система] Запит #{request.Id} ({request.Severity}) залишився без відповіді.");
        }
    }
}