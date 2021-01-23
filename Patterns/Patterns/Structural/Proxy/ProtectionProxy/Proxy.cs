using System;

namespace Patterns.Structural.Proxy.ProtectionProxy
{
    public class Proxy : Subject
    {
        private readonly Subject _realOperator;
        private readonly string _accessLevel;

        public Proxy(Subject realOperator, string accessLevel)
        {
            _realOperator = realOperator;
            _accessLevel = accessLevel;
        }

        public override void Create(string key, string value)
        {
            if (_accessLevel.Equals("Owner"))
            {
                _realOperator.Create(key, value);
            }
            else
            {
                throw new UnauthorizedAccessException("Create operation: Access denied.");
            }
        }

        public override string Read(string key)
        {
            return _realOperator.Read(key);
        }

        public override bool Update(string key, string value)
        {
            if (_accessLevel.Equals("User"))
            {
                throw new UnauthorizedAccessException("Update operation: Access denied.");
            }

            return _realOperator.Update(key, value);
        }

        public override bool Delete(string key)
        {
            if(_accessLevel.Equals("Administrator") || _accessLevel.Equals("Owner"))
            { 
                return _realOperator.Delete(key);
            }

            throw new UnauthorizedAccessException("Delete operation: Access denied.");
        }
    }
}