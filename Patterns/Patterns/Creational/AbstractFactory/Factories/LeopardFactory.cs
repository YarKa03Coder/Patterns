using Patterns.Creational.AbstractFactory.Abstract;
using Patterns.Creational.AbstractFactory.Buttons;
using Patterns.Creational.AbstractFactory.Windows;

namespace Patterns.Creational.AbstractFactory.Factories
{
    public class LeopardFactory : WidgetFactory
    {
        public override AbstractButton CreateButton()
        {
            return new LeopardButton();
        }

        public override AbstractWindow CreateForm()
        {
            return new LeopardForm();
        }
    }
}