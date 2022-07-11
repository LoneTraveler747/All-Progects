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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AuthorizationForm_Click(object sender, EventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var date_end = DateTime.Parse("21-10-2021");
            labelTime.Text = $"{string.Format("{0:dd} дн. {0:hh} ч. {0:mm} м. {0:ss} сек.", date_end - DateTime.Now)} до старта марафона";
        }

        private void IWantToBeARunner_Click(object sender, EventArgs e)
        {
            LoginRegistr loginRegistr = new LoginRegistr();
            loginRegistr.Show();
            this.Hide();
        }
    }
}
