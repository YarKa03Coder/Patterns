namespace Patterns.Behavioral.Strategy.Interfaces
{
    public interface IPrint
    {
        void PrintArray<T>(T[] collection) where T : struct, System.IConvertible;
    }
}