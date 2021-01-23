using System;
using Patterns.Structural.Facade.AssemblerScriptChecker;

namespace Patterns.Structural.Facade
{
    public class ScriptChecker
    {
        private readonly Scanner _scanner;
        private readonly Parser _parser;
        
        public ScriptChecker()
        {
            _parser = new Parser();
            _scanner = new Scanner();
        }

        public void ScriptCheck(string sourceCode, Action<string> notification)
        {
            try
            {
                _parser.Parse(_scanner, sourceCode);

                notification("Operation is successful. Script checked.");
            }
            catch (Exception exception)
            {
                var errorMessage = "Operation is not successful. ERROR:\n";
                errorMessage += $"{exception.GetType().Name}: {exception.Message}";
                notification(errorMessage);
            }
        }
    }
}