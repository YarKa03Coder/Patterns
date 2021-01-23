using System.Windows.Forms;
using Patterns.Creational.AbstractFactory.Abstract;

namespace Patterns.Creational.AbstractFactory.Buttons
{
    public partial class LeopardButton : AbstractButton
    {
        public LeopardButton()
        {
            InitializeComponent();
        }
    }
    
    public partial class LeopardButton
    {
        private void InitializeComponent()
        {
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Location = new System.Drawing.Point(82, 59);
            this.Anchor = AnchorStyles.None;
            this.Name = "LeopardButton";
            this.Size = new System.Drawing.Size(191, 42);
            this.Text = "Leopard";
            this.UseVisualStyleBackColor = true;
        }
    }
}