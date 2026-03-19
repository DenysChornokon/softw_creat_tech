namespace MessageAdapterTask.ExternalLibraries;

// Стороння бібліотека для SMS
public class SMSsender
{
    public void SendSMS(string message, string phoneNumber)
    {
        Console.WriteLine($"[SMS] Відправлено на номер {phoneNumber}: {message}");
    }
}