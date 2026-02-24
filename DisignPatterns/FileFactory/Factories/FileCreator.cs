using FileFactory.Products;

namespace FileFactory.Factories;

// Creator
public abstract class FileCreator
{
    // метод який підкласи повинні перевизначити
    public abstract IFile CreateFile(string name);

    // робота з об'єктом через його інтерфейс
    public void WorkWithFile(string name)
    {
        IFile file = CreateFile(name); // Виклик фабричного методу
        file.Open();
        file.Process();
    }
}