namespace CompositeTask.Shapes;

// Leaf - простий об'єкт
public class Rectangle : IShape
{
    private readonly int _width;
    private readonly int _height;

    public Rectangle(int width, int height)
    {
        _width = width;
        _height = height;
    }

    public void Draw(int depth)
    {
        Console.WriteLine(new string('-', depth) + $" Малюю прямокутник [{_width}x{_height}] []");
    }
}