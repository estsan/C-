using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace LektionsPloj
{
    class MyForm : Form
    {
        private TextBox nameBox;

        public MyForm()
        {
            TableLayoutPanel table = new TableLayoutPanel
            {
                RowCount = 2,
                ColumnCount = 2

            };
            Controls.Add(table);

            nameBox = new TextBox { };
            table.Controls.Add(nameBox);

            Button button1 = new Button
            {
                Text = "Try to insult me",
            };
            table.Controls.Add(button1);

            button1.Click += button1_Click;
            // När Click sker på knappen, anropa metoden "button1_Click"


        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can be " + nameBox.Text);
        }
    }
}
