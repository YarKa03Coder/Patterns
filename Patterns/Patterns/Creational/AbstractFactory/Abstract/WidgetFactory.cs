namespace Patterns.Creational.AbstractFactory.Abstract
{
    public abstract class WidgetFactory
    {
        public abstract AbstractButton CreateButton();
        public abstract AbstractWindow CreateForm();
    }
}