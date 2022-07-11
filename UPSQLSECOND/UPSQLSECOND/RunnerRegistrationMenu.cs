using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPSQLSECOND
{
    public partial class RunnerRegistrationMenu : Form
    {
        public RunnerRegistrationMenu()
        {
            InitializeComponent();
        }
        public Image ByteArrayToImage(byte[] bt)
        {
            using (var ms = new MemoryStream(bt))
            {
                Image image = Image.FromStream(ms);
                return image;

            }
        }

        private void buttonRegistation_Click(object sender, EventArgs e)
        {
            var path_img = "";
            if (pictureBoxPhotoRegistr.Text == "")
            {
                path_img = Application.StartupPath.Replace("\\bin\\Debug", "") + "\\Resources\\unnamed.jpg";
            }
            else
            {
                path_img = openFileDialog1.FileName;
            }

            if (textNameRegistr.Text != "" && textLastNameRegistr.Text != "" && Password() && Date() && textEmailRegistr.Text != "")
            {
                string SQL1 = $"set language english insert Runner (Email,Gender,DateOfBirth,CountryCode)  values(N'{textEmailRegistr.Text}',N'{comboGender.SelectedItem}',CAST(N'{dateTimePickerBirthRegistr.Value.ToString("yyyy-MM-dd HH:mm:ss") + ".000"}' AS DateTime),N'{comboCountryRegistr.SelectedValue}')";
                string SQL = $"insert [User] values(N'{textEmailRegistr.Text}',N'{textPasswordRegistr.Text}',N'{textNameRegistr.Text}',N'{textLastNameRegistr.Text}',N'R',@img)";
                var img_byte = File.ReadAllBytes(path_img);
                var conect = new SqlConnection(Properties.Resources.connection);
                try
                {
                    conect.Open();
                    var command = new SqlCommand(SQL, conect);
                    ////     var adapter = new SqlDataAdapter("select * from test", conect);
                    ////     var ds = new DataSet();
                    ////     adapter.Fill(ds);
                    ////     var row = ds.Tables[0].Rows[1].ItemArray;
                    ////     var bt = row[0] as byte[];
                    command.Parameters.Add(new SqlParameter("@img", img_byte));
                    command.ExecuteNonQuery();
                    //     img_runner.Image = ByteArrayToImage(bt);
                    command = new SqlCommand(SQL1, conect);
                    command.ExecuteNonQuery();
                    Hide();
                    var form = new RegistrationForTheMarathon(textEmailRegistr.Text);
                    form.Show();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
                finally
                {
                    conect.Close();
                }
                path_img = "";
            }
        }

        private void buttonViewing_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) //показываем диалог открытия
                textImageFile.Text = openFileDialog1.FileName;
        }

        private void textNameRegistr_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();

            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textNameRegistr_Leave(object sender, EventArgs e)
        {
            if (((TextBox)sender).TextLength != 0)
                (sender as TextBox).Text = (sender as TextBox).Text[0].ToString().ToUpper() + (sender as TextBox).Text.Substring(1, (sender as TextBox).Text.Length - 1).ToLower();
        }

        private void textEmailRegistr_Leave(object sender, EventArgs e)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(textEmailRegistr.Text);
            }
            catch
            {
                textEmailRegistr.Text = "";
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            pictureBoxPhotoRegistr.Image = Image.FromFile(openFileDialog1.FileName);
        }
        Boolean Password()
        {
            Debug.WriteLine(textPasswordRegistr.Text.Contains("!"));
            Debug.WriteLine(textPasswordRegistr.Text.Contains("@"));
            Debug.WriteLine(textPasswordRegistr.Text.Contains("#"));
            Debug.WriteLine(textPasswordRegistr.Text.Contains("$"));
            Debug.WriteLine(textPasswordRegistr.Text.Contains("%"));
            Debug.WriteLine(textPasswordRegistr.Text.Contains("^"));
            Debug.WriteLine(textReplayPasswordRegistr == textPasswordRegistr);
            if ((textPasswordRegistr.Text.Contains("!") || textPasswordRegistr.Text.Contains("@") || textPasswordRegistr.Text.Contains("#") || textPasswordRegistr.Text.Contains("$") || textPasswordRegistr.Text.Contains("%") || textPasswordRegistr.Text.Contains("^")) && textReplayPasswordRegistr.Text == textPasswordRegistr.Text && textPasswordRegistr.Text.Length >= 6 && Regex.IsMatch(textPasswordRegistr.Text, @"[0-9]") && Regex.IsMatch(textPasswordRegistr.Text, @"[А-ЯA-Z]"))
            {
                return true;
            }
            return false;
        }
        Boolean Date()
        {
            var DateOfBirth = dateTimePickerBirthRegistr.Value.AddYears(10);
            var datenow = DateTime.Now;

            if (datenow >= DateOfBirth)
            {
                return true;
            }
            return false;
        }
        public class Country
        {
            public string CountryCode { get; set; }
            public string CountryName { get; set; }
            public string CountryFlag { get; set; }
        }
    }
}
