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
    public partial class FormKassa : Form
    {

        string connectionString = @"Server = DESKTOP-64DGCJU\LOEN_TRAVELER;Initial Catalog=P3_MotoSolonEcipUP;Persist Security Info=True;User ID=sa;Password=S34g56F109";
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter dataAdapter;

        public void loadKassaEmployees()
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT * FROM Employees", connection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                comboBox1.DataSource = ds.Tables[0];
                comboBox1.ValueMember = "ID_Employees";
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
                dataAdapter = new SqlDataAdapter("SELECT  dbo.Kassa.ID_Kassa, dbo.Kassa.Data_start_change as НачалоСмены, dbo.Kassa.Date_end_change as КонецСмены, dbo.Kassa.ID_Employees as НомерСотрудника FROM   dbo.Employees INNER JOIN dbo.Kassa ON dbo.Employees.ID_Employees = dbo.Kassa.ID_Employees", connection);
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

        public FormKassa()
        {
            InitializeComponent();
        }

        private void FormKassa_Load(object sender, EventArgs e)
        {
            loadKassaEmployees();
            loadKassa();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue.ToString() != "")
            {
                connection = new SqlConnection(connectionString);
                try
                {
                    connection.Open();
                    cmd = new SqlCommand($"INSERT INTO Kassa (Data_start_change, Date_end_change, ID_Employees) VALUES ('{dateTimePicker1.Value.ToShortDateString()}','{dateTimePicker2.Value.ToShortDateString()}','{ comboBox1.SelectedValue}')", connection);
                    cmd.ExecuteNonQuery();
                    loadKassa();
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
                cmd = new SqlCommand($"DELETE FROM Kassa WHERE ID_Kassa = {dataGridView1.SelectedRows[0].Cells[0].Value}", connection);
                cmd.ExecuteNonQuery();
                loadKassa();
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
            if (comboBox1.SelectedValue.ToString() != "")
            {
                connection = new SqlConnection(connectionString);
                try
                {
                    connection.Open();
                    cmd = new SqlCommand($"UPDATE Kassa SET ID_Employees ='{comboBox1.SelectedValue}' WHERE ID_Pay = {dataGridView1.SelectedRows[0].Cells[0].Value}", connection);
                    cmd.ExecuteNonQuery();
                    loadKassa();
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
            comboBox1.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void away_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
