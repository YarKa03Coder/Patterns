using System;

namespace Patterns.Structural.Facade.Exceptions
{
    internal class ParserException : Exception
    {
        public ParserException(string message) :
            base(message)
        {
        }
    }
}