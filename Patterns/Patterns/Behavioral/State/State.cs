namespace Patterns.Behavioral.State
{
    public abstract class State
    {
        protected Phone Phone;
        
        protected State(Phone phone)
        {
            Phone = phone;
        }
        
        public virtual void Handle(Power power)
        {
            ChangeState(Phone, power);
        }

        protected abstract void ChangeState(Phone phone, Power power);
    }
}