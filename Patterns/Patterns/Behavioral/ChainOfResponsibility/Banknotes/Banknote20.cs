namespace Patterns.Behavioral.ChainOfResponsibility.Banknotes
{
    public class Banknote20 : AtmMachine
    {
        private const int Leaf = (int)Leafs.Leaf20;

        public Banknote20() :
            base(Leaf)
        {

        }
    }
}