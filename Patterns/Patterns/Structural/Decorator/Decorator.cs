namespace Patterns.Structural.Decorator
{
    public class Decorator : Component
    {
        public Component Component { protected get; set; }
        
        public override string Operation()
        {
            return Component is null ? string.Empty : Component.Operation();
        }
    }
}