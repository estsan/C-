using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace _15_2
{
    class MyForm : Form
    {
        public MyForm()
        {
            TableLayoutPanel panel = new TableLayoutPanel
            {
                RowCount = 5,
                ColumnCount = 5,
                Dock = DockStyle.Fill
            };
            Controls.Add(panel);

            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12));
            panel.RowStyles.Add(new RowStyle(SizeType.Percent, 6));
            panel.RowStyles.Add(new RowStyle(SizeType.Percent, 1));
            panel.RowStyles.Add(new RowStyle(SizeType.Percent, 2));
            panel.RowStyles.Add(new RowStyle(SizeType.Percent, 1));
            panel.RowStyles.Add(new RowStyle(SizeType.Percent, 6));

            panel.Controls.Add(MyPaint(Color.Red));
            panel.Controls.Add(MyPaint(Color.White));
            panel.Controls.Add(MyPaint(Color.Blue));
            panel.Controls.Add(MyPaint(Color.White));
            panel.Controls.Add(MyPaint(Color.Red));

            panel.Controls.Add(MyPaint(Color.White));
            panel.Controls.Add(MyPaint(Color.White));
            panel.Controls.Add(MyPaint(Color.Blue));
            panel.Controls.Add(MyPaint(Color.White));
            panel.Controls.Add(MyPaint(Color.White));

            panel.Controls.Add(MyPaint(Color.Blue));
            panel.Controls.Add(MyPaint(Color.Blue));
            panel.Controls.Add(MyPaint(Color.Blue));
            panel.Controls.Add(MyPaint(Color.Blue));
            panel.Controls.Add(MyPaint(Color.Blue));

            panel.Controls.Add(MyPaint(Color.White));
            panel.Controls.Add(MyPaint(Color.White));
            panel.Controls.Add(MyPaint(Color.Blue));
            panel.Controls.Add(MyPaint(Color.White));
            panel.Controls.Add(MyPaint(Color.White));

            panel.Controls.Add(MyPaint(Color.Red));
            panel.Controls.Add(MyPaint(Color.White));
            panel.Controls.Add(MyPaint(Color.Blue));
            panel.Controls.Add(MyPaint(Color.White));
            panel.Controls.Add(MyPaint(Color.Red));
        }

        static Panel MyPaint(Color color)
        {
            Panel panel1 = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = color,
                Margin = new Padding(0)
            };
            return panel1;
        }
    }
}
