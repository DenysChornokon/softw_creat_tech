namespace MessageAdapterTask.Core;

// Загальний інтерфейс
public interface IMessageSender
{
    void Send(string message, string recipient);
}