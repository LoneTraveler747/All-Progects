using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace NeVB
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public int count_x = 0;
        public int count_o = 0;
        public MainPage()
        {
            this.InitializeComponent();
            X.Text = "Счет Х: 0";
            O.Text = "Счет O: 0";
            Schet.Text = "Игра до 10-тиочков (победа)!";
        }
        public bool XO;

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            Clear.IsEnabled = true;

            Start.IsEnabled = false;

            B1.IsEnabled = true;
            B2.IsEnabled = true;
            B3.IsEnabled = true;

            B4.IsEnabled = true;
            B5.IsEnabled = true;
            B6.IsEnabled = true;

            B7.IsEnabled = true;
            B8.IsEnabled = true;
            B9.IsEnabled = true;

            B1.Content = "";
            B2.Content = "";
            B3.Content = "";

            B4.Content = "";
            B5.Content = "";
            B6.Content = "";

            B7.Content = "";
            B8.Content = "";
            B9.Content = "";

            XO = true;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            B1.IsEnabled = false;
            B2.IsEnabled = false;
            B3.IsEnabled = false;

            B4.IsEnabled = false;
            B5.IsEnabled = false;
            B6.IsEnabled = false;

            B7.IsEnabled = false;
            B8.IsEnabled = false;
            B9.IsEnabled = false;

            Clear.IsEnabled = false;

        }

        private async void B1_Click(object sender, RoutedEventArgs e)
        {
            Button button = (sender as Button);
            button.IsEnabled = false;
            if (XO)
            {
                button.Content = "X";
            }
            else
            {
                button.Content = "O";
            }
            XO = !XO;
            if((B1.Content.ToString() == "X") && (B2.Content.ToString() == "X") && (B3.Content.ToString() == "X"))
            {
                B1.IsEnabled = true;
                B2.IsEnabled = true;
                B3.IsEnabled = true;

                B4.IsEnabled = true;
                B5.IsEnabled = true;
                B6.IsEnabled = true;

                B7.IsEnabled = true;
                B8.IsEnabled = true;
                B9.IsEnabled = true;

                B1.Content = "";
                B2.Content = "";
                B3.Content = "";

                B4.Content = "";
                B5.Content = "";
                B6.Content = "";

                B7.Content = "";
                B8.Content = "";
                B9.Content = "";

                XO = true;

                count_x++;
                X.Text = "Счет Х:" + " " + count_x;

                MessageDialog dialog = new MessageDialog("Конец игры");
                dialog.Title = "Победили крестики";
                await dialog.ShowAsync();
            }
            else if((B4.Content.ToString() == "X") && (B5.Content.ToString() == "X") && (B6.Content.ToString() == "X"))
            {
                B1.IsEnabled = true;
                B2.IsEnabled = true;
                B3.IsEnabled = true;

                B4.IsEnabled = true;
                B5.IsEnabled = true;
                B6.IsEnabled = true;

                B7.IsEnabled = true;
                B8.IsEnabled = true;
                B9.IsEnabled = true;

                B1.Content = "";
                B2.Content = "";
                B3.Content = "";

                B4.Content = "";
                B5.Content = "";
                B6.Content = "";

                B7.Content = "";
                B8.Content = "";
                B9.Content = "";

                XO = true;

                count_x += 10;
                X.Text = "Счет Х:" + " " + count_x;

                MessageDialog dialog = new MessageDialog("Конец игры");
                dialog.Title = "Победили крестики";
                await dialog.ShowAsync();
            }
            else if((B7.Content.ToString() == "X") && (B8.Content.ToString() == "X") && (B9.Content.ToString() == "X"))
            {
                B1.IsEnabled = true;
                B2.IsEnabled = true;
                B3.IsEnabled = true;

                B4.IsEnabled = true;
                B5.IsEnabled = true;
                B6.IsEnabled = true;

                B7.IsEnabled = true;
                B8.IsEnabled = true;
                B9.IsEnabled = true;

                B1.Content = "";
                B2.Content = "";
                B3.Content = "";

                B4.Content = "";
                B5.Content = "";
                B6.Content = "";

                B7.Content = "";
                B8.Content = "";
                B9.Content = "";

                XO = true;

                count_x++;
                X.Text = "Счет Х:" + " " + count_x;

                MessageDialog dialog = new MessageDialog("Конец игры");
                dialog.Title = "Победили крестики";
                await dialog.ShowAsync();
            }
            if ((B1.Content.ToString() == "X") && (B4.Content.ToString() == "X") && (B7.Content.ToString() == "X"))
            {
                B1.IsEnabled = true;
                B2.IsEnabled = true;
                B3.IsEnabled = true;

                B4.IsEnabled = true;
                B5.IsEnabled = true;
                B6.IsEnabled = true;

                B7.IsEnabled = true;
                B8.IsEnabled = true;
                B9.IsEnabled = true;

                B1.Content = "";
                B2.Content = "";
                B3.Content = "";

                B4.Content = "";
                B5.Content = "";
                B6.Content = "";

                B7.Content = "";
                B8.Content = "";
                B9.Content = "";

                XO = true;

                count_x++;
                X.Text = "Счет Х:" + " " + count_x;

                MessageDialog dialog = new MessageDialog("Конец игры");
                dialog.Title = "Победили крестики";
                await dialog.ShowAsync();
            }
            else if ((B2.Content.ToString() == "X") && (B5.Content.ToString() == "X") && (B8.Content.ToString() == "X"))
            {
                B1.IsEnabled = true;
                B2.IsEnabled = true;
                B3.IsEnabled = true;

                B4.IsEnabled = true;
                B5.IsEnabled = true;
                B6.IsEnabled = true;

                B7.IsEnabled = true;
                B8.IsEnabled = true;
                B9.IsEnabled = true;

                B1.Content = "";
                B2.Content = "";
                B3.Content = "";

                B4.Content = "";
                B5.Content = "";
                B6.Content = "";

                B7.Content = "";
                B8.Content = "";
                B9.Content = "";

                XO = true;

                count_x++;
                X.Text = "Счет Х:" + " " + count_x;

                MessageDialog dialog = new MessageDialog("Конец игры");
                dialog.Title = "Победили крестики";
                await dialog.ShowAsync();
            }
            else if ((B3.Content.ToString() == "X") && (B6.Content.ToString() == "X") && (B9.Content.ToString() == "X"))
            {
                B1.IsEnabled = true;
                B2.IsEnabled = true;
                B3.IsEnabled = true;

                B4.IsEnabled = true;
                B5.IsEnabled = true;
                B6.IsEnabled = true;

                B7.IsEnabled = true;
                B8.IsEnabled = true;
                B9.IsEnabled = true;

                B1.Content = "";
                B2.Content = "";
                B3.Content = "";

                B4.Content = "";
                B5.Content = "";
                B6.Content = "";

                B7.Content = "";
                B8.Content = "";
                B9.Content = "";

                XO = true;

                count_x++;
                X.Text = "Счет Х:" + " " + count_x;

                MessageDialog dialog = new MessageDialog("Конец игры");
                dialog.Title = "Победили крестики";
                await dialog.ShowAsync();
            }
            else if ((B1.Content.ToString() == "X") && (B5.Content.ToString() == "X") && (B9.Content.ToString() == "X"))
            {
                B1.IsEnabled = true;
                B2.IsEnabled = true;
                B3.IsEnabled = true;

                B4.IsEnabled = true;
                B5.IsEnabled = true;
                B6.IsEnabled = true;

                B7.IsEnabled = true;
                B8.IsEnabled = true;
                B9.IsEnabled = true;

                B1.Content = "";
                B2.Content = "";
                B3.Content = "";

                B4.Content = "";
                B5.Content = "";
                B6.Content = "";

                B7.Content = "";
                B8.Content = "";
                B9.Content = "";

                XO = true;

                count_x++;
                X.Text = "Счет Х:" + " " + count_x;

                MessageDialog dialog = new MessageDialog("Конец игры");
                dialog.Title = "Победили крестики";
                await dialog.ShowAsync();
            }
            else if ((B3.Content.ToString() == "X") && (B5.Content.ToString() == "X") && (B7.Content.ToString() == "X"))
            {
                B1.IsEnabled = true;
                B2.IsEnabled = true;
                B3.IsEnabled = true;

                B4.IsEnabled = true;
                B5.IsEnabled = true;
                B6.IsEnabled = true;

                B7.IsEnabled = true;
                B8.IsEnabled = true;
                B9.IsEnabled = true;

                B1.Content = "";
                B2.Content = "";
                B3.Content = "";

                B4.Content = "";
                B5.Content = "";
                B6.Content = "";

                B7.Content = "";
                B8.Content = "";
                B9.Content = "";

                XO = true;

                count_x++;
                X.Text = "Счет Х:" + " " + count_x;

                MessageDialog dialog = new MessageDialog("Конец игры");
                dialog.Title = "Победили крестики";
                await dialog.ShowAsync();
            }
            else if ((B1.Content.ToString() == "O") && (B2.Content.ToString() == "O") && (B3.Content.ToString() == "O"))
            {
                B1.IsEnabled = true;
                B2.IsEnabled = true;
                B3.IsEnabled = true;

                B4.IsEnabled = true;
                B5.IsEnabled = true;
                B6.IsEnabled = true;

                B7.IsEnabled = true;
                B8.IsEnabled = true;
                B9.IsEnabled = true;

                B1.Content = "";
                B2.Content = "";
                B3.Content = "";

                B4.Content = "";
                B5.Content = "";
                B6.Content = "";

                B7.Content = "";
                B8.Content = "";
                B9.Content = "";

                XO = true;

                count_o++;
                O.Text = "Счет O:" + " " + count_o;

                MessageDialog dialog = new MessageDialog("Конец игры");
                dialog.Title = "Победили нолики";
                await dialog.ShowAsync();
            }
            else if ((B4.Content.ToString() == "O") && (B5.Content.ToString() == "O") && (B6.Content.ToString() == "O"))
            {
                B1.IsEnabled = true;
                B2.IsEnabled = true;
                B3.IsEnabled = true;

                B4.IsEnabled = true;
                B5.IsEnabled = true;
                B6.IsEnabled = true;

                B7.IsEnabled = true;
                B8.IsEnabled = true;
                B9.IsEnabled = true;

                B1.Content = "";
                B2.Content = "";
                B3.Content = "";

                B4.Content = "";
                B5.Content = "";
                B6.Content = "";

                B7.Content = "";
                B8.Content = "";
                B9.Content = "";

                XO = true;

                count_o++;
                O.Text = "Счет O:" + " " + count_o;

                MessageDialog dialog = new MessageDialog("Конец игры");
                dialog.Title = "Победили нолики";
                await dialog.ShowAsync();
            }
            else if ((B7.Content.ToString() == "O") && (B8.Content.ToString() == "O") && (B9.Content.ToString() == "O"))
            {
                B1.IsEnabled = true;
                B2.IsEnabled = true;
                B3.IsEnabled = true;

                B4.IsEnabled = true;
                B5.IsEnabled = true;
                B6.IsEnabled = true;

                B7.IsEnabled = true;
                B8.IsEnabled = true;
                B9.IsEnabled = true;

                B1.Content = "";
                B2.Content = "";
                B3.Content = "";

                B4.Content = "";
                B5.Content = "";
                B6.Content = "";

                B7.Content = "";
                B8.Content = "";
                B9.Content = "";

                XO = true;

                count_o++;
                O.Text = "Счет O:" + " " + count_o;

                MessageDialog dialog = new MessageDialog("Конец игры");
                dialog.Title = "Победили нолики";
                await dialog.ShowAsync();
            }
            else if ((B2.Content.ToString() == "O") && (B5.Content.ToString() == "O") && (B8.Content.ToString() == "O"))
            {
                B1.IsEnabled = true;
                B2.IsEnabled = true;
                B3.IsEnabled = true;

                B4.IsEnabled = true;
                B5.IsEnabled = true;
                B6.IsEnabled = true;

                B7.IsEnabled = true;
                B8.IsEnabled = true;
                B9.IsEnabled = true;

                B1.Content = "";
                B2.Content = "";
                B3.Content = "";

                B4.Content = "";
                B5.Content = "";
                B6.Content = "";

                B7.Content = "";
                B8.Content = "";
                B9.Content = "";

                XO = true;

                count_o++;
                O.Text = "Счет O:" + " " + count_o;

                MessageDialog dialog = new MessageDialog("Конец игры");
                dialog.Title = "Победили нолики";
                await dialog.ShowAsync();
            }
            else if ((B1.Content.ToString() == "O") && (B4.Content.ToString() == "O") && (B7.Content.ToString() == "O"))
            {
                B1.IsEnabled = true;
                B2.IsEnabled = true;
                B3.IsEnabled = true;

                B4.IsEnabled = true;
                B5.IsEnabled = true;
                B6.IsEnabled = true;

                B7.IsEnabled = true;
                B8.IsEnabled = true;
                B9.IsEnabled = true;

                B1.Content = "";
                B2.Content = "";
                B3.Content = "";

                B4.Content = "";
                B5.Content = "";
                B6.Content = "";

                B7.Content = "";
                B8.Content = "";
                B9.Content = "";

                XO = true;

                count_o++;
                O.Text = "Счет O:" + " " + count_o;

                MessageDialog dialog = new MessageDialog("Конец игры");
                dialog.Title = "Победили нолики";
                await dialog.ShowAsync();
            }
            else if ((B3.Content.ToString() == "O") && (B6.Content.ToString() == "O") && (B9.Content.ToString() == "O"))
            {
                B1.IsEnabled = true;
                B2.IsEnabled = true;
                B3.IsEnabled = true;

                B4.IsEnabled = true;
                B5.IsEnabled = true;
                B6.IsEnabled = true;

                B7.IsEnabled = true;
                B8.IsEnabled = true;
                B9.IsEnabled = true;

                B1.Content = "";
                B2.Content = "";
                B3.Content = "";

                B4.Content = "";
                B5.Content = "";
                B6.Content = "";

                B7.Content = "";
                B8.Content = "";
                B9.Content = "";

                XO = true;

                count_o++;
                O.Text = "Счет O:" + " " + count_o;

                MessageDialog dialog = new MessageDialog("Конец игры");
                dialog.Title = "Победили нолики";
                await dialog.ShowAsync();
            }
            else if ((B1.Content.ToString() == "O") && (B5.Content.ToString() == "O") && (B9.Content.ToString() == "O"))
            {
                B1.IsEnabled = true;
                B2.IsEnabled = true;
                B3.IsEnabled = true;

                B4.IsEnabled = true;
                B5.IsEnabled = true;
                B6.IsEnabled = true;

                B7.IsEnabled = true;
                B8.IsEnabled = true;
                B9.IsEnabled = true;

                B1.Content = "";
                B2.Content = "";
                B3.Content = "";

                B4.Content = "";
                B5.Content = "";
                B6.Content = "";

                B7.Content = "";
                B8.Content = "";
                B9.Content = "";

                XO = true;

                count_o++;
                O.Text = "Счет O:" + " " + count_o;

                MessageDialog dialog = new MessageDialog("Конец игры");
                dialog.Title = "Победили нолики";
                await dialog.ShowAsync();
            }
            else if ((B3.Content.ToString() == "O") && (B5.Content.ToString() == "O") && (B7.Content.ToString() == "O"))
            {
                B1.IsEnabled = true;
                B2.IsEnabled = true;
                B3.IsEnabled = true;

                B4.IsEnabled = true;
                B5.IsEnabled = true;
                B6.IsEnabled = true;

                B7.IsEnabled = true;
                B8.IsEnabled = true;
                B9.IsEnabled = true;

                B1.Content = "";
                B2.Content = "";
                B3.Content = "";

                B4.Content = "";
                B5.Content = "";
                B6.Content = "";

                B7.Content = "";
                B8.Content = "";
                B9.Content = "";

                XO = true;

                count_o++;
                O.Text = "Счет O:" + " " + count_o;

                MessageDialog dialog = new MessageDialog("Конец игры");
                dialog.Title = "Победили нолики";
                await dialog.ShowAsync();
            }

            else if (B1.Content != "" && B2.Content != "" && B3.Content != "" && B4.Content != "" && B5.Content != "" && B6.Content != "" && B7.Content != "" && B8.Content != "" && B9.Content != "")
            {
                B1.IsEnabled = true;
                B2.IsEnabled = true;
                B3.IsEnabled = true;

                B4.IsEnabled = true;
                B5.IsEnabled = true;
                B6.IsEnabled = true;

                B7.IsEnabled = true;
                B8.IsEnabled = true;
                B9.IsEnabled = true;

                B1.Content = "";
                B2.Content = "";
                B3.Content = "";

                B4.Content = "";
                B5.Content = "";
                B6.Content = "";

                B7.Content = "";
                B8.Content = "";
                B9.Content = "";

                XO = true;

                MessageDialog dialog = new MessageDialog("Конец игры");
                dialog.Title = "Ничья";
                await dialog.ShowAsync();
            }

            won();

        }
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            B1.IsEnabled = true;
            B2.IsEnabled = true;
            B3.IsEnabled = true;

            B4.IsEnabled = true;
            B5.IsEnabled = true;
            B6.IsEnabled = true;

            B7.IsEnabled = true;
            B8.IsEnabled = true;
            B9.IsEnabled = true;

            B1.Content = "";
            B2.Content = "";
            B3.Content = "";

            B4.Content = "";
            B5.Content = "";
            B6.Content = "";

            B7.Content = "";
            B8.Content = "";
            B9.Content = "";

            XO = true;

        }

        async void won()
        {
            if(count_o == 10)
            {
                count_o = 0;
                count_x = 0;
                MessageDialog dialog = new MessageDialog("Конец игры!");
                dialog.Title = "Победили нолики набрав 10 очков";
                await dialog.ShowAsync();
                O.Text = "Счет О: " + count_o;
            }
            else if(count_x == 10)
            {
                count_x = 0;
                count_o = 0;
                MessageDialog dialog = new MessageDialog("Конец игры!");
                dialog.Title = "Победили кретсики набрав 10 очков";
                await dialog.ShowAsync();
                X.Text = "Счет Х: " + count_x;
            }
        }

    }
}
