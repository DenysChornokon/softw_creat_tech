namespace SupportChainTask.Models;

public enum RequestSeverity
{
    Basic,   // Забув пароль
    Medium,  // Не проходить оплата
    Complex, // Впала база даних
    Critical // Згорів дата-центр
}

public record SupportRequest(int Id, RequestSeverity Severity, string Description);