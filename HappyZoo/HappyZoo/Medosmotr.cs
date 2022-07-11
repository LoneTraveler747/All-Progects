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
    public partial class Medosmotr : Form
    {
        string connectionString = @"Server = DESKTOP-64DGCJU\LOEN_TRAVELER;Initial Catalog=P3_HappyZOOZoo;Persist Security Info=True;User ID=sa;Password=S34g56F109";
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter dataAdapter;
        public void Sick()
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT * FROM Sick", connection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                comboBoxSick.DataSource = ds.Tables[0];
                comboBoxSick.DisplayMember = "Name_Sick";
                comboBoxSick.ValueMember = "ID_Sick";
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
        public void LoadSick()
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT dbo.Physical.ID_Physical, dbo.Physical.Weight AS Вес, dbo.Physical.Growth AS Рост, dbo.Physical.Graft 'Информация о прививках', dbo.Physical.State AS 'Информация о текущем состоянии животного', dbo.Physical.Date_Physical AS 'Дата осмотра', dbo.Physical.Sick_ID, dbo.Sick.Name_Sick AS 'Название болезни' FROM  dbo.Physical INNER JOIN dbo.Sick ON dbo.Physical.Sick_ID = dbo.Sick.ID_Sick", connection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridViewMed.DataSource = ds.Tables[0];
                dataGridViewMed.Columns[0].Visible = false;
                dataGridViewMed.Columns[6].Visible = false;
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

        public Medosmotr()
        {
            InitializeComponent();
        }

        private void Medosmotr_Load(object sender, EventArgs e)
        {
            Sick();
            LoadSick();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxSos.Text != "" && textOpisanie.Text != "" && maskedTextBoxRost.MaskCompleted && maskedTextBoxVes.MaskCompleted)
            {
                connection = new SqlConnection(connectionString);
                try
                {
                    connection.Open();
                    cmd = new SqlCommand($"INSERT INTO Physical (Weight, Growth, Graft, State, Date_Physical,Sick_ID) VALUES ('{maskedTextBoxVes.Text}','{maskedTextBoxRost.Text}','{textOpisanie.Text}','{textOpisanie.Text}','{dateTimePicker1.Value.ToShortDateString()}','{comboBoxSick.SelectedValue}')", connection);
                    cmd.ExecuteNonQuery();
                    LoadSick();
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
                MessageBox.Show("Поля не заполены или заполенеы некорректное");
            }
        }

        private void textBoxSos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(sender is TextBox)
            if ((sender as TextBox).Text.Length == 0)
             e.Handled = e.KeyChar == ' ';
        }

        private void ExapeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                cmd = new SqlCommand($"DELETE FROM Physical WHERE ID_Physical = {dataGridViewMed.SelectedRows[0].Cells[0].Value}", connection);
                cmd.ExecuteNonQuery();
                LoadSick();
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
