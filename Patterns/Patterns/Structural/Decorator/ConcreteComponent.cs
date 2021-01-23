namespace Patterns.Structural.Decorator
{
    public class ConcreteComponent : Component
    {
        public string TextToBeWrapped { get; set; }
        
        public override string Operation()
        {
            return TextToBeWrapped;
        }
    }
}