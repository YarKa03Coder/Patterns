namespace Patterns.Behavioral.Iterator.ClassicRepresentation
{
    public class ConcreteIterator : IIterator
    {
        private readonly IterableCollection _collection;
        private int _current = 0;

        public ConcreteIterator(IterableCollection collection)
        {
            _collection = collection;
        }

        public object CurrentItem => _collection[_current];
        
        public object First => _collection[0];

        public object NextOrReturnNull()
        {
            return _current++ < _collection.Count - 1 ? _collection[_current] : null;
        }

        public bool IsDone()
        {
            if (_current < _collection.Count)
            {
                return false;
            }

            _current = 0;
            return true;
        }
    }
}