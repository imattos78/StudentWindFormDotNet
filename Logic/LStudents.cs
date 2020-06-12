using Logic.Library;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic
{
    public class LStudents : Librarys
    {
        private List<TextBox> listTextBox;
        private List<Label> listLabel;

        public LStudents(List<TextBox> listTextBox, List<Label> listLabel)
        {
            this.listTextBox = listTextBox;
            this.listLabel = listLabel;
        }
        public void Register()
        {
            if(listTextBox[0].Text.Equals(""))
            {
                listLabel[0].Text = "ID required";
                listLabel[0].ForeColor = Color.Red;
                listTextBox[0].Focus();
            
            }
            else
            {
                if (listTextBox[1].Text.Equals(""))
                {
                    listLabel[1].Text = "Name required";
                    listLabel[1].ForeColor = Color.Red;
                    listTextBox[1].Focus();
                }
                else
                {
                    if (listTextBox[2].Text.Equals(""))
                    {
                        listLabel[2].Text = "Last Name required";
                        listLabel[2].ForeColor = Color.Red;
                        listTextBox[2].Focus();
                    }
                    else
                    {
                        if (listTextBox[3].Text.Equals(""))
                        {
                            listLabel[3].Text = "Email required";
                            listLabel[3].ForeColor = Color.Red;
                            listTextBox[3].Focus();
                        }
                        else
                        {
                           
                        }

                    }

                }
            }
        }
    }
}
