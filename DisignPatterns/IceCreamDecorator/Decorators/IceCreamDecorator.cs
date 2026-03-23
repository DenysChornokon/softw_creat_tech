using IceCreamDecoratorTask.Components;

namespace IceCreamDecoratorTask.Decorators;

public abstract class IceCreamDecorator : IceCream
{
    protected readonly IceCream _iceCream;

    protected IceCreamDecorator(IceCream iceCream)
    {
        _iceCream = iceCream;
    }

    public override string GetDescription() => _iceCream.GetDescription();

    public override double GetCost() => _iceCream.GetCost();
}