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
    public partial class Feeding : Form
    {
        string connectionString = @"Server = DESKTOP-64DGCJU\LOEN_TRAVELER;Initial Catalog=P3_HappyZOOZoo;Persist Security Info=True;User ID=sa;Password=S34g56F109";
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter dataAdapter;
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
        public void LoadSeason()
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT * FROM Season", connection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                season.DataSource = ds.Tables[0];
                season.DisplayMember = "Name_Season";
                season.ValueMember = "ID_Season";
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
        public void LoadMenu()
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT * FROM Menu", connection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                numMenu.DataSource = ds.Tables[0];
                numMenu.DisplayMember = "Name_Menu";
                numMenu.ValueMember = "ID_Menu";
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

        public void LoadFirmTable()
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT dbo.Feeding.ID_Feeding, dbo.Feeding.Time as 'Дата кормления', dbo.Feeding.Count_in_Day as 'Количество раз', dbo.Feeding.Menu_ID, dbo.Feeding.Season_ID, dbo.Feeding.Type_ID, dbo.Season.Name_Season as 'Сезон', dbo.TypeFood.Name_Type as 'Название типа', dbo.Menu.Name_Menu as 'Название меню' FROM  dbo.Feeding INNER JOIN dbo.Menu ON dbo.Feeding.Menu_ID = dbo.Menu.ID_Menu INNER JOIN dbo.Season ON dbo.Feeding.Season_ID = dbo.Season.ID_Season INNER JOIN dbo.TypeFood ON dbo.Feeding.Type_ID = dbo.TypeFood.ID_Type", connection);

                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridViewFeeding.DataSource = ds.Tables[0];
                dataGridViewFeeding.Columns[0].Visible = false;
                dataGridViewFeeding.Columns[3].Visible = false;
                dataGridViewFeeding.Columns[4].Visible = false;
                dataGridViewFeeding.Columns[5].Visible = false;
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

        public Feeding()
        {
            InitializeComponent();
        }
        private void Feeding_Load(object sender, EventArgs e)
        {
            LoadSeason();
            LoadFood();
            LoadMenu();
            LoadFirmTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (numMenu.SelectedIndex != 0 && typeFood.SelectedIndex != 0 && season.SelectedIndex != 0)
            {
                if (int.TryParse(maskedTextBoxCount.Text, out int num) && (int.TryParse(maskedTextBox3.Text, out int numMin)) && (int.TryParse(maskedTextBox4.Text, out int numSec)) && (int.TryParse(maskedTextBox2.Text, out int numhou)))
                {
                    if (num > 0 && numhou < 9 && (numMin<=59 || numMin>=30) && numSec >= 0)
                    {
                        connection = new SqlConnection(connectionString);
                        try
                        {
                            connection.Open();
                            cmd = new SqlCommand($"INSERT INTO Feeding (Time, Count_in_Day, Menu_ID, Season_ID, Type_ID) VALUES ('{maskedTextBox2.Text}:{maskedTextBox3.Text}:{maskedTextBox4.Text}','{maskedTextBoxCount.Text}','{numMenu.SelectedValue}','{season.SelectedValue}','{typeFood.SelectedValue}')", connection);
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
                        MessageBox.Show("Кормление должно быть более одного раза ИЛИ вы указали не верное время!");
                    }
                }
                else
                {
                    MessageBox.Show("Ошибка!");
                }
            }
            else
            {
                MessageBox.Show("Поля не заполены или заполенеы некорректное!");
            }
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
                cmd = new SqlCommand($"DELETE FROM Feeding WHERE ID_Feeding = {dataGridViewFeeding.SelectedRows[0].Cells[0].Value}", connection);
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
