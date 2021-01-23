namespace Patterns.Behavioral.Interpreter.ConcreteExpressions
{
    public class AndExpression : BooleanExpression
    {
        private readonly BooleanExpression _operand1;
        private readonly BooleanExpression _operand2;

        public AndExpression(BooleanExpression operand1, BooleanExpression operand2)
        {
            _operand1 = operand1;
            _operand2 = operand2;
        }

        public override bool Evaluate(Context context)
        {
            return _operand1.Evaluate(context) && _operand2.Evaluate(context);
        }

        public override BooleanExpression CopyExpression()
        {
            return new AndExpression(_operand1.CopyExpression(), _operand2.CopyExpression());
        }

        public override BooleanExpression ReplaceExpression(string name, BooleanExpression expression)
        {
            return new AndExpression(_operand1.ReplaceExpression(name, expression),
                _operand2.ReplaceExpression(name, expression));
        }
    }
}