using System;
using System.Collections.Generic;
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

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace TestSQLConnect
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        string connectServer = @"Server = DESKTOP-64DGCJU\LOEN_TRAVELER;Initial Catalog=TestConnect;Persist Security Info=True;User ID=sa;Password=S34g56F109";

        SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter dataAdapter;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void connectSQL_Click(object sender, RoutedEventArgs e)
        {
            connection = new SqlConnection(connectServer);
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT * FROM Specialization", connection);
                textConnect.Text = dataAdapter.ToString();
            }
            catch(Exception ex)
            {
                textConnect.Text = ex.Message;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
