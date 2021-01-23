using System;
using System.Windows.Forms;

namespace Patterns.Behavioral.Mediator.GUIExample
{
    public partial class MainForm : Form
    {
        private readonly Mediator _mediator;
        
        public MainForm(Mediator mediator)
        {
            _mediator = mediator;

            InitializeComponent();
        }

        private void RadioButtonClicked(object sender, EventArgs e)
        {
            _mediator.Send((RadioButton) sender);
        }

        private void ComboBoxClicked(object sender, EventArgs e)
        {
            _mediator.Send((ComboBox) sender);
        }

        private void NumericButtonClicked(object sender, EventArgs e)
        {
            _mediator.Send((NumericUpDown) sender);
        }
    }
}
