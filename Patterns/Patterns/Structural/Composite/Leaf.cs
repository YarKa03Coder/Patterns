using System;

namespace Patterns.Structural.Composite
{
    public class Leaf : Component
    {
        public Leaf(string name)
            : base(name)
        {

        }
        
        public override void Add(int key, Component component)
        {
            throw new System.NotImplementedException();
        }

        public override void Operation()
        {
            Console.WriteLine(Name);
        }

        public override void Build(int[] numberInts)
        {
            throw new NotImplementedException();
        }
    }
}