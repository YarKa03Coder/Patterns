namespace Patterns.Structural.Flyweight
{
    public class Actor : Flyweight
    {
        private readonly string _actorName;

        public Actor(string actorName)
        {
            _actorName = actorName;
        }

        public override void Greeting(string speech)
        {
            System.Console.WriteLine($"[I'm {_actorName}] {speech}");
        }
    }
}