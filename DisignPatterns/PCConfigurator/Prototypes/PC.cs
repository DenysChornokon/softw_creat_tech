using PCConfigurator.Components;

namespace PCConfigurator.Prototypes;

public class PC
{
    public string TypeName { get; set; } = string.Empty;
    public Case PcCase { get; set; } = null!;
    public Ram Memory { get; set; } = null!;
    public Storage Drive { get; set; } = null!;
    public Storage? SecondaryDrive { get; set; } // Опціональний другий диск
    public Motherboard Board { get; set; } = null!;
    public Cpu Processor { get; set; } = null!;
    public Gpu VideoCard { get; set; } = null!;
    public PcMonitor Display { get; set; } = null!;

    // Глибоке копіювання (Deep cloning)
    public PC Clone()
    {
        var clonedPc = (PC)MemberwiseClone();

        // Обов'язково клонуємо референсні типи (компоненти), щоб вони не вказували на ті самі об'єкти в пам'яті
        clonedPc.PcCase = (Case)PcCase.Clone();
        clonedPc.Memory = (Ram)Memory.Clone();
        clonedPc.Drive = (Storage)Drive.Clone();
        clonedPc.SecondaryDrive = (Storage?)SecondaryDrive?.Clone();
        clonedPc.Board = (Motherboard)Board.Clone();
        clonedPc.Processor = (Cpu)Processor.Clone();
        clonedPc.VideoCard = (Gpu)VideoCard.Clone();
        clonedPc.Display = (PcMonitor)Display.Clone();

        return clonedPc;
    }

    public void PrintSpecs()
    {
        Console.WriteLine($"\n--- Конфігурація: {TypeName} ---");
        Console.WriteLine($"Корпус: {PcCase.Manufacturer} ({PcCase.FormFactor})");
        Console.WriteLine($"Мат. плата: {Board.Manufacturer} {Board.Chipset}");
        Console.WriteLine($"Процесор: {Processor.Manufacturer} {Processor.Model}");
        Console.WriteLine($"Відеокарта: {VideoCard.Manufacturer} {VideoCard.Model}");
        Console.WriteLine($"ОЗП: {Memory.Manufacturer} {Memory.CapacityGb}GB");
        Console.WriteLine($"Накопичувач 1: {Drive.Manufacturer} {Drive.CapacityGb}GB {Drive.Type}");

        if (SecondaryDrive != null)
            Console.WriteLine($"Накопичувач 2: {SecondaryDrive.Manufacturer} {SecondaryDrive.CapacityGb}GB {SecondaryDrive.Type}");

        Console.WriteLine($"Монітор: {Display.Manufacturer} {Display.Diagonal}\"");
    }
}
