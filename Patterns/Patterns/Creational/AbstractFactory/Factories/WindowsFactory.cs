using Patterns.Creational.AbstractFactory.Abstract;
using Patterns.Creational.AbstractFactory.Buttons;
using Patterns.Creational.AbstractFactory.Windows;

namespace Patterns.Creational.AbstractFactory.Factories
{
    public class WindowsFactory : WidgetFactory
    {
        public override AbstractButton CreateButton()
        {
            return new WindowsButton();
        }

        public override AbstractWindow CreateForm()
        {
            return new WindowsForm();
        }
    }
}