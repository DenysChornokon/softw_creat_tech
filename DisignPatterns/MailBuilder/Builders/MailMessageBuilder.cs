using MailBuilderTask.Models;
using System;

namespace MailBuilderTask.Builders;

public class MailMessageBuilder
{
    private readonly EmailMessage _emailMessage = new();

    public MailMessageBuilder SetFrom(string address)
    {
        _emailMessage.From = address;
        return this;
    }

    public MailMessageBuilder SetTo(string address)
    {
        _emailMessage.To = address;
        return this;
    }

    public MailMessageBuilder SetSubject(string subject)
    {
        _emailMessage.Subject = subject;
        return this;
    }

    public MailMessageBuilder SetBody(string body)
    {
        _emailMessage.Body = body;
        return this;
    }

    public EmailMessage Build()
    {
        if (string.IsNullOrWhiteSpace(_emailMessage.From) || string.IsNullOrWhiteSpace(_emailMessage.To))
        {
            throw new InvalidOperationException("Поля 'Від кого' та 'Кому' є обов'язковими для листа.");
        }

        return _emailMessage;
    }
}