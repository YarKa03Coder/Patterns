namespace Patterns.Behavioral.Command
{
    public abstract class Command
    {
        protected ArithmeticUnit ArithmeticUnit;
        protected int Operand;

        public abstract void Execute();
        public abstract void UnExecute();
    }
}