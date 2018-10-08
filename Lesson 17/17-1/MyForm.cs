using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace _17_1
{
    class MyForm : Form
    {
        string otherString = "String from CSV";
        ComboBox comboBox;
        TableLayoutPanel panel;

        public MyForm()
        {
            panel = new TableLayoutPanel
            {
                RowCount = 4,
                Dock = DockStyle.Fill
            };
            Controls.Add(panel);

            Label rubrik = new Label
            {
                Text = "Hey! Don't spy!"
            };
            panel.Controls.Add(rubrik);

            comboBox = new ComboBox
            {

            };

            string[] inventoryString = File.ReadAllLines("TextFile1.txt");

            comboBox.Items.Add("Emanuel");

            comboBox.Items.Add("Martin");
            comboBox.Items.Add("Rasmus");
            comboBox.Items.Add("Jakob");

            panel.Controls.Add(comboBox);

            Button spy = new Button
            {
                Text = "Spy anyways"
            };
            panel.Controls.Add(spy);

            spy.Click += Info;


        }
        private void Info(object sender, EventArgs e)
        {
            if (true)
            {
                otherString = "Text om Emanuel";
            }
            else
            {
                otherString = "Är du verkligen intresserad av den typen...?";
            }
            Label info = new Label
            {
                Text = otherString
            };
            panel.Controls.Add(info);
        }
    }
}
