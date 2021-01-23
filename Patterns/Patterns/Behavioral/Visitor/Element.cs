namespace Patterns.Behavioral.Visitor
{
    public abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
    }
}