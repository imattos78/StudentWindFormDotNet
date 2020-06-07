using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic.Library
{
    public class TextBoxEvent
    {
        public void textKeyPress(KeyPressEventArgs e)
        {
            //Condition that allow us enter a text type data ONLY
            if (char.IsLetter(e.KeyChar)) { e.Handled = false; }
            //Condition that allow us blocking the action of the line break when pressing ENTER
            else if(e.KeyChar == Convert.ToChar(Keys.Enter)) { e.Handled = true; }
            //This line allow us using the Backspace key
            else if(char.IsControl(e.KeyChar)) { e.Handled = false; }
            //This line allow us using the Space key
            else if(char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else { e.Handled = true; }
        }
        public void numberKeyPress(KeyPressEventArgs e)
        {
            //Condition that allow us enter a text type data ONLY
            if (char.IsDigit(e.KeyChar)) { e.Handled = false; }
            //Condition that allow us blocking the action of the line break when pressing ENTER
            else if (e.KeyChar == Convert.ToChar(Keys.Enter)) { e.Handled = true; }
            //Condition that not allow us enter characters 
            else if (char.IsLetter(e.KeyChar)) { e.Handled = true; }
            //This line allow us using the Backspace key
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            //This line allow us using the Space key
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = true; }
            else { e.Handled = true; }
        }
    }
}
