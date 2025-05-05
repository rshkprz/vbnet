using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegForm
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            textBox1.KeyPress += only_Allow_Numbers;
            textBox2.KeyPress += only_Allow_Numbers;
        }
        private void only_Allow_Numbers(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);

            int result = num1 + num2;
            textBox3.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);

            int result = num1 - num2;
            textBox3.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);

            int result = num1 * num2;
            textBox3.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(textBox1.Text);
            float num2 = float.Parse(textBox2.Text);

            if (num2 == 0)
            {
                MessageBox.Show("Cannot divide by zero.");
                return;
            }

            float result = num1 / num2;
            textBox3.Text = result.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
