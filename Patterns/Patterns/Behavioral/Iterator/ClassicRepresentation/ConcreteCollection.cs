using System.Collections;

namespace Patterns.Behavioral.Iterator.ClassicRepresentation
{
    public class ConcreteCollection : IterableCollection
    {
        private readonly ArrayList _arrayList = new ArrayList();

        public override IIterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public override object this[int index]
        {
            get => _arrayList[index];
            set => _arrayList.Insert(index, value);
        }

        public override int Count => _arrayList.Count;
    }
}