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
    public partial class FormTableEmployee : Form
    {
        string connectionString = @"Server = DESKTOP-64DGCJU\LOEN_TRAVELER;Initial Catalog=P3_MotoSolonEcipUP;Persist Security Info=True;User ID=sa;Password=S34g56F109";
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter dataAdapter;

        public FormTableEmployee()
        {
            InitializeComponent();
        }

        public void loadDolj()
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT * FROM Dolj", connection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                DoljnostComboBox.DataSource = ds.Tables[0];
                DoljnostComboBox.DisplayMember = "PositionForDolj";
                DoljnostComboBox.ValueMember = "ID";
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
        public void loadEmployee()
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT dbo.Employees.ID_Employees AS Номер, dbo.Employees.Last_Name AS Фамилия, dbo.Employees.First_Name AS Имя, dbo.Employees.Middle_Name AS Отчество, dbo.Employees.Passport_data AS Паспорт, dbo.Dolj.ID AS Проффесия, dbo.Dolj.PositionForDolj AS Проффесия FROM dbo.Dolj INNER JOIN dbo.Employees ON dbo.Dolj.ID = dbo.Employees.Position", connection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[5].Visible = false;
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


        private void FormTableEmployee_Load(object sender, EventArgs e)
        {
            loadDolj();
            loadEmployee();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (nameText.Text != "" && lastText.Text != "" && middleText.Text != "" && middleText.Text != "" && DoljnostComboBox.SelectedValue.ToString() != "")
            {
                connection = new SqlConnection(connectionString);
                try
                {
                    connection.Open();
                    cmd = new SqlCommand($"INSERT INTO Employees (Last_Name, First_Name, Middle_Name, Passport_data, Position) VALUES ('{nameText.Text}','{lastText.Text}','{middleText.Text}','{passText.Text}','{DoljnostComboBox.SelectedValue}')", connection);
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

        private void Replace_Click(object sender, EventArgs e)
        {
            if (nameText.Text != "" && lastText.Text != "" && middleText.Text != "" && passText.Text != "" && DoljnostComboBox.SelectedValue.ToString() != "")
            {
                connection = new SqlConnection(connectionString);
                try
                {
                    connection.Open();
                    cmd = new SqlCommand($"UPDATE Employees SET Last_Name ='{lastText.Text}', First_Name = '{nameText.Text}', Middle_Name = '{middleText.Text}', Passport_data = '{passText.Text}', Position = {DoljnostComboBox.SelectedValue} WHERE ID_Employees = {dataGridView1.SelectedRows[0].Cells[0].Value}", connection);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nameText.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            lastText.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            middleText.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            passText.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            DoljnostComboBox.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[5].Value;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                cmd = new SqlCommand($"DELETE FROM Employees WHERE ID_Employees = {dataGridView1.SelectedRows[0].Cells[0].Value}", connection);
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

        private void away_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
