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
    public partial class Menu : Form
    {
        string connectionString = @"Server = DESKTOP-64DGCJU\LOEN_TRAVELER;Initial Catalog=P3_HappyZOOZoo;Persist Security Info=True;User ID=sa;Password=S34g56F109";
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter dataAdapter;

        public Menu()
        {
            InitializeComponent();
        }
        public void LoadFirmTable()
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT dbo.Menu.ID_Menu, dbo.Menu.Time_Feed as 'Время кормления',dbo.Menu.Name_Menu as 'Название меню', dbo.Menu.Count_Food as 'Количество', dbo.Menu.Type_ID, dbo.TypeFood.Name_Type as 'Название типа еды' FROM  dbo.Menu INNER JOIN dbo.TypeFood ON dbo.Menu.Type_ID = dbo.TypeFood.ID_Type", connection);

                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridViewMenu.DataSource = ds.Tables[0];
                dataGridViewMenu.Columns[0].Visible = false;
                dataGridViewMenu.Columns[4].Visible = false;
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

        public void LoadFood()
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT * FROM TypeFood", connection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                typeFood.DataSource = ds.Tables[0];
                typeFood.DisplayMember = "Name_Type";
                typeFood.ValueMember = "ID_Type";
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
        private void Menu_Load(object sender, EventArgs e)
        {
            LoadFood();
            LoadFirmTable();
        }

        private void countFood_KeyPress(object sender, KeyPressEventArgs e)
        {
            (sender as TextBox).MaxLength = 3;
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back) return;
            else
                e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (timeFood.Text != "" && countFood.Text != "" && typeFood.SelectedIndex != 0 && textBoxName.Text != "")
            {
                if (int.TryParse(timeFood.Text, out int num))
                {
                    if (num > 0 && num <= 120)
                    {
                        connection = new SqlConnection(connectionString);
                        try
                        {
                            connection.Open();
                            cmd = new SqlCommand($"INSERT INTO Menu (Time_Feed, Count_Food, Type_ID, Name_Menu) VALUES ('{timeFood.Text}','{countFood.Text}','{typeFood.SelectedValue}','{textBoxName.Text}')", connection);
                            cmd.ExecuteNonQuery();
                            LoadFirmTable();
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
                        MessageBox.Show("Неверно указано время кормления, оно не должно превышать 120 минут!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Поля не заполены или заполенеы некорректное");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z' || (e.KeyChar >= 'А' && e.KeyChar <= 'Я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я')) || e.KeyChar == (char)Keys.Back) || !Char.IsDigit(e.KeyChar) && Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void ExapeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                cmd = new SqlCommand($"DELETE FROM Menu WHERE ID_Menu = {dataGridViewMenu.SelectedRows[0].Cells[0].Value}", connection);
                cmd.ExecuteNonQuery();
                LoadFirmTable();
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
}
