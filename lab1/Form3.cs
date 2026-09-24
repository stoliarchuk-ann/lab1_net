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
            try
            {
                int n = Convert.ToInt32(textBox1.Text);
                arrays2d myMatrix = new arrays2d(n);
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.ColumnCount = myMatrix.length;
                dataGridView1.RowCount = myMatrix.length;

                for (int i = 0; i < myMatrix.length; i++)
                {
                    dataGridView1.Columns[i].HeaderText = (i + 1).ToString();
                    dataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString();
                    for (int j = 0; j < myMatrix.length; j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = myMatrix[i, j];
                    }
                }
                int sum = myMatrix.calculateSumAboveMainDiagonal();
                label1.Text = "Сума над головною діагоналлю: " + sum.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка вводу: " + ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }
    }
}
