using System;
using System.Collections.Generic;

namespace Patterns.Structural.Facade.AssemblerScriptChecker
{
    public class Scanner
    {
        private readonly List<Token> _tokens = new List<Token>();
        
        public List<Token> Scan(string sourceCode)
        {
            var commands = sourceCode.Trim().Split(Constants.ProgramDelimiter, StringSplitOptions.RemoveEmptyEntries);

            foreach (var command in commands)
            {
                var lexemes = command.Split(Constants.LexemesDelimiter, StringSplitOptions.RemoveEmptyEntries);
                
                _tokens.Add(new Token(lexemes));
            }
            
            return _tokens;
        }
    }
}