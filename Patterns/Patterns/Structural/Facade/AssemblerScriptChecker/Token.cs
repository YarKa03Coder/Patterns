using System.Collections.Generic;

namespace Patterns.Structural.Facade.AssemblerScriptChecker
{
    public class Token
    {
        public List<string> Lexemes { get; set; } = new List<string>();
        
        public Token(IEnumerable<string> lexemes)
        {
            Lexemes.AddRange(lexemes);
        }
    }
}