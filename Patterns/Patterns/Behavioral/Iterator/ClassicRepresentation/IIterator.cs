namespace Patterns.Behavioral.Iterator.ClassicRepresentation
{
    public interface IIterator
    {
        object CurrentItem { get; }
        object First { get; }
        object NextOrReturnNull();
        bool IsDone();
    }
}