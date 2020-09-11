using System;
using System.Collections.Generic;

namespace worksheet_nine_behavioural_design_patterns
{
    public class CareTaker
    {
        private Dictionary<string, Memento> _savepointStorage = new Dictionary<string, Memento>();

        public void SaveMemento(Memento memento, string savepointName)
        {
            try
            {
                _savepointStorage.Add(savepointName, memento);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        public Memento Memento(string savepointName)
        {
            Memento memento = null;

            try
            {
                memento = _savepointStorage[savepointName];
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

            return memento;
        }

        public void ClearSavePoints() => _savepointStorage.Clear();
    }
}