namespace FileFactory.Products;

// загальний інтерфейс для всіх типів файлів
public interface IFile
{
    string FileName { get; }
    void Open();
    void Process();
}