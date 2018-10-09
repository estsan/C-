using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Exercise_2
{
    class MyForm : Form
    {
        public MyForm()
        {
            PictureBox pictureBox = new PictureBox
            {

            };

            Bitmap cat1 = new Bitmap("images.jpg");
            pictureBox.Image = (Image)cat1;
            //Image cat1 = Image.FromFile("images.jpg");
            Controls.Add(pictureBox);



            //imageControl.Width = 400;
            //imageControl.Height = 400;
            //imageControl.Dock = DockStyle.Fill;
            //imageControl.Image = (Image)image;
            //Controls.Add(imageControl);
        }
    }
}
