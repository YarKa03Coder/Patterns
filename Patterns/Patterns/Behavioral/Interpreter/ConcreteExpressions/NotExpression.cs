namespace Patterns.Behavioral.Interpreter.ConcreteExpressions
{
    public class NotExpression : BooleanExpression
    {
        private readonly BooleanExpression _operand1;
        
        public NotExpression(BooleanExpression operand1)
        {
            _operand1 = operand1;
        }
        
        public override bool Evaluate(Context context)
        {
            return ! _operand1.Evaluate(context);
        }

        public override BooleanExpression CopyExpression()
        {
            return new NotExpression(_operand1.CopyExpression());
        }

        public override BooleanExpression ReplaceExpression(string name, BooleanExpression expression)
        {
            return new NotExpression(_operand1.ReplaceExpression(name, expression));
        }
    }
}