using System.Windows.Forms;
using Patterns.Creational.AbstractFactory.Abstract;

namespace Patterns.Creational.AbstractFactory
{
    public class Client
    {
        private readonly AbstractButton _abstractButton;
        private readonly AbstractWindow _abstractWindow;

        public Client(WidgetFactory widgetFactory)
        {
            _abstractWindow = widgetFactory.CreateForm();
            _abstractButton = widgetFactory.CreateButton();
        }

        public Form GetForm()
        {
            _abstractWindow.BindButton(_abstractButton);
            return _abstractWindow;
        }
    }
}