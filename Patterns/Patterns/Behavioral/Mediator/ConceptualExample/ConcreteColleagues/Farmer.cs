using System;

namespace Patterns.Behavioral.Mediator.ConceptualExample.ConcreteColleagues
{
    public class Farmer : Colleague
    {
        public Farmer(Mediator mediator) : base(mediator)
        {
        }

        public void GrowTomato()
        {
            string tomato = "Tomatoes";
            Console.WriteLine(this.GetType().Name + " raised " + tomato);
            Mediator.Send(tomato, this);
        }
    }
}