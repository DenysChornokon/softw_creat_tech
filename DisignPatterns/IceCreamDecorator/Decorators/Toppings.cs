using IceCreamDecoratorTask.Components;

namespace IceCreamDecoratorTask.Decorators;

// ConcreteDecorator 1
public class ChocolateSyrup : IceCreamDecorator
{
    public ChocolateSyrup(IceCream iceCream) : base(iceCream) { }

    public override string GetDescription() => $"{base.GetDescription()}, з шоколадним сиропом";

    public override double GetCost() => base.GetCost() + 15.0; // + 15 грн до вартості
}

// ConcreteDecorator 2
public class Nuts : IceCreamDecorator
{
    public Nuts(IceCream iceCream) : base(iceCream) { }

    public override string GetDescription() => $"{base.GetDescription()}, з горішками";

    public override double GetCost() => base.GetCost() + 20.0;
}

// ConcreteDecorator 3
public class FruitBerries : IceCreamDecorator
{
    public FruitBerries(IceCream iceCream) : base(iceCream) { }

    public override string GetDescription() => $"{base.GetDescription()}, з ягодами";

    public override double GetCost() => base.GetCost() + 25.0;
}