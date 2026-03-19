using MessageAdapterTask.Core;
using MessageAdapterTask.ExternalLibraries;
using MessageAdapterTask.Adapters;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("=== Патерн Adapter (Відправка повідомлень) ===\n");

// Старий спосіб (Email)
IMessageSender emailSender = new MessageSender();
emailSender.Send("Звіт за місяць готовий.", "boss@company.com");

// сторонні бібліотеки
var externalSmsLib = new SMSsender();
var externalTelegramLib = new TelegramSender();

// Адаптери
IMessageSender smsSender = new SmsAdapter(externalSmsLib);
IMessageSender telegramSender = new TelegramAdapter(externalTelegramLib);


smsSender.Send("Ваша посилка прибула у відділення.", "+380501234567");
telegramSender.Send("Привіт.", "denys_ch");

Console.ReadKey();