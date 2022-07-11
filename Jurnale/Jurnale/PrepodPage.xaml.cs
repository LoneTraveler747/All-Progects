using AE.Net.Mail;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Windows.UI.Notifications;
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
    [Serializable]
    public class JurnaleStudent
    {
        public string FirstNameStud { get; set; }
        public string SecondNameStud { get; set; }
        public string EndNameStud { get; set; }
        public string GroupeStud { get; set; }
        public string MarkStud { get; set; }
        public JurnaleStudent(string FirstNameStud, string SecondNameStud, string EndNameStud, string GroupeStud, string MarkStud)
        {
            this.FirstNameStud = FirstNameStud;
            this.SecondNameStud = SecondNameStud;
            this.EndNameStud = EndNameStud;
            this.GroupeStud = GroupeStud;
            this.MarkStud = MarkStud;
        }
        public JurnaleStudent()
        {

        }
    }
    public sealed partial class PrepodPage : Page
    {
        public Zapis zapis = new Zapis();

        public static string connectionString = @"Server=DESKTOP-64DGCJU\LOEN_TRAVELER;Initial Catalog=P3_MPTJurnale;User ID=sa;Password=S34g56F109";
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter dataAdapter;
        public PrepodPage()
        {
            this.InitializeComponent();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }

        public List<string> disciplineList = new List<string>();
        public List<string> groupeList = new List<string>();

        //Для нвого класса
        public List<Registration> student = new List<Registration>();
        public List<JurnaleStudent> jurnaleStudents = new List<JurnaleStudent>();

        public StorageFolder storageFolder = ApplicationData.Current.LocalFolder;
        public XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<string>));

        public XmlSerializer xmlSerializerStudent = new XmlSerializer(typeof(List<Registration>));
        public XmlSerializer xmlSerializerStudentWhithMark = new XmlSerializer(typeof(List<JurnaleStudent>));
        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            StorageFile storageFileDiscipline = await storageFolder.CreateFileAsync("Discipline.xml", CreationCollisionOption.OpenIfExists);
            Stream writeAdmin = await storageFileDiscipline.OpenStreamForWriteAsync();
            try
            {
                disciplineList = (List<string>)xmlSerializer.Deserialize(writeAdmin);
                Distciplins.ItemsSource = disciplineList;
            }
            catch { }
            writeAdmin.Close();

            StorageFile storageFileGroupe = await storageFolder.CreateFileAsync("Groupe.xml", CreationCollisionOption.OpenIfExists);
            Stream writeStudent = await storageFileGroupe.OpenStreamForWriteAsync();
            try
            {
                groupeList = (List<string>)xmlSerializer.Deserialize(writeStudent);
                GroupesAll.ItemsSource = groupeList;
            }
            catch { }
            writeStudent.Close();

            StorageFile storageFileStudent = await storageFolder.CreateFileAsync("Student.xml", CreationCollisionOption.OpenIfExists);
            Stream streamStudent = await storageFileStudent.OpenStreamForWriteAsync();
            try
            {
                student = (List<Registration>)xmlSerializerStudent.Deserialize(streamStudent);
                for (int i = 0; i < student.Count; i++)
                {
                    JurnaleStudent jurnale = new JurnaleStudent(student[i].firstName, student[i].secondName, student[i].endName, student[i].groupe, "");
                    jurnaleStudents.Add(jurnale);
                }

                dataGrid.ItemsSource = jurnaleStudents;
            }
            catch { }

        }

        public AE.Net.Mail.Imap.Mailbox[] listMailboxes;
        public ImapClient ic;
        public AE.Net.Mail.MailMessage[] mm;

        private void GroupesAll_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            dataGrid.ItemsSource = new ObservableCollection<JurnaleStudent>(from jr in jurnaleStudents where jr.GroupeStud == GroupesAll.SelectedItem.ToString() select jr);
        }
        //public bool ayf = true;
        private void SaveAll_Click(object sender, RoutedEventArgs e)
        {
            Saveusers();
        }

        public async void Saveusers()
        {
            if (Distciplins.SelectedIndex != -1 && dataPicker.Date.Year >= 2015)
            {
                StorageFile storageFileAdmin = await storageFolder.CreateFileAsync(Distciplins.SelectedItem.ToString() + " " + dataPicker.Date.ToString("dd-MM-yyyy") + ".xml", CreationCollisionOption.ReplaceExisting);
                Stream writeAdmin = await storageFileAdmin.OpenStreamForWriteAsync();
                xmlSerializerStudentWhithMark.Serialize(writeAdmin, jurnaleStudents);
                writeAdmin.Close();
            }
        }

        private void dataGrid_CellEditEnded(object sender, Microsoft.Toolkit.Uwp.UI.Controls.DataGridCellEditEndedEventArgs e)
        {
            JurnaleStudent cell = jurnaleStudents[dataGrid.SelectedIndex];
            if (e.Column.Header.ToString() == "MarkStud")
            {
                if (cell.MarkStud != "2" || cell.MarkStud != "3" || cell.MarkStud != "4" || cell.MarkStud != "5" || cell.MarkStud != "нб" || cell.MarkStud != "НБ")
                {
                    cell.MarkStud = "";
                }
            }
        }

        private async void Distciplins_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Иван-> O --(шиканов человек не очень человек)
            //      <|\
            //      / \
            StorageFile storageFileStudent = await storageFolder.CreateFileAsync(Distciplins.SelectedItem.ToString() + " " + dataPicker.Date.ToString("dd-MM-yyyy") + ".xml", CreationCollisionOption.OpenIfExists);
            Stream writeSrudent = await storageFileStudent.OpenStreamForWriteAsync();
            try
            {
                jurnaleStudents = (List<JurnaleStudent>)xmlSerializerStudentWhithMark.Deserialize(writeSrudent);
                dataGrid.ItemsSource = jurnaleStudents;
            }
            catch
            {
                dataGrid.ItemsSource = jurnaleStudents;
                for (int i = 0; i < jurnaleStudents.Count; i++)
                {
                    jurnaleStudents[i].MarkStud = "";
                }
            }
            writeSrudent.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void CreateExcelFile_Click(object sender, RoutedEventArgs e)
        {
            if (Distciplins.SelectedIndex != -1 && dataPicker.Date.Year >= 2015)
            {
                ToastNotifier toastNote = ToastNotificationManager.CreateToastNotifier();
                Windows.Data.Xml.Dom.XmlDocument xml = ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastText02);
                Windows.Data.Xml.Dom.XmlNodeList nodes = xml.GetElementsByTagName("text");
                nodes.Item(0).AppendChild(xml.CreateTextNode("Журнал"));
                try
                {
                    using (ExcelPackage excelPackage = new ExcelPackage())
                    {

                        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Журнал");

                        worksheet.Cells[1, 1].Value = "Имя";
                        worksheet.Cells[1, 2].Value = "Фамилия";
                        worksheet.Cells[1, 3].Value = "Отчество";
                        worksheet.Cells[1, 4].Value = "Группа";
                        worksheet.Cells[1, 5].Value = "Оценка";
                        for (int i = 2; i < jurnaleStudents.Count + 2; i++)
                        {
                            worksheet.Cells[i, 1].Value = jurnaleStudents[i - 2].FirstNameStud;
                            worksheet.Cells[i, 2].Value = jurnaleStudents[i - 2].SecondNameStud;
                            worksheet.Cells[i, 3].Value = jurnaleStudents[i - 2].EndNameStud;
                            worksheet.Cells[i, 4].Value = jurnaleStudents[i - 2].GroupeStud;
                            worksheet.Cells[i, 5].Value = jurnaleStudents[i - 2].MarkStud;
                        }

                        FileInfo fi = new FileInfo(ApplicationData.Current.LocalFolder.Path + @"\" + Distciplins.SelectedItem.ToString() + " " + dataPicker.Date.ToString("dd-MM-yyyy") + ".xlsx");
                        excelPackage.SaveAs(fi);
                        nodes.Item(1).AppendChild(xml.CreateTextNode("Excel файл успешно сохранен!"));
                    }

                }
                catch
                {
                    nodes.Item(1).AppendChild(xml.CreateTextNode("Ошибка в создании Excel файла"));
                }
            }
        }
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
            catch
            {
               
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
    }
}