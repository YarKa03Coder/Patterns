namespace Patterns.Structural.Flyweight
{
    public class HeroRole : Flyweight
    {
        private readonly Flyweight _flyweight;
        private readonly string _character;

        public HeroRole(Flyweight flyweight, string character)
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