namespace ComputerFacadeTask.Subsystems;

public class HardDrive
{
    public byte[] Read(long lba, int size)
    {
        Console.WriteLine($"[HDD] Читання {size} байт із сектора {lba}...");
        return new byte[size]; // Імітація зчитаних даних
    }
}