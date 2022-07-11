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

namespace UPSQLSECOND
{
    public partial class Authorization : Form
    {
        string connection = @"Data Source=DESKTOP-64DGCJU\LOEN_TRAVELER;Initial Catalog=MarathonSkills2016;Integrated Security=True";

        public Authorization()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            LoginRegistr loginRegistr = new LoginRegistr();
            loginRegistr.Show();
            this.Hide();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            var conect = new SqlConnection(connection);
            try
            {
                conect.Open();

                string sql = $"select [User].Email,[User].Password,[User].RoleId from [User] where ([User].Email = '{textEmailLogin.Text}' )";
                var adapter = new SqlDataAdapter(sql, conect);
                var ds = new DataSet();
                adapter.Fill(ds);
                var row = ds.Tables[0].Rows[0].ItemArray;

                if (textPasswordLogin.Text == row[1].ToString())
                {
                    if (row[2].ToString() == "R")
                    {
                        var form = new RunnerMenu(textEmailLogin.Text);
                        form.Show();
                        this.Hide();
                    }
                    if (row[2].ToString() == "A")
                    {
                        var form = new MenuCoordination();
                        form.Show();
                        this.Hide();
                    }
                    if (row[2].ToString() == "C")
                    {
                        var form = new MenuAdmin();
                        form.Show();
                        this.Hide();
                    }
                }

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
    }
}
