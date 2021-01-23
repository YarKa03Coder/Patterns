using System.Collections.Generic;

namespace Patterns.Structural.Proxy.ProtectionProxy
{
    public class RealOperator : Subject
    {
        private readonly Dictionary<string, string> _dictionary;

        public RealOperator()
        {
            _dictionary = new Dictionary<string, string>
            {
                {"Pre-created Key","TestValue"}
            };
        }

        public override void Create(string key, string value)
        {
            _dictionary.Add(key, value);
        }

        public override string Read(string key)
        {
            return _dictionary[key];
        }

        public override bool Update(string key, string value)
        {
            if (_dictionary.ContainsKey(key))
            {
                _dictionary[key] = value;
                return true;
            }

            return false;
        }

        public override bool Delete(string key)
        {
            return _dictionary.Remove(key);
        }
    }
}