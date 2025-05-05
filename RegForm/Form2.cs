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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }






        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProvince = comboBox1.SelectedItem.ToString();
            List<string> bagmatiDistricts = new List<string> { "Kathmandu", "Bhaktapur" };
            List<string> koshiDistricts = new List<string> { "Jhapa", "Illam" };

            switch (selectedProvince)
            {
                case "Bagmati":
                    comboBox2.Items.Clear();
                    comboBox2.Items.AddRange(bagmatiDistricts.ToArray());
                    break;

                case "Koshi":
                    comboBox2.Items.Clear();
                    comboBox2.Items.AddRange(koshiDistricts.ToArray());
                    break;

                default:
                    comboBox2.Items.Clear();
                    break;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Name is required.");
            }
            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Gender is required.");
            }
            if (numericUpDown1.Value <= 0)
            {
                MessageBox.Show("Age is required.");
            }
            if (comboBox1 == null)
            {
                MessageBox.Show("Province is required.");
            }
            if (comboBox2 == null)
            {
                MessageBox.Show("District is required.");
            }
            string Message = $"Name: {textBox1.Text}\n" +
                                $"Gender: {(radioButton1.Checked? radioButton1.Text : radioButton2.Text)}\n" +
                                $"Age: {numericUpDown1.Value}\n" +
                                $"Province: {comboBox1.SelectedItem}\n" +
                                $"District: {comboBox2.SelectedItem}\n";
            MessageBox.Show(Message, "Registration Details");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //reset
            textBox1.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            numericUpDown1.Value = 0;
            comboBox1.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
               

        }
    }
}
