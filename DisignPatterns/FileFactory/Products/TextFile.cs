using System;

namespace FileFactory.Products;

// текстовий файл
public class TextFile : IFile
{
    public string FileName { get; }

    public TextFile(string fileName)
    {
        FileName = $"{fileName}.txt";
    }

    public void Open() => Console.WriteLine($"[TextFile] Відкриття текстового файлу: {FileName}");

    public void Process() => Console.WriteLine($"[TextFile] Читання та редагування тексту у файлі {FileName}...");
}