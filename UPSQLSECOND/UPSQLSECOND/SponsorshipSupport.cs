using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static UPSQLSECOND.SponsorWindow;

namespace UPSQLSECOND
{
    public partial class SponsorshipSupport : Form
    {
        public SponsorshipSupport()
        {
            InitializeComponent();
        }

        private void SponsorshipSupport_Load(object sender, EventArgs e)
        {
            label7.Text = $"${SaveDate_Sponsor_Runner.cost.ToString()}";
            label6.Text = SaveDate_Sponsor_Runner.name_blag_organization.ToString();
            label5.Text = SaveDate_Sponsor_Runner.name_runner.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
