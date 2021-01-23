using Patterns.Behavioral.Mediator.ConceptualExample.ConcreteColleagues;

namespace Patterns.Behavioral.Mediator.ConceptualExample
{
    public class ConcreteMediator : Mediator
    {
        public Farmer Farmer { get; set; }
        public Shop Shop { get; set; }
        
        public override void Send(string message, Colleague colleague)
        {
            if (colleague == Farmer)
            {
                Shop.SellTomatoes(message);
            }
        }
    }
}