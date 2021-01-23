namespace Patterns.Behavioral.ChainOfResponsibility.Banknotes
{
    public class Banknote200 : AtmMachine
    {
        private const int Leaf = (int)Leafs.Leaf200;

        public Banknote200() :
            base(Leaf)
        {

        }
    }
}