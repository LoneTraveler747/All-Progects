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
    public partial class FormTableZakupki : Form
    {
        string connectionString = @"Server = DESKTOP-64DGCJU\LOEN_TRAVELER;Initial Catalog=P3_MotoSolonEcipUP;Persist Security Info=True;User ID=sa;Password=S34g56F109";
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter dataAdapter;
        public void loadProduct()
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT dbo.Purchase_of_goods.ID_Parachase, dbo.Purchase_of_goods.Data_salePur AS Дата, dbo.Purchase_of_goods.Quantity AS Количество, dbo.Purchase_of_goods.Article_Number AS НомерТовара FROM dbo.Product INNER JOIN dbo.Purchase_of_goods ON dbo.Product.Article_Numbera_ID = dbo.Purchase_of_goods.Article_Number", connection);
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

        public FormTableZakupki()
        {
            InitializeComponent();
        }

        private void FormTableZakupki_Load(object sender, EventArgs e)
        {
            loadProduct();
            loadnum();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (numProd.Text != "")
            {
                connection = new SqlConnection(connectionString);
                try
                {
                    connection.Open();
                    cmd = new SqlCommand($"INSERT INTO Purchase_of_goods (Data_salePur, Quantity, Article_Number ) VALUES ('{dateTimePicker1.Value.ToShortDateString()}','{numProd.Text}','{comboBox1.SelectedValue}')", connection);
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

        private void Delete_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                cmd = new SqlCommand($"DELETE FROM Purchase_of_goods WHERE ID_Parachase = {dataGridView1.SelectedRows[0].Cells[0].Value}", connection);
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
            if (comboBox1.SelectedValue.ToString() != "" && numProd.Text != "")
            {
                connection = new SqlConnection(connectionString);
                try
                {
                    connection.Open();
                    cmd = new SqlCommand($"UPDATE Purchase_of_goods SET Article_Number ='{comboBox1.SelectedValue}', Quantity = '{numProd.Text}' WHERE ID_Parachase = {dataGridView1.SelectedRows[0].Cells[0].Value}", connection);
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
            numProd.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBox1.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void away_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
