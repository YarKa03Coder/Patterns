namespace Patterns.Behavioral.Iterator.NETRepresentation
{
    public class Enumerator : IEnumerator
    {
        private readonly Enumerable _enumerable;
        
        private int _current = -1;
        
        public Enumerator(Enumerable enumerable)
        {
            _enumerable = enumerable;
        }

        public bool MoveNext()
        {
            return _current++ < _enumerable.Count - 1;
        }

        public void Reset()
        {
            _current = -1;
        }

        public object Current => _enumerable[_current];
    }
}