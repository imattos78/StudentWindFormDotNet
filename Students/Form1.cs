using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students
{
    public partial class Form1 : Form
    {
        private Logic.LStudents student;
        public Form1()
        {
            InitializeComponent();

            var listTextBox = new List<TextBox>();
            listTextBox.Add(IdStudent);
            listTextBox.Add(TextBoxName);
            listTextBox.Add(TextBoxLastName);
            listTextBox.Add(Email);
            var listLabel = new List<Label>();
            listLabel.Add(labelId);
            listLabel.Add(labelName);
            listLabel.Add(labelLastName);
            listLabel.Add(labelEmail);
            student = new Logic.LStudents(listTextBox, listLabel);
        }

        private void ProfilePhoto_Enter(object sender, EventArgs e)
        {

        }

        private void TextBoxLastName_TextChanged(object sender, EventArgs e)
        {
            //Check if the texbox is empty
            //Logic: .Text property and .Equals() method checks TextBoxLastName
            if (TextBoxLastName.Text.Equals("")) 
            {

                //Change the label color when the text box is empty or when is being erased
                //Logic: .ForeColor assign Color.LightSlateGray to the labelLastName if the condition is TRUE
                labelLastName.ForeColor = Color.LightSlateGray;  
            
            }
            else
            {
                //Logic: .ForeColor assign Color.Green to the labelLastName if the condition is FALSE
                //Change the label color if the textbox is filling out
                labelLastName.ForeColor = Color.Green;  
                labelLastName.Text = "Last Name";
            }
        }

        private void TextBoxName_TextChanged(object sender, EventArgs e)
        {
            //Check if the texbox is empty
            //Logic: .Text property and .Equals() method checks TextBoxName
            if (TextBoxName.Text.Equals(""))
            {
                //Change the label color when the text box is empty or when is being erased
                //Logic: .ForeColor assign Color.LightSlateGray to the labelName if the condition is TRUE
                labelName.ForeColor = Color.LightSlateGray;
            }
            else
            {
                //Logic: .ForeColor assign Color.Green to the labelLastName if the condition is FALSE
                //Change the label color if the textbox is filling out
                labelName.ForeColor = Color.Green;
                labelName.Text = "Name";
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

            //Check if the texbox is empty
            //Logic: .Text property and .Equals() method checks Email Textbox
            if (Email.Text.Equals(""))
            {
                //Change the label color when the text box is empty or when is being erased
                //Logic: .ForeColor assign Color.LightSlateGray to the labelEmail if the condition is TRUE
                labelEmail.ForeColor = Color.LightSlateGray;
               
            }
            else
            {
                //Logic: .ForeColor assign Color.Green to the labelLastName if the condition is FALSE
                //Change the label color if the textbox is filling out
                labelEmail.ForeColor = Color.Green;
                labelEmail.Text = "E-mail";
            }
            //Regular expression used to verify the correct format of an email 
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

            if (Regex.IsMatch(Email.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(Email, "Provide valid email address");
                labelEmail.ForeColor = Color.Red;
            }
        }

        private void PictureBoxPhoto_Click(object sender, EventArgs e)
        {
            student.uploadimage.UploadImage(PictureBoxPhoto);
        }

        private void IdStudent_TextChanged(object sender, EventArgs e)
        {
            //Check if the texbox is empty
            //Logic: .Text property and .Equals() method checks IdStudent Textbox
            if (IdStudent.Text.Equals(""))
            {
                //Change the label color when the text box is empty or when is being erased
                //Logic: .ForeColor assign Color.LightSlateGray to the labelId if the condition is TRUE
                labelId.ForeColor = Color.LightSlateGray;
            }
            else
            {
                //Logic: .ForeColor assign Color.Green to the labelLastName if the condition is FALSE
                //Change the label color if the textbox is filling out
                labelId.ForeColor = Color.Green;
                labelId.Text = "Student ID";
            }
        }

        private void IdStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
           
                student.textBoxEvent.numberKeyPress(e);   

        }

        private void TextBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            student.textBoxEvent.textKeyPress(e);

        }

        private void TextBoxLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            student.textBoxEvent.textKeyPress(e);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            student.Register();
        }
    }
}