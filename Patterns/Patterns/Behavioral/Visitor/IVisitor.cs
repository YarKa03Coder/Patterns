using Patterns.Behavioral.Visitor.ConcreteElements;

namespace Patterns.Behavioral.Visitor
{
    public interface IVisitor
    {
        void PrintBooks(Books books);
        void PrintMagazines(Magazines magazines);
    }
}