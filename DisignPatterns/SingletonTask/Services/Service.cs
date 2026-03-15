namespace SingletonTask.Services;

public sealed class Service
{
    private static readonly Lazy<Service> _instance = new(() => new Service());

    private bool _isWorking = false;
    private readonly object _lockObject = new(); // Об'єкт для блокування потоків 

    public static Service Instance => _instance.Value;

    private Service()
    {
    }

    public void DoWork(string message)
    {
        // статус "Working"
        lock (_lockObject)
        {
            _isWorking = true;
        }

        Console.WriteLine($"[Service] Виконую роботу: {message}");

        Thread.Sleep(2000);

        // статус "Idle"
        lock (_lockObject)
        {
            _isWorking = false;
        }
    }

    public string GetStatus()
    {
        lock (_lockObject)
        {
            return _isWorking ? "Working" : "Idle";
        }
    }
}
