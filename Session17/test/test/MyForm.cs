using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace test
{
    class MyForm : Form
    {
        public PictureBox pictureBox;
        string catFile;

        public MyForm()
        {
            FlowLayoutPanel panel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill
            };

            for (int i = 1; i <= 9; i++)
            {
                catFile = "cat" + i + ".jpg";
                pictureBox = new PictureBox();
                pictureBox.Width = 150;
                pictureBox.Height = 150;
                Bitmap cat = new Bitmap(catFile);
                pictureBox.Image = (Image)cat;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                panel.Controls.Add(pictureBox);
            }
            Controls.Add(panel);
        }
    }
}

//AutoSize = true;