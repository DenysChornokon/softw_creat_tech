using TextEditorCommandTask.Core;

namespace TextEditorCommandTask.Commands;

public class InsertTextCommand : ICommand
{
    private readonly TextDocument _document;
    private readonly string _textToInsert;
    private readonly int _index;

    public InsertTextCommand(TextDocument document, int index, string textToInsert)
    {
        _document = document;
        _index = index;
        _textToInsert = textToInsert;
    }

    public void Execute() => _document.Insert(_index, _textToInsert);

    // скасувати вставку - видалити вставлений текст
    public void Undo() => _document.Delete(_index, _textToInsert.Length);
}