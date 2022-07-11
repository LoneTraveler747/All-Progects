using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPSQLSECOND
{
    public partial class SponsorWindow : Form
    {
        string connection = @"Data Source=DESKTOP-64DGCJU\LOEN_TRAVELER;Initial Catalog=MarathonSkills2016;Integrated Security=True";
        List<ComBox> arraylist = null;
        public SponsorWindow()
        {
            InitializeComponent();
        }

        private void SponsorWindow_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label14.Text = $"${ textBox1.Text}";


            var conect = new SqlConnection(connection);
            try
            {
                conect.Open();

                string sql = Properties.Resources.sql_select_Runner_Sponsor;
                var adapter = new SqlDataAdapter(sql, conect);
                var ds = new DataSet();
                adapter.Fill(ds);

                arraylist = new List<ComBox>();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    var row = ds.Tables[0].Rows[i].ItemArray;
                    arraylist.Add(new ComBox { name = row[1].ToString(), blag = row[2].ToString(), logo = row[3].ToString(), desription = row[4].ToString() });
                }

                comboBox1.DataSource = arraylist;
                comboBox1.DisplayMember = "name";
                comboBox1.ValueMember = "blag";

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
        public static int summa_count = 0;

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            summa_count = summa_count + 10;
            textBox1.Text = summa_count.ToString();
            label14.Text = $"${  summa_count}";
        }

        private void buttonMins_Click(object sender, EventArgs e)
        {
            summa_count = summa_count - 10;
            if (summa_count >= 0)
            {
                textBox1.Text = summa_count.ToString();
                label14.Text = $"${ summa_count }";
            }
            else
            {
                summa_count = summa_count + 10;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                if (!Regex.IsMatch(textBox1.Text, @"[A-я]"))
                {
                    if (label14.Text != "")
                    {
                        label14.Text = $"${textBox1.Text}";
                        summa_count = Convert.ToInt32(label14.Text.Replace("$", ""));
                    }
                    else
                    {
                        label14.Text = $"${textBox1.Text}";
                        summa_count = Convert.ToInt32("");
                    }
                }
                else
                {
                    textBox1.Text = "0";
                }
            }
            else
            {
                textBox1.Text = "0";
            }
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            int year = 0;
            int month = 0;
            if (maskedTextBox3.Text != "" && maskedTextBox4.Text != "")
            {
                month = Convert.ToInt32(maskedTextBox3.Text);
                year = Convert.ToInt32(maskedTextBox4.Text);
            }

            bool month_prov = (month > 0 && month < 13);
            bool year_prov = (year >= DateTime.Now.Year);

            if (textBox2.Text != "" && textBox4.Text != "" && maskedTextBox1.Text.Replace(" ", "").Length == 16 && month_prov && year_prov && maskedTextBox2.Text != "" && summa_count != 0)
            {
                SaveDate_Sponsor_Runner.name_runner = comboBox1.SelectedItem.ToString();
                SaveDate_Sponsor_Runner.name_blag_organization = label13.Text;
                SaveDate_Sponsor_Runner.cost = Convert.ToInt32(textBox1.Text);

                var form = new SponsorshipSupport();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Не корректный данные");
            }
        }

        public class ComBox
        {
            public string name { get; set; }
            public string blag { get; set; }
            public string logo { get; set; }
            public string desription { get; set; }
        }
        public class SaveDate_Sponsor_Runner
        {
            public static string name_runner { get; set; }
            public static string name_blag_organization { get; set; }
            public static int cost { get; set; }
        }

        private void icon_information_Click(object sender, EventArgs e)
        {
            var index = comboBox1.SelectedIndex;

            var form = new InformationsSponsor(arraylist[index].blag, arraylist[index].desription, arraylist[index].logo);
            form.ShowDialog();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            textBox2.Text = comboBox1.SelectedValue.ToString();
        }
    }
}
