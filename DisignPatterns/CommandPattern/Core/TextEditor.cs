using TextEditorCommandTask.Commands;

namespace TextEditorCommandTask.Core;

public class TextEditor
{
    private readonly TextDocument _document = new();
    private readonly Stack<ICommand> _undoStack = new();
    private readonly Stack<ICommand> _redoStack = new();

    public string Clipboard { get; set; } = string.Empty;
    public string Content => _document.Content;

    public void ExecuteCommand(ICommand command)
    {
        command.Execute();
        _undoStack.Push(command);
        _redoStack.Clear();
    }

    // Відміна дії (Undo)
    public void Undo()
    {
        if (_undoStack.Count > 0)
        {
            var command = _undoStack.Pop();
            command.Undo();
            _redoStack.Push(command); // Переносимо команду в стек Redo
        }
    }

    // Повтор дії (Redo)
    public void Redo()
    {
        if (_redoStack.Count > 0)
        {
            var command = _redoStack.Pop();
            command.Execute();
            _undoStack.Push(command); // Повертаємо команду назад в стек Undo
        }
    }

    // Обгортки для клієнта
    public void Insert(int index, string text) => ExecuteCommand(new InsertTextCommand(_document, index, text));

    public void Delete(int index, int length) => ExecuteCommand(new DeleteTextCommand(_document, index, length));


    public void Copy(int index, int length)
    {
        var command = new CopyTextCommand(_document, index, length, text => Clipboard = text);
        command.Execute();
    }
}