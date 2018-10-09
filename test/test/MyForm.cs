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
        public MyForm()
        {
            TableLayoutPanel panel = new TableLayoutPanel
            {
                RowCount =4,
                ColumnCount = 4
            };
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
            panel.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
            panel.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
            panel.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
            panel.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
            Controls.Add(panel);

            pictureBox = new PictureBox();
            pictureBox.Width = 150;
            pictureBox.Height = 150;
            Bitmap cat1 = new Bitmap("cat1.jpg");
            //imageControl.Dock = DockStyle.Fill;
            pictureBox.Image = (Image)cat1;
            panel.Controls.Add(pictureBox);

            pictureBox = new PictureBox();
            pictureBox.Width = 150;
            pictureBox.Height = 150;
            Bitmap cat2 = new Bitmap("cat2.jpg");
            //imageControl.Dock = DockStyle.Fill;
            pictureBox.Image = (Image)cat2;
            panel.Controls.Add(pictureBox);
        }
    }
}
