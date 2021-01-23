using System.Collections;

namespace Patterns.Behavioral.Visitor
{
    public class Library
    {
        private readonly ArrayList _elements = new ArrayList();
        
        public void Add(Element element)
        {
            _elements.Add(element);
        }

        public void Remove(Element element)
        {
            _elements.Remove(element);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (Element item in _elements)
            {
                item.Accept(visitor);
            }

        }
    }
}