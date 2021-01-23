using System.ComponentModel;
using Patterns.Creational.AbstractFactory.Abstract;

namespace Patterns.Creational.AbstractFactory.Windows
{
    public partial class WindowsForm : AbstractWindow
    {
        public WindowsForm()
        {
            InitializeComponent();
        }

        public override void BindButton(AbstractButton button)
        {
            this.Controls.Add(button);
        }
    }

    public partial class WindowsForm
    {
        private readonly IContainer components = null;
        
        private void InitializeComponent()
        {
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(348, 184);
            this.Name = "WindowsForm";
            this.Text = "Windows Explorer";
            this.ResumeLayout(false);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                components?.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}