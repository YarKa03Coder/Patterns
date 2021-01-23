using System.Windows.Forms;

namespace Patterns.Structural.Bridge
{
    public abstract class WindowImplementor
    {
        protected Button Button;
        protected Form Form;
        public abstract Button CreateButton();
        public abstract Form CreateForm();
    }
}