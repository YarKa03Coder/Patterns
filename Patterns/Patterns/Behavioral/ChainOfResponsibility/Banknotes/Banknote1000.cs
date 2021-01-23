namespace Patterns.Behavioral.ChainOfResponsibility.Banknotes
{
    public class Banknote1000 : AtmMachine
    {
        private const int Leaf = (int)Leafs.Leaf1000;

        public Banknote1000() :
            base(Leaf)
        {

        }
    }
}