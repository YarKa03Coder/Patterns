namespace Patterns.Behavioral.Command.Commands
{
    class Substract : Command
    {
        public Substract(ArithmeticUnit unit, int operand)
        {
            this.ArithmeticUnit = unit;
            this.Operand = operand;
        }

        public override void Execute()
        {
            this.ArithmeticUnit.Run('-', this.Operand);
        }

        public override void UnExecute()
        {
            this.ArithmeticUnit.Run('+', this.Operand);
        }
    }
}
