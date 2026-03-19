using MessageAdapterTask.Core;
using MessageAdapterTask.ExternalLibraries;

namespace MessageAdapterTask.Adapters;

public class SmsAdapter : IMessageSender
{
    private readonly SMSsender _smsSender;

    public SmsAdapter(SMSsender smsSender)
    {
        _smsSender = smsSender;
    }

    // јдаптуЇмо метод Send п≥д SendSMS
    public void Send(string message, string recipient)
    {
        _smsSender.SendSMS(message, recipient);
    }
}