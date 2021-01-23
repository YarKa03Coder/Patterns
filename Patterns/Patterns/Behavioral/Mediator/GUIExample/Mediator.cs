using System.Drawing;
using System.Windows.Forms;

namespace Patterns.Behavioral.Mediator.GUIExample
{
    public class Mediator
    {
        public TextBox TextBox { get; set; }
        
        public void Send(Control control)
        {
            if (control.GetType() == typeof(ComboBox))
            {
                TextBox.Font = new Font(new FontFamily(((ComboBox)control).Text), TextBox.Font.Size, TextBox.Font.Style);
            }
            else if(control.GetType() == typeof(NumericUpDown))
            {
                TextBox.Font = new Font(TextBox.Font.FontFamily, (float)((NumericUpDown) control).Value, TextBox.Font.Style);
            }
            else if(control.GetType() == typeof(RadioButton))
            {
                switch (control.Name)
                {
                    case "BoldButton":
                        TextBox.Font = new Font(TextBox.Font, FontStyle.Bold);
                        break;
                    case "ItalicButton":
                        TextBox.Font = new Font(TextBox.Font, FontStyle.Italic);
                        break;
                    case "StrikeoutButton":
                        TextBox.Font = new Font(TextBox.Font, FontStyle.Strikeout);
                        break;
                    case "UnderlineButton":
                        TextBox.Font = new Font(TextBox.Font, FontStyle.Underline);
                        break;
                    default:
                        TextBox.Font = new Font(TextBox.Font, FontStyle.Regular);
                        break;
                }
            }
            else
            {
                throw new System.NotImplementedException();
            }
        }
    }
}