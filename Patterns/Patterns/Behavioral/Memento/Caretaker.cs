using System;
using System.Collections.Generic;
using System.Linq;
using Patterns.Behavioral.Memento.Interfaces;

namespace Patterns.Behavioral.Memento
{
    public class Caretaker
    {
        private readonly List<INarrowMemento> _mementoes = new List<INarrowMemento>();

        private readonly Originator _originator;

        public Caretaker(Originator originator)
        {
            _originator = originator;
        }
        
        public void Backup()
        {
            Console.Write("(Saving state ...)" + '\t');
            _mementoes.Add(_originator.CreateMemento());
        }

        public void Restore()
        {
            if (_mementoes.Count == 0)
            {
                return;
            }

            var memento = _mementoes.Last();
            _mementoes.Remove(memento);
            
            Console.Write("(Restoring state ...)" + '\t');
            _originator.SetMemento(memento);
        }
    }
}