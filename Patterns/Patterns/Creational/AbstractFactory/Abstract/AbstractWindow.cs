using System.Windows.Forms;

namespace Patterns.Creational.AbstractFactory.Abstract
{
    public abstract class AbstractWindow : Form
    {
        public abstract void BindButton(AbstractButton button);
    }
}