using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Xml.Serialization;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace Regust
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    /// 
    [Serializable]
    public class zapis
    {
        public string familia1 { get; set; }
        public string imya1 { get; set; }
        public string otchestvo1 { get; set; }
        public string login1 { get; set; }
        public string password1 { get; set; }
        public string pol1 { get; set; }
        public string mail1 { get; set; }
        public zapis(string familia, string imya, string otchestvo, string login, string password, string pol, string mail)
        {
            this.familia1 = familia;
            this.imya1 = imya;
            this.otchestvo1 = otchestvo;
            this.login1 = login;
            this.password1 = password;
            this.pol1 = pol;
            this.mail1 = mail;
        }
        public zapis()
        {

        }
    }

    public sealed partial class MainPage : Page
    {
        bool small, big, number, item, full;

        public List<zapis> lupa = new List<zapis>();

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            StorageFolder kinfull = ApplicationData.Current.LocalFolder;
            XmlSerializer serializ = new XmlSerializer(typeof(List<zapis>));

            string Email = name.Text + "@" + email_servise.Text + "." + domen.Text;
            string pol;
            if (posudomoyka.IsChecked == true)
            {
                pol = "Женщина";
            }
            else
            {
                pol = "Мужчина";
            }
            //Чтение файла
            StorageFile kinfiles = await kinfull.CreateFileAsync("DataBase.xml", CreationCollisionOption.OpenIfExists);
            Stream opens = await kinfiles.OpenStreamForReadAsync();
            try
            {
                lupa = (List<zapis>)serializ.Deserialize(opens);
            }
            catch { }
            opens.Close();
            bool loginx = true;
            for (int i = 0; i < lupa.Count; i++)
            {
                if (login.Text == lupa[i].login1)
                {
                    loginx = false;
                }
            }
            if (loginx == false)
            {
                error.Text = "Логин занят!";
            }

            if (big == true && small == true && number == true && /*item == true &&*/ full == true && firstName.Text != "" && secondName.Text != "" && lastName.Text != "" && lastName.Text != "" && login.Text != "" && password.Password != "" && pol != "" && Email != "" && loginx == true)
            {
                error.Text = "";
                StorageFile kinfile = await kinfull.CreateFileAsync("DataBase.xml", CreationCollisionOption.ReplaceExisting);
                //Запись в файл по условию
                zapis pupa = new zapis(firstName.Text, secondName.Text, lastName.Text, login.Text, password.Password, pol, Email);
                lupa.Add(pupa);
                Stream open = await kinfile.OpenStreamForWriteAsync();
                serializ.Serialize(open, lupa);
                open.Close();
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            firstName.Text = "";
            secondName.Text = "";
            lastName.Text = "";
            password.Password = "";
            login.Text = "";
            name.Text = "";
            email_servise.Text = "";
            domen.Text = "";
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            string isFirst;
            if ((sender as TextBox).Text != "")
            {
                isFirst = char.ToUpper((sender as TextBox).Text[0]) + (sender as TextBox).Text.Substring(1);
                (sender as TextBox).Text = isFirst;
            }

        }

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {

            char end;

            if (password.Password != "")
            {
                end = Convert.ToChar(password.Password.Substring(password.Password.Length - 1));

                if (char.IsUpper(end))
                {
                    big = true;
                }

                if (char.IsLower(end))
                {
                    small = true;
                }

                if (char.IsDigit(end))
                {
                    number = true;
                }

                if (password.Password.Length > 8)
                {
                    full = true;
                }
            }
        }
    }
}
