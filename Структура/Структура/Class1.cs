namespace Структура_1._1
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class Class1

    {
        public static int number = 11;
        public static int nomer = 0;
        private static ally[] allies;

        public static int alfa = 1, b = 1, y = 0, i = 0, godforoshibka, dni;
        public static string FIO1, kk = "", pasport1, snils1, DDMMGG, savePol, mail1, telefon1 = "", telefon2, rabotka;
        public static string INN1, durdom = "";
        public static double coins;
        struct ally
        {
            public string pronum;
            public string homenum;
        }

        public static void Nomera()
        {
            allies = new ally[number];
            //nomer = 12;
            Console.WriteLine("Номер телефона(рабочий): ");
            allies[nomer].pronum = Console.ReadLine();
            while (allies[nomer].pronum.Length != 11)
                allies[nomer].pronum = Console.ReadLine();
            Console.WriteLine("Номер телефона(домашний): ");
            allies[nomer].homenum = Console.ReadLine();
            while (allies[nomer].homenum.Length != 11)
                allies[nomer].homenum = Console.ReadLine();
            Console.ReadKey();
            telefon1 = allies[nomer].homenum;
            telefon2 = allies[nomer].pronum;
        }
        public struct FIO
        {
            public string LastName;
            public string FirstName;
            public string SurName;
        }
        public struct PASPORT
        {
            public string seria;
            public string nomer;
        }
        public struct DATA_ROJD
        {
            public int DD;
            public int MM;
            public int GG;
        }
        public struct INN
        {
            public string inn;
        }
        public struct study
        {
            public string[] school;
            public string[] obraz;
            public string[] godobraz;
            public string[] god;
        }
        public struct CNILC
        {
            public string cnilc;
        }
        public struct mail
        {
            public string Mail;
            public string Mail2;
        }
        public struct pol
        {
            public string M;
            public string J;
        }
        public struct rab
        {
            public int stavka;
            public string dolznost;
            public int ZP;
            public int oklad;
        }
        public static void OPS()
        {
            FIO fIO = new FIO();
            Console.WriteLine("Введите Фамилию");
            fIO.LastName = Console.ReadLine();

            while (fIO.LastName.Length == 0 || (fIO.LastName.IndexOf(' ') != -1))
            {
                Console.Clear();
                Console.WriteLine("Введите Фамилию");
                fIO.LastName = Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine("Введите Фамилию");
            Console.WriteLine(fIO.LastName);
            Console.WriteLine("Введите Имя");
            fIO.FirstName = Console.ReadLine();
            while (fIO.FirstName.Length == 0 || (fIO.FirstName.IndexOf(' ') != -1))
            {
                Console.Clear();
                Console.WriteLine("Введите Фамилию");
                Console.WriteLine(fIO.LastName);
                Console.WriteLine("Введите Имя");
                fIO.FirstName = Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine("Введите Фамилию");
            Console.WriteLine(fIO.LastName);
            Console.WriteLine("Введите Имя");
            Console.WriteLine(fIO.FirstName);
            Console.WriteLine("Введите Очество ");
            fIO.SurName = Console.ReadLine();
            while ((fIO.SurName.Length == 0) || (fIO.SurName.IndexOf(' ') != -1))
            {

                Console.Clear();
                Console.WriteLine("Введите Фамилию");
                Console.WriteLine(fIO.LastName);
                Console.WriteLine("Введите Имя");
                Console.WriteLine(fIO.FirstName);
                Console.WriteLine("Введите Очество ");
                fIO.SurName = Console.ReadLine();
            }
            FIO1 = fIO.LastName + " || " + fIO.FirstName + " || " + fIO.SurName + " ";

        }
        public static void pasport()
        {
            PASPORT pasport = new PASPORT();
            int alfa3 = 1;


            while (alfa3 == 1)
            {

                int trollolo3;

                Console.WriteLine("Серия паспорта:");

                while (!int.TryParse(Console.ReadLine(), out trollolo3))
                {
                    Console.Clear();
                    Console.WriteLine("Серия паспорта:");
                }
                pasport.seria = trollolo3.ToString();

                if (pasport.seria.Length != 4 || pasport.seria.StartsWith("-") || pasport.seria.StartsWith("+"))

                {
                    Console.Clear();

                }
                else { alfa3 = 0; }

            }
            Console.Clear();
            int alfa4 = 1;
            while (alfa4 == 1)
            {
                int trollolo4;
                Console.WriteLine("Серия паспорта:");
                Console.WriteLine(pasport.seria);
                Console.WriteLine("Номер паспорта:");
                while (!int.TryParse(Console.ReadLine(), out trollolo4))
                {
                    Console.Clear();
                    Console.WriteLine("Серия паспорта:");
                    Console.WriteLine(pasport.seria);
                    Console.WriteLine("Номер паспорта:");
                }
                pasport.nomer = trollolo4.ToString();
                if (pasport.nomer.Length != 6 || pasport.nomer.StartsWith("-") || pasport.nomer.StartsWith("+"))

                {
                    Console.Clear();

                }
                else { alfa4 = 0; }
            }

            pasport1 = " " + pasport.seria + "||" + pasport.nomer;
            Console.Clear();
        }
        public static void Data()
        {
            Console.WriteLine("Введите Год");
            int alfa = 1;
            DATA_ROJD dmg = new DATA_ROJD();
            while (!int.TryParse(Console.ReadLine(), out dmg.GG))
            {

                Console.Clear();
                Console.WriteLine("Введите Год");
            }
            while (alfa == 1)
            {
                godforoshibka = dmg.GG;
                Console.Clear();
                Console.WriteLine("Год");
                Console.WriteLine(dmg.GG);
                Console.WriteLine("Месяц");
                while (!int.TryParse(Console.ReadLine(), out dmg.MM))
                {
                    Console.Clear();
                    Console.WriteLine("Год");
                    Console.WriteLine(dmg.GG);
                    Console.WriteLine("Месяц");
                }
                if (dmg.MM >= 13 || dmg.MM <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Год");
                    Console.WriteLine(dmg.GG);
                    Console.WriteLine("Месяц");
                }
                else
                {
                    alfa = 0;
                }
            }
            alfa = 1;
            while (alfa == 1)
            {
                Console.Clear();
                Console.WriteLine("Год");
                Console.WriteLine(dmg.GG);
                Console.WriteLine("Месяц");
                Console.WriteLine(dmg.MM);
                Console.WriteLine("Введите день");

                while (!int.TryParse(Console.ReadLine(), out dmg.DD))
                {
                    Console.Clear();
                    Console.WriteLine("Год");
                    Console.WriteLine(dmg.GG);
                    Console.WriteLine("Месяц");
                    Console.WriteLine(dmg.MM);
                }
                if (dmg.DD >= 32 || dmg.DD <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Год");
                    Console.WriteLine(dmg.GG);
                    Console.WriteLine("Месяц");
                    Console.WriteLine(dmg.MM);
                }
                else
                {
                    alfa = 0;
                }
                DDMMGG = dmg.DD + "." + dmg.MM + "." + dmg.GG;
                Console.Clear();
            }
        }
        public static void inn()
        {
            INN iNN = new INN() ;
            Console.WriteLine("ИНН состоит из 12 символов");
            Console.Write("Ваш ИНН:");
            iNN.inn = Console.ReadLine();
            while (iNN.inn.Length !=12)
            {
                Console.Clear();
                Console.Write("Ваш ИНН:");
                iNN.inn = Console.ReadLine();
            }
            
        }
        public static void Cnils()
        {
            CNILC snils = new CNILC();
            Console.WriteLine("СНИЛС состоит из 11 символов");
            Console.WriteLine("Ваш СНИЛС:");
            snils.cnilc = Console.ReadLine();
            while (snils.cnilc.Length !=11)
            {
                Console.Clear();
                Console.Write("Ваш СНИЛС:");
                snils.cnilc = Console.ReadLine();
            }
            //snils.cnilc = new int[11];
            //for (int i = 0; i < 11; i++)
            //{
            //    Console.Clear();
            //    Console.Write("Ваш СНИЛС:");


            //    for (int a = 0; a < snils.cnilc.Length; a++)
            //    {

            //        Console.Write(snils.cnilc[a]);
            //        if (a == 2)
            //        {
            //            Console.Write("-");
            //        }
            //        if (a == 5)
            //        {
            //            Console.Write("-");
            //        }
            //        if (a == 8)
            //        {
            //            Console.Write("-");
            //        }
            //    }
            //    Console.WriteLine("");
            //    while (!int.TryParse(Console.ReadLine(), out snils.cnilc[i]))
            //    {
            //        Console.Clear();
            //        Console.Write("Ваш СНИЛС:");
            //        for (int a = 0; a < snils.cnilc.Length; a++)
            //        {


            //            Console.Write(snils.cnilc[a]);
            //            if (a == 2)
            //            {
            //                Console.Write("-");
            //            }
            //            if (a == 5)
            //            {
            //                Console.Write("-");
            //            }
            //            if (a == 8)
            //            {
            //                Console.Write("-");
            //            }
            //        }
            //        Console.WriteLine("");
            //    }
            //    if (Convert.ToString(snils.cnilc[i]).Length != 1)
            //    {
            //        Console.Clear();
            //        snils.cnilc[i] = 0;
            //        if (i > 0)
            //        {
            //            i--;
            //        }
            //        if (i == 0)
            //        {
            //            i = -1;
            //        }

            //    }
            //}
            //Console.Clear(); Console.Write("Ваш СНИЛС:");
            //for (int b = 0; b < snils.cnilc.Length; b++)
            //{


            //    Console.Write(snils.cnilc[b]);

            //    if (b == 2)
            //    {
            //        Console.Write("-");


            //    }
            //    if (b == 5)
            //    {
            //        Console.Write("-");
            //    }
            //    if (b == 8)
            //    {
            //        Console.Write("-");
            //    }

            //    snils1 += snils.cnilc[b];

            //}
            //Console.Clear();
            //snils1 = snils1.Insert(3, "-");
            //snils1 = snils1.Insert(7, "-");
            //snils1 = snils1.Insert(11, "-");
        }
        public static void Obrazovanie()
        {
            int colvo;

            study study = new study();
            Console.Write("Введите количество образований: ");
            while (!int.TryParse(Console.ReadLine(), out colvo))
            {
                Console.Clear();
                Console.Write("Введите количество образований");

            }
            colvo = Math.Abs(colvo);
            study.obraz = new string[colvo];
            study.school = new string[colvo];
            study.godobraz = new string[colvo];
            study.god = new string[colvo];


            string[] menu = { "Среднее", "Профессиональное ", "Высшее" };
            int currentSelection = 0; int ii = 0;
            while (true && ii <= colvo--)
            {
                bool menuwhile = true;
                while (menuwhile)
                {
                    Console.Clear();
                    for (int i = 0; i < menu.Length; i++)
                    {
                        if (currentSelection == i)
                        {
                            Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.Black;
                        }
                        Console.WriteLine(menu[i]);
                        Console.ResetColor();
                    }
                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.UpArrow:
                            {
                                if (currentSelection > 0)
                                {
                                    currentSelection--;
                                }
                            }
                            break;
                        case ConsoleKey.DownArrow:
                            {
                                if (currentSelection < menu.Length - 1)
                                {
                                    currentSelection++;
                                }
                            }
                            break;

                        case ConsoleKey.Enter:
                            {
                                switch (currentSelection)
                                {
                                    case 0:
                                        {

                                            Console.Clear();
                                            study.school[ii] = "Среднее";


                                        }
                                        break;
                                    case 1:
                                        {

                                            Console.Clear();
                                            study.school[ii] = "Профессиональное";


                                        }
                                        break;
                                    case 2:
                                        {

                                            Console.Clear();
                                            study.school[ii] = "Высшее";


                                        }
                                        break;
                                }
                                menuwhile = false;
                            }
                            break;

                    }

                }

                Console.WriteLine("Место окончания образования: " + study.school[ii]);



                study.obraz[ii] = Console.ReadLine();

                Console.WriteLine("Год"); bool net = true;

                while (net)
                {
                    try
                    {
                        study.godobraz[ii] = Console.ReadLine();
                        if (Convert.ToInt32(study.godobraz[ii]) > (godforoshibka + 15) && Convert.ToInt32(study.godobraz[ii]) <= 2119) { net = false; }
                        else { Console.WriteLine("Введите правильную дату!"); }
                    }
                    catch { Console.WriteLine("Тут была ошибка"); }
                } // защита года
                Console.WriteLine("Месяц"); net = true;
                while (net)
                {
                    try
                    {
                        string s = Console.ReadLine(); int _s = Convert.ToInt32(s);
                        if (_s > 0 && _s <= 12)
                        {
                            study.godobraz[ii] += " " + s;
                            net = false;
                        }
                        else { Console.WriteLine("Введите правильно!"); }
                    }
                    catch { Console.WriteLine("Введите правильно!"); }
                } //защита месяца
                Console.WriteLine("День"); net = true;
                while (net)
                {
                    try
                    {
                        string s = Console.ReadLine(); int _s = Convert.ToInt32(s);
                        if (_s > 0 && _s <= 31)
                        {
                            study.godobraz[ii] += " " + s;
                            net = false;
                        }
                        else { Console.WriteLine("Введите правильно!"); }
                    }

                    catch { Console.WriteLine("Введите верно!"); }
                }
                ii++;
                
                durdom = study.school[0] + "||" + study.obraz[0] + "||" + study.godobraz[0];
            }


        }
        public static void Mail()
        {
            mail mail = new mail();
            Console.WriteLine("Введите почту без @ (пример: privet@mail.ru)"); bool defedsobaka = true;

            bool check = false;
            while (defedsobaka)
            {

                defedsobaka = false;
                mail.Mail = Console.ReadLine();
                for (int i = mail.Mail.Length - 1; i >= 0; i--)
                {

                    if (mail.Mail[i] == '@')
                    {

                        Console.WriteLine("Введите без собаки");
                        defedsobaka = true;

                    }

                }
            }

            string[] menu = { mail.Mail + "@mail.ru", mail.Mail + "@gmail.com ", mail.Mail + "@yandex.ru", mail.Mail + "@bk.ru", mail.Mail + "mpt.ru"};
            int currentSelection = 0; bool menuwhile = true; Console.Clear();
            while (menuwhile)
            {
                Console.Clear();
                for (int i = 0; i < menu.Length; i++)
                {

                    if (currentSelection == i)
                    {
                        Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.Black;
                    }
                    Console.WriteLine(menu[i]);
                    Console.ResetColor();

                }
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.UpArrow:
                        {
                            if (currentSelection > 0)
                            {
                                currentSelection--; Console.Clear();
                            }
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        {
                            if (currentSelection < menu.Length - 1)
                            {
                                currentSelection++;
                                Console.Clear();
                            }
                        }
                        break;

                    case ConsoleKey.Enter:
                        {
                            {
                                switch (currentSelection)
                                {
                                    case 0:
                                        {

                                            Console.Clear();
                                            mail.Mail2 = "@mail.ru";


                                        }
                                        break;
                                    case 1:
                                        {

                                            Console.Clear();
                                            mail.Mail2 = "@gmail.com";

                                        }
                                        break;
                                    case 2:
                                        {

                                            Console.Clear();
                                            mail.Mail2 = "@yandex.ru";


                                        }
                                        break;
                                    case 3:
                                        {

                                            Console.Clear();
                                            mail.Mail2 = "@bk.ru";


                                        }
                                        break;
                                    case 4:
                                        {

                                            Console.Clear();
                                            mail.Mail2 = "mpt.ru";


                                        }
                                        break;
                                }
                                menuwhile = false;


                            }
                        }

                        break;

                }
            }
            mail1 = mail.Mail + mail.Mail2;
        }
        public static void POL()
        {
            pol pol = new pol();
            pol.M = "Мужской";
            pol.J = "Женский";
            int currentSelection = 0;
            bool menuwhile = true;
            string[] menu = { "Мужской", "Женский" };

            while (menuwhile)
            {
                Console.Clear();
                for (int i = 0; i < menu.Length; i++)
                {
                    if (currentSelection == i)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    Console.WriteLine(menu[i]);
                    Console.ResetColor();
                }

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.UpArrow:
                        {
                            if (currentSelection > 0)
                            {
                                currentSelection--;
                            }
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        {
                            if (currentSelection < menu.Length - 1)
                            {
                                currentSelection++;
                            }
                        }
                        break;
                    case ConsoleKey.Enter:
                        {
                            switch (currentSelection)
                            {
                                case 0:
                                    {
                                        Console.Clear();
                                        savePol = pol.M;

                                    }
                                    break;
                                case 1:
                                    {
                                        Console.Clear();
                                        savePol = pol.J;
                                    }
                                    break;
                            }
                            menuwhile = false;
                        }
                        break;
                }
            }
        }
        public static void rabota()
        {
            rab rab1 = new rab();
            Console.WriteLine("Выберете должность: ");
            string[] menu = { "Ответственный за территорию", "Кладовщик", "Охранник" };
            int currentSelection = 0; bool menuwhile = true; Console.Clear();
            while (menuwhile)
            {
                Console.Clear();
                for (int i = 0; i < menu.Length; i++)
                {

                    if (currentSelection == i)
                    {
                        Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.Black;
                    }
                    Console.WriteLine(menu[i]);
                    Console.ResetColor();

                }
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.UpArrow:
                        {
                            if (currentSelection > 0)
                            {
                                currentSelection--; Console.Clear();
                            }
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        {
                            if (currentSelection < menu.Length - 1)
                            {
                                currentSelection++;
                                Console.Clear();
                            }
                        }
                        break;

                    case ConsoleKey.Enter:
                        {
                            {
                                switch (currentSelection)
                                {
                                    case 0:
                                        {

                                            Console.Clear();
                                            rab1.dolznost = "Ответственный за территорию";
                                            Console.WriteLine(rab1.dolznost);


                                        }
                                        break;
                                    case 1:
                                        {

                                            Console.Clear();
                                            rab1.dolznost = "Кладовщик";
                                            Console.WriteLine(rab1.dolznost);
                                        }
                                        break;
                                    case 2:
                                        {

                                            Console.Clear();
                                            rab1.dolznost = "Охраннк";
                                            Console.WriteLine(rab1.dolznost);

                                        }
                                        break;
                                }
                                menuwhile = false;
                                Console.ReadKey();

                            }
                        }

                        break;

                }

            }
            Console.Clear();
            Console.WriteLine("У вас ставка или оклад?");
            string[] menu1 = { "Ставка", "Оклад" };
            int currentSelection1 = 0; bool menuwhile1 = true; Console.Clear();
            while (menuwhile1)
            {
                Console.Clear();
                for (int i = 0; i < menu1.Length; i++)
                {

                    if (currentSelection1 == i)
                    {
                        Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.Black;
                    }
                    Console.WriteLine(menu1[i]);
                    Console.ResetColor();

                }
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.UpArrow:
                        {
                            if (currentSelection1 > 0)
                            {
                                currentSelection1--; Console.Clear();
                            }
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        {
                            if (currentSelection1 < menu1.Length - 1)
                            {
                                currentSelection1++;
                                Console.Clear();
                            }
                        }
                        break;

                    case ConsoleKey.Enter:
                        {
                            {
                                switch (currentSelection1)
                                {
                                    case 0:
                                        {

                                            Console.Clear();
                                            Console.WriteLine(rab1.dolznost);
                                            Console.WriteLine("Ставка");
                                            rab1.oklad = 0;
                                            if (rab1.dolznost == "Охраннк")
                                            {
                                                rab1.stavka = 2400;
                                                Console.WriteLine("Ваша ставка за день работы: " + rab1.stavka);
                                                Console.WriteLine("Кол-во дней работы");
                                                while (!int.TryParse(Console.ReadLine(), out dni))
                                                {
                                                    Console.WriteLine("Так нельзя");
                                                    dni = Convert.ToInt32(Console.ReadLine());
                                                    while (dni >= 32 || dni <= 0)
                                                    {

                                                        Console.WriteLine("Так нельзя");
                                                        dni = Convert.ToInt32(Console.ReadLine());

                                                    }

                                                }

                                                Console.Clear();

                                            }
                                            if (rab1.dolznost == "Кладовщик")
                                            {
                                                rab1.stavka = 3600;
                                                Console.WriteLine("Ваша ставка за день работы: " + rab1.stavka);
                                                Console.WriteLine("Кол-во дней работы");
                                                while (!int.TryParse(Console.ReadLine(), out dni))
                                                {
                                                    Console.WriteLine("Так нельзя");
                                                    dni = Convert.ToInt32(Console.ReadLine());
                                                    while (dni >= 32 || dni <= 0)
                                                    {

                                                        Console.WriteLine("Так нельзя");
                                                        dni = Convert.ToInt32(Console.ReadLine());

                                                    }
                                                }

                                                Console.Clear();
                                            }
                                            if (rab1.dolznost == "Ответственный за территорию")
                                            {
                                                rab1.stavka = 5000;
                                                Console.WriteLine("Ваша ставка за день работы: " + rab1.stavka);
                                                Console.WriteLine("Кол-во дней работы");
                                                while (!int.TryParse(Console.ReadLine(), out dni))
                                                {
                                                    Console.WriteLine("Так нельзя");
                                                    dni = Convert.ToInt32(Console.ReadLine());
                                                    while (dni >= 32 || dni <= 0)
                                                    {

                                                        Console.WriteLine("Так нельзя");
                                                        dni = Convert.ToInt32(Console.ReadLine());

                                                    }
                                                }

                                                Console.Clear();
                                            }
                                            Console.WriteLine("Ваша Ставочная зарплата " + (rab1.stavka * dni) + rab1.oklad);
                                            Console.ReadKey();



                                        }
                                        break;
                                    case 1:
                                        {
                                            rab1.stavka = 0;
                                            Console.Clear();
                                            Console.WriteLine("Oклад");
                                            if (rab1.dolznost == "")
                                            {
                                                rab1.oklad = 40000;

                                            }
                                            if (rab1.dolznost == "Кладовщик")
                                            {
                                                rab1.oklad = 80000;
                                            }
                                            if (rab1.dolznost == "Ответственный за территорию")
                                            {
                                                rab1.oklad = 160000;
                                            }
                                            Console.WriteLine("Ваш Оклад за месяц :" + rab1.oklad + rab1.stavka);
                                            Console.ReadKey();
                                        }
                                        break;

                                }
                                menuwhile1 = false;


                            }
                        }

                        break;

                }
                Console.Clear();

                rab1.ZP = (rab1.stavka * dni) + rab1.oklad;
                Console.WriteLine("Вот ваша ЗП за месяц " + rab1.ZP);
                Console.ReadKey();
            }

            rabotka = rab1.dolznost + "||" + rab1.ZP;
        }
        public static void save()
        {
            string path = @"C:\\Users\Lone_Traveler\Desktop\list.txt";


            using (StreamWriter stream = new StreamWriter(path, true))

                stream.WriteLine("ФИО: " + FIO1 + "//" + DDMMGG + "//" + savePol + "//" + pasport1 + "//" + INN1 + "//" + snils1 + "//" + "//" + telefon1 + "//" + telefon2 + "//" + mail1 + "//" + durdom + "//" + rabotka);
            Console.Clear();


        }

        public static void Zap()
        {
            string path1 = @"C:\\Users\Lone_Traveler\Desktop\Zarpl.txt";
            using (StreamReader reader = new StreamReader(path1, true))

                Console.WriteLine(reader.ReadToEnd());
            Console.ReadKey();
            Console.Clear();
        }
    }
}