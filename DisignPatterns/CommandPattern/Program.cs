using TextEditorCommandTask.Core;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("=== Патерн Command (Текстовий редактор) ===\n");

TextEditor editor = new TextEditor();

// Вставка тексту
editor.Insert(0, "Привіт, світе!");
Console.WriteLine($"[Вставка]: {editor.Content}");

// Вставка додаткового тексту
editor.Insert(7, "прекрасний ");
Console.WriteLine($"[Вставка]: {editor.Content}");

// Копіювання частини тексту
editor.Copy(7, 10);
Console.WriteLine($"[Буфер обміну]: {editor.Clipboard}");

// Видалення слова "світе"
editor.Delete(18, 7);
Console.WriteLine($"[Видалення]: {editor.Content}");

Console.WriteLine("\n--- (Undo / Redo) ---");

// Відміняємо видалення
editor.Undo();
Console.WriteLine($"[Undo 1]: {editor.Content}");

// Відміняємо вставку слова "прекрасний"
editor.Undo();
Console.WriteLine($"[Undo 2]: {editor.Content}");

// Повертаємо вставку слова "прекрасний" назад
editor.Redo();
Console.WriteLine($"[Redo 1]: {editor.Content}");

Console.ReadKey();