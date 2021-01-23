using Patterns.Behavioral.Command.Commands;

namespace Patterns.Behavioral.Command
{
    public class Calculator
    {
        private readonly ArithmeticUnit _arithmeticUnit;
        private readonly ControlUnit _controlUnit;

        public Calculator()
        {
            _arithmeticUnit = new ArithmeticUnit();
            _controlUnit = new ControlUnit();
        }

        private int Run(Command command)
        {
            _controlUnit.StoreCommand(command);
            _controlUnit.ExecuteCommand();
            return _arithmeticUnit.Register;
        }

        public int Add(int operand)
        {
            return Run(new Addition(_arithmeticUnit, operand));
        }

        public int Sub(int operand)
        {
            return Run(new Substract(_arithmeticUnit, operand));
        }

        public int Mult(int operand)
        {
            return Run(new Multiplication(_arithmeticUnit, operand));
        }

        public int Div(int operand)
        {
            return Run(new Division(_arithmeticUnit, operand));
        }

        public int Undo(int levels)
        {
            _controlUnit.Undo(levels);
            return _arithmeticUnit.Register;
        }

        public int Redo(int levels)
        {
            _controlUnit.Redo(levels);
            return _arithmeticUnit.Register;
        }
    }
}