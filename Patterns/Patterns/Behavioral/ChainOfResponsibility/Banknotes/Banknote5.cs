namespace Patterns.Behavioral.ChainOfResponsibility.Banknotes
{
    public class Banknote5 : AtmMachine
    {
        private const int Leaf = (int)Leafs.Leaf5;

        public Banknote5() :
            base(Leaf)
        {

        }
    }
}