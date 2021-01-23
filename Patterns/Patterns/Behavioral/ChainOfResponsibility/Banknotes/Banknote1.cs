namespace Patterns.Behavioral.ChainOfResponsibility.Banknotes
{
    public class Banknote1 : AtmMachine
    {
        private const int Leaf = (int) Leafs.Leaf1;

        public Banknote1() : 
            base(Leaf)
        {
            
        }
    }
}