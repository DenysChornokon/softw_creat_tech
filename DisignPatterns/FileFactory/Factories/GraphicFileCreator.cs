using FileFactory.Products;

namespace FileFactory.Factories;


public class GraphicFileCreator : FileCreator
{
    public override IFile CreateFile(string name)
    {
        return new GraphicFile(name);
    }
}