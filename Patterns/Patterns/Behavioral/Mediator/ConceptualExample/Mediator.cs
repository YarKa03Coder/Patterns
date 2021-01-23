namespace Patterns.Behavioral.Mediator.ConceptualExample
{
    public abstract class Mediator
    {
        public abstract void Send(string message, Colleague colleague);
    }
}