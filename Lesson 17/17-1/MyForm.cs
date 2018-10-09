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
        TableLayoutPanel panel;
        ComboBox comboBox;
        Label info;
        string otherString = "";
        string[] ringmastersMembers;
        string[,] ringmastersMemberParts;
        int m;

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

            ringmastersMembers = File.ReadAllLines("People.txt");
            m = ringmastersMembers.Length;
            ringmastersMemberParts = new string[m, 2];

            int i = 0;
            foreach (string line in ringmastersMembers)
            {
                string[] temp = line.Split(new char[] { ',' });

                    for (int j = 0; j < 2; j++)
                    {
                        ringmastersMemberParts[i, j] = temp[j].Trim(' ');
                    }
                i++;
            }
            for (int k = 0; k < m; k++)
            {
                comboBox.Items.Add(ringmastersMemberParts[k,0]);
            }


            panel.Controls.Add(comboBox);
            comboBox.DropDownClosed += Info;

            //Button spy = new Button
            //{
            //    Text = "Spy anyways"
            //};
            //panel.Controls.Add(spy);

            //spy.Click += Info;
            


        }
        private void Info(object sender, EventArgs e)
        {
            int w = comboBox.SelectedIndex;

            otherString = ringmastersMemberParts[w, 1];

            panel.Controls.Remove(info);

            info = new Label
            {
                Text = otherString
            };
            panel.Controls.Add(info);
        }
    }
}
