using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPSQLSECOND
{
    public partial class LoginRegistr : Form
    {
        public LoginRegistr()
        {
            InitializeComponent();
        }

        private void LoginRegistr_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {
            userControl11.timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RunnerRegistrationMenu runnerRegistrationMenu = new RunnerRegistrationMenu();
            runnerRegistrationMenu.Show();
            this.Show();
        }
    }
}
