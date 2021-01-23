namespace Patterns.Structural.Decorator.ConcreteWrappers
{
    public class BoldTag : Decorator
    {
        public override string Operation()
        {
            return $"<b>{base.Operation()}</b>";
        }
    }
}