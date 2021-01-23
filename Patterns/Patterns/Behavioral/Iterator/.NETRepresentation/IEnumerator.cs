namespace Patterns.Behavioral.Iterator.NETRepresentation
{
    public interface IEnumerator
    {
        bool MoveNext();
        void Reset();
        object Current { get; }
    }
}