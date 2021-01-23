using System.Windows.Forms;
using Patterns.Creational.AbstractFactory.Abstract;

namespace Patterns.Creational.AbstractFactory.Buttons
{
    public partial class WindowsButton : AbstractButton
    {
        public WindowsButton()
        {
            InitializeComponent();
        }
    }
    
    public partial class WindowsButton
    {
        private void InitializeComponent()
        {
            this.BackColor = System.Drawing.Color.MediumBlue;
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Anchor = AnchorStyles.None;
            this.Location = new System.Drawing.Point(82, 59);
            this.Name = "WindowsButton";
            this.Size = new System.Drawing.Size(191, 42);
            this.Text = "Windows";
            this.UseVisualStyleBackColor = false;
        }
    }
}