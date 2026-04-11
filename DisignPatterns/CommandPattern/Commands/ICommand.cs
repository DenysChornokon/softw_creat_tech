namespace TextEditorCommandTask.Commands;

public interface ICommand
{
    void Execute();
    void Undo();
}