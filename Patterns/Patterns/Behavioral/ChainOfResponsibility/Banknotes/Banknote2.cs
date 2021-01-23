namespace Patterns.Behavioral.ChainOfResponsibility.Banknotes
{
    public class Banknote2 : AtmMachine
    {
        private const int Leaf = (int)Leafs.Leaf2;

        public Banknote2() :
            base(Leaf)
        {

        }
    }
}