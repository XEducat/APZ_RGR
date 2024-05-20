using System;

// Originator - клас, чия структура може бути збережена та відновлена
class Editor
{
    private string content;

    public Editor(string content)
    {
        this.content = content;
    }

    public void Type(string words)
    {
        content += " " + words;
    }

    public string GetContent()
    {
        return content;
    }

    public EditorMemento Save()
    {
        return new EditorMemento(content);
    }

    public void Restore(EditorMemento memento)
    {
        content = memento.GetSavedContent();
    }
}

// Memento - клас, який зберігає стан Originator
class EditorMemento
{
    private readonly string content;

    public EditorMemento(string content)
    {
        this.content = content;
    }

    public string GetSavedContent()
    {
        return content;
    }
}

// Caretaker - клас, який зберігає історію змін
class History
{
    private readonly List<EditorMemento> states = new List<EditorMemento>();

    public void Push(EditorMemento memento)
    {
        states.Add(memento);
    }

    public EditorMemento Pop()
    {
        var lastIndex = states.Count - 1;
        var lastState = states[lastIndex];
        states.RemoveAt(lastIndex);
        return lastState;
    }
}

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
