namespace Patterns.Behavioral.ChainOfResponsibility.Banknotes
{
    public class Banknote100 : AtmMachine
    {
        private const int Leaf = (int)Leafs.Leaf100;

        public Banknote100() :
            base(Leaf)
        {

        }
    }
}