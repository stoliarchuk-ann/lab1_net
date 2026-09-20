using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            arrays2d myMatrix = new arrays2d();

            for (int i = 0; i < 5; i++)
            {
                dataGridView1.Columns.Add("col" + i, i.ToString());
                dataGridView1.Columns[i].Width = 40;
            }

            dataGridView1.RowCount = 5;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = myMatrix[i, j].ToString();
                }
            }

            int sum = myMatrix.calculateSumAboveMainDiagobal();
            label1.Text = "Сума елементів вище діагоналі: " + sum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }
    }
}
