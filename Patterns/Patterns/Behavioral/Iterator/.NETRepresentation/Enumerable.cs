using System.Collections;

namespace Patterns.Behavioral.Iterator.NETRepresentation
{
    public class Enumerable : IEnumerable
    {
        private readonly ArrayList _items = new ArrayList();

        public object this[int index]
        {
            get => _items[index];
            set => _items.Insert(index, value);
        }

        public int Count => _items.Count;
        
        public IEnumerator GetEnumerator()
        {
            return new Enumerator(this);
            
        }
    }
}