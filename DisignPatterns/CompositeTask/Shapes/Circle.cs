namespace CompositeTask.Shapes;

// Leaf - простий об'єкт, не має нащадків
public class Circle : IShape
{
    private readonly string _color;

    public Circle(string color)
    {
        _color = color;
    }

    public void Draw(int depth)
    {
        Console.WriteLine(new string('-', depth) + $" Малюю {_color} коло O");
    }
}