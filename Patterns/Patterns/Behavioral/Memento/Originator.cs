using System;
using System.Threading;
using Patterns.Behavioral.Memento.Interfaces;

namespace Patterns.Behavioral.Memento
{
    public class Originator
    {
        private DateTime Time { get; set; }

        private string _state;
        
        public string State
        {
            get => _state;
            set
            { 
                _state = value;
                Time = DateTime.UtcNow;
                
                Thread.Sleep(500);
            }
        }

        public Originator()
        {
            Time = DateTime.UtcNow;
            State = "Unstated";
            
            Thread.Sleep(500);
        }

        public void SetMemento(INarrowMemento memento)
        {
            (State, Time) = ((IWideMemento)memento).GetState();
            Console.WriteLine(this.ToString());
        }

        public INarrowMemento CreateMemento()
        {
            Console.WriteLine(this.ToString());
            return new Memento(State, Time);
        }

        public override string ToString()
        {
            return $"State: {State}\tDate Time: {Time}";
        }
    }
}