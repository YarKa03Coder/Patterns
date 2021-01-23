using System;

namespace Patterns.Behavioral.Interpreter
{
    public class Constant
    {
        public BooleanExpression ReturnBooleanConstant(Context context, bool value)
        {
            VariableExpression variableExpression = null;
            
            switch (value)
            {
                case true:
                    variableExpression = new VariableExpression(Constants.True.ToString());
                    context.Assign(variableExpression, Convert.ToBoolean(Constants.True));
                    break;
                case false:
                    variableExpression = new VariableExpression(Constants.False.ToString());
                    context.Assign(variableExpression, Convert.ToBoolean(Constants.False));
                    break;
            }

            return variableExpression;
        }
    }
}