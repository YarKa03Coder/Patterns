using System.Drawing;
using System.Windows.Forms;

namespace Patterns.Structural.Bridge.Implementors
{
    public class MacOsImplementor : WindowImplementor
    {
        public override Button CreateButton()
        {
            Button = new Button
            {
                Location = new Point(75, 70),
                Size = new Size(125, 25),
                Text = "Leopard",
                ForeColor = Color.White,
                BackColor = Color.LightGray
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
                Name = "Mac Form",
                Text = "Mac OS - Snow Leopard",
                BackColor = Color.White
            };
            return Form;
        }
    }
}