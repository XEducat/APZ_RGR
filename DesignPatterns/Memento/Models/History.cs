using Memento.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
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
}
