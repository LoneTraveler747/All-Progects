using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace Audioplayer
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public bool play = true;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void stop_Click(object sender, RoutedEventArgs e)
        {
            media.Stop();
        }

        private void pouse_Click(object sender, RoutedEventArgs e)
        {
            if (play == true)
            {
                media.Play();
                play = false;
            }
            else
            {
                media.Pause();
                play = true;
            }
        }

        private void volue_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            media.Volume = volue.Value / 100;
        }

        public IReadOnlyList<StorageFile> folder;

        private async void open_Click(object sender, RoutedEventArgs e)
        {
            FolderPicker folderPicker = new FolderPicker();
            folderPicker.ViewMode = PickerViewMode.Thumbnail;
            folderPicker.SuggestedStartLocation = PickerLocationId.MusicLibrary;
            folderPicker.FileTypeFilter.Add("*");
            var storageFolder = await folderPicker.PickSingleFolderAsync();

            if (storageFolder != null)
            {
                folder = await storageFolder.GetFilesAsync();

                list.Items.Clear();

                for (int i = 0; i < folder.Count; i++)
                {
                    list.Items.Add(folder[i].Name);
                }
            }
        }

        private async void list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            StorageFile storageFile = folder[list.SelectedIndex];
            var stream = await storageFile.OpenReadAsync();
            media.SetSource(stream, " ");
        }

        private async void CreatePlayList_Click(object sender, RoutedEventArgs e)
        {
            if (namePlaylist.Text != "")
            {
                StorageFolder storageFolder = ApplicationData.Current.LocalFolder;
                StorageFolder storage = await storageFolder.CreateFolderAsync(namePlaylist.Text, CreationCollisionOption.OpenIfExists);
            }
        }

        private async void AddPlayList_Click(object sender, RoutedEventArgs e)
        {
            StorageFolder storage = ApplicationData.Current.LocalFolder;
            var storageFolder = await storage.GetFoldersAsync();

            if (namePlaylist.Text != "" && list.SelectedIndex != -1)
            {
                for (int i = 0; i < storageFolder.Count; i++)
                {
                    if (storageFolder[i].Name == namePlaylist.Text)
                    {
                        await folder[list.SelectedIndex].CopyAsync(storageFolder[i]);
                        break;
                    }
                }
            }
        }

        private async void viewfile_Click(object sender, RoutedEventArgs e)
        {
            StorageFolder storage = ApplicationData.Current.LocalFolder;
            var storageFolder = await storage.GetFoldersAsync();

            if (namePlaylist.Text != "")
            {
                for (int i = 0; i < storageFolder.Count; i++)
                {
                    if (storageFolder[i].Name == namePlaylist.Text)
                    {
                        folder = await storageFolder[i].GetFilesAsync();

                        list.Items.Clear();

                        for (int t = 0; t < folder.Count; t++)
                        {
                            list.Items.Add(folder[t].Name);
                        }
                        break;
                    }
                }
            }
        }
    }
}
