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
    public partial class Employees : Form
    {
        string connectionString = @"Server = DESKTOP-64DGCJU\LOEN_TRAVELER;Initial Catalog=P3_HappyZOOZoo;Persist Security Info=True;User ID=sa;Password=S34g56F109";
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter dataAdapter;

        public Employees()
        {
            InitializeComponent();
        }

        public void LoadDolj()
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT * FROM Post", connection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                Doljnost.DataSource = ds.Tables[0];
                Doljnost.DisplayMember = "Name_Post";
                Doljnost.ValueMember = "ID_Post";
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

        public void LoadGender() 
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT * FROM Gender", connection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                Gender.DataSource = ds.Tables[0];
                Gender.DisplayMember = "Name_Gender";
                Gender.ValueMember = "ID_Gender";
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

        public void LoadEmployees()
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT dbo.Employees.ID_Employee, dbo.Employees.Genderint_ID AS 'Пол', dbo.Employees.Post_ID, dbo.Employees.Login_Text AS 'Логин', dbo.Employees.Password_Text AS 'Пароль', dbo.Employees.Last_Name AS 'Фамилия', dbo.Employees.First_Name AS 'Имя', dbo.Employees.Surname AS 'Отчество', dbo.Employees.Date_Of_Employees AS 'ДатаПринятия', dbo.Employees.Salary AS 'Зарплата', dbo.Post.Name_Post as 'Должность' FROM dbo.Employees INNER JOIN dbo.Gender ON dbo.Employees.Genderint_ID = dbo.Gender.ID_Gender INNER JOIN dbo.Post ON dbo.Employees.Post_ID = dbo.Post.ID_Post", connection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridViewEmployees.DataSource = ds.Tables[0];
                dataGridViewEmployees.Columns[0].Visible = false;
                dataGridViewEmployees.Columns[2].Visible = false;
                dataGridViewEmployees.Columns[3].Visible = false;
                dataGridViewEmployees.Columns[4].Visible = false;
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
        
        private void Employees_Load(object sender, EventArgs e)
        {
            LoadDolj();
            LoadGender();
            LoadEmployees();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textFirst.Text != "" && textLast.Text != "" && textMiddle.Text != "" && textLogin.Text != "" && (textPassword.Text != "" && textPassword.Text.Length >= 8) && Gender.SelectedIndex != 0 && Doljnost.SelectedIndex != 0)
            {
                connection = new SqlConnection(connectionString);
                try
                {
                    connection.Open();
                    cmd = new SqlCommand($"INSERT INTO Employees (Last_Name, First_Name, Surname, Login_Text, Password_Text,Genderint_ID,Post_ID, Date_Of_Employees, Salary) VALUES ('{textLast.Text}','{textFirst.Text}','{textMiddle.Text}','{textLogin.Text}','{textPassword.Text}','{Gender.SelectedValue}','{Doljnost.SelectedValue}','{dateTimePicker1.Value.ToShortDateString()}', '{maskedTextBoxMoney.Text}')", connection);
                    cmd.ExecuteNonQuery();
                    LoadEmployees();
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
                MessageBox.Show("Не верные данныевозможных полей: Выплаты, Логин или пароль.");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                cmd = new SqlCommand($"DELETE FROM Employees WHERE ID_Employee = {dataGridViewEmployees.SelectedRows[0].Cells[0].Value}", connection);
                cmd.ExecuteNonQuery();
                LoadEmployees();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textLogin.Text = dataGridViewEmployees.Rows[e.RowIndex].Cells[3].Value.ToString();
            textPassword.Text = dataGridViewEmployees.Rows[e.RowIndex].Cells[4].Value.ToString();
            textLast.Text = dataGridViewEmployees.Rows[e.RowIndex].Cells[5].Value.ToString();
            textFirst.Text = dataGridViewEmployees.Rows[e.RowIndex].Cells[6].Value.ToString();
            textMiddle.Text = dataGridViewEmployees.Rows[e.RowIndex].Cells[7].Value.ToString();
            Gender.SelectedValue = dataGridViewEmployees.Rows[e.RowIndex].Cells[1].Value;
            Doljnost.SelectedValue = dataGridViewEmployees.Rows[e.RowIndex].Cells[2].Value;
        }

        private void textLast_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z' || (e.KeyChar >= 'А' && e.KeyChar <= 'Я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я')) || e.KeyChar == (char)Keys.Back) || !Char.IsDigit(e.KeyChar) && Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;

            if(sender is TextBox)
                if ((sender as TextBox).Text.Length == 0)
                    e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void textPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z' || (e.KeyChar >= 'А' && e.KeyChar <= 'Я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я')) || e.KeyChar == (char)Keys.Back) || Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;

            if (sender is TextBox)
                if ((sender as TextBox).Text.Length == 0)
                    e.Handled = e.KeyChar == ' ';
        }

        private void ExapeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
