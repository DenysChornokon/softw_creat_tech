namespace ComputerFacadeTask.Subsystems;

public class Cpu
{
    public void Freeze() => Console.WriteLine("[CPU] Заморозка поточних процесів...");
    public void Jump(long position) => Console.WriteLine($"[CPU] Перехід до адреси пам'яті 0x{position:X}...");
    public void Execute() => Console.WriteLine("[CPU] Початок виконання інструкцій...");
}