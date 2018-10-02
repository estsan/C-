using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace _15_1
{
    class MyForm : Form
    {
        public MyForm()
        {
            Button button = new Button
            {
                Text = "Can I be President?",
                Dock = DockStyle.Top
            };
            Controls.Add(button);

            TableLayoutPanel panel = new TableLayoutPanel
            {
                RowCount = 4,
                ColumnCount = 2,
                Dock=DockStyle.Top,
            };
            Controls.Add(panel);

            Label label1 = new Label
            {
                Text = "Country",
                Dock = DockStyle.Bottom
            };
            panel.Controls.Add(label1);

            TextBox text = new TextBox
            {
                Dock = DockStyle.Fill
            };
            panel.Controls.Add(text);

            Label label2 = new Label
            {
                Text = "Age",
                Dock = DockStyle.Bottom
            };
            panel.Controls.Add(label2);

            NumericUpDown age = new NumericUpDown
            {
                Dock = DockStyle.Fill
            };
            panel.Controls.Add(age);

            Label label3 = new Label
            {
                Text = "Times elected",
                Dock = DockStyle.Bottom
            };
            panel.Controls.Add(label3);

            NumericUpDown mandate = new NumericUpDown
            {
                Dock = DockStyle.Fill
            };
            panel.Controls.Add(mandate);

            Label label4 = new Label
            {
                Text = "I am a woman",
                Dock = DockStyle.Bottom
            };
            panel.Controls.Add(label4);

            CheckBox checkBox = new CheckBox
            {

            };
            panel.Controls.Add(checkBox);
        }
    }
}
