namespace Patterns.Creational.Prototype
{
    public abstract class PrototypeShape
    {
        public abstract PrototypeShape Clone();

        public abstract void PrintInfo();
    }
}