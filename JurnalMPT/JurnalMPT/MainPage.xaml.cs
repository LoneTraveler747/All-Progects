using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Windows;
using Windows.UI.Popups;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace JurnalMPT
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
       // string connectionString = @"Server =DESKTOP-64DGCJU\LOEN_TRAVELER;Initial Catalog = P3_MPTJurnale; Persist Security Info=True;User ID = sa; Password=S34g56F109";
        public static string connectionString = @"Server=DESKTOP-64DGCJU\LOEN_TRAVELER;Initial Catalog=P3_MPTJurnale;User ID=sa;Password=S34g56F109";
        //string connectionString = "Server = DESKTOP-64DGCJU\\LOEN_TRAVELER;Database=P3_MPTJurnale;Trusted_Connection=True";
        //string connString = "Data Source=DESKTOP-64DGCJU\\LOEN_TRAVELER;Initial Catalog=P3_MPTJurnale;Integrated Security = false;User Id = sa;Password=S34g56F109";

        SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter dataAdapter;


        //string dataQuery = "SELECT dbo.[User].ID_User," +
        //    "dbo.[User].ID_Access_Level, dbo.[User].Surname AS Фамилия, " +
        //    "dbo.[User].Name AS Имя, dbo.[User].Patronymic AS " +
        //    "Отчество," +
        //    "dbo.[User].Login AS Логин, dbo.[User].Password" +
        //    "AS Пароль, dbo.Access_Level.Name AS Роль FROM dbo.[User] " +
        //    "INNER JOIN dbo.Access_Level ON dbo.[User].ID_Access_Level = dbo.Access_Level.ID_Access_Level";


        public MainPage()
        {
            this.InitializeComponent();
        }

        private void autorizationIn_Click(object sender, RoutedEventArgs e)
        {
            if (Login.Text != "" && LogPass.PlaceholderText != "")
            {

            }
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            ContentDialog subscribeDialog = new ContentDialog
            {
                Title = "Окно регистрации администратора",
                Content = "Вы попали на скрытое окно администратора. Здесь вы можете зарегистрировать администратора.",
                CloseButtonText = "Закрыть",
            };

            ContentDialogResult result = await subscribeDialog.ShowAsync();
        }


        private async void Split_Click(object sender, RoutedEventArgs e)
        {
            aut.Visibility = Visibility.Collapsed;
            RegistrAdminPanel.Visibility = Visibility.Visible;
            ContentDialog subscribeDialog = new ContentDialog
            {
                Title = "Окно регистрации администратора",
                Content = "Вы попали на скрытое окно администратора. Здесь вы можете зарегистрировать администратора.",
                CloseButtonText = "Закрыть",
            };
            ContentDialogResult result = await subscribeDialog.ShowAsync();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            aut.Visibility = Visibility.Visible;
            RegistrAdminPanel.Visibility = Visibility.Collapsed;
        }

        private void LogAuto_Click(object sender, RoutedEventArgs e)
        {
            string adminText = $"SELECT dbo.AdminProg.ID_AdminProg, dbo.AdminProg.Login_Text, dbo.AdminProg.Password_Text, dbo.Post.Name_Post, dbo.AdminProg.Post_ID FROM  dbo.AdminProg INNER JOIN dbo.Post ON dbo.AdminProg.Post_ID = dbo.Post.Number_Post where [Login_Text]= '{Login.Text}' and [Password_Text]= '{LogPass.Password}'";
            string studentText = $" SELECT        dbo.Destinations.ID_Groupe, dbo.Student.ID_Student, dbo.Student.Last_Name, dbo.Student.First_Name, dbo.Student.Surname, dbo.Student.Post_ID, dbo.Student.Destinations_ID, dbo.Student.Login_Text, dbo.Student.Password_Text, dbo.Student.Mail, dbo.Post.Number_Post FROM dbo.Destinations INNER JOIN dbo.Student ON dbo.Destinations.Number_Destinations = dbo.Student.Destinations_ID INNER JOIN dbo.Post ON dbo.Student.Post_ID = dbo.Post.Number_Post where [Login_Text]= '{Login.Text}' and [Password_Text]= '{LogPass.Password}'";

            if (Login.Text != "" && LogPass.Password != "")
            {
                if (aDMIN.IsChecked == true)
                {
                    connection = new SqlConnection(connectionString);
                    try
                    {
                        connection.Open();
                        dataAdapter = new SqlDataAdapter(adminText, connection);
                        Frame frame = new Frame();
                        Window.Current.Content = frame;
                        frame.Navigate(typeof(AdminPanelRegistrUser));
                        Window.Current.Activate();
                    }
                    catch
                    {

                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                else if (tEACHER.IsChecked == true)
                {
                    connection = new SqlConnection(connectionString);
                    try
                    {
                        connection.Open();
                        dataAdapter = new SqlDataAdapter(studentText, connection);
                        DataSet ds = new DataSet();
                        var from = new Teacher(ds.Tables[0].Rows[0].ItemArray);
                        dataAdapter.Fill(ds);

                        Frame frame = new Frame();
                        Window.Current.Content = frame;
                        frame.Navigate(typeof(AdminPanelRegistrUser));
                        Window.Current.Activate();
                    }
                    catch
                    {

                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                else if (sTUDENT.IsChecked == true)
                {
                    connection = new SqlConnection(connectionString);
                    try
                    {
                        connection.Open();
                        dataAdapter = new SqlDataAdapter();
                        DataSet ds = new DataSet();
                        var from = new Teacher(ds.Tables[0].Rows[0].ItemArray);
                        dataAdapter.Fill(ds);

                        Frame frame = new Frame();
                        Window.Current.Content = frame;
                        frame.Navigate(typeof(AdminPanelRegistrUser));
                        Window.Current.Activate();
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

        // Регистрация
        private void RegistrAdmin_Click(object sender, RoutedEventArgs e)
        {
            if (LoginAdmin.Text != "" && PasseordAdmin.Password != "" && PasseordAdminRepit.Password != "")
            {
                if (PasseordAdmin.Password == PasseordAdminRepit.Password)
                {
                    connection = new SqlConnection(connectionString);
                    try
                    {
                        connection.Open();

                        //Вывести значение
                        cmd = new SqlCommand($"INSERT INTO AdminProg (Login_Text, Post_ID, Password_Text) VALUES('{LoginAdmin.Text}', '{1}', '{PasseordAdmin.Password}')", connection);
                        cmd.ExecuteNonQuery();
                        Frame frame = new Frame();
                        Window.Current.Content = frame;
                        frame.Navigate(typeof(AdminPanelRegistrUser));
                        Window.Current.Activate();
                    }
                    catch(Exception ex)
                    {
                        Message(ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                else
                {
                    Message("Поля пароль и повтор пароля не совпадают.");                   
                }
            }
            else
            {
                Message("Вы не ввели данные поля! Пожалуйста, проверьте поля на отсутствие пустоты.");
            }
        }
        private async void Message(string ex)
        {
            aut.Visibility = Visibility.Collapsed;
            RegistrAdminPanel.Visibility = Visibility.Visible;
            ContentDialog subscribeDialog = new ContentDialog
            {
                Title = "Ошибка",
                Content = ex,
                CloseButtonText = "Закрыть",
            };
            ContentDialogResult result = await subscribeDialog.ShowAsync();
        }
    }
}