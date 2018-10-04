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
        TableLayoutPanel panel;
        CheckBox checkBox;
        Label label2;

        public MyForm()
        {
            #region Outer panel
            panel = new TableLayoutPanel
            {
                RowCount = 3,
                ColumnCount = 1,
                Dock = DockStyle.Fill
            };
            Controls.Add(panel);
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize, 100));
            panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20));
            panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 35));
            panel.RowStyles.Add(new RowStyle(SizeType.AutoSize, 80));
            #endregion

            TableLayoutPanel topPanel = new TableLayoutPanel
            {
                ColumnCount = 2,
                RowCount = 1,
                Dock = DockStyle.Fill
            };
            topPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5));
            topPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2));
            topPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize, 80));


            #region Labels
            TextBox t1 = new TextBox
            {
                BackColor = Color.LightGreen,
                Dock = DockStyle.Fill
            };
            Button b1 = new Button
            {
                Text = "Add item.",
                BackColor = Color.Blue,
                Dock = DockStyle.Fill,
            };
            Label l1 = new Label
            {
                Text = "TO-DO LIST!",
                BackColor = Color.LightCyan,
                Dock = DockStyle.Fill,
            };
            Label l4 = new Label
            {
                BackColor = Color.Red,
                Dock = DockStyle.Fill,
                Margin = new Padding(0, 0, 0, 0)
            };
            #endregion
            panel.Controls.Add(l1);
            panel.Controls.Add(topPanel);
            topPanel.Controls.Add(t1);
            topPanel.Controls.Add(b1);

            TableLayoutPanel bottomPanel = new TableLayoutPanel
            {
                ColumnCount = 2,
                Dock = DockStyle.Fill
            };
            panel.Controls.Add(bottomPanel);
            bottomPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1));
            bottomPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5));

            checkBox = new CheckBox
            {
                BackColor = Color.Yellow
            };
            bottomPanel.Controls.Add(checkBox);

            label2 = new Label
            {
                BackColor = Color.Pink

            };
            bottomPanel.Controls.Add(label2);

        }

    }
}
