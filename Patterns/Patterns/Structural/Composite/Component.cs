namespace Patterns.Structural.Composite
{
    public abstract class Component
    {
        protected string Name;

        protected Component(string name)
        {
            Name = name;
        }
        
        public abstract void Add(int key, Component component);
        public abstract void Operation();
        public abstract void Build(int[] numberInts);
    }
}