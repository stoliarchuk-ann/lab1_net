using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab1
{
    public partial class unitTest : Form
    {
        public unitTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var myTask = new task1(
                    Convert.ToInt32(textBox1.Text),
                    Convert.ToInt32(textBox2.Text),
                    Convert.ToInt32(textBox3.Text)
                );

                label4.Text = myTask.calculate().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка вводу даних: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var myTask = new task2(
                    Convert.ToInt32(textBox4.Text),
                    Convert.ToInt32(textBox5.Text)
                );

                label7.Text = myTask.calculateSum().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double R = Convert.ToDouble(textBox6.Text);
                double r = Convert.ToDouble(textBox7.Text);

                var ring = new task3(R, r);

                label10.Text = "Площа: " + ring.calculateArea().ToString("F2");
                label11.Text = "Середній радіус: " + ring.calculateAvgRadius().ToString("F2");
                label12.Text = "Ширина: " + ring.calculateWidth().ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                var myTask = new task1(
                    Convert.ToInt32(textBox1.Text),
                    Convert.ToInt32(textBox2.Text),
                    Convert.ToInt32(textBox3.Text)
                );

                label4.Text = myTask.calculate().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка вводу даних: " + ex.Message);
            }
        }
    }
}
