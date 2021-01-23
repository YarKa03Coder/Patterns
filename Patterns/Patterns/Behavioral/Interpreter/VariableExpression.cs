namespace Patterns.Behavioral.Interpreter
{
    public class VariableExpression : BooleanExpression
    {
        public string Name { get; }

        public VariableExpression(string name)
        {
            Name = name;
        }
        
        public override bool Evaluate(Context context)
        { 
            return context.Lookup(Name);
        }

        public override BooleanExpression CopyExpression()
        {
            return new VariableExpression(Name);
        }

        public override BooleanExpression ReplaceExpression(string name, BooleanExpression expression)
        {
            return string.CompareOrdinal(name, Name) == 0 ? expression.CopyExpression() : new VariableExpression(Name);
        }
    }
}