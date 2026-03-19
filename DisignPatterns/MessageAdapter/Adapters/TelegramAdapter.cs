using MessageAdapterTask.Core;
using MessageAdapterTask.ExternalLibraries;

namespace MessageAdapterTask.Adapters;

public class TelegramAdapter : IMessageSender
{
    private readonly TelegramSender _telegramSender;

    public TelegramAdapter(TelegramSender telegramSender)
    {
        _telegramSender = telegramSender;
    }

    // јдаптуЇмо метод Send п≥д SendTelegram
    public void Send(string message, string recipient)
    {
        _telegramSender.SendTelegram(message, recipient);
    }
}