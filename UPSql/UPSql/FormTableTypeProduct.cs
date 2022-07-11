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
    public partial class FormTableTypeProduct : Form
    {
        string connectionString = @"Server = DESKTOP-64DGCJU\LOEN_TRAVELER;Initial Catalog=P3_MotoSolonEcipUP;Persist Security Info=True;User ID=sa;Password=S34g56F109";
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter dataAdapter;

        public FormTableTypeProduct()
        {
            InitializeComponent();
        }
        public void loadEmployee()
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT dbo.Type_product.ID_Type AS Номер, dbo.Type_product.Name_Type AS ТипТовара FROM dbo.Type_product", connection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                dataTypeView.DataSource = ds.Tables[0];
                dataTypeView.Columns[0].Visible = true;
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

        private void FormTableTypeProduct_Load(object sender, EventArgs e)
        {
            loadEmployee();
        }

        private void newType_Click(object sender, EventArgs e)
        {
            if (textType.Text != "")
            {
                connection = new SqlConnection(connectionString);
                try
                {
                    connection.Open();
                    cmd = new SqlCommand($"INSERT INTO Type_product (Name_Type) VALUES ('{textType.Text}')", connection);
                    textType.Text = "";
                    cmd.ExecuteNonQuery();
                    loadEmployee();
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

        private void deleteType_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                cmd = new SqlCommand($"DELETE FROM Type_product WHERE ID_Type = {dataTypeView.SelectedRows[0].Cells[0].Value}", connection);
                cmd.ExecuteNonQuery();
                loadEmployee();
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

        private void dataTypeView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textType.Text = dataTypeView.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void replaceType_Click(object sender, EventArgs e)
        {
            if (textType.Text != "")
            {
                connection = new SqlConnection(connectionString);
                try
                {
                    connection.Open();
                    cmd = new SqlCommand($"UPDATE Type_product SET Name_Type ='{textType.Text}' WHERE ID_Type = {dataTypeView.SelectedRows[0].Cells[0].Value}", connection);
                    cmd.ExecuteNonQuery();
                    loadEmployee();
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
