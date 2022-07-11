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
    public partial class FormTableProduct : Form
    {
        string connectionString = @"Server = DESKTOP-64DGCJU\LOEN_TRAVELER;Initial Catalog=P3_MotoSolonEcipUP;Persist Security Info=True;User ID=sa;Password=S34g56F109";
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter dataAdapter;


        public void loadType()
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT * FROM Type_product", connection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                typeProd.DataSource = ds.Tables[0];
                typeProd.DisplayMember = "Name_Type";
                typeProd.ValueMember = "ID_Type";
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
                dataAdapter = new SqlDataAdapter("SELECT dbo.Product.Article_Numbera_ID as ID, dbo.Product.Name_of_item as Название, dbo.Product.Values_of_goods as Количество, dbo.Product.Article_Number_for_Table_Product as НомерТовара, dbo.Type_product.Name_Type as НазваниеТипа FROM dbo.Product INNER JOIN dbo.Type_product ON dbo.Product.ID_Type = dbo.Type_product.ID_Type", connection);
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

        public FormTableProduct()
        {
            InitializeComponent();
        }

        private void FormTableProduct_Load(object sender, EventArgs e)
        {
            loadProduct();
            loadType();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (nameProd.Text != "" && numProd.Text != "" && nomer.Text != "" && typeProd.SelectedValue.ToString() != "")
            {
                connection = new SqlConnection(connectionString);
                try
                {
                    connection.Open();
                    cmd = new SqlCommand($"INSERT INTO Product (Name_of_item, Values_of_goods, Article_Number_for_Table_Product, ID_Type) VALUES ('{nameProd.Text}','{numProd.Text}','{nomer.Text}','{typeProd.SelectedValue}')", connection);
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
            nameProd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            numProd.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            nomer.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            typeProd.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[4].Value;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                cmd = new SqlCommand($"DELETE FROM Product WHERE Article_Numbera_ID = {dataGridView1.SelectedRows[0].Cells[0].Value}", connection);
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
            if (nameProd.Text != "" && numProd.Text != "" && nomer.Text != "" && typeProd.SelectedValue.ToString() != "")
            {
                connection = new SqlConnection(connectionString);
                try
                {
                    connection.Open();
                    cmd = new SqlCommand($"UPDATE Product SET Name_of_item ='{nameProd.Text}',  Values_of_goods = '{numProd.Text}', Article_Number_for_Table_Product = '{nomer.Text}', ID_Type = '{typeProd.SelectedValue}' WHERE Article_Numbera_ID = {dataGridView1.SelectedRows[0].Cells[0].Value}", connection);
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
