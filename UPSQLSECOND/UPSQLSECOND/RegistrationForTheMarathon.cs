using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static UPSQLSECOND.SponsorWindow;

namespace UPSQLSECOND
{
    public partial class RegistrationForTheMarathon : Form
    {
        string email = "";
        string connection = @"Data Source=DESKTOP-64DGCJU\LOEN_TRAVELER;Initial Catalog=MarathonSkills2016;Integrated Security=True";

        public RegistrationForTheMarathon(string Email)
        {
            InitializeComponent();
            this.email = Email;
        }
        List<ComBox> arraylist = null;

        private void buttonRegistation_Click(object sender, EventArgs e)
        {
            if (textBoxContribution.Text.Length != 0)
                if ((checkBoxFullMarathon.Checked == true || checkBoxHalfMarathon.Checked == true || checkBoxLowDistanceMarathon.Checked == true) && Convert.ToInt32(textBoxContribution.Text) >= vznos)
                {
                    ConfirmationOfRunnerRegistration confirmationOfRunnerRegistration = new ConfirmationOfRunnerRegistration();
                    confirmationOfRunnerRegistration.Show();
                    this.Hide();
                }
                else
                {
                }
        }
        

        private void RegistrationForTheMarathon_Load(object sender, EventArgs e)
        {
            var conect = new SqlConnection(Properties.Resources.connection);
            try
            {
                conect.Open();

                string sql = "select * from [Charity]";
                var adapter = new SqlDataAdapter(sql, conect);
                var ds = new DataSet();
                adapter.Fill(ds);

                arraylist = new List<ComBox>();

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    var row = ds.Tables[0].Rows[i].ItemArray;
                    arraylist.Add(new ComBox { name = row[1].ToString(), blag = row[0].ToString(), logo = row[3].ToString(), desription = row[2].ToString() });
                }

                comboContribution.DataSource = arraylist;
                comboContribution.DisplayMember = "name";
                comboContribution.ValueMember = "blag";

            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
            finally
            {
                conect.Close();
            }
        }

        private void icon_information_Click(object sender, EventArgs e)
        {
            var index = comboContribution.SelectedIndex;

            var form = new InformationsSponsor(arraylist[index].name, arraylist[index].desription, arraylist[index].logo);
            form.ShowDialog();
        }

        private void comboContribution_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        int vznos = 0;
        private void checkBoxFullMarathon_CheckedChanged(object sender, EventArgs e)
        {
            var test = sender.GetType().Name;
            if (test == "CheckBox")
            {
                if (((CheckBox)sender).Checked == true)
                {
                    vznos += Convert.ToInt32(((CheckBox)sender).Tag);
                    labelSumma.Text = $"${vznos}";
                }
                else
                {
                    vznos -= Convert.ToInt32(((CheckBox)sender).Tag);
                    labelSumma.Text = $"${vznos}";
                }
            }
            else
            {
                if (((RadioButton)sender).Checked == true)
                {
                    vznos += Convert.ToInt32(((RadioButton)sender).Tag);
                    labelSumma.Text = $"${vznos}";
                }
                else
                {
                    vznos -= Convert.ToInt32(((RadioButton)sender).Tag);
                    labelSumma.Text = $"${vznos}";
                }
            }
        }
    }
}
