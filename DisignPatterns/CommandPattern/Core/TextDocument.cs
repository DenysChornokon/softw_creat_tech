namespace TextEditorCommandTask.Core;

public class TextDocument
{
    private string _content = string.Empty;
    public string Content => _content;

    public void Insert(int index, string text)
    {
        if (index < 0 || index > _content.Length) index = _content.Length;
        _content = _content.Insert(index, text);
    }

    public void Delete(int index, int length)
    {
        if (index < 0 || index >= _content.Length) return;
        if (index + length > _content.Length) length = _content.Length - index;

        _content = _content.Remove(index, length);
    }
}