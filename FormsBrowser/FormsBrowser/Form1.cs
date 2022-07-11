using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace FormsBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            OpenWeb();
        }
        List<zapis> zapis1 = new List<zapis>();
        public string home = "https://yandex.ru/";

        private void SerializerXML(List<zapis> web)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<zapis>));

            using (FileStream file = new FileStream("Zapis.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(file, web);
            }
        }
        private void OpenWeb()
        {
            TabPage tabPage = new TabPage("Вкладка");
            WebBrowser webBrowser = new WebBrowser();
            webBrowser.Dock = DockStyle.Fill;
            tabPage.Controls.Add(webBrowser);
            webBrowser.Navigate(home);
            Vkladki.TabPages.Add(tabPage);
            addres.Text = home;

            zapis webb = new zapis(addres.Text);

            zapis1.Add(webb);
            SerializerXML(zapis1);
        }


        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            (Vkladki.SelectedTab.Controls[0] as WebBrowser).Navigate(addres.Text);

            zapis webb = new zapis(addres.Text);

            zapis1.Add(webb);
            SerializerXML(zapis1);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if ((Vkladki.SelectedTab.Controls[0] as WebBrowser).CanGoForward)
            {
                (Vkladki.SelectedTab.Controls[0] as WebBrowser).GoForward();
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            (Vkladki.SelectedTab.Controls[0] as WebBrowser).Navigate(home);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if ((Vkladki.SelectedTab.Controls[0] as WebBrowser).CanGoBack)
            {
                (Vkladki.SelectedTab.Controls[0] as WebBrowser).GoBack();
            }
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            OpenWeb();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            if (Vkladki.TabCount == 1)
            {
                Application.Exit();
            }
            else
            {
                Vkladki.TabPages.Remove(Vkladki.SelectedTab);
            }
        }
    }
    [Serializable]
    public class zapis
    {
        public string web { get; set; }

        public zapis(string web)
        {
            this.web = web;
        }

        public zapis()
        {
        }
    }
}