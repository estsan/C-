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
        #region Instance Variables
        TableLayoutPanel panel;
        ComboBox dropDownMenu;
        Label info;
        string infoString;
        string part;
        string member;
        string[] ringmastersMembers;
        string[,] ringmastersMemberParts;
        int m;
        #endregion

        public MyForm()
        {
            Font = new Font ( "Arial", 10);

            #region Table
            panel = new TableLayoutPanel
            {
                RowCount = 3,
                Dock = DockStyle.Fill
            };
            Controls.Add(panel);
            #endregion

            #region Things
            Label rubrik = new Label
            {
                Text = "Hey! Don't spy!",
                Dock = DockStyle.Fill
            };

            dropDownMenu = new ComboBox
            {

            };

            //Button spy = new Button
            //{
            //    Text = "Spy anyways"
            //};
            #endregion

            #region DropDownMenu
            panel.Controls.Add(rubrik);
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
                dropDownMenu.Items.Add(ringmastersMemberParts[k,0]);
            }
            #endregion

            #region Adding to panel
            panel.Controls.Add(dropDownMenu);
            dropDownMenu.DropDownClosed += MenuClosed;
            //panel.Controls.Add(spy);
            //spy.Click += Info;
            #endregion
        }
        private void MenuClosed(object sender, EventArgs e)
        {
            int w = dropDownMenu.SelectedIndex;

            member = ringmastersMemberParts[w, 0];
            part = ringmastersMemberParts[w, 1];
            infoString = member + " sings " + part + " in Ringmasters.";

            panel.Controls.Remove(info);

            info = new Label
            {
                Text = infoString,
                Dock = DockStyle.Fill
            };
            info.TextAlign = ContentAlignment.MiddleCenter;
            panel.Controls.Add(info);
        }
    }
}
