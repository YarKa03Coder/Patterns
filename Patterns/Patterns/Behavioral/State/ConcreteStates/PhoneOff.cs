using System;

namespace Patterns.Behavioral.State.ConcreteStates
{
    public class PhoneOff : State
    {
        public PhoneOff(Phone phone):
            base(phone)
        {
            Console.WriteLine($"Phone : {phone.Name} => State : Phone is off");
        }
        
        protected override void ChangeState(Phone phone, Power power)
        {
            switch (power)
            {
                case Power.Off:
                    break;
                case Power.On:
                    phone.State = new PhoneOn(phone);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(power), power, null);
            }
        }
    }
}