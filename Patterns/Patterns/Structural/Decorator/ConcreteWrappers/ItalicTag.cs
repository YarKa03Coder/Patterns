namespace Patterns.Structural.Decorator.ConcreteWrappers
{
    public class ItalicTag : Decorator
    {
        public override string Operation()
        {
            return $"<i>{base.Operation()}</i>";
        }
    }
}