using TextEditorCommandTask.Core;

namespace TextEditorCommandTask.Commands;

public class DeleteTextCommand : ICommand
{
    private readonly TextDocument _document;
    private readonly int _index;
    private readonly int _length;

    private string _deletedText = string.Empty;

    public DeleteTextCommand(TextDocument document, int index, int length)
    {
        _document = document;
        _index = index;
        _length = length;
    }

    public void Execute()
    {
        if (_index >= 0 && _index < _document.Content.Length)
        {
            int len = Math.Min(_length, _document.Content.Length - _index);
            _deletedText = _document.Content.Substring(_index, len); 
            _document.Delete(_index, len);
        }
    }

    public void Undo()
    {
        if (!string.IsNullOrEmpty(_deletedText))
        {
            _document.Insert(_index, _deletedText);
        }
    }
}