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

namespace RegLog
{
    public partial class Form1 : Form
    {
        public List<zapis> regustLog = new List<zapis>();
        public Form1()
        {
            InitializeComponent();
            regustLog = DeserializerXML();
        }

        public bool mailtrue = false, passwordbool = false;

        private void SerializerXML(List<zapis> user)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<zapis>));// не нада

            using (FileStream file = new FileStream("Zapis.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(file, user);
                file.Close();
            }
        }

        public string mail;
        public bool loginx = true;

        private void regust_Click(object sender, EventArgs e)
        {
            loginx = true;
            string pol;

            if (male.Checked == true)
            {
                pol = "Мужской";
            }
            else
            {
                pol = "Женский";
            }
            List<zapis> zapis = DeserializerXML(); //вот жто конечно замечательно, только ты должен пробежаться по всем логинам через for, а этого for-а у тебя нет
            for (int i = 0; i < zapis.Count; i++)//и тут как тогда будлет? если мы через цикл по листу идем
            {
                if (zapis[i].login1 == maskedTextBox2.Text) // дело ещё в том, что он кидает ошибку при возврате
                {
                    loginx = false;//если я сейчас спущусь в сериализацию и увиду, что ты там сериализуешь zapis, а не List<zapis>, я тебя убью нахер, так что даю тебе 5 минут чтобы это пофиксить
                } //Тип, зачем нам дпругое условие р, ш, я чекаю
            }
            if (!loginx)//попробуй
                MessageBox.Show("Логин занят!");

            if ((tegMail.Text != "" && !tegMail.Text.Contains("@") && !tegMail.Text.Contains(".")) && (typeMail.Text != "" && !typeMail.Text.Contains("@") && !typeMail.Text.Contains(".")) && (domen.Text != "" && !domen.Text.Contains("@") && !domen.Text.Contains(".")))
            {
                mailtrue = true;
                mail = tegMail.Text + "@" + typeMail.Text + "." + domen.Text;
            }
            else
            {
                MessageBox.Show("Не правильный ввод почты!");
                mailtrue = false;
            }

            if ((maskedTextBox3.Text == maskedTextBox4.Text) || (maskedTextBox4.Text == maskedTextBox3.Text))
            {
                passwordbool = true;
            }
            else
            {
                MessageBox.Show("Пароль не совпадает!");
                passwordbool = false;
            }

            if (!serPassport.Text.Contains(" ") && !numPassport.Text.Contains(" ") && maskedTextBox1.Text.Contains(" "))
            {
                if (mailtrue == true && passwordbool == true && loginx == true)
                {
                    zapis user = new zapis(maskedTextBox2.Text, maskedTextBox3.Text, serPassport.Text, numPassport.Text, maskedTextBox1.Text, mail.ToString(), pol); //тут поменяешь на лист - зарежу вдвойне
                                                                                                                                                                     //самое время тебе кое че скинуть
                                                                                                                                                                     //эта строка у тебя в правильная. эта строка - большая оранжевая коробка. тебе из нее надо сделать маленькую и запихнуть в лист, а потом сериализовать
                                                                                                                                                                     //мишаня злица буду
                                                                                                                                                                     //у меня мозг отключен
                    /*
                     * так включи!
                     * bruh
                     * у тебя все zapis должны хранится в листе
                     * LListname.Add(user);
                     * и уже сюда ты пишешь
                     * SerializerXML(Listname);
                     * рр
                     * Публичный лист? джа
                     * 
                     * 
                     * Файл нужно удалять? щас я буду кричать как драгонзы в фрикшон
                     */
                    regustLog.Add(user);//спасибо боже что не сдох) и теперь? запускай шарманку еба

                    SerializerXML(regustLog);

                    maskedTextBox2.Text = "";
                    maskedTextBox3.Text = "";
                    serPassport.Text = "";
                    numPassport.Text = "";
                    maskedTextBox1.Text = "";
                    tegMail.Text = "";
                    typeMail.Text = "";
                    domen.Text = "";
                    maskedTextBox4.Text = "";
                    male.Checked = false;
                    female.Checked = false;
                    maskedTextBox5.Text = "";
                    maskedTextBox6.Text = "";

                    MessageBox.Show("Вы зарегестрированны!");
                }
            }
            else
            {
                MessageBox.Show("Есть пробелы!");
            }
        }

        private List<zapis> DeserializerXML()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<zapis>));

            using (FileStream file = new FileStream("Zapis.xml", FileMode.OpenOrCreate))
            {
                try//а) кто будет файлы закрывать, б) что должно выводится? сначала б
                {
                    return (List<zapis>)xmlSerializer.Deserialize(file);//ну потому что ты дурашка, мишаня, трай кетч кто в десериализации буде ставить!
                }
                catch {
                    return new List<zapis>(); // это шо? у тебя метод в любом случае должен что-то возвращать, будь то правильное выполенине кода, будь то ошибка. поэтому, если вдруг тебе в лицо вылетет экзепшон, то ты просто должен вернуть этим методом пустой лист. а пустой лист мы создаем череез new List<zapis>();
                }
            }//БУ БУ БУ БУ БУ БУ :) (-_-)
        }

        private void inLog_Click(object sender, EventArgs e)
        {
            List<zapis> zapis = DeserializerXML();//это не вопрос за что это отвечает, я про то, почему тут ошибка, если ты десериализуешщь лист, угум!

            for (int i = 0; i < zapis.Count; i++)
            {
                if ((zapis[i].login1 == maskedTextBox5.Text) && (zapis[i].password1 == maskedTextBox6.Text)) //Проверяем? давай
                {
                    maskedTextBox2.Text = "";
                    maskedTextBox3.Text = "";
                    maskedTextBox5.Text = "";
                    maskedTextBox6.Text = "";
                    serPassport.Text = "";
                    numPassport.Text = "";
                    maskedTextBox1.Text = "";
                    tegMail.Text = "";
                    typeMail.Text = "";
                    domen.Text = "";
                    maskedTextBox4.Text = "";
                    male.Checked = false;
                    female.Checked = false;
                    maskedTextBox5.Text = "";
                    maskedTextBox6.Text = "";

                    Form2 form2 = new Form2();
                    form2.Show();
                    break;
                }
            }
        }
    }

    [Serializable]
    public class zapis
    {
        public string login1 { get; set; }
        public string password1 { get; set; }
        public string seriaPassport1 { get; set; }
        public string numberPassport1 { get; set; }
        public string numberPhone1 { get; set; }
        public string mail1 { get; set; }
        public string pol1 { get; set; }

        public zapis(string login, string password, string seriaPassport, string numberPassport, string numberPhone, string mail, string pol)
        {
            this.login1 = login;
            this.password1 = password;
            this.seriaPassport1 = seriaPassport;
            this.numberPassport1 = numberPassport;
            this.numberPhone1 = numberPhone;
            this.mail1 = mail;
            this.pol1 = pol;
        }

        public zapis()
        {

        }
    }
}