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
    public partial class FormtableStorage : Form
    {
        string connectionString = @"Server = DESKTOP-64DGCJU\LOEN_TRAVELER;Initial Catalog=P3_MotoSolonEcipUP;Persist Security Info=True;User ID=sa;Password=S34g56F109";
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter dataAdapter;

        public void loadnum()
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT * FROM Product", connection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                comboBox1.DataSource = ds.Tables[0];
                comboBox1.DisplayMember = "Name_of_item";
                comboBox1.ValueMember = "Article_Numbera_ID";
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
                dataAdapter = new SqlDataAdapter("SELECT dbo.Storage.Article_Numberss_for_pay, dbo.Storage.Article_Numberss, dbo.Storage.Quantity, dbo.Storage.Cost FROM dbo.Product INNER JOIN dbo.Storage ON dbo.Product.Article_Numbera_ID = dbo.Storage.Article_Numberss", connection);
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

        public FormtableStorage()
        {
            InitializeComponent();
        }

        private void FormtableStorage_Load(object sender, EventArgs e)
        {
            loadProduct();
            loadnum();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (Colvo.Text != "" && valuee.Text != "" && comboBox1.SelectedValue.ToString() != "")
            {
                connection = new SqlConnection(connectionString);
                try
                {
                    connection.Open();
                    cmd = new SqlCommand($"INSERT INTO Storage (Quantity, Cost, Article_Numberss) VALUES ('{Colvo.Text}','{valuee.Text}','{comboBox1.SelectedValue}')", connection);
                    cmd.ExecuteNonQuery();
                    loadProduct();
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
            Colvo.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            valuee.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            comboBox1.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[1].Value;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                cmd = new SqlCommand($"DELETE FROM Storage WHERE Article_Numberss_for_pay = {dataGridView1.SelectedRows[0].Cells[0].Value}", connection);
                cmd.ExecuteNonQuery();
                loadProduct();
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
            if (Colvo.Text != "" && valuee.Text != "" && comboBox1.SelectedValue.ToString() != "")
            {
                connection = new SqlConnection(connectionString);
                try
                {
                    connection.Open();
                    cmd = new SqlCommand($"UPDATE Storage SET Quantity ='{Colvo.Text}',  Cost = '{valuee.Text}', Article_Numberss = '{comboBox1.SelectedValue}' WHERE Article_Numberss_for_pay = {dataGridView1.SelectedRows[0].Cells[0].Value}", connection);
                    cmd.ExecuteNonQuery();
                    loadProduct();
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

        private void away_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
