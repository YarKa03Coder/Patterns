namespace Patterns.Behavioral.Command
{
    public class ArithmeticUnit
    {
        public int Register { get; private set; }

        public void Run(char operatorCode, int operand)
        {
            //System.Console.Write($"{Register} {operatorCode} {operand} = ");

            switch (operatorCode)
            {
                case '+':
                    Register += operand;
                    break;
                case '-':
                    Register -= operand;
                    break;
                case '*':
                    Register *= operand;
                    break;
                case '/':
                    Register /= operand;
                    break;
            }
        }
    }
}