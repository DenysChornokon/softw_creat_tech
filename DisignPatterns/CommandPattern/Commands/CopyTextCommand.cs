using TextEditorCommandTask.Core;

namespace TextEditorCommandTask.Commands;

public class CopyTextCommand : ICommand
{
    private readonly TextDocument _document;
    private readonly int _index;
    private readonly int _length;
    private readonly Action<string> _clipboardAction;

    public CopyTextCommand(TextDocument document, int index, int length, Action<string> clipboardAction)
    {
        _document = document;
        _index = index;
        _length = length;
        _clipboardAction = clipboardAction; 
    }

    public void Execute()
    {
        if (_index >= 0 && _index < _document.Content.Length)
        {
            int len = Math.Min(_length, _document.Content.Length - _index);
            string textToCopy = _document.Content.Substring(_index, len);
            _clipboardAction(textToCopy); 
            Console.WriteLine($"[Система] Скопійовано: '{textToCopy}'");
        }
    }

    public void Undo()
    {}
}