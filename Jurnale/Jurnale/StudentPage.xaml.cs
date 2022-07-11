using AE.Net.Mail;
using Microsoft.Toolkit.Uwp.UI.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
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

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace Jurnale
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public class Zapis
    {
        public string mail { get; set; }
        public string login { get; set; }
        public string passwordText { get; set; }
        public Zapis(string mail, string login, string passwordText)
        {
            this.mail = mail;
            this.login = login;
            this.passwordText = passwordText;
        }
        public Zapis()
        {

        }
    }

    public sealed partial class StudentPage : Page
    {

        public Zapis zapis = new Zapis();

        public static string connectionString = @"Server=DESKTOP-64DGCJU\LOEN_TRAVELER;Initial Catalog=P3_MPTJurnale;User ID=sa;Password=S34g56F109";
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter dataAdapter;

        public StudentPage()
        {
            this.InitializeComponent();
            //Message(ApplicationData.Current.LocalFolder.Path);
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        public List<JurnaleStudent> userStudent = new List<JurnaleStudent>();

        public StorageFolder storageFolder = ApplicationData.Current.LocalFolder;
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<JurnaleStudent>));

        private async void Message(string ex)
        {
            ContentDialog subscribeDialog = new ContentDialog
            {
                Title = "Ошибка",
                Content = ex,
                CloseButtonText = "Закрыть",
            };
            ContentDialogResult result = await subscribeDialog.ShowAsync();
        }

        private async void accept_Click(object sender, RoutedEventArgs e)
        {
            if (allDiscipline.SelectedIndex != -1 && dateDiscipline.Date.Year >= 2015)
            {
                StorageFile storageFileAdmin = await storageFolder.CreateFileAsync(allDiscipline.SelectedItem.ToString() + " " + dateDiscipline.Date.ToString("dd-MM-yyyy") + ".xml", CreationCollisionOption.OpenIfExists);
                Stream writeStudent = await storageFileAdmin.OpenStreamForWriteAsync();

                try
                {
                    userStudent = (List<JurnaleStudent>)xmlSerializer.Deserialize(writeStudent);
                }
                catch { }

                writeStudent.Close();
                StorageFile userStudentfile = await storageFolder.CreateFileAsync("AcceptUser.xml", CreationCollisionOption.OpenIfExists);
                XmlSerializer xml = new XmlSerializer(typeof(Registration));
                Stream streamUser = await userStudentfile.OpenStreamForWriteAsync();
                Registration registration = new Registration();
                try
                {
                    registration = (Registration)xml.Deserialize(streamUser);
                }
                catch { }
                streamUser.Close();

                for (int i = 0; i < userStudent.Count; i++)
                {
                    if (userStudent[i].FirstNameStud == registration.firstName && userStudent[i].SecondNameStud == registration.secondName && userStudent[i].EndNameStud == registration.endName)
                    {
                        fname.Text = userStudent[i].FirstNameStud;
                        sname.Text = userStudent[i].SecondNameStud;
                        ename.Text = userStudent[i].EndNameStud;
                        userGroupe.Text = userStudent[i].GroupeStud;

                        userDiscipline.Text = allDiscipline.SelectedItem.ToString();
                        userMark.Text = userStudent[i].MarkStud;
                    }
                }
            }
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            StorageFile storageFileDiscipline = await storageFolder.CreateFileAsync("Discipline.xml", CreationCollisionOption.OpenIfExists);
            XmlSerializer xml = new XmlSerializer(typeof(List<string>));
            Stream writeAdmin = await storageFileDiscipline.OpenStreamForWriteAsync();
            try
            {
                allDiscipline.ItemsSource = (List<string>)xml.Deserialize(writeAdmin);
            }
            catch { }
            writeAdmin.Close();
            Load();
        }

        private async void InPut_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ImapClient ic = new ImapClient("imap.mail.ru", login.Text.ToString(), password.Password.ToString(), AuthMethods.Login, 993, true);

                StorageFolder folder = ApplicationData.Current.LocalFolder;
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Zapis));
                StorageFile file = await folder.CreateFileAsync("DataBaseMailPassword.xml", CreationCollisionOption.ReplaceExisting);
                Zapis zapis = new Zapis("mail.ru", login.Text.ToString(), password.Password.ToString());
                Stream write = await file.OpenStreamForWriteAsync();
                xmlSerializer.Serialize(write, zapis);
                write.Close();

                LoadMail();

                XXX.Visibility = Visibility.Collapsed;
                YYY.Visibility = Visibility.Visible;
            }
            catch { }
        }

        public AE.Net.Mail.Imap.Mailbox[] listMailboxes;
        public ImapClient ic;
        public AE.Net.Mail.MailMessage[] mm;

        private void Menu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ic.SelectMailbox(listMailboxes[Menu.SelectedIndex].Name);
            view.Items.Clear();
            mm = ic.GetMessages(0, ic.GetMessageCount(), false);

            foreach (AE.Net.Mail.MailMessage m in mm)
            {
                view.Items.Add(m.Subject);
            }
        }

        private void latter_SelectionChanged(object sender, RoutedEventArgs e)
        {
            latter.Text = "";
            if (view.SelectedIndex != -1)
            {
                latter.Text = mm[view.SelectedIndex].Body;
            }

        }
        public bool click = false;
        private void WriteLatter_Click(object sender, RoutedEventArgs e)
        {
            latter.Text = "";
            if (click == true)
            {
                GridLatterView.Visibility = Visibility.Visible;
                GridLatterWrite.Visibility = Visibility.Collapsed;
                click = false;
            }
            else
            {
                click = true;
                GridLatterWrite.Visibility = Visibility.Visible;
                GridLatterView.Visibility = Visibility.Collapsed;
            }
        }
        private void AddLatterToSend_Click(object sender, RoutedEventArgs e)
        {
            if (user.Text != "" && teg.Text != "" && LatterText.Text != "")
            {
                MailAddress from = new MailAddress(zapis.login);
                // кому отправляем
                MailAddress to = new MailAddress(user.Text);
                // создаем объект сообщения
                System.Net.Mail.MailMessage m = new System.Net.Mail.MailMessage(from, to);
                // тема письма
                m.Subject = teg.Text;
                // текст письма
                m.Body = LatterText.Text;
                // письмо представляет код html
                m.IsBodyHtml = true;
                // адрес smtp-сервера и порт, с которого будем отправлять письмо
                SmtpClient smtp = new SmtpClient("smtp." + zapis.mail, 587);
                // логин и пароль
                smtp.Credentials = new NetworkCredential(zapis.login, zapis.passwordText);
                smtp.EnableSsl = true;
                smtp.Send(m);

                user.Text = "";

                teg.Text = "";

                LatterText.Text = "";

                GridLatterWrite.Visibility = Visibility.Collapsed;
                GridLatterView.Visibility = Visibility.Visible;
            }
        }
        private async void LoadMail()
        {
            StorageFolder storageFolderr = ApplicationData.Current.LocalFolder;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Zapis));
            StorageFile storageFile = await storageFolderr.CreateFileAsync("DataBaseMailPassword.xml", CreationCollisionOption.OpenIfExists);
            Stream read = await storageFile.OpenStreamForReadAsync();
            try
            {
                zapis = (Zapis)xmlSerializer.Deserialize(read);
            }
            catch { }
            read.Close();

            ic = new ImapClient("imap." + zapis.mail, zapis.login, zapis.passwordText, AuthMethods.Login, 993, true);
            mm = ic.GetMessages(0, ic.GetMessageCount(), false);

            foreach (AE.Net.Mail.MailMessage m in mm)
            {
                view.Items.Add(m.Subject);
            }
            listMailboxes = ic.ListMailboxes(string.Empty, "*");
            for (int i = 0; i < listMailboxes.Length; i++)
            {
                Menu.Items.Add(listMailboxes[i].Name);
            }
        }
        public static bool visible = false;
        private void raspisanie_Click(object sender, RoutedEventArgs e)
        {
            if (visible)
            {
                view1.Visibility = Visibility.Visible;
                view2.Visibility = Visibility.Collapsed;
                visible = false;
            }
            else if (!visible)
            {
                view1.Visibility = Visibility.Collapsed;
                view2.Visibility = Visibility.Visible;
                visible = true;
            }
        }
        private void Load()
        {
            dataGridRaspisanie.Columns.Clear();
            connection = new SqlConnection(connectionString);
            dataGridRaspisanie.AutoGenerateColumns = false;
            dataGridRaspisanie.ItemsSource = null;
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter($"SELECT dbo.RaspisanieGroupe.Name_Day AS 'День недели', dbo.Raspisanie.FirstPara AS 'Первая пара', dbo.Raspisanie.SecondPara AS 'Вторая пара',"
                        + "dbo.Raspisanie.ThirdPara AS 'Третья пара', dbo.Raspisanie.FourthPara AS 'Четвертая пара', dbo.Raspisanie.FifthPara AS 'Пятая пара', dbo.Raspisanie.SixthPara AS 'Шестая пара',"
                       + "dbo.[Group].Name_Group AS 'Номер группы'"
                      + "FROM dbo.RaspisanieGroupe INNER JOIN dbo.Raspisanie ON dbo.RaspisanieGroupe.Num_Paspisanie = dbo.Raspisanie.Number_Raspisanie INNER JOIN dbo.Destinations ON dbo.RaspisanieGroupe.ID_Destination = dbo.Destinations.Number_Destinations INNER JOIN dbo.[Group] ON dbo.Destinations.ID_Groupe = dbo.[Group].Number_Group", connection);
                //dataAdapter = new SqlDataAdapter("Select * from AdminProg", connection);

                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);

                for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
                {
                    dataGridRaspisanie.Columns.Add(new DataGridTextColumn()
                    {
                        Header = ds.Tables[0].Columns[i].ColumnName,
                        Binding = new Binding { Path = new PropertyPath("[" + i.ToString() + "]") }
                    });
                }

                var collection = new ObservableCollection<object>();

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    collection.Add(row.ItemArray);
                }

                dataGridRaspisanie.ItemsSource = collection;
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }
        }
    }
}