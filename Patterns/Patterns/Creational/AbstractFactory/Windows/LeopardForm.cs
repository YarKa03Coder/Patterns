using System.ComponentModel;
using Patterns.Creational.AbstractFactory.Abstract;

namespace Patterns.Creational.AbstractFactory.Windows
{
    public partial class LeopardForm : AbstractWindow
    {
        public LeopardForm()
        {
            InitializeComponent();
        }

        public override void BindButton(AbstractButton button)
        {
            this.Controls.Add(button);
        }
    }
    
    public partial class LeopardForm
    {
        private readonly IContainer components = null;
        
        private void InitializeComponent()
        {
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 184);
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Name = "LeopardForm";
            this.Text = "Mac OS - Snow Leopard";
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