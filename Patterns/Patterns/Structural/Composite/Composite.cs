using System;
using System.Collections.Generic;

namespace Patterns.Structural.Composite
{
    public class Composite : Component
    {
        private readonly Dictionary<int, Component> _dictionary = new Dictionary<int, Component>();
        private int _currentPosition = -1;
        
        public Composite(string name)
            : base(name)
        {

        }
        
        public override void Add(int key, Component component)
        {
            _dictionary.Add(key, component);
        }

        public override void Operation()
        {
            Console.WriteLine(Name);

            foreach (var component in _dictionary)
            {
                component.Value.Operation();
            }
        }

        public override void Build(int[] numberInts)
        {
            while (true)
            {
                if (_currentPosition < numberInts.Length - 1)
                {
                    var keyValue = numberInts[++_currentPosition] % 2;

                    if (!_dictionary.ContainsKey(keyValue))
                    {
                        _dictionary.Add(keyValue, new Composite($"branch {keyValue}"));
                    }

                    _dictionary[keyValue].Add(_currentPosition, new Leaf(numberInts[_currentPosition].ToString()));

                    continue;
                }

                break;
            }
            
            _currentPosition = -1;
        }
    }
}