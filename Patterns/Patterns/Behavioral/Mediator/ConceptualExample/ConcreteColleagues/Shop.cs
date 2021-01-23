using System;

namespace Patterns.Behavioral.Mediator.ConceptualExample.ConcreteColleagues
{
    public class Shop : Colleague
    {
        public Shop(Mediator mediator) : base(mediator)
        {
        }

        public void SellTomatoes(string message)
        {
            Console.WriteLine(this.GetType().Name + " sold " + message);
        }
    }
}