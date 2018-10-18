using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace _16_3_ToDoList
{
    class MyForm : Form
    {
        TableLayoutPanel outerPanel;
        TableLayoutPanel bottomPanel;
        TableLayoutPanel innerPanel;
        CheckBox done;
        Label toDo;
        TextBox itemToAdd;
        Button addItem;
        Button remove;

        public MyForm()
        {
            #region Panels
            outerPanel = new TableLayoutPanel
            {
                RowCount = 3,
                ColumnCount = 1,
                Dock = DockStyle.Fill
            };
            outerPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize, 100));
            outerPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20));
            outerPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 35));

            TableLayoutPanel middlePanel = new TableLayoutPanel
            {
                ColumnCount = 2,
                RowCount = 1,
                Dock = DockStyle.Fill
            };
            middlePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5));
            middlePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2));

            bottomPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Pink
            };
            middlePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 2));


            #endregion

            #region Labels
            itemToAdd = new TextBox
            {
                BackColor = Color.LightGreen,
                Dock = DockStyle.Fill
            };

            addItem = new Button
            {
                Text = "Add item",
                BackColor = Color.Blue,
                Dock = DockStyle.Fill,
            };
            Label toDoList = new Label
            {
                Text = "TO-DO LIST!",
                BackColor = Color.LightCyan,
                Dock = DockStyle.Fill,
            };
            #endregion
            Controls.Add(outerPanel);
            outerPanel.Controls.Add(toDoList);
            outerPanel.Controls.Add(middlePanel);
            outerPanel.Controls.Add(bottomPanel);
            middlePanel.Controls.Add(itemToAdd);
            middlePanel.Controls.Add(addItem);

            addItem.Click += AddItem;
            AcceptButton = addItem;

            }
        private void RemoveItem(object sender, EventArgs e)
        {
            Button remove = (Button)sender;
            bottomPanel.Controls.Remove((TableLayoutPanel) remove.Tag);
        }

        private void AddItem(object sender, EventArgs e)
        {
            innerPanel = new TableLayoutPanel
            {
                ColumnCount = 3,
                RowCount = 1,
                Dock = DockStyle.Top,
                BackColor = Color.Pink
            };
            innerPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1));
            innerPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5));
            innerPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2));

            done = new CheckBox
            {
                BackColor = Color.Yellow
            };
            innerPanel.Controls.Add(done);

            toDo = new Label
            {
                Text = itemToAdd.Text
            };
            innerPanel.Controls.Add(toDo);

            remove = new Button
            {
                BackColor = Color.Red,
                Text = "Remove"
            };
            innerPanel.Controls.Add(remove);

            bottomPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 35));
            bottomPanel.Controls.Add(innerPanel);

            remove.Tag = innerPanel;
            remove.Click += RemoveItem;
        }
    }
}
