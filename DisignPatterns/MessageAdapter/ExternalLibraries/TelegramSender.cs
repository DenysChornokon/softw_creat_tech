namespace MessageAdapterTask.ExternalLibraries;

// Стороння бібліотека для Telegram
public class TelegramSender
{
    public void SendTelegram(string message, string username)
    {
        Console.WriteLine($"[Telegram] Відправлено користувачу @{username}: {message}");
    }
}