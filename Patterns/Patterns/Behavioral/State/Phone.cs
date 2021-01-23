using Patterns.Behavioral.State.ConcreteStates;

namespace Patterns.Behavioral.State
{
    public class Phone
    {
        public string Name { get; }
        internal State State;

        public Phone(string name)
        {
            Name = name;
            State = new PhoneOff(this);
        }

        public void Request(Power power)
        {
            State.Handle(power);
        }
    }
}