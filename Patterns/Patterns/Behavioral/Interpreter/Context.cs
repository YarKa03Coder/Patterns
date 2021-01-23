using System.Collections.Generic;

namespace Patterns.Behavioral.Interpreter
{
    public class Context
    {
        private readonly Dictionary<string, bool> _values;

        public Context()
        {
            _values = new Dictionary<string, bool>();
        }
        
        public bool Lookup(string name)
        {
            return _values[name];
        }

        public void Assign(VariableExpression variableExpression, bool value)
        {
            if (_values.ContainsKey(variableExpression.Name))
            {
                _values[variableExpression.Name] = value;
            }
            else
            {
                _values.Add(variableExpression.Name, value);
            }
        }
    }
}