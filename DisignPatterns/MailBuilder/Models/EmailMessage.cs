namespace MailBuilderTask.Models;

// електронний лист
public class EmailMessage
{
    public string? From { get; set; }
    public string? To { get; set; }
    public string? Subject { get; set; }
    public string? Body { get; set; }


    public override string ToString()
    {
        return $"Від кого: {From}\nКому: {To}\nТема: {Subject}\nПовідомлення:\n{Body}";
    }
}