using System;
using System.Collections.Generic;
using Patterns.Structural.Facade.Exceptions;

namespace Patterns.Structural.Facade.AssemblerScriptChecker
{
    internal class Parser
    {
        private readonly Dictionary<string, int> _dictionaryVariables = new Dictionary<string, int>();
        private Scanner _scanner;
        
        public void Parse(Scanner scanner, string sourceCode)
        {
            _scanner = scanner;

            var tokens = _scanner.Scan(sourceCode);

            foreach (var token in tokens)
            {
                ParseToken(token.Lexemes);
            }
        }

        private void ParseToken(IList<string> lexemes)
        {
            if (Enum.TryParse(lexemes[0].ToUpper(), out Commands command))
            {
                lexemes.RemoveAt(0);
                
                var parameters = string.Join(string.Empty, lexemes).Replace(" ",string.Empty).
                    Split(Constants.ParameterDelimiter, StringSplitOptions.RemoveEmptyEntries);
                
                VerifyParameters(parameters, command);
            }
            else
            {
                if (lexemes.Count == 3 && lexemes[1].ToUpper() == "DD" && int.TryParse(lexemes[2], out var parsedResult)) // DD (dd) -> 4 bytes -> 32-bits, so it means int value
                {
                    if (!_dictionaryVariables.ContainsKey(lexemes[0]))
                    {
                        _dictionaryVariables.Add(lexemes[0], parsedResult);
                    }
                    else
                    {
                        throw new ParserException($"A variable named {lexemes[0]} already exists");
                    }
                }
                else
                {
                    throw new ParserException("Wrong token");
                }
            }
        }

        private void VerifyParameters(IReadOnlyList<string> parameters, Commands command)
        {
            switch (command)
            {
                case Commands.MOV:
                case Commands.ADD:
                case Commands.SUB:
                    if (parameters.Count != 2)
                        throw new ParserException($"{command} must have two parameters");
                    
                    foreach (var parameter in parameters)
                    {
                        if (!_dictionaryVariables.ContainsKey(parameter) && !int.TryParse(parameter, out var value) && parameter.ToUpper() != Constants.RegisterEax)
                            throw new ParserException($"The {parameter[1]} must be an initialized variable, integer, or a valid processor register.");
                    }
                    
                    break;
                case Commands.XOR:
                    if (parameters.Count != 2)
                        throw new ParserException("Invalid number of parameters for XOR instruction");
                    
                    if (parameters[0].ToUpper() != Constants.RegisterEax || parameters[1].ToUpper() != Constants.RegisterEax)
                        throw new ParserException("Invalid XOR instruction format");
                    
                    break;
                case Commands.NOP:
                    if (parameters.Count != 0)
                    {
                        throw new ParserException("The NOP command must have no parameters.");
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(command), command, "Unknown command was detected");
            }
        }
    }
}