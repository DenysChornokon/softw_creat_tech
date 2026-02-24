using FileFactory.Products;

namespace FileFactory.Factories;


public class TextFileCreator : FileCreator
{
    public override IFile CreateFile(string name)
    {
        return new TextFile(name);
    }
}