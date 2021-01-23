namespace Patterns.Behavioral.Interpreter
{
    public abstract class BooleanExpression
    {
        public abstract bool Evaluate(Context context);

        public abstract BooleanExpression CopyExpression();

        public abstract BooleanExpression ReplaceExpression(string name, BooleanExpression expression);
    }
}