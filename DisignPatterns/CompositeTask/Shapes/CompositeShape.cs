namespace CompositeTask.Shapes;

// Composite - складений об'єкт
public class CompositeShape : IShape
{
    private readonly string _name;
    private readonly List<IShape> _children = new();

    public CompositeShape(string name)
    {
        _name = name;
    }

    // Методи для керування нащадками
    public void Add(IShape shape) => _children.Add(shape);
    public void Remove(IShape shape) => _children.Remove(shape);

    public void Draw(int depth)
    {
        Console.WriteLine(new string('-', depth) + $" Група фігур: {_name} +");

        foreach (var shape in _children)
        {
            shape.Draw(depth + 2);
        }
    }
}