namespace Patterns.Structural.Flyweight
{
    public class EvilRole : Flyweight
    {
        private readonly Flyweight _flyweight;
        private readonly string _character;

        public EvilRole(Flyweight flyweight, string character)
        {
            _flyweight = flyweight;
            _character = character;
        }
        
        public override void Greeting(string speech)
        {
            _flyweight.Greeting($"{speech} ({_character})");
        }
    }
}