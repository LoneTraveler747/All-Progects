using Microsoft.Toolkit.Uwp.UI.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
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

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace Jurnale
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class AdminPage : Page
    {
        public static string connectionString = @"Server=DESKTOP-64DGCJU\LOEN_TRAVELER;Initial Catalog=P3_MPTJurnale;User ID=sa;Password=S34g56F109";
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter dataAdapter;
        public AdminPage()
        {
            this.InitializeComponent();
        }
        //__________________________________________________________________________________
        public List<string> disciplineList = new List<string>();
        private void Button_Click(object sender, RoutedEventArgs e) //Добавление дисциплин 
        {
            if (disciplineText.Text != "")
            {
                disciplineList.Add(disciplineText.Text);
                Dobavlenie();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) // Изменение дисц
        {
            if (discipline.SelectedIndex != -1 && disciplineText.Text != "")
            {
                disciplineList[discipline.SelectedIndex] = disciplineText.Text;
                Dobavlenie();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) //Удаление дисциплины
        {
            if (discipline.SelectedIndex != -1)
            {
                disciplineList.RemoveAt(discipline.SelectedIndex);
                Dobavlenie();
            }
        }
        public StorageFolder storageFolder = ApplicationData.Current.LocalFolder;
        public XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<string>));

        public XmlSerializer usersSerializer = new XmlSerializer(typeof(List<Registration>));
        public async void Dobavlenie()
        {
            discipline.Items.Clear();
            for (int i = 0; i < disciplineList.Count; i++)
            {
                discipline.Items.Add(disciplineList[i]);
            }
            StorageFile storageFileAdmin = await storageFolder.CreateFileAsync("Discipline.xml", CreationCollisionOption.ReplaceExisting);
            Stream writeAdmin = await storageFileAdmin.OpenStreamForWriteAsync();
            xmlSerializer.Serialize(writeAdmin, disciplineList);
            writeAdmin.Close();
        }
        //_________________________________________________________________
        public List<string> groupeList = new List<string>();
        private void addGroupe_Click(object sender, RoutedEventArgs e)
        {
            if (gRoupeText.Text != "")
            {
                groupeList.Add(gRoupeText.Text);
                GropeDob();

                connection = new SqlConnection(connectionString);
                try
                {
                    connection.Open();

                    //Вывести значение
                    cmd = new SqlCommand($"INSERT INTO dbo.[Group] (Name_Group) VALUES ('{gRoupeText.Text}')", connection);
                    cmd.ExecuteNonQuery();
                    Load();
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    connection.Close();
                }

            }
        }

        private void changeGroupe_Click(object sender, RoutedEventArgs e)
        {
            if (gRoupe.SelectedIndex != -1 && gRoupeText.Text != "")
            {
                groupeList[gRoupe.SelectedIndex] = gRoupeText.Text;
                GropeDob();
            }
        }

        private void DeleteGroupe_Click(object sender, RoutedEventArgs e)
        {
            if (gRoupe.SelectedIndex != -1)
            {
                groupeList.RemoveAt(gRoupe.SelectedIndex);
                GropeDob();
            }
        }
        public async void GropeDob()
        {
            gRoupe.Items.Clear();
            for (int i = 0; i < groupeList.Count; i++)
            {
                gRoupe.Items.Add(groupeList[i]);
            }
            StorageFile storageFileAdmin = await storageFolder.CreateFileAsync("Groupe.xml", CreationCollisionOption.ReplaceExisting);
            Stream writeAdmin = await storageFileAdmin.OpenStreamForWriteAsync();
            xmlSerializer.Serialize(writeAdmin, groupeList);
            writeAdmin.Close();
        }
        //_________________________________________________________________
        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            StorageFile storageFileDiscipline = await storageFolder.CreateFileAsync("Discipline.xml", CreationCollisionOption.OpenIfExists);
            Stream writeAdmin = await storageFileDiscipline.OpenStreamForWriteAsync();
            try
            {
                disciplineList = (List<string>)xmlSerializer.Deserialize(writeAdmin);
            }
            catch { }
            writeAdmin.Close();
            StorageFile storageFileGroupe = await storageFolder.CreateFileAsync("Groupe.xml", CreationCollisionOption.OpenIfExists);
            Stream writeStudent = await storageFileGroupe.OpenStreamForWriteAsync();
            try
            {
                groupeList = (List<string>)xmlSerializer.Deserialize(writeStudent);
            }
            catch { }
            writeStudent.Close();
            GropeDob();
            Dobavlenie();
            Users();
            Load();
            LoadTest();
            LoadRaspisanieOnNumber();
            LoadGroupe();
        }
        public List<Registration> DataBase = new List<Registration>();

        public List<Registration> ADMIN = new List<Registration>();
        public List<Registration> STUDENT = new List<Registration>();
        public List<Registration> TEACHER = new List<Registration>();

        public async void Users()
        {
            StorageFile storageFileAdmin = await storageFolder.CreateFileAsync("Admin.xml", CreationCollisionOption.OpenIfExists);
            Stream writeAdmin = await storageFileAdmin.OpenStreamForWriteAsync();
            try
            {
                ADMIN = (List<Registration>)usersSerializer.Deserialize(writeAdmin);

                for (int i = 0; i < ADMIN.Count; i++)
                {
                    DataBase.Add(ADMIN[i]);
                }
            }
            catch { }
            writeAdmin.Close();
            StorageFile storageFileStudent = await storageFolder.CreateFileAsync("Student.xml", CreationCollisionOption.OpenIfExists);
            Stream writeStudent = await storageFileStudent.OpenStreamForWriteAsync();
            try
            {
                STUDENT = (List<Registration>)usersSerializer.Deserialize(writeStudent);

                for (int i = 0; i < STUDENT.Count; i++)
                {
                    DataBase.Add(STUDENT[i]);
                }
            }
            catch { }
            writeStudent.Close();
            StorageFile storageFileTeacher = await storageFolder.CreateFileAsync("Teacher.xml", CreationCollisionOption.OpenIfExists);
            Stream writeTeacher = await storageFileTeacher.OpenStreamForWriteAsync();
            try
            {
                TEACHER = (List<Registration>)usersSerializer.Deserialize(writeTeacher);

                for (int i = 0; i < TEACHER.Count; i++)
                {
                    DataBase.Add(TEACHER[i]);
                }
            }
            catch { }
            writeTeacher.Close();
            dataGrid.ItemsSource = DataBase;
        }

        private void newUser_Click(object sender, RoutedEventArgs e)
        {
            Registration student = new Registration("", "", "", "", "", "", "");
            DataBase.Add(student);
            dataGrid.ItemsSource = new List<Registration>();
            dataGrid.ItemsSource = DataBase;
            SaveUsers();
        }

        private void deleteUser_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedIndex != -1)
            {
                DataBase.RemoveAt(dataGrid.SelectedIndex);
                dataGrid.ItemsSource = new List<Registration>();
                dataGrid.ItemsSource = DataBase;
                SaveUsers();
            }
        }

        XmlSerializer SaveXmlSerializer = new XmlSerializer(typeof(List<Registration>));

        public async void SaveUsers()
        {
            ADMIN = new List<Registration>();
            STUDENT = new List<Registration>();
            TEACHER = new List<Registration>();
            for (int i = 0; i < DataBase.Count; i++)
            {
                if (DataBase[i].who == "Студент" && (DataBase[i].firstName != "" || DataBase[i].secondName != "" || DataBase[i].login != "" || DataBase[i].password != "" || DataBase[i].groupe != ""))
                {
                    STUDENT.Add(DataBase[i]);
                }
            }
            for (int i = 0; i < DataBase.Count; i++)
            {
                if (DataBase[i].who == "Админ" && (DataBase[i].firstName != "" || DataBase[i].secondName != "" || DataBase[i].login != "" || DataBase[i].password != ""))
                {
                    ADMIN.Add(DataBase[i]);
                }
            }
            for (int i = 0; i < DataBase.Count; i++)
            {
                if (DataBase[i].who == "Преподаватель" && (DataBase[i].firstName != "" || DataBase[i].secondName != "" || DataBase[i].login != "" || DataBase[i].password != ""))
                {
                    TEACHER.Add(DataBase[i]);
                }
            }
            StorageFile storageFileAdmin = await storageFolder.CreateFileAsync("Admin.xml", CreationCollisionOption.ReplaceExisting);
            Stream writeAdmin = await storageFileAdmin.OpenStreamForWriteAsync();
            SaveXmlSerializer.Serialize(writeAdmin, ADMIN);
            writeAdmin.Close();

            StorageFile storageFileStudent = await storageFolder.CreateFileAsync("Student.xml", CreationCollisionOption.ReplaceExisting);
            Stream writeStudent = await storageFileStudent.OpenStreamForWriteAsync();
            SaveXmlSerializer.Serialize(writeStudent, STUDENT);
            writeStudent.Close();

            StorageFile storageFileTheacher = await storageFolder.CreateFileAsync("Teacher.xml", CreationCollisionOption.ReplaceExisting);
            Stream writeTeacher = await storageFileTheacher.OpenStreamForWriteAsync();
            SaveXmlSerializer.Serialize(writeTeacher, TEACHER);
            writeTeacher.Close();
        }

        private void SaveUsers_Click(object sender, RoutedEventArgs e)
        {
            SaveUsers();
        }

        private void dataGrid_CellEditEnded(object sender, Microsoft.Toolkit.Uwp.UI.Controls.DataGridCellEditEndedEventArgs e)
        {
            Registration cell = DataBase[dataGrid.SelectedIndex];
            if (e.Column.Header.ToString() == "who")
            {
                if (cell.who != "Админ" && cell.who != "Преподаватель" && cell.who != "Студент")
                {
                    cell.who = "Студент";
                }
            }
            if (e.Column.Header.ToString() == "groupe")
            {
                if (cell.who != "Студент")
                {
                    cell.groupe = "";
                }
                else
                {
                    bool groupe = false;
                    for (int i = 0; i < groupeList.Count; i++)
                    {
                        if (cell.groupe == groupeList[i])
                        {
                            groupe = true;
                            break;
                        }
                    }
                    if (groupe == false)
                    {
                        cell.groupe = "";
                    }
                }
            }
            if (e.Column.Header.ToString() == "password")
            {
                if (cell.password.Length != 32)
                {
                    string itogShifr = ShifrPassword(cell.password);

                    cell.password = itogShifr;
                }
            }
            if (e.Column.Header.ToString() == "login")
            {
                if (cell.who == "Студент")
                {
                    for (int i = 0; i < STUDENT.Count; i++)
                    {
                        if (cell.login == STUDENT[i].login)
                        {
                            cell.login = "";
                            break;
                        }
                    }
                }
                if (cell.who == "Админ")
                {
                    for (int i = 0; i < ADMIN.Count; i++)
                    {
                        if (i == dataGrid.SelectedIndex && i != ADMIN.Count - 1)
                        {
                            i++;
                        }

                        if (cell.login == ADMIN[i].login)
                        {
                            cell.login = "";
                            break;
                        }
                    }
                }
                if (cell.who == "Преподаватель")
                {
                    for (int i = 0; i < TEACHER.Count; i++)
                    {
                        if (cell.login == TEACHER[i].login)
                        {
                            cell.login = "";
                            break;
                        }
                    }
                }
            }
            DataBase[dataGrid.SelectedIndex] = cell;
        }

        public string ShifrPassword(string input)
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

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
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

        private void LoadRaspisanieOnNumber()
        {
            connection = new SqlConnection(connectionString);
            raspisanie.AutoGenerateColumns = false;
            raspisanie.ItemsSource = null;
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter($"SELECT FirstPara as 'Первая пара', SecondPara as 'Вторая пара', ThirdPara as 'Третья пара', FourthPara as 'Четвертая пара', FifthPara as 'Пятая пара', SixthPara as 'Шестая пара' From Raspisanie", connection);
                //dataAdapter = new SqlDataAdapter("Select * from AdminProg", connection);

                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);

                for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
                {
                    raspisanie.Columns.Add(new DataGridTextColumn()
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

                raspisanie.ItemsSource = collection;
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }
        }

        private void LoadTest()
        {
            connection = new SqlConnection(connectionString);
            try
            {

                SqlDataAdapter adapter = new SqlDataAdapter("select * from Raspisanie", connection);
                DataTable allfaculty = new DataTable();

                adapter.Fill(allfaculty);

                for (int i = 0; i < allfaculty.Rows.Count; i++)
                {
                    phonesList.Items.Add(allfaculty.Rows[i]["Number_Raspisanie"].ToString());
                }

            }
            catch (Exception)
            {
                //Do Something
            }
            finally
            {
                connection.Close();
            }
            //phonesList
        }
        public static bool visible = false;
        private void openRasp_Click(object sender, RoutedEventArgs e)
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

        public void LoadGroupe()
        {
            connection = new SqlConnection(connectionString);
            try
            {

                SqlDataAdapter adapter = new SqlDataAdapter("select * from Destinations", connection);
                DataTable allfaculty = new DataTable();

                adapter.Fill(allfaculty);

                for (int i = 0; i < allfaculty.Rows.Count; i++)
                {
                    groupeListData.Items.Add(allfaculty.Rows[i]["Number_Destinations"].ToString());
                }

            }
            catch (Exception)
            {
                //Do Something
            }
            finally
            {
                connection.Close();
            }
        }

        private void accessBut_Click(object sender, RoutedEventArgs e)
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();

                //Вывести значение
                cmd = new SqlCommand($"INSERT INTO RaspisanieGroupe (ID_Destination, Name_Day, Num_Paspisanie) VALUES('{groupeListData.SelectedItem}', '{dayWeeck.Text}', '{phonesList.SelectedItem}')", connection);
                cmd.ExecuteNonQuery();
                Load();
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                connection.Close();
            }
        }
    }//dataGridRaspisanie
}