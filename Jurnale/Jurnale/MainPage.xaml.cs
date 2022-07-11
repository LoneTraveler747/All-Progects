using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Xml.Serialization;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Security.Cryptography;
using System.Text;
using System.Data.SqlClient;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace Jurnale
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    [Serializable]
    public class Registration
    {
        public string firstName { get; set; }
        public string secondName { get; set; }
        public string endName { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string groupe { get; set; }
        public string who { get; set; }
        public Registration(string firstName, string secondName, string endName, string login, string password, string groupe, string who)
        {
            this.firstName = firstName;
            this.secondName = secondName;
            this.endName = endName;
            this.login = login;
            this.password = password;
            this.groupe = groupe;
            this.who = who;
        }
        public Registration()
        {

        }
    }


    public sealed partial class MainPage : Page
    {
        public static string connectionString = @"Server=DESKTOP-64DGCJU\LOEN_TRAVELER;Initial Catalog=P3_MPTJurnale;User ID=sa;Password=S34g56F109";
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter dataAdapter;

        public MainPage()
        {
            this.InitializeComponent();
        }
        public bool click = false;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (click == true)
            {
                InPutLog.Visibility = Visibility.Visible;
                Regist.Visibility = Visibility.Collapsed;
                click = false;
            }
        }

        private void RegisterInPut_Click(object sender, RoutedEventArgs e)
        {
            if (click == false)
            {
                Regist.Visibility = Visibility.Visible;
                InPutLog.Visibility = Visibility.Collapsed;
                click = true;
            }
        }
        public List<Registration> aDmin = new List<Registration>();
        public List<Registration> sTudent = new List<Registration>();
        public List<Registration> tEacher = new List<Registration>();

        public StorageFolder storageFolder = ApplicationData.Current.LocalFolder;
        public XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Registration>));
        private async void RegistrarionIN_Click(object sender, RoutedEventArgs e)
        {
            if (FirstName.Text != "" && SecondName.Text != "" && Login.Text != "" && passwordReg.Password != "")
            {
                string shifrPassword = Shifr(passwordReg.Password);

                if (AdminReg.IsChecked == true)
                {
                    bool loginx = true;
                    for (int i = 0; i < aDmin.Count; i++)
                    {
                        if (Login.Text == aDmin[i].login)
                        {
                            loginx = false;
                        }
                    }
                    if (loginx == false)
                    {
                        var rep = await new MessageDialog("Ошибка! Повтор логина").ShowAsync();
                    }
                    else
                    {
                        StorageFile storageFileAdmin = await storageFolder.CreateFileAsync("Admin.xml", CreationCollisionOption.OpenIfExists);
                        Registration admin = new Registration(FirstName.Text, SecondName.Text, EndName.Text, Login.Text, shifrPassword, "", "Админ");
                        aDmin.Add(admin);
                        Stream writeAdmin = await storageFileAdmin.OpenStreamForWriteAsync();
                        xmlSerializer.Serialize(writeAdmin, aDmin);
                        writeAdmin.Close();
                    }
                }
                else if (StudReg.IsChecked == true && groupeBoxCombo.SelectedIndex != -1)
                {
                    bool loginx = true;
                    for (int i = 0; i < sTudent.Count; i++)
                    {
                        if (Login.Text == sTudent[i].login)
                        {
                            loginx = false;
                        }
                    }
                    if (loginx == false)
                    {
                        var rep = await new MessageDialog("Ошибка! Повтор логина").ShowAsync();
                    }
                    else
                    {
                        StorageFile storageFileAdmin = await storageFolder.CreateFileAsync("Student.xml", CreationCollisionOption.OpenIfExists);
                        Registration student = new Registration(FirstName.Text, SecondName.Text, EndName.Text, Login.Text, shifrPassword, groupeBoxCombo.SelectedItem.ToString(), "Студент");
                        sTudent.Add(student);
                        Stream writeAdmin = await storageFileAdmin.OpenStreamForWriteAsync();
                        xmlSerializer.Serialize(writeAdmin, sTudent);
                        writeAdmin.Close();
                    }
                }
                else if (TeacherReg.IsChecked == true)
                {
                    bool loginx = true;
                    for (int i = 0; i < tEacher.Count; i++)
                    {
                        if (Login.Text == tEacher[i].login)
                        {
                            loginx = false;
                        }
                    }
                    if (loginx == false)
                    {
                        var rep = await new MessageDialog("Ошибка! Повтор логина").ShowAsync();
                    }
                    else
                    {
                        StorageFile storageFileAdmin = await storageFolder.CreateFileAsync("Teacher.xml", CreationCollisionOption.OpenIfExists);
                        Registration teacher = new Registration(FirstName.Text, SecondName.Text, EndName.Text, Login.Text, shifrPassword, "", "Преподаватель");
                        tEacher.Add(teacher);
                        Stream writeAdmin = await storageFileAdmin.OpenStreamForWriteAsync();
                        xmlSerializer.Serialize(writeAdmin, tEacher);
                        writeAdmin.Close();
                    }
                }
            }
            else
            {
                var rep = await new MessageDialog("Ошибка! Нужные поля не заполнены!").ShowAsync();
            }
        }
        public string Shifr(string input)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder sBuilder = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }
                return sBuilder.ToString();
            }
        }

        private async void InPut_Click(object sender, RoutedEventArgs e)
        {
            string pass = Shifr(passwordIn.Password);
            if (adMin.IsChecked == true)
            {
                for (int i = 0; i < aDmin.Count; i++)
                {
                    if (loginIn.Text == aDmin[i].login && pass == aDmin[i].password)
                    {
                        this.Frame.Navigate(typeof(AdminPage));
                        break;
                    }
                }
            }
            else if (stUd.IsChecked == true)
            {
                for (int i = 0; i < sTudent.Count; i++)
                {
                    if (loginIn.Text == sTudent[i].login && pass == sTudent[i].password)
                    {
                        StorageFile userStudent = await storageFolder.CreateFileAsync("AcceptUser.xml", CreationCollisionOption.ReplaceExisting);
                        XmlSerializer xml = new XmlSerializer(typeof(Registration));
                        Stream streamUser = await userStudent.OpenStreamForWriteAsync();

                        xml.Serialize(streamUser, sTudent[i]);
                        streamUser.Close();

                        this.Frame.Navigate(typeof(StudentPage));
                        break;
                    }
                }
            }
            else if (teaCher.IsChecked == true)
            {
                for (int i = 0; i < tEacher.Count; i++)
                {
                    if (loginIn.Text == tEacher[i].login && pass == tEacher[i].password)
                    {
                        this.Frame.Navigate(typeof(PrepodPage));
                        break;
                    }
                }
            }
        }
        public XmlSerializer xmlSerializerGroupe = new XmlSerializer(typeof(List<string>));
        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            StorageFile fileGroupe = await storageFolder.CreateFileAsync("Groupe.xml", CreationCollisionOption.OpenIfExists);
            Stream streamGroup = await fileGroupe.OpenStreamForReadAsync();
            try
            {
                groupeBoxCombo.ItemsSource = (List<string>)xmlSerializerGroupe.Deserialize(streamGroup);
            }
            catch { }
            streamGroup.Close();

            if (StudReg.IsChecked == true)
            {
                groupeGrid.Visibility = Visibility.Visible;
            }
            else
            {
                groupeGrid.Visibility = Visibility.Collapsed;
            }
            StorageFile storageFileAdmin = await storageFolder.CreateFileAsync("Admin.xml", CreationCollisionOption.OpenIfExists);
            Stream writeAdmin = await storageFileAdmin.OpenStreamForWriteAsync();
            try
            {
                aDmin = (List<Registration>)xmlSerializer.Deserialize(writeAdmin);
            }
            catch { }
            writeAdmin.Close();
            StorageFile storageFileStudent = await storageFolder.CreateFileAsync("Student.xml", CreationCollisionOption.OpenIfExists);
            Stream writeStudent = await storageFileStudent.OpenStreamForWriteAsync();
            try
            {
                sTudent = (List<Registration>)xmlSerializer.Deserialize(writeStudent);
            }
            catch { }
            writeStudent.Close();
            StorageFile storageFileTeacher = await storageFolder.CreateFileAsync("Teacher.xml", CreationCollisionOption.OpenIfExists);
            Stream writeTeacher = await storageFileTeacher.OpenStreamForWriteAsync();
            try
            {
                tEacher = (List<Registration>)xmlSerializer.Deserialize(writeTeacher);
            }
            catch { }
            writeTeacher.Close();
        }

        private void StudReg_Checked(object sender, RoutedEventArgs e)
        {

            if ((sender as RadioButton).IsChecked == true && (sender as RadioButton).Name == "StudReg")
            {
                groupeGrid.Visibility = Visibility.Visible;
            }
            else
            {
                groupeGrid.Visibility = Visibility.Collapsed;
            }
        }
    }
}