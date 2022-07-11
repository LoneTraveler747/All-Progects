
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Printing;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.Storage.Provider;
using Windows.Storage.Streams;
using Windows.UI.Popups;
using Windows.UI.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Printing;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace TextRedaktor
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {

            this.InitializeComponent();
            string[] fontsNames = Microsoft.Graphics.Canvas.Text.CanvasTextFormat.GetSystemFontFamilies();
            for (int i = 0; i < fontsNames.Length; i++)
            {
                Font.Items.Add(fontsNames[i]);
            }
            Font.SelectedIndex = 0;
            editText.FontFamily = new FontFamily(fontsNames[0]);

            razmer.Text = "14";

            printMan = PrintManager.GetForCurrentView();
            printMan.PrintTaskRequested += PrintTaskRequested;
            printDoc = new PrintDocument();
            printDocSource = printDoc.DocumentSource;
            printDoc.Paginate += Paginate;
            printDoc.GetPreviewPage += GetPreviewPage;
            printDoc.AddPages += AddPages;

        }

        public IRandomAccessStream randomAccess;
        public StorageFile file = null;

        private async void SaveAs_Click(object sender, RoutedEventArgs e)
        {
            FileSavePicker savePicker = new FileSavePicker();
            savePicker.SuggestedStartLocation = PickerLocationId.DocumentsLibrary;

            savePicker.FileTypeChoices.Add("Rich Text", new List<string>() { ".rtf" });
            savePicker.SuggestedFileName = "New Document";

            file = await savePicker.PickSaveFileAsync();
            if (file != null)
            {
                CachedFileManager.DeferUpdates(file);
                randomAccess = await file.OpenAsync(FileAccessMode.ReadWrite);

                editText.Document.SaveToStream(Windows.UI.Text.TextGetOptions.FormatRtf, randomAccess);
                FileUpdateStatus status = await CachedFileManager.CompleteUpdatesAsync(file);
            }
        }

        private async void open_Click(object sender, RoutedEventArgs e)
        {
            FileOpenPicker open = new FileOpenPicker();
            open.SuggestedStartLocation = PickerLocationId.DocumentsLibrary;
            open.FileTypeFilter.Add(".rtf");

            file = await open.PickSingleFileAsync();

            if (file != null)
            {
                try
                {
                    randomAccess = await file.OpenAsync(FileAccessMode.Read);
                    editText.Document.LoadFromStream(TextSetOptions.FormatRtf, randomAccess);
                }
                catch (Exception) { }
            }
        }

        private void kurs_Click(object sender, RoutedEventArgs e)
        {
            editText.Document.Selection.CharacterFormat.Italic = Windows.UI.Text.FormatEffect.Toggle;
        }
        private void bold_Click(object sender, RoutedEventArgs e)
        {
            editText.Document.Selection.CharacterFormat.Bold = Windows.UI.Text.FormatEffect.Toggle;
        }

        private void underlinedText_Click(object sender, RoutedEventArgs e)
        {
            editText.Document.Selection.CharacterFormat.Underline = Windows.UI.Text.UnderlineType.Dash;
        }

        private void Font_DropDownClosed(object sender, object e)
        {
            editText.FontFamily = new FontFamily(Font.SelectedItem.ToString());
        }

        private void colors_DropDownClosed(object sender, object e)
        {
            if (colors.SelectedIndex == 0)
            {
                editText.Document.Selection.CharacterFormat.ForegroundColor = Windows.UI.Colors.Azure;
            }

            if (colors.SelectedIndex == 1)
            {
                editText.Document.Selection.CharacterFormat.ForegroundColor = Windows.UI.Colors.Aqua;
            }

            if (colors.SelectedIndex == 2)
            {
                editText.Document.Selection.CharacterFormat.ForegroundColor = Windows.UI.Colors.Chocolate;
            }

            if (colors.SelectedIndex == 3)
            {
                editText.Document.Selection.CharacterFormat.ForegroundColor = Windows.UI.Colors.Black;
            }

            if (colors.SelectedIndex == 4)
            {
                editText.Document.Selection.CharacterFormat.ForegroundColor = Windows.UI.Colors.White;
            }
        }

        private void razmer_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!Char.IsDigit(razmer.Text, razmer.Text.Length - 1)) {razmer.Text = razmer.Text.Substring(0, razmer.Text.Length -1); }
            if (razmer.Text != "" && razmer.Text != "0")
                editText.FontSize = Convert.ToDouble(razmer.Text);
        }


        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }

        private void MenuFlyoutCopy_Click(object sender, RoutedEventArgs e)
        {
            editText.Document.Selection.Copy();
        }

        private void MenuFlyoutPaste_Click(object sender, RoutedEventArgs e)
        {
            editText.Document.Selection.Paste(0);
        }

        private void MenuFlyoutCut_Click(object sender, RoutedEventArgs e)
        {
            editText.Document.Selection.Cut();
        }

        private void MenuFlyoutUndo_Click(object sender, RoutedEventArgs e)
        {
            if (editText.Document.CanUndo())
            {
                editText.Document.Undo();
            }
        }
        private async void MenuFlyoutItem_Click(object sender, RoutedEventArgs e)
        {
            if(file != null)
            {
                editText.Document.SaveToStream(Windows.UI.Text.TextGetOptions.FormatRtf, randomAccess);
                FileUpdateStatus status = await CachedFileManager.CompleteUpdatesAsync(file);
            }
        }
        private  void newFile_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                file = null;
                randomAccess.Dispose();
                editText.Document.SetText(TextSetOptions.None, string.Empty);
            }
            catch { }
        }
        private void MenuFlyoutReUndo_Click(object sender, RoutedEventArgs e)
        {
            editText.Document.Redo();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
              editText.Document.Selection.Delete(TextRangeUnit.Word,editText.Document.Selection.Text.Length);
        }

        private void MenuFlyoutSelectAll_Click(object sender, RoutedEventArgs e)
        {
            editText.Focus(FocusState.Pointer);
            editText.Document.Selection.SetRange(0, editText.Document.Selection.EndPosition);
        }

        private async void MenuFlyoutItem_Click_1(object sender, RoutedEventArgs e)
        {
            var message = await new MessageDialog("Программа Текстовый редактор.\n " +
                "Под фунцкиями редактора текста есть поле, где можно вписывать текст и изменять его\n " +
                "сврху представленны кнопки - функции редактора текста. Редактор сделан Русецким М.А.").ShowAsync();
        }

        private async void MenuFlyoutItem_Click_2(object sender, RoutedEventArgs e)
        {
            var message = await new MessageDialog("Сдаю долги. Редактор, как редактор, что бубнить-то").ShowAsync();
        }
        private PrintManager printMan;
        private PrintDocument printDoc;
        private IPrintDocumentSource printDocSource;
        //__________________________________________________________________________Принтер__|
        //__________________________________________________________________________________\|/
        private async void Print_Click(object sender, RoutedEventArgs e)
        {
            if (PrintManager.IsSupported())
            {
                try
                {
                    await PrintManager.ShowPrintUIAsync();
                }
                catch { }
            }
        }
        private void PrintTaskRequested(PrintManager sender, PrintTaskRequestedEventArgs args)
        {
            var printTask = args.Request.CreatePrintTask("Print", PrintTaskSourceRequrested);
        }

        private void PrintTaskSourceRequrested(PrintTaskSourceRequestedArgs args)
        {
            args.SetSource(printDocSource);
        }

        private void Paginate(object sender, PaginateEventArgs e)
        {
            printDoc.SetPreviewPageCount(1, PreviewPageCountType.Final);
        }

        private void GetPreviewPage(object sender, GetPreviewPageEventArgs e)
        {
            string textStr = "";
            editText.Document.GetText(TextGetOptions.FormatRtf, out textStr);
            RichEditBox richTextBlock = new RichEditBox();
            richTextBlock.Document.SetText(TextSetOptions.FormatRtf, textStr);
            richTextBlock.Background = new SolidColorBrush(Windows.UI.Colors.White);
            printDoc.SetPreviewPage(e.PageNumber, richTextBlock);
        }

        private void AddPages(object sender, AddPagesEventArgs e)
        {
            string textStr = "";
            editText.Document.GetText(TextGetOptions.FormatRtf, out textStr);
            RichEditBox richTextBlock = new RichEditBox();
            richTextBlock.Document.SetText(TextSetOptions.FormatRtf, textStr);
            richTextBlock.Background = new SolidColorBrush(Windows.UI.Colors.White);
            richTextBlock.Padding = new Thickness(20, 20, 20, 20);
            printDoc.AddPage(richTextBlock);
        }

    }
}
