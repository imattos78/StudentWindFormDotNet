using Logic.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic
{
    public class LStudents : Librarys
    {
        private List<TextBox> listTextBox;

        public LStudents(List<TextBox> listTextBox)
        {
            this.listTextBox = listTextBox;
        }
    }
}
