namespace Patterns.Behavioral.ChainOfResponsibility
{
    public abstract class AtmMachine
    {
        protected AtmMachine Handler;

        private readonly int _leaf;
        private int _amount;

        protected AtmMachine(int leaf)
        {
            _leaf = leaf;
        }

        public AtmMachine SetNext(AtmMachine handler) => Handler = handler;

        public void HandlerRequest(int cash)
        {
            if (cash - _leaf >= 0)
            {
                _amount = cash / _leaf;
                cash -= _amount * _leaf;

                System.Console.WriteLine(this.ToString());
            }
            
            Handler?.HandlerRequest(cash);
        }

        public override string ToString()
        {
            return _leaf.ToString() + '\t' + 'x' + _amount;
        }
    }
}