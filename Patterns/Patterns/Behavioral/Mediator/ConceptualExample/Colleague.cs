namespace Patterns.Behavioral.Mediator.ConceptualExample
{
    public abstract class Colleague
    {
        protected Mediator Mediator;

        protected Colleague(Mediator mediator)
        {
            this.Mediator = mediator;
        }
    }
}