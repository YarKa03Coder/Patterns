using System.Windows.Forms;
using Patterns.Structural.Bridge.Implementors;

namespace Patterns.Structural.Bridge.AbstractionRepresentatives
{
    public class MacOsForm : Window
    {
        public MacOsForm()
        {
            WindowImplementor = new MacOsImplementor();
            Form = WindowImplementor.CreateForm();
            Button = WindowImplementor.CreateButton();
        }

        public override void DrawWindow()
        {
            Form.FormBorderStyle = FormBorderStyle.FixedSingle;
            base.DrawWindow();
        }
    }
}