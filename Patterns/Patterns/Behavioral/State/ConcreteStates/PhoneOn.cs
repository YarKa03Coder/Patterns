using System;

namespace Patterns.Behavioral.State.ConcreteStates
{
    public class PhoneOn : State
    {
        public PhoneOn(Phone phone)
            :base(phone)
        {
            Console.WriteLine($"Phone : {phone.Name} => State : Phone is on");
        }

        protected override void ChangeState(Phone phone, Power power)
        {
            switch (power)
            {
                case Power.Off:
                    phone.State = new PhoneOff(phone);
                    break;
                case Power.On:
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(power), power, null);
            }
        }
    }
}