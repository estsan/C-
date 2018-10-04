using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace _16_1
{
    class MyForm : Form
    {
        bool nationality;
        bool ageBool;
        bool mandates;
        bool womans;
        TextBox text;
        NumericUpDown age;
        NumericUpDown mandate;
        CheckBox checkBox;
        TableLayoutPanel panel;
        Label label5;

        public MyForm()
        {
            label5 = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
            };
            Controls.Add(label5);

            Button button = new Button
            {
                Text = "Can I be President?",
                Dock = DockStyle.Top
            };
            Controls.Add(button);

            panel = new TableLayoutPanel
            {
                RowCount = 5,
                ColumnCount = 2,
                Dock = DockStyle.Top,
            };
            Controls.Add(panel);
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize, 50));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize, 50));
            panel.RowStyles.Add(new RowStyle(SizeType.AutoSize, 20));
            panel.RowStyles.Add(new RowStyle(SizeType.AutoSize, 20));
            panel.RowStyles.Add(new RowStyle(SizeType.AutoSize, 20));
            panel.RowStyles.Add(new RowStyle(SizeType.AutoSize, 20));
            panel.RowStyles.Add(new RowStyle(SizeType.AutoSize, 20));


            Label label1 = new Label
            {
                Text = "Country",
                TextAlign = ContentAlignment.MiddleRight
            };
            panel.Controls.Add(label1);

            text = new TextBox
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

            age = new NumericUpDown
            {
                Dock = DockStyle.Fill,
            };
            panel.Controls.Add(age);

            Label label3 = new Label
            {
                Text = "Times elected",
                TextAlign = ContentAlignment.MiddleRight
            };
            panel.Controls.Add(label3);

            mandate = new NumericUpDown
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

            checkBox = new CheckBox
            {
                Dock = DockStyle.Fill
            };
            panel.Controls.Add(checkBox);
            button.Click += ClickedEventHandler;
        }

        private void ClickedEventHandler(object sender, EventArgs e)
        {
            nationality = text.Text == "USA";
            ageBool = age.Value >= 35;
            mandates = mandate.Value < 2;
            womans = checkBox.Checked;

            if ((nationality && ageBool && mandates) || womans)
            {
                label5.Text = "You have got this! Apply immideately.";
                label5.BackColor = Color.Green;
            }
            else
            {
                label5.Text = "Nah brah! No precidency for you!";
                label5.BackColor = Color.Red;

            }
        }
    }
}
