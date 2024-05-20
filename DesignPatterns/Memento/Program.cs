using Memento.Models;

class Program
{
    static void Main(string[] args)
    {
        var editor = new Editor("This is the initial content.");

        var history = new History();

        // Зберігаємо початковий стан
        history.Push(editor.Save());

        // Редагуємо вміст
        editor.Type(" More text added.");

        // Переглядаємо та відновлюємо попередній стан
        Console.WriteLine(editor.GetContent()); // This is the initial content. More text added.

        editor.Restore(history.Pop());

        Console.WriteLine(editor.GetContent()); // This is the initial content.
    }
}
