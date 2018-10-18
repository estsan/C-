using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace Session17Exercise3
{
    class MyForm : Form
    {
        DataGridView dataGridView;

        public MyForm()
        {
            dataGridView = new DataGridView
            {
                Dock = DockStyle.Fill,
                ColumnCount = 3,
            };
            Controls.Add(dataGridView);
            dataGridView.Columns[0].Name = "Placering";
            dataGridView.Columns[1].Name = "Djur";
            dataGridView.Columns[2].Name = "Sort";
            PopulateDataGridView();
        }
        private void PopulateDataGridView()
        {
            string[] rows = File.ReadAllLines("TextFile1.txt");
            foreach (string line in rows)
            {
                string[] listItem = line.Split(new char[] { ',' });
                dataGridView.Rows.Add(listItem);
            }
        }
    }
}
