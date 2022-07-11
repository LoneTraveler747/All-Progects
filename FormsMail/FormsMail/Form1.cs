using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsMail
{
    public partial class Form1 : Form
    {
        public string mail = "", name = "", mailto = "", title = "", message = "", port = "", server = "", password = "";

        public Form1()
        {
            InitializeComponent();
            int count = 0;

            mail = "";
            name = "";
            mailto = "";
            title = "";
            message = "";
            port = "";
            server = "";
            password = "";

            if (!File.Exists("Zapis.txt"))
            {
                File.Create("Zapis.txt");
            }
            else
            {
                using (StreamReader streamReader = new StreamReader("Zapis.txt"))
                {
                    while (!streamReader.EndOfStream)
                    {
                        switch (count)
                        {
                            case 0:
                                {
                                    mail = streamReader.ReadLine();
                                    mailaddres.Text = mail;
                                    break;
                                }
                            case 1:
                                {
                                    port = streamReader.ReadLine();
                                    portmail.Text = port;
                                    break;
                                }
                            case 2:
                                {
                                    server = streamReader.ReadLine();
                                    servermail.Text = server;
                                    break;
                                }
                            case 3:
                                {
                                    password = streamReader.ReadLine();
                                    passwordmail.Text = password;
                                    break;
                                }
                        }
                        count++;
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter;

            if(mailaddres.Text != "" && Name.Text != "" && maildaddresto.Text != "" && titlemail.Text != "" && massagemail.Text != "" && portmail.Text != "" && servermail.Text != "" && passwordmail.Text != "")
            {
                try
                {
                    MailAddress senderEmail = new MailAddress(mailaddres.Text, Name.Text);
                    MailAddress recipientMail = new MailAddress(maildaddresto.Text);

                    MailMessage message = new MailMessage(senderEmail, recipientMail);
                    message.Subject = titlemail.Text;
                    message.Body = massagemail.Text;
                    message.IsBodyHtml = false;

                    SmtpClient smtp = new SmtpClient(servermail.Text, Convert.ToInt32(portmail.Text));
                    smtp.UseDefaultCredentials = false;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(mailaddres.Text, passwordmail.Text);
                    smtp.EnableSsl = true;

                    smtp.Send(message);
                }
                catch
                {
                    MessageBox.Show("Ошибка");
                }

                streamWriter = new StreamWriter("Zapis.txt");

                streamWriter.WriteLine(mailaddres.Text);
                streamWriter.WriteLine(portmail.Text);
                streamWriter.WriteLine(servermail.Text);
                streamWriter.WriteLine(passwordmail.Text);

                streamWriter.Close();
            }
            else
            {
                MessageBox.Show("Поле/поля пустые!");
            }
        }
    }
}