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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(textBox1.Text);
                arrays myArr = new arrays(n);
                dataGridView1.RowCount = myArr.length;
                dataGridView1.ColumnCount = 1;
                dataGridView1.Columns[0].HeaderText = "Температура";

                for (int i = 0; i < myArr.length; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = myArr[i];
                    dataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString();
                }
                int warmDays = myArr.countWarmDays();
                label1.Text = "Придатних для купання днів: " + warmDays.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка вводу: " + ex.Message);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
