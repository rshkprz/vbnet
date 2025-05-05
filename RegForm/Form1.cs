using System.Diagnostics;
using System.Drawing.Text;

namespace RegForm
{
    public partial class Form1 : Form
    {
        private Form2 reg;
        private login login;
        private Calculator calculator;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            if (reg == null || reg.IsDisposed)
            {
                reg = new Form2();
                reg.TopLevel = false;
                reg.FormBorderStyle = FormBorderStyle.None;
                reg.Dock = DockStyle.Fill;
            }
            panel3.Controls.Add(reg);
            reg.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            if (calculator == null || calculator.IsDisposed)
            {
                calculator = new Calculator();
                calculator.TopLevel = false;
                calculator.FormBorderStyle = FormBorderStyle.None;
                calculator.Dock = DockStyle.Fill;
            }
            panel3.Controls.Add(calculator);
            calculator.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            label3.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            if (login == null || login.IsDisposed)
            {
                login = new login();
                login.TopLevel = false;
                login.FormBorderStyle = FormBorderStyle.None;
                login.Dock = DockStyle.Fill;
            }
            panel3.Controls.Add(login);
            login.Show();
        }
    }
}
