using System.Drawing;
using System.Windows.Forms;

namespace Patterns.Structural.Bridge.Implementors
{
    public class WindowsOsImplementor : WindowImplementor
    {
        public override Button CreateButton()
        {
            Button = new Button
            {
                Location = new Point(75,70),
                Size = new Size(125,25),
                Text = "Windows",
                ForeColor = Color.Aqua,
                BackColor = Color.DarkBlue
            };
            
            return Button;
        }

        public override Form CreateForm()
        {
            Form = new Form
            {
                AutoScaleDimensions = new SizeF(6F, 13F),
                AutoScaleMode = AutoScaleMode.Font,
                ClientSize = new Size(284, 172), 
                Name = "Microsoft Form",
                Text = "Windows Explorer",
                BackColor = Color.LightBlue
            };
            
            return Form;
        }
    }
}