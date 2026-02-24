using System;

namespace FileFactory.Products;

// графічний файл
public class GraphicFile : IFile
{
    public string FileName { get; }

    public GraphicFile(string fileName)
    {
        FileName = $"{fileName}.png";
    }

    public void Open() => Console.WriteLine($"[GraphicFile] Відкриття зображення: {FileName}");

    public void Process() => Console.WriteLine($"[GraphicFile] Завантаження пікселів для {FileName}...");
}