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
    public partial class RunnerMenu : Form
    {
        string email = "";
        public RunnerMenu(string Email)
        {
            InitializeComponent();
            this.email = Email;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RegistrationForTheMarathon registrationForTheMarathon = new RegistrationForTheMarathon(email);
            Hide();
            registrationForTheMarathon.Show();
        }
    }
}
