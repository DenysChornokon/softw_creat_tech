namespace ComputerFacadeTask.Subsystems;

public class Memory
{
    public void Load(long position, byte[] data)
    {
        Console.WriteLine($"[Memory] Завантаження {data.Length} байт даних за адресою 0x{position:X}...");
    }
}