using System.Collections.Specialized;

namespace Patterns.Behavioral.Visitor.ConcreteElements
{
    public class Books : Element
    {
        private readonly NameValueCollection _bookCollection = new NameValueCollection();

        public int Count => _bookCollection.Count;

        #region Indexators

        public string this[string author]
        {
            get
            {
                if (_bookCollection.Get(author) is null)
                {
                    return "Author" + " : " + "Nothing found";
                }

                return author + " : " + _bookCollection.Get(author);
            }

            set => _bookCollection.Add(author, value);
        }

        public string this[int index]
        {
            get
            {
                if (_bookCollection.Get(index) is null)
                {
                    return "Author" + " : " + "Nothing found";
                }

                return _bookCollection.GetKey(index) + " : " + _bookCollection.Get(index);
            }
        }

        #endregion

        public override void Accept(IVisitor visitor)
        {
            visitor.PrintBooks(this);
        }
    }
}