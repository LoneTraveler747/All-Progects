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
    public partial class FormPay : Form
    {
        string connectionString = @"Server = DESKTOP-64DGCJU\LOEN_TRAVELER;Initial Catalog=P3_MotoSolonEcipUP;Persist Security Info=True;User ID=sa;Password=S34g56F109";
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter dataAdapter;
        public void loadPay()
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT dbo.Pay.ID_Pay,  dbo.Pay.ID_Magazin, dbo.Pay.ID_Kassa, dbo.Pay.ID_tovara, dbo.Pay.Date_sale, dbo.Pay.Count FROM  dbo.Kassa INNER JOIN dbo.Pay ON dbo.Kassa.ID_Kassa = dbo.Pay.ID_Kassa INNER JOIN dbo.Name_Shop ON dbo.Pay.ID_Magazin = dbo.Name_Shop.ID_Shop INNER JOIN  dbo.Storage ON dbo.Pay.ID_tovara = dbo.Storage.Article_Numberss_for_pay", connection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].Visible = false;
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
        public void loadMagazin()
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT * FROM Name_Shop", connection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                magazin.DataSource = ds.Tables[0];
                magazin.DisplayMember = "Address";
                magazin.ValueMember = "ID_Shop";
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
        public void loadProduct()
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT * FROM Product", connection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                product.DataSource = ds.Tables[0];
                product.DisplayMember = "Name_of_item";
                product.ValueMember = "Article_Numbera_ID";
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
        public void loadKassa()
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT * FROM Kassa", connection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                kassa.DataSource = ds.Tables[0];
                kassa.DisplayMember = "ID_Employees";
                kassa.ValueMember = "ID_Kassa";
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


        public FormPay()
        {
            InitializeComponent();
        }

        private void FormPay_Load(object sender, EventArgs e)
        {
            loadPay();
            loadMagazin();
            loadProduct();
            loadKassa();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (magazin.SelectedValue.ToString() != "" && kassa.SelectedValue.ToString() != "" && product.SelectedValue.ToString() != "" && colvo.Text != "")
            {
                connection = new SqlConnection(connectionString);
                try
                {
                    connection.Open();
                    cmd = new SqlCommand($"INSERT INTO Pay (ID_Magazin, ID_Kassa, ID_tovara, Date_sale, Count) VALUES ('{magazin.SelectedValue}','{kassa.SelectedValue}','{product.SelectedValue}', '{dateTimePicker1.Value.ToShortDateString()}','{colvo.Text}')", connection);
                    cmd.ExecuteNonQuery();
                    loadPay();
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
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                cmd = new SqlCommand($"DELETE FROM Pay WHERE ID_Pay = {dataGridView1.SelectedRows[0].Cells[0].Value}", connection);
                cmd.ExecuteNonQuery();
                loadPay();
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

        private void Replace_Click(object sender, EventArgs e)
        {
            if (magazin.SelectedValue.ToString() != "" && kassa.SelectedValue.ToString() != "" && product.SelectedValue.ToString() != "" && colvo.Text != "")
            {
                connection = new SqlConnection(connectionString);
                try
                {
                    connection.Open();
                    cmd = new SqlCommand($"UPDATE Pay SET ID_tovara ='{product.SelectedValue}',  ID_Kassa = '{kassa.SelectedValue}', ID_Magazin = '{magazin.SelectedValue}', Count = '{colvo.Text}' WHERE ID_Pay = {dataGridView1.SelectedRows[0].Cells[0].Value}", connection);
                    cmd.ExecuteNonQuery();
                    loadPay();
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
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            magazin.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            kassa.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            product.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

            colvo.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void away_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
