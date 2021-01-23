using System.Windows.Forms;

namespace Patterns.Structural.Bridge
{
    public abstract class Window
    {
        protected WindowImplementor WindowImplementor;
        protected Form Form;
        protected Button Button;

        public virtual void DrawWindow()
        {
            Form.Controls.Add(Button);
            Application.EnableVisualStyles();
            Application.Run(Form);
        }
    }
}