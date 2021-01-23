namespace Patterns.Behavioral.ChainOfResponsibility.Banknotes
{
    public class Banknote10 : AtmMachine
    {
        private const int Leaf = (int) Leafs.Leaf10;

        public Banknote10() :
            base(Leaf)
        {

        }
    }
}