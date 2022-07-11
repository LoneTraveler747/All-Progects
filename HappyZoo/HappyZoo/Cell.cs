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
    public partial class Cell : Form
    {
        string connectionString = @"Server = DESKTOP-64DGCJU\LOEN_TRAVELER;Initial Catalog=P3_HappyZOOZoo;Persist Security Info=True;User ID=sa;Password=S34g56F109";
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter dataAdapter;

        public Cell()
        {
            InitializeComponent();
        }
        public void LoadCell()
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT dbo.Cell.Cell_ID, dbo.Cell.Combination as 'Информация о совмещении', dbo.Cell.Barter_ID, dbo.Cell.Animal_ID, dbo.Cell.Feeding_ID, dbo.Cell.Physical_ID, dbo.Cell.Offspring as 'Информация о потомстве', dbo.Animal.View_Animal as 'Вид животного', dbo.ZooBarter.Adress as 'Адресс обмена', dbo.Feeding.Menu_ID as 'Меню',  dbo.Physical.State as 'Медосмотр' FROM dbo.Animal INNER JOIN dbo.Cell ON dbo.Animal.Animal_ID = dbo.Cell.Animal_ID INNER JOIN dbo.Feeding ON dbo.Cell.Feeding_ID = dbo.Feeding.ID_Feeding INNER JOIN dbo.Physical ON dbo.Cell.Physical_ID = dbo.Physical.ID_Physical INNER JOIN dbo.ZooBarter ON dbo.Cell.Barter_ID = dbo.ZooBarter.ID_Barter", connection);

                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridViewCell.DataSource = ds.Tables[0];
                dataGridViewCell.Columns[0].Visible = false;
                dataGridViewCell.Columns[2].Visible = false;
                dataGridViewCell.Columns[3].Visible = false;
                dataGridViewCell.Columns[4].Visible = false;
                dataGridViewCell.Columns[5].Visible = false;
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

        public void LoadBurder()
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT * FROM ZooBarter", connection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                burderBox.DataSource = ds.Tables[0];
                burderBox.DisplayMember = "Adress";
                burderBox.ValueMember = "ID_Barter";
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

        public void LoadAnimal()
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT * FROM Animal", connection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                animalBox.DataSource = ds.Tables[0];
                animalBox.DisplayMember = "View_Animal";
                animalBox.ValueMember = "Animal_ID";
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
        public void LoadFeeding()
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT * FROM Feeding", connection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                feedingBox.DataSource = ds.Tables[0];
                feedingBox.DisplayMember = "Menu_ID";
                feedingBox.ValueMember = "ID_Feeding";
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
        public void LoadPhysical()
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT * FROM Physical", connection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                physicalBox.DataSource = ds.Tables[0];
                physicalBox.DisplayMember = "[State]";
                physicalBox.ValueMember = "ID_Physical";
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
            if (combinationBox.Text != "" && offspirngBox.Text != "")
            {
                connection = new SqlConnection(connectionString);
                try
                {
                    connection.Open();
                    cmd = new SqlCommand($"INSERT INTO Cell (Combination, Barter_ID, Animal_ID, Feeding_ID,Physical_ID,Offspring) VALUES ('{combinationBox.Text}','{burderBox.SelectedValue}','{animalBox.SelectedValue}','{feedingBox.SelectedValue}', '{physicalBox.SelectedValue}', '{offspirngBox.Text}')", connection);
                    cmd.ExecuteNonQuery();
                    LoadCell();
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

        private void combinationBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender is TextBox)
                if ((sender as TextBox).Text.Length == 0)
                    e.Handled = e.KeyChar == ' ';
        }

        private void Cell_Load(object sender, EventArgs e)
        {
            LoadPhysical();
            LoadFeeding();
            LoadBurder();
            LoadAnimal();
            LoadCell();
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
                cmd = new SqlCommand($"DELETE FROM Cell WHERE Cell_ID = {dataGridViewCell.SelectedRows[0].Cells[0].Value}", connection);
                cmd.ExecuteNonQuery();
                LoadCell();
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
