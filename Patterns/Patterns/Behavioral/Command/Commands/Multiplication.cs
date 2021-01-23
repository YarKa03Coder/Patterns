namespace Patterns.Behavioral.Command.Commands
{
    class Multiplication : Command
    {
        public Multiplication(ArithmeticUnit unit, int operand)
        {
            this.ArithmeticUnit = unit;
            this.Operand = operand;
        }

        public override void Execute()
        {
            this.ArithmeticUnit.Run('*', this.Operand);
        }

        public override void UnExecute()
        {
            this.ArithmeticUnit.Run('/', this.Operand);
        }
    }
}
