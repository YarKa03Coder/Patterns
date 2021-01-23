namespace Patterns.Behavioral.Iterator.ClassicRepresentation
{
    public abstract class IterableCollection
    {
        public abstract IIterator CreateIterator();
        
        public abstract object this[int index]
        {
            get;
            set;
        }
        
        public abstract int Count { get; }
    }
}