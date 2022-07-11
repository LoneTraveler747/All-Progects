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

namespace UPSql
{
    public partial class Form1 : Form
    {
        string connectionString = @"Server = DESKTOP-64DGCJU\LOEN_TRAVELER;Initial Catalog=P3_MotoSolonEcipUP;Persist Security Info=True;User ID=sa;Password=S34g56F109";
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter dataAdapter;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (login.Text != "" && password.Text != "")
            {

                connection = new SqlConnection(connectionString);
                try
                {
                    connection.Open();
                    dataAdapter = new SqlDataAdapter($"SELECT Login_users, Password_users, ID_access FROM Users WHERE Login_users = '{login.Text}' and Password_users = '{password.Text}' and  ID_access = 0", connection);
                    DataSet ds = new DataSet();
                    dataAdapter.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        login.Enabled = false;
                        password.Enabled = false;
                        button1.Enabled = true;
                        button2.Enabled = true;
                        button3.Enabled = true;
                        button4.Enabled = true;
                        button5.Enabled = true;
                        button6.Enabled = true;
                        button7.Enabled = true;
                        button8.Enabled = true;
                        button9.Enabled = true;
                    }
                    else
                    {
                        dataAdapter = new SqlDataAdapter($"SELECT Login_users, Password_users, ID_access FROM Users WHERE Login_users = '{login.Text}' and Password_users = '{password.Text}' and  ID_access = 1", connection);
                        ds = new DataSet();
                        dataAdapter.Fill(ds);
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            login.Enabled = false;
                            password.Enabled = false;
                            button1.Enabled = true;
                            button5.Enabled = true;
                            button7.Enabled = true;

                        }
                        else
                        {
                            MessageBox.Show("Ошибка");
                        }
                    }
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

        private void button2_Click(object sender, EventArgs e)
        {
            FormTableTypeProduct typeProduct = new FormTableTypeProduct();
            typeProduct.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormTableProduct formTableProduct = new FormTableProduct();
            formTableProduct.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormTableZakupki formTableZakupki = new FormTableZakupki();
            formTableZakupki.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormtableStorage formtableStorage = new FormtableStorage();
            formtableStorage.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormMagazine formMagazine = new FormMagazine();
            formMagazine.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormKassa formKassa = new FormKassa();
            formKassa.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormPay formPay = new FormPay();
            formPay.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FormTableEmployee employee = new FormTableEmployee();
            employee.Show();
            this.Hide();
        }
    }
}
