namespace Patterns.Behavioral.ChainOfResponsibility.Banknotes
{
    public class Banknote500 : AtmMachine
    {
        private const int Leaf = (int)Leafs.Leaf500;

        public Banknote500() :
            base(Leaf)
        {

        }
    }
}