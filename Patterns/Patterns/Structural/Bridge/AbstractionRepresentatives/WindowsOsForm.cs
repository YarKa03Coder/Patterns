using System.Windows.Forms;
using Patterns.Structural.Bridge.Implementors;

namespace Patterns.Structural.Bridge.AbstractionRepresentatives
{
    public class WindowsOsForm : Window
    {
        public WindowsOsForm()
        {
            WindowImplementor = new WindowsOsImplementor(); 
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