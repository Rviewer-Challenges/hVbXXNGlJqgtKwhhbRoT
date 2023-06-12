using System.Windows.Forms;

namespace UnitConverter.Controls
{
    /// <summary>
    /// TextBox inheritance that only accepts numbers and dots on keyPressing event.
    /// </summary>
    public class NumericTextBox : TextBox
    {
        public NumericTextBox()
        {
            this.KeyPress += NumericTextBox_KeyPress;
        }

        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }
    }
}
