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
    public partial class Barder : Form
    {
        string connectionString = @"Server = DESKTOP-64DGCJU\LOEN_TRAVELER;Initial Catalog=P3_HappyZOOZoo;Persist Security Info=True;User ID=sa;Password=S34g56F109";
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter dataAdapter;

        public Barder()
        {
            InitializeComponent();
        }
        public void LoadBarderTable()
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT dbo.ZooBarter.ID_Barter, dbo.ZooBarter.Zoo_request, dbo.ZooBarter.Zoo_answer, dbo.ZooBarter.Adress as 'Адрес принимающего', dbo.ZooBarter.What_animal_barter as 'Вид животного', dbo.BarterRequest.ListZooRequest as 'Отправленный запрос', dbo.BarterAnswer.ListZooAnswer as 'Принимающий запрос' FROM  dbo.BarterAnswer INNER JOIN dbo.ZooBarter ON dbo.BarterAnswer.ID_BarterAnswer = dbo.ZooBarter.Zoo_answer INNER JOIN dbo.BarterRequest ON dbo.ZooBarter.Zoo_request = dbo.BarterRequest.ID_BarterRequest", connection);

                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridViewBarder.DataSource = ds.Tables[0];
                dataGridViewBarder.Columns[0].Visible = false;
                dataGridViewBarder.Columns[2].Visible = false;
                dataGridViewBarder.Columns[1].Visible = false;
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

        public void LoadBarderZooOutRequest()
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT * FROM BarterRequest", connection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);

                comboBoxIn.DataSource = ds.Tables[0];
                comboBoxIn.DisplayMember = "ListZooRequest";
                comboBoxIn.ValueMember = "ID_BarterRequest";

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
        public void LoadBarderAnimalAnswer()
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT * FROM BarterAnswer", connection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);

                comboBoxOut.DataSource = ds.Tables[0];
                comboBoxOut.DisplayMember = "ListZooAnswer";
                comboBoxOut.ValueMember = "ID_BarterAnswer";

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

        private void Barder_Load(object sender, EventArgs e)
        {
            LoadBarderTable();
            LoadBarderZooOutRequest();
            LoadBarderAnimalAnswer();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBoxIn.SelectedIndex != comboBoxOut.SelectedIndex && adres.Text != "" && viewAnimal.Text != "")
            {
                connection = new SqlConnection(connectionString);
                try
                {
                    connection.Open();
                    cmd = new SqlCommand($"INSERT INTO ZooBarter (Zoo_request, Zoo_answer, Adress, What_animal_barter) VALUES ('{comboBoxIn.SelectedValue}','{comboBoxOut.SelectedValue}','{adres.Text}','{viewAnimal.Text}')", connection);
                    cmd.ExecuteNonQuery();
                    LoadBarderTable();
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
                MessageBox.Show("Не верно заполены поля");
            }
        }

        private void adres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender is TextBox)
                if ((sender as TextBox).Text.Length == 0)
                    e.Handled = e.KeyChar == ' ';
        }

        private void viewAnimal_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
