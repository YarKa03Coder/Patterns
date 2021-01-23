namespace Patterns.Behavioral.ChainOfResponsibility.Banknotes
{
    public class Banknote50 : AtmMachine
    {
        private const int Leaf = (int)Leafs.Leaf50;

        public Banknote50() :
            base(Leaf)
        {

        }
    }
}