using System.Collections.Specialized;

namespace Patterns.Behavioral.Visitor.ConcreteElements
{
    public class Magazines : Element
    {
        private readonly NameValueCollection _magazinesCollection = new NameValueCollection();

        public int Count => _magazinesCollection.Count;

        #region Indexators

        public string this[string publisher]
        {
            get
            {
                if (_magazinesCollection.Get(publisher) is null)
                {
                    return "Author" + " : " + "Nothing found";
                }

                return publisher + " : " + _magazinesCollection.Get(publisher);
            }

            set => _magazinesCollection.Add(publisher, value);
        }

        public string this[int index]
        {
            get
            {
                if (_magazinesCollection.Get(index) is null)
                {
                    return "Author" + " : " + "Nothing found";
                }

                return _magazinesCollection.GetKey(index) + " : " + _magazinesCollection.Get(index);
            }
        }

        #endregion

        public override void Accept(IVisitor visitor)
        {
            visitor.PrintMagazines(this);
        }
    }
}