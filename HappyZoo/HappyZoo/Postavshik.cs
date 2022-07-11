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
    public partial class Postavshik : Form
    {
        string connectionString = @"Server = DESKTOP-64DGCJU\LOEN_TRAVELER;Initial Catalog=P3_HappyZOOZoo;Persist Security Info=True;User ID=sa;Password=S34g56F109";
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter dataAdapter;

        public Postavshik()
        {
            InitializeComponent();
        }
        public void LoadRoom()
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT * FROM TypeFood", connection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                comboBoxfood.DataSource = ds.Tables[0];
                comboBoxfood.DisplayMember = "Name_Type";
                comboBoxfood.ValueMember = "ID_Type";
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

        public void LoadFirm()
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT * FROM Firm", connection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                comboBoxFirm.DataSource = ds.Tables[0];
                comboBoxFirm.DisplayMember = "Name_Firm";
                comboBoxFirm.ValueMember = "ID_Firm";
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
                dataAdapter = new SqlDataAdapter("SELECT dbo.Supplier.Supplier_ID, dbo.Supplier.Adress as Адрес, dbo.Supplier.Name_Food as 'Название еды', dbo.Supplier.Count_Food as 'Количество еды', dbo.Supplier.Cost_Food as 'Цена еды', dbo.Supplier.Date_Supply as 'Дата привозки', dbo.Firm.Name_Firm as Фирма, dbo.TypeFood.Name_Type as 'Название типа', dbo.Supplier.Firm_ID, dbo.Supplier.Type_ID FROM dbo.Firm INNER JOIN dbo.Supplier ON dbo.Firm.ID_Firm = dbo.Supplier.Firm_ID INNER JOIN dbo.TypeFood ON dbo.Supplier.Type_ID = dbo.TypeFood.ID_Type", connection);
                
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridViewPostavchik.DataSource = ds.Tables[0];
                dataGridViewPostavchik.Columns[0].Visible = false;
                dataGridViewPostavchik.Columns[8].Visible = false;
                dataGridViewPostavchik.Columns[9].Visible = false;
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            (sender as TextBox).MaxLength = 3;
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back) return;
            else
                e.Handled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBoxVes.Text != "")
            {
                if (int.TryParse(textBoxVes.Text, out int num))
                    if (num > 0)
                        textBox1.Text = Convert.ToString(num * 10);
                    else
                        MessageBox.Show("Нельзя вводи 0");
            }
            else MessageBox.Show("Пустота поля, хоть и без этой защиты не работает, но на всякий вписал :3");
        }

        private void Postavshik_Load(object sender, EventArgs e)
        {
            LoadRoom();
            LoadFirm();
            LoadFirmTable();
        }

        private void textBoxSos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((sender as TextBox).Text.Length == 0)
                e.Handled = e.KeyChar == ' ';
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z' || (e.KeyChar >= 'А' && e.KeyChar <= 'Я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я')) || e.KeyChar == (char)Keys.Back) || !Char.IsDigit(e.KeyChar) && Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBoxAdres.Text != "" && textBoxVes.Text != "" && textBox1.Text != "" && textBoxkorm.Text != "" && comboBoxFirm.SelectedIndex != 0 && comboBoxfood.SelectedIndex != 0)
            {
                connection = new SqlConnection(connectionString);
                try
                {
                    connection.Open();
                    cmd = new SqlCommand($"INSERT INTO Supplier (Adress, Name_Food, Count_Food, Cost_Food, Date_Supply, Firm_ID, Type_ID) VALUES ('{textBoxAdres.Text}','{textBoxkorm.Text}','{textBoxVes.Text}','{textBox1.Text}','{dateTimePicker1.Value.ToShortDateString()}','{comboBoxFirm.SelectedValue}','{comboBoxfood.SelectedValue}')", connection);
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
                MessageBox.Show("Поля не заполены или заполенеы некорректное");
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
                cmd = new SqlCommand($"DELETE FROM Supplier WHERE Supplier_ID = {dataGridViewPostavchik.SelectedRows[0].Cells[0].Value}", connection);
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
