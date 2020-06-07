using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic.Library
{
    public class Uploadimage
    {
        //This line will allow us to open a dialog window to find the file.
        private OpenFileDialog fd = new OpenFileDialog();

        public void UploadImage(PictureBox pictureBox)
        {
            //I set WaitOnLoad property to true
            //It means the image will load asynchronously in the pictureBox
            pictureBox.WaitOnLoad = true;

            // Property that allowed to filter the valid extensions for the profile image
            fd.Filter = "Images| *.jpg;*.gif;*.png;*.bmp"; 
            fd.ShowDialog();

            if(fd.FileName != string.Empty) //I used this to check if in the dialog box was selected a file, so filename is different to empty
            {
                pictureBox.ImageLocation = fd.FileName; //ImageLocation prop have the path of our image selected to display in the PictureBox
            }
        }
    }
}
