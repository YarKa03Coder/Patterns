using System;
using Patterns.Behavioral.Memento.Interfaces;

namespace Patterns.Behavioral.Memento
{
    public class Memento : IWideMemento
    {
        private readonly string _state;
        private readonly DateTime _dateTime;
        
        public (string, DateTime) GetState()
        {
            return (_state, _dateTime);
        }

        public Memento(string state, DateTime dateTime)
        {
            _state = state;
            _dateTime = dateTime;
        }
    }
}