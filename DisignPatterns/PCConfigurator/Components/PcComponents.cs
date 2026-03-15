namespace PCConfigurator.Components;

// Базовий абстрактний клас для всіх компонентів
public abstract class PcComponent
{
    public string Manufacturer { get; set; }

    protected PcComponent(string manufacturer)
    {
        Manufacturer = manufacturer;
    }

    public abstract PcComponent Clone();
}

public class Case : PcComponent
{
    public string FormFactor { get; set; }
    public Case(string manufacturer, string formFactor) : base(manufacturer) => FormFactor = formFactor;
    public override PcComponent Clone() => (PcComponent)MemberwiseClone();
}

public class Ram : PcComponent
{
    public int CapacityGb { get; set; }
    public Ram(string manufacturer, int capacityGb) : base(manufacturer) => CapacityGb = capacityGb;
    public override PcComponent Clone() => (PcComponent)MemberwiseClone();
}

public class Storage : PcComponent
{
    public int CapacityGb { get; set; }
    public string Type { get; set; } // HDD, SSD
    public Storage(string manufacturer, int capacityGb, string type) : base(manufacturer)
    {
        CapacityGb = capacityGb;
        Type = type;
    }
    public override PcComponent Clone() => (PcComponent)MemberwiseClone();
}

public class Motherboard : PcComponent
{
    public string Chipset { get; set; }
    public Motherboard(string manufacturer, string chipset) : base(manufacturer) => Chipset = chipset;
    public override PcComponent Clone() => (PcComponent)MemberwiseClone();
}

public class Cpu : PcComponent
{
    public string Model { get; set; }
    public Cpu(string manufacturer, string model) : base(manufacturer) => Model = model;
    public override PcComponent Clone() => (PcComponent)MemberwiseClone();
}

public class Gpu : PcComponent
{
    public string Model { get; set; }
    public Gpu(string manufacturer, string model) : base(manufacturer) => Model = model;
    public override PcComponent Clone() => (PcComponent)MemberwiseClone();
}

public class PcMonitor : PcComponent 
{
    public double Diagonal { get; set; }
    public PcMonitor(string manufacturer, double diagonal) : base(manufacturer) => Diagonal = diagonal;
    public override PcComponent Clone() => (PcComponent)MemberwiseClone();
}
