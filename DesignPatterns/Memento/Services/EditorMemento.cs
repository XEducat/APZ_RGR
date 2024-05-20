namespace Memento.Services
{
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
}
