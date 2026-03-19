namespace MessageAdapterTask.Core;

// Клас, відправка пошти
public class MessageSender : IMessageSender
{
    public void Send(string message, string recipient)
    {
        Console.WriteLine($"[Email] Відправлено лист на {recipient}: {message}");
    }
}