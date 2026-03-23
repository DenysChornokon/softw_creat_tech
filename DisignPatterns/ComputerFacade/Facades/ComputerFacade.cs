using ComputerFacadeTask.Subsystems;

namespace ComputerFacadeTask.Facades;

public class ComputerFacade
{
    private const long BootAddress = 0x0000000;
    private const long BootSector = 0;
    private const int SectorSize = 512;

    private readonly Cpu _cpu;
    private readonly Memory _memory;
    private readonly HardDrive _hardDrive;

    public ComputerFacade()
    {
        _cpu = new Cpu();
        _memory = new Memory();
        _hardDrive = new HardDrive();
    }

    public void TurnOn()
    {
        Console.WriteLine("=== Початок запуску комп'ютера ===");

        _cpu.Freeze();
        _memory.Load(BootAddress, _hardDrive.Read(BootSector, SectorSize));
        _cpu.Jump(BootAddress);
        _cpu.Execute();

        Console.WriteLine("=== Комп'ютер успішно запущено! ===");
    }
}