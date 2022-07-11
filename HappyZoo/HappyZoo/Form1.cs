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

namespace HappyZoo
{
    public partial class Form1 : Form
    {
        string connectionString = @"Server = DESKTOP-64DGCJU\LOEN_TRAVELER;Initial Catalog=P3_HappyZOOZoo;Persist Security Info=True;User ID=sa;Password=S34g56F109";
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter dataAdapter;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (login.Text != "" && password.Text != "")
            {

                connection = new SqlConnection(connectionString);
                try
                {
                    connection.Open();
                    dataAdapter = new SqlDataAdapter($"SELECT dbo.Employees.Post_ID, dbo.Post.Name_Post FROM dbo.Post INNER JOIN dbo.Employees ON dbo.Post.ID_Post = dbo.Employees.Post_ID where [Login_Text]= '{login.Text}' and [Password_Text]= '{password.Text}'", connection);
                    DataSet ds = new DataSet();
                    dataAdapter.Fill(ds);
                        this.Hide();
                        var form = new ADMIN(ds.Tables[0].Rows[0].ItemArray);
                    form.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Пустые поля");
            }
        }
    }

}
