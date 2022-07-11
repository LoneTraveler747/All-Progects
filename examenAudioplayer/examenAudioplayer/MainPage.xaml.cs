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

namespace examenAudioplayer
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        public IReadOnlyList<StorageFile> folder;

        private async void files_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            StorageFile storageFile = folder[files.SelectedIndex];
            var stream = await storageFile.OpenReadAsync();
            media.SetSource(stream, " ");
        }

        public bool play = true;
        
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

        private async void fileOpen_Click(object sender, RoutedEventArgs e)
        {
            FolderPicker folderPicker = new FolderPicker();
            folderPicker.ViewMode = PickerViewMode.Thumbnail;
            folderPicker.SuggestedStartLocation = PickerLocationId.MusicLibrary;
            folderPicker.FileTypeFilter.Add(".mp3");
            var storageFolder = await folderPicker.PickSingleFolderAsync();

            if (storageFolder != null)
            {
                folder = await storageFolder.GetFilesAsync();

                files.Items.Clear();

                for (int i = 0; i < folder.Count; i++)
                {
                    files.Items.Add(folder[i].Name);
                }
            }
        }
    }
}
