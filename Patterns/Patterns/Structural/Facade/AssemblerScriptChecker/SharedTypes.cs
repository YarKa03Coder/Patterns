namespace Patterns.Structural.Facade.AssemblerScriptChecker
{
    internal enum Commands
    {
        MOV,
        ADD,
        SUB,
        XOR,
        NOP
    }

    internal static class Constants
    {
        public static readonly char[] ProgramDelimiter = {';'};
        public static readonly char[] LexemesDelimiter = {' '};
        public static readonly char[] ParameterDelimiter = {','};
        public static readonly string RegisterEax = "EAX";
    }
}