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
    class Barbershopper
    {
        public string Name;
        public string Part;
        public string Summary;
    }
    class MyForm : Form
    {
        #region Instance Variables
        TableLayoutPanel panel;
        ComboBox dropDownMenu;
        Label info;
        Barbershopper[] barbers;
        string infoString;
        string part;
        string member;
        string summary;
        string[] ringmastersMembers;
        string[,] ringmastersMemberParts;
        int m;
        #endregion

        public MyForm()
        {
            Font = new Font("Arial", 10);

            #region Table
            panel = new TableLayoutPanel
            {
                RowCount = 3,
                Dock = DockStyle.Fill
            };
            #endregion

            #region Things
            Label rubrik = new Label
            {
                Text = "Hey! Don't spy!",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };

            dropDownMenu = new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                Dock = DockStyle.Fill
            };

            //Button spy = new Button
            //{
            //    Text = "Spy anyways"
            //};
            #endregion

            #region DropDownMenu
            barbers = MakeBarbershopper();
            foreach (Barbershopper b in barbers)
            {
                dropDownMenu.Items.Add(b.Name);
            }
            #endregion

            #region Adding to panel
            Controls.Add(panel);
            panel.Controls.Add(rubrik);
            panel.Controls.Add(dropDownMenu);
            dropDownMenu.SelectedIndexChanged += MenuClosed;
            //panel.Controls.Add(spy);
            //spy.Click += Info;
            #endregion
        }
        private void MenuClosed(object sender, EventArgs e)
        {
            int w = dropDownMenu.SelectedIndex;

            member = barbers[w].Name;
            part = barbers[w].Part;
            summary = barbers[w].Summary;

            infoString = member + " sings " + part + " in Ringmasters. He is " + summary;

            panel.Controls.Remove(info);

            info = new Label
            {
                Text = infoString,
                Dock = DockStyle.Fill
            };
            info.TextAlign = ContentAlignment.MiddleCenter;
            panel.Controls.Add(info);
        }

        private Barbershopper[] MakeBarbershopper()
        {
            ringmastersMembers = File.ReadAllLines("People.txt");
            m = ringmastersMembers.Length;
            ringmastersMemberParts = new string[m, 2];
            Barbershopper[] barbers = new Barbershopper[m];
            int i = 0;

            foreach (string line in ringmastersMembers)
            {
                Barbershopper barb = new Barbershopper { };
                string[] temp = line.Split(new char[] { ',' });
                barb.Name = temp[0].Trim(' ');
                barb.Part = temp[1].Trim(' ');
                barb.Summary = temp[2].Trim(' ');
                barbers[i] = barb;
                i++;
            }
            return barbers;


        }

    }
}
