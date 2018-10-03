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
            TableLayoutPanel panel = new TableLayoutPanel
            {
                RowCount = 5,
                ColumnCount = 2,
                Dock=DockStyle.Top,
            };
            Controls.Add(panel);

            Label label1 = new Label
            {
                Text = "Country",
                TextAlign = ContentAlignment.MiddleRight
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
                TextAlign = ContentAlignment.MiddleRight
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
                TextAlign = ContentAlignment.MiddleRight
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
                TextAlign = ContentAlignment.MiddleRight
            };
            panel.Controls.Add(label4);

            CheckBox checkBox = new CheckBox
            {
                Dock = DockStyle.Fill
            };
            panel.Controls.Add(checkBox);

            Button button = new Button
            {
                Text = "Can I be President?",
                Dock = DockStyle.Fill
            };
            Controls.Add(button);

            bool nationality = text.Text == "USA";
            bool ageBool = age.Value >= 35;
            bool mandates = mandate.Value < 2;
            bool womans = checkBox.Checked;

            button.Click += ClickedEventHandler;
        }

        private void ClickedEventHandler(object sender, EventArgs e)
        {
            { MessageBox.Show("You clicked the button"); }
        }
    }
}
