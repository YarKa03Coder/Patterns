namespace Patterns.Creational.FactoryMethod.Locator
{
    public interface IServiceLocator
    {
        T GetService<T>();
    }
}