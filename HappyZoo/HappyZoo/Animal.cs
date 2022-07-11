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
    public partial class Animal : Form
    {
        string connectionString = @"Server = DESKTOP-64DGCJU\LOEN_TRAVELER;Initial Catalog=P3_HappyZOOZoo;Persist Security Info=True;User ID=sa;Password=S34g56F109";
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter dataAdapter;

        public void LoadType_Animal()
        {

        }

        public void LoadClass()
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT * FROM Class_Animal", connection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                ClassAnimal.DataSource = ds.Tables[0];
                ClassAnimal.DisplayMember = "Name_Class";
                ClassAnimal.ValueMember = "ID_Class";
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

        public void LoadType()
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT * FROM Type_animal", connection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                TypeAnimal.DataSource = ds.Tables[0];
                TypeAnimal.DisplayMember = "Name_Type";
                TypeAnimal.ValueMember = "ID_Type";
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

        public void LoadRoom()
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT * FROM Room", connection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                comboBoxRoom.DataSource = ds.Tables[0];
                comboBoxRoom.DisplayMember = "Type_Room";
                comboBoxRoom.ValueMember = "ID_Room";
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

        public Animal()
        {
            InitializeComponent();
        }

        private void Animal_Load(object sender, EventArgs e)
        {
            LoadClass();
            LoadRoom();
            LoadGender();
            LoadType();
            LoadAnimals();
        }

        public void LoadAnimals()
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT dbo.Animal.Animal_ID, dbo.Animal.Gender_ID AS 'Пол', dbo.Animal.Type_ID AS 'Тип животного', dbo.Animal.Class_ID AS 'Класс животного', dbo.Animal.Room_ID AS 'Комната', dbo.Animal.View_Animal AS 'Вид', dbo.Animal.The_exepted_offspring AS 'Ожидаемое потомство', dbo.Animal.Age AS 'Возраст(в годах)', dbo.Animal.Arrival_date_at_the_zoo AS 'Дата прибывания', dbo.Class_Animal.Name_Class, dbo.Gender.Name_Gender, dbo.Type_animal.Name_Type, dbo.Room.Type_Room FROM dbo.Animal INNER JOIN dbo.Class_Animal ON dbo.Animal.Class_ID = dbo.Class_Animal.ID_Class INNER JOIN dbo.Gender ON dbo.Animal.Gender_ID = dbo.Gender.ID_Gender INNER JOIN dbo.Room ON dbo.Animal.Room_ID = dbo.Room.ID_Room INNER JOIN dbo.Type_animal ON dbo.Animal.Type_ID = dbo.Type_animal.ID_Type", connection);

                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridViewAnimal.DataSource = ds.Tables[0];
                dataGridViewAnimal.Columns[0].Visible = false;
                dataGridViewAnimal.Columns[1].Visible = false;
                dataGridViewAnimal.Columns[2].Visible = false;
                dataGridViewAnimal.Columns[3].Visible = false;
                dataGridViewAnimal.Columns[4].Visible = false;
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (Gender.SelectedIndex != 0 && maskedTextBoxAge.MaskCompleted && textBoxView.Text != "" && textPotomstvo.Text != "") {
                connection = new SqlConnection(connectionString);
                try
                {
                    connection.Open();
                    cmd = new SqlCommand($"INSERT INTO Animal (Gender_ID, Type_ID, Class_ID, Room_ID, View_Animal, The_exepted_offspring, Age, Arrival_date_at_the_zoo) VALUES ('{Gender.SelectedValue}','{TypeAnimal.SelectedValue}','{ClassAnimal.SelectedValue}','{comboBoxRoom.SelectedValue}','{textBoxView.Text}','{textPotomstvo.Text}','{maskedTextBoxAge.Text}','{dateTimePicker1.Value.ToShortDateString()}')", connection);
                    cmd.ExecuteNonQuery();
                    LoadAnimals();
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= 'А' && e.KeyChar <= 'Я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back) || !Char.IsDigit(e.KeyChar) && Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void textLast_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= 'А' && e.KeyChar <= 'Я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back) || !Char.IsDigit(e.KeyChar) && Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void ExapeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                cmd = new SqlCommand($"DELETE FROM Animal WHERE Animal_ID = {dataGridViewAnimal.SelectedRows[0].Cells[0].Value}", connection);
                cmd.ExecuteNonQuery();
                LoadAnimals();
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