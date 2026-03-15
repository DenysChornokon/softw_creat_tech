using PCConfigurator.Prototypes;
using PCConfigurator.Components;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("=== Патерн Prototype (Конфігуратор ПК) ===\n");

// 1. Створюємо базові прототипи
var officePcPrototype = new PC
{
    TypeName = "Офісний ПК (Базовий)",
    PcCase = new Case("Dell", "Mini-Tower"),
    Board = new Motherboard("Gigabyte", "H410"),
    Processor = new Cpu("Intel", "Core i3-10100"),
    VideoCard = new Gpu("Intel", "UHD Graphics 630"),
    Memory = new Ram("Kingston", 8),
    Drive = new Storage("Western Digital", 256, "SSD"),
    Display = new PcMonitor("Philips", 24)
};

var gamingPcPrototype = new PC
{
    TypeName = "Ігровий ПК (Базовий)",
    PcCase = new Case("Asus", "Mid-Tower"),
    Board = new Motherboard("Asus", "PRIME B360M-K"),
    Processor = new Cpu("Intel", "Core i7-9700"),
    VideoCard = new Gpu("Nvidia", "RTX 4060"),
    Memory = new Ram("Crucial", 16),
    Drive = new Storage("Acer RE100", 1000, "SSD"),
    SecondaryDrive = new Storage("Toshiba HDWD110", 1000, "HDD"),
    Display = new PcMonitor("AOC", 27)
};

// 2. Демонстрація роботи: Клієнт замовляє ігровий ПК, але хоче більше ОЗП
Console.WriteLine("Створюємо замовлення на базі ігрового прототипу...");

PC customOrder = gamingPcPrototype.Clone(); // Клонуємо прототип
customOrder.TypeName = "Ігровий ПК (Кастомне замовлення)";

// Змінюємо характеристики клону (завдяки Deep Clone це не вплине на gamingPcPrototype)
customOrder.Memory.CapacityGb = 32;

// 3. Виводимо результати
gamingPcPrototype.PrintSpecs();
customOrder.PrintSpecs();

Console.ReadKey();