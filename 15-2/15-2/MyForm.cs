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
                RowCount = 3,
                ColumnCount = 3,
                Dock = DockStyle.Fill
            };
            Controls.Add(panel);

            panel.RowStyles.Add(new RowStyle(SizeType.Percent, 40));
            panel.RowStyles.Add(new RowStyle(SizeType.Percent, 20));
            panel.RowStyles.Add(new RowStyle(SizeType.Percent, 40));



            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.25F));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56.25F));


            Panel panel1 = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Blue,
                Margin =new Padding(0)
            };
            panel.Controls.Add(panel1);

            Panel panel2 = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Yellow,
                Margin = new Padding(0)
            };
            panel.Controls.Add(panel2);

            Panel panel3 = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Blue,
                Margin = new Padding(0)
            };
            panel.Controls.Add(panel3);

            Panel panel4 = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Yellow,
                Margin = new Padding(0)
            };
            panel.Controls.Add(panel4);

            Panel panel5 = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Yellow,
                Margin = new Padding(0)
            };
            panel.Controls.Add(panel5);

            Panel panel6 = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Yellow,
                Margin = new Padding(0)
            };
            panel.Controls.Add(panel6);

            Panel panel7 = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Blue,
                Margin = new Padding(0)
            };
            panel.Controls.Add(panel7);

            Panel panel8 = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Yellow,
                Margin = new Padding(0)
            };
            panel.Controls.Add(panel8);

            Panel panel9 = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Blue,
                Margin = new Padding(0)
            };
            panel.Controls.Add(panel9);
        }
    }
}
