namespace Patterns.Behavioral.Strategy.Interfaces
{
    public interface ISort
    {
        void SortArray<T>(ref T[] collection) where T : struct, System.IConvertible;
    }
}