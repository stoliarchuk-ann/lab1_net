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
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 1;
            dataGridView1.Columns[0].HeaderText = "Температура";

            arrays myArr = new arrays(10);

            for (int i = 0; i < 10; i++)
            {
                dataGridView1.Rows.Add(myArr[i].ToString());
            }

            int warmDays = myArr.countWarmDays();
            label1.Text = "Придатних для купання днів: " + warmDays.ToString();
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
    }
}
