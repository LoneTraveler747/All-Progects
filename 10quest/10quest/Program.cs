using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp6
{
    class Program
    {
        private static ally[] allies;
        struct FIO
        {
            public string lastname;
            public string firstname;
            public string surname;
        }
        struct Educ
        {
            public string whatEduc;
            public Date whenEduc;
            public string whereEduc;
        }
        struct Job
        {
            public string jobname;
            public string jobsalary;
            public string jobstake;
        }
        struct Passport
        {
            public string passnum;
            public string passserial;
        }
        struct Date
        {
            public string day;
            public string month;
            public string year;
        }
        struct ally
        {
            public FIO fio;
            public Job job;
            public Passport pass;
            public string numEduc;
            public Educ[] educat;
            public Date birthday;
            public string inn;
            public string snilsone;
            public string snilstwo;
            public string truddognum;
        }

        static int cur = 0;
        static int logrole = 5;
        static string accpath = @"D:\users";
        static string infopath = @"D:\info";
        static string operpath = @"D:\operations";
        static string storepath = @"D:\store";
        static string moneypath = @"D:\money";
        static string[] logins;
        static string[] pwords;
        static int[] roles;
        static int gmoney;
        static string login = "";
        static void Admin()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\t\t\t\tАдмин");
                Console.WriteLine("\t\t\t\tЗдесь вы можете создать аккаунт пользователя и присвоить ему роль");
                if (cur < 0) cur = 0;
                if (cur > 2) cur = 2;

                if (cur == 0) Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("Вход");
                Console.ResetColor();

                if (cur == 1) Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("Регистрация");
                Console.ResetColor();

                if (cur == 2) Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("Пользователи");
                Console.ResetColor();

                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.DownArrow) cur++;
                if (key.Key == ConsoleKey.UpArrow) cur--;

                if (key.Key == ConsoleKey.Escape) Login();
                if ((cur == 0) && (key.Key == ConsoleKey.Enter)) Login();
                if ((cur == 1) && (key.Key == ConsoleKey.Enter)) Registration();
                if ((cur == 2) && (key.Key == ConsoleKey.Enter))
                {
                    int num = 0;
                    using (BinaryReader reader = new BinaryReader(new FileStream(accpath, FileMode.Open)))
                    {
                        while (reader.PeekChar() != -1)
                        {
                            reader.ReadString();
                            reader.ReadString();
                            reader.ReadInt32();
                            num++;
                        }
                    }
                    if (num == 0)
                    {
                        Console.WriteLine("Пользователей нет");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Clear();
                        cur = 0;
                        int nomer = 0;
                        using (BinaryReader reader = new BinaryReader(new FileStream(accpath, FileMode.Open)))
                        {
                            while (reader.PeekChar() != -1)
                            {
                                reader.ReadString();
                                reader.ReadString();
                                reader.ReadInt32();
                                nomer++;
                            }
                        }
                        logins = new string[nomer];
                        pwords = new string[nomer];
                        roles = new int[nomer];

                        using (BinaryReader reader = new BinaryReader(new FileStream(accpath, FileMode.Open)))
                        {
                            for (int i = 0; i < nomer; i++)
                            {
                                logins[i] = reader.ReadString();
                                pwords[i] = reader.ReadString();
                                roles[i] = reader.ReadInt32();
                            }
                        }
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("F1 удаление пользователя");
                            if (cur < 0) cur = 0;
                            if (cur > (nomer - 1)) cur = nomer - 1;
                            for (int i = 0; i < nomer; i++)
                            {
                                if (cur == i) Console.BackgroundColor = ConsoleColor.Blue;
                                Console.WriteLine("Пользователь №" + i + " Логин: " + logins[i] + " Пароль: " + pwords[i] + " Роль: " + roles[i]);
                                Console.ResetColor();
                            }
                            ConsoleKeyInfo keyy = Console.ReadKey(true);
                            if (keyy.Key == ConsoleKey.DownArrow) cur++;
                            if (keyy.Key == ConsoleKey.UpArrow) cur--;
                            if (keyy.Key == ConsoleKey.Escape) Admin();
                            if (keyy.Key == ConsoleKey.F1)
                            {
                                int userdel = cur;
                                string del = "";
                                cur = 0;
                                while (true)
                                {
                                    if (cur < 0) cur = 0;
                                    if (cur > 1) cur = 1;

                                    Console.Clear();
                                    Console.WriteLine("Вы уверены, что хотите удалить пользователя №" + userdel + "? (delete)");

                                    if (cur == 0) Console.BackgroundColor = ConsoleColor.Blue;
                                    Console.WriteLine(del);
                                    Console.ResetColor();
                                    if (cur == 1) Console.BackgroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("УДАЛИТЬ");
                                    Console.ResetColor();

                                    ConsoleKeyInfo keyd = Console.ReadKey(true);
                                    if (keyd.Key == ConsoleKey.DownArrow) cur++;
                                    if (keyd.Key == ConsoleKey.UpArrow) cur--;
                                    if (keyd.Key == ConsoleKey.Escape) break;
                                    if ((keyd.KeyChar >= 'a' && keyd.KeyChar <= 'z') && cur == 0)
                                    {
                                        del += keyd.KeyChar;
                                    }
                                    if ((keyd.Key == ConsoleKey.Backspace) && cur == 0)
                                    {
                                        if (del.Length > 0)
                                            del = del.Substring(0, del.Length - 1);
                                    }
                                    if ((keyd.Key == ConsoleKey.Enter && cur == 1) && (del == "delete"))
                                    {
                                        int kol = 0;
                                        Console.Clear();

                                        using (BinaryReader reader = new BinaryReader(new FileStream(@"D:\users", FileMode.Open)))
                                        {
                                            while (reader.PeekChar() != -1)
                                            {
                                                reader.ReadString();
                                                reader.ReadString();
                                                reader.ReadInt32();
                                                kol++;
                                            }
                                        }
                                        using (BinaryReader reader = new BinaryReader(new FileStream(@"D:\users", FileMode.Open)))
                                        {
                                            for (int i = 0; i < kol; i++)
                                            {
                                                logins[i] = reader.ReadString();
                                                pwords[i] = reader.ReadString();
                                                roles[i] = reader.ReadInt32();
                                            }
                                        }
                                        using (BinaryWriter writer = new BinaryWriter(new FileStream(@"D:\users1", FileMode.Create)))
                                        {
                                            for (int i = 0; i < kol; i++)
                                            {
                                                if (logins[i] != logins[userdel])
                                                {
                                                    writer.Write(logins[i]);
                                                    writer.Write(pwords[i]);
                                                    writer.Write(roles[i]);
                                                }
                                            }
                                        }
                                        File.Delete(@"D:\users");
                                        File.Move(@"D:\users1", @"D:\users");

                                        Console.WriteLine("Пользователь удален");
                                        Console.ReadKey();
                                        Admin();
                                    }
                                }
                            }
                        }

                    }
                }

                if (key.Key == ConsoleKey.Escape) Main();
            }
        }

        static void Otdel() //изменить ввод сотрудников, сделать ввод через меню, изменить работу ESC
        {
            int num = 0, educnum = 0;
            cur = 0;
            using (BinaryReader reader = new BinaryReader(new FileStream(accpath, FileMode.Open)))
            {
                while (reader.PeekChar() != -1)
                {
                    reader.ReadString();
                    reader.ReadString();
                    reader.ReadInt32();
                    num++;
                }
            }

            allies = new ally[num];

            while (true)
            {
                Console.Clear();
                Console.WriteLine("\t\t\t\tОтдел кадров");
                if (cur < 0) cur++;
                if (cur > 1) cur--;
                if (cur == 0) Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Добавить пользователя");
                Console.ResetColor();
                if (cur == 1) Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Список");
                Console.ResetColor();

                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.DownArrow) cur++;
                if (key.Key == ConsoleKey.UpArrow) cur--;
                if (key.Key == ConsoleKey.Escape) Login();

                if (key.Key == ConsoleKey.Enter && cur == 0)
                {
                    if (num == 0)
                    {
                        Console.WriteLine("Пользователей нет");
                        Console.ReadKey();
                        Otdel();
                    }

                    int nomer = 0;
                    int kol = 0;
                    int kolobr;
                    using (BinaryReader reader = new BinaryReader(File.Open(infopath, FileMode.Open)))
                    {
                        while (reader.PeekChar() != -1)
                        {
                            reader.Read();
                            reader.Read();
                            reader.Read();
                            reader.Read();
                            reader.Read();
                            kolobr = Convert.ToInt32(reader.Read());
                            for (int i = 0; i < kolobr; i++)
                            {
                                reader.Read();
                                reader.Read();
                                reader.Read();
                                reader.Read();
                                reader.Read();
                            }
                            reader.Read();
                            reader.Read();
                            reader.Read();
                            reader.Read();
                            reader.Read();
                            reader.Read();
                            reader.Read();
                            reader.Read();
                            reader.Read();
                            reader.Read();
                            kol++;
                        }
                    }
                    if (kol > num)
                    {
                        Console.WriteLine("Введены все пользователи");
                        Console.ReadKey();
                        Otdel();
                    }

                    allies[nomer].fio.lastname = "";
                    allies[nomer].fio.firstname = "";
                    allies[nomer].fio.surname = "";
                    allies[nomer].pass.passserial = "";
                    allies[nomer].pass.passnum = "";
                    allies[nomer].numEduc = Convert.ToString(0);
                    allies[nomer].job.jobname = "";
                    allies[nomer].job.jobsalary = "";
                    allies[nomer].job.jobstake = "";
                    allies[nomer].birthday.month = "";
                    allies[nomer].birthday.day = "";
                    allies[nomer].birthday.year = "";
                    allies[nomer].inn = "";
                    allies[nomer].snilsone = "";
                    allies[nomer].snilstwo = "";
                    allies[nomer].truddognum = "";

                    while (true)
                    {
                        if (cur < 0) cur = 0;
                        if (cur > 16) cur = 16;

                        Console.Clear();
                        if (cur == 0) Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Фамилия: " + allies[nomer].fio.lastname);
                        Console.ResetColor();
                        if (cur == 1) Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Имя: " + allies[nomer].fio.firstname);
                        Console.ResetColor();
                        if (cur == 2) Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Отчество: " + allies[nomer].fio.surname);
                        Console.ResetColor();
                        if (cur == 3) Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Серия пасспорта: " + allies[nomer].pass.passserial);
                        Console.ResetColor();
                        if (cur == 4) Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Номер пасспорта: " + allies[nomer].pass.passnum);
                        Console.ResetColor();
                        if (cur == 5) Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Сколько образований: " + allies[nomer].numEduc);
                        Console.ResetColor();



                        if (cur == 6) Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Должность: " + allies[nomer].job.jobname);
                        Console.ResetColor();

                        if (cur == 7) Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Оклад: " + allies[nomer].job.jobsalary);
                        Console.ResetColor();

                        if (cur == 8) Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Ставка: " + allies[nomer].job.jobstake);
                        Console.ResetColor();

                        Console.WriteLine("Дата рождения: ");
                        Console.ResetColor();

                        if (cur == 9) Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Месяц: " + allies[nomer].birthday.month);
                        Console.ResetColor();

                        if (cur == 10) Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("День: " + allies[nomer].birthday.day);
                        Console.ResetColor();

                        if (cur == 11) Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Год: " + allies[nomer].birthday.year);
                        Console.ResetColor();

                        if (cur == 12) Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("ИНН (10 чисел): " + allies[nomer].inn);
                        Console.ResetColor();

                        if (cur == 13) Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("СНИЛС (первые 9 чисел): " + allies[nomer].snilsone);
                        Console.ResetColor();

                        if (cur == 14) Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("СНИЛС (последние 2 числа): " + allies[nomer].snilstwo);
                        Console.ResetColor();

                        if (cur == 15) Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Номер трудового договора: " + allies[nomer].truddognum);
                        Console.ResetColor();
                        Console.WriteLine();
                        if (cur == 16) Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\tДОБАВИТЬ");
                        Console.ResetColor();



                        ConsoleKeyInfo keys = Console.ReadKey(true);
                        if (keys.Key == ConsoleKey.DownArrow) cur++;
                        if (keys.Key == ConsoleKey.UpArrow) cur--;
                        if (keys.Key == ConsoleKey.Escape) Otdel();

                        //---------------------------------------------------------ФИО-------------------------------------------------------------------
                        if (((keys.KeyChar >= 'А' && keys.KeyChar <= 'я') || (keys.KeyChar >= '0' && keys.KeyChar <= '9') || (keys.KeyChar >= 'A' && keys.KeyChar <= 'z')) && cur == 0)
                        {
                            allies[nomer].fio.lastname += keys.KeyChar;
                        }

                        if (keys.Key == ConsoleKey.Backspace && cur == 0)
                        {
                            if (allies[nomer].fio.lastname.Length > 0) allies[nomer].fio.lastname = allies[nomer].fio.lastname.Substring(0, allies[nomer].fio.lastname.Length - 1);
                        }


                        if (((keys.KeyChar >= 'А' && keys.KeyChar <= 'я') || (keys.KeyChar >= '0' && keys.KeyChar <= '9') || (keys.KeyChar >= 'A' && keys.KeyChar <= 'z')) && cur == 1)
                        {
                            allies[nomer].fio.firstname += keys.KeyChar;
                        }

                        if (keys.Key == ConsoleKey.Backspace && cur == 1)
                        {
                            if (allies[nomer].fio.firstname.Length > 0) allies[nomer].fio.firstname = allies[nomer].fio.firstname.Substring(0, allies[nomer].fio.firstname.Length - 1);
                        }

                        if (((keys.KeyChar >= 'А' && keys.KeyChar <= 'я') || (keys.KeyChar >= '0' && keys.KeyChar <= '9')|| (keys.KeyChar >= 'A' && keys.KeyChar <= 'z')) && cur == 2)
                        {
                            allies[nomer].fio.surname += keys.KeyChar;
                        }

                        if (keys.Key == ConsoleKey.Backspace && cur == 2)
                        {
                            if (allies[nomer].fio.surname.Length > 0) allies[nomer].fio.surname = allies[nomer].fio.surname.Substring(0, allies[nomer].fio.surname.Length - 1);
                        }
                        //-------------------------------------------------------ПАСПОРТ-----------------------------------------------------------
                        if ((keys.KeyChar >= '0' && keys.KeyChar <= '9') && cur == 3 && allies[nomer].pass.passserial.Length != 4)
                        {
                            allies[nomer].pass.passserial += keys.KeyChar;
                        }
                        if (keys.Key == ConsoleKey.Backspace && cur == 3)
                        {
                            if (allies[nomer].pass.passserial.Length > 0) allies[nomer].pass.passserial = allies[nomer].pass.passserial.Substring(0, allies[nomer].pass.passserial.Length - 1);
                        }

                        if ((keys.KeyChar >= '0' && keys.KeyChar <= '9') && cur == 4)
                        {
                            if (allies[nomer].pass.passnum.Length != 6) allies[nomer].pass.passnum += keys.KeyChar;
                        }
                        if (keys.Key == ConsoleKey.Backspace && cur == 4)
                        {
                            if (allies[nomer].pass.passnum.Length > 0) allies[nomer].pass.passnum = allies[nomer].pass.passnum.Substring(0, allies[nomer].pass.passnum.Length - 1);
                        }
                        //------------------------------------------------------ОБРАЗОВАНИЕ---------------------------------------------------------------
                        if ((keys.KeyChar >= '0' && keys.KeyChar <= '3') && cur == 5)
                        {
                            allies[nomer].numEduc = Convert.ToString(keys.KeyChar);
                        }

                        if (keys.Key == ConsoleKey.Enter && cur == 5)
                        {
                            allies[nomer].educat = new Educ[Convert.ToInt32(allies[nomer].numEduc)];
                            for (int i = 0; i < Convert.ToInt32(allies[nomer].numEduc); i++)
                            {
                                cur = 0;
                                allies[nomer].educat[i].whatEduc = "";
                                allies[nomer].educat[i].whereEduc = "";
                                allies[nomer].educat[i].whenEduc.month = "";
                                allies[nomer].educat[i].whenEduc.day = "";
                                allies[nomer].educat[i].whenEduc.year = "";
                                while (true)
                                {
                                    Console.Clear();
                                    if (cur < 0) cur = 0;
                                    if (cur > 5) cur = 5;
                                    if (cur == 0) Console.BackgroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("Какое образование: " + allies[nomer].educat[i].whatEduc);
                                    Console.ResetColor();
                                    if (cur == 1) Console.BackgroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("Что закончил: " + allies[nomer].educat[i].whereEduc);
                                    Console.ResetColor();
                                    Console.WriteLine("Когда закончил: ");
                                    Console.ResetColor();
                                    if (cur == 2) Console.BackgroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("Месяц: " + allies[nomer].educat[i].whenEduc.month);
                                    Console.ResetColor();
                                    if (cur == 3) Console.BackgroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("День: " + allies[nomer].educat[i].whenEduc.day);
                                    Console.ResetColor();
                                    if (cur == 4) Console.BackgroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("Год: " + allies[nomer].educat[i].whenEduc.year);
                                    Console.ResetColor();
                                    if (cur == 5) Console.BackgroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("Готово");
                                    Console.ResetColor();

                                    ConsoleKeyInfo keyd = Console.ReadKey(true);
                                    if (keyd.Key == ConsoleKey.DownArrow) cur++;
                                    if (keyd.Key == ConsoleKey.UpArrow) cur--;
                                    if (((keyd.KeyChar >= 'А' && keyd.KeyChar <= 'я') || (keyd.KeyChar >= '0' && keyd.KeyChar <= '9')||(keys.KeyChar >= 'A' && keys.KeyChar <= 'z')) && cur == 0)
                                    {
                                        allies[nomer].educat[i].whatEduc += keyd.KeyChar;
                                    }
                                    if (keyd.Key == ConsoleKey.Backspace && cur == 0)
                                    {
                                        if (allies[nomer].educat[i].whatEduc.Length > 0) allies[nomer].educat[i].whatEduc = allies[nomer].educat[i].whatEduc.Substring(0, allies[nomer].educat[i].whatEduc.Length - 1);
                                    }

                                    if (((keyd.KeyChar >= 'А' && keyd.KeyChar <= 'я') || (keyd.KeyChar >= '0' && keyd.KeyChar <= '9') || (keys.KeyChar >= 'A' && keys.KeyChar <= 'z')) && cur == 1)
                                    {
                                        allies[nomer].educat[i].whereEduc += keyd.KeyChar;
                                    }
                                    if (keyd.Key == ConsoleKey.Backspace && cur == 1)
                                    {
                                        if (allies[nomer].educat[i].whereEduc.Length > 0) allies[nomer].educat[i].whereEduc = allies[nomer].educat[i].whereEduc.Substring(0, allies[nomer].educat[i].whereEduc.Length - 1);
                                    }

                                    if ((keyd.KeyChar >= '0' && keyd.KeyChar <= '9') && cur == 2 && allies[nomer].educat[i].whenEduc.month.Length != 2)
                                    {
                                        allies[nomer].educat[i].whenEduc.month += keyd.KeyChar;
                                    }
                                    if (keyd.Key == ConsoleKey.Backspace && cur == 2)
                                    {
                                        if (allies[nomer].educat[i].whenEduc.month.Length > 0) allies[nomer].educat[i].whenEduc.month = allies[nomer].educat[i].whenEduc.month.Substring(0, allies[nomer].educat[i].whenEduc.month.Length - 1);
                                    }

                                    if ((keyd.KeyChar >= '0' && keyd.KeyChar <= '9') && cur == 3 && allies[nomer].educat[i].whenEduc.day.Length != 2)
                                    {
                                        allies[nomer].educat[i].whenEduc.day += keyd.KeyChar;
                                    }
                                    if (keyd.Key == ConsoleKey.Backspace && cur == 3)
                                    {
                                        if (allies[nomer].educat[i].whenEduc.day.Length > 0) allies[nomer].educat[i].whenEduc.day = allies[nomer].educat[i].whenEduc.day.Substring(0, allies[nomer].educat[i].whenEduc.day.Length - 1);
                                    }

                                    if ((keyd.KeyChar >= '0' && keyd.KeyChar <= '9') && cur == 4 && allies[nomer].educat[i].whenEduc.year.Length != 4)
                                    {
                                        allies[nomer].educat[i].whenEduc.year += keyd.KeyChar;
                                    }
                                    if (keyd.Key == ConsoleKey.Backspace && cur == 4)
                                    {
                                        if (allies[nomer].educat[i].whenEduc.year.Length > 0) allies[nomer].educat[i].whenEduc.year = allies[nomer].educat[i].whenEduc.year.Substring(0, allies[nomer].educat[i].whenEduc.year.Length - 1);
                                    }
                                    if (keyd.Key == ConsoleKey.Enter && cur == 5)
                                        if (allies[nomer].educat[i].whatEduc == "" || allies[nomer].educat[i].whereEduc == "" || !int.TryParse(allies[nomer].educat[i].whenEduc.month, out _) || !int.TryParse(allies[nomer].educat[i].whenEduc.day, out _) || !int.TryParse(allies[nomer].educat[i].whenEduc.year, out _) || (Convert.ToInt32(allies[nomer].educat[i].whenEduc.month) < 1 || Convert.ToInt32(allies[nomer].educat[i].whenEduc.month) > 12) || (Convert.ToInt32(allies[nomer].educat[i].whenEduc.day) < 1 || Convert.ToInt32(allies[nomer].educat[i].whenEduc.day) > 31) || (Convert.ToInt32(allies[nomer].educat[i].whenEduc.year) < 1900 || Convert.ToInt32(allies[nomer].educat[i].whenEduc.year) > 2019))
                                        {
                                            Console.WriteLine("Ошибка в образовании");
                                            Console.ReadKey();
                                        }
                                        else
                                        {
                                            educnum++;
                                            break;
                                        }
                                }
                            }
                        }
                        //---------------------------------------------------------ДОЛЖНОСТЬ-------------------------------------------------------------------
                        if (((keys.KeyChar >= 'А' && keys.KeyChar <= 'я') || (keys.KeyChar >= '0' && keys.KeyChar <= '9')|| (keys.KeyChar >= 'A' && keys.KeyChar <= 'z')) && cur == 6)
                        {
                            allies[nomer].job.jobname += keys.KeyChar;
                        }
                        if (keys.Key == ConsoleKey.Backspace && cur == 6)
                        {
                            if (allies[nomer].job.jobname.Length > 0) allies[nomer].job.jobname = allies[nomer].job.jobname.Substring(0, allies[nomer].job.jobname.Length - 1);
                        }

                        if ((keys.KeyChar >= '0' && keys.KeyChar <= '9') && cur == 7)
                        {
                            allies[nomer].job.jobsalary += keys.KeyChar;
                        }
                        if (keys.Key == ConsoleKey.Backspace && cur == 7)
                        {
                            if (allies[nomer].job.jobsalary.Length > 0) allies[nomer].job.jobsalary = allies[nomer].job.jobsalary.Substring(0, allies[nomer].job.jobsalary.Length - 1);
                        }

                        if ((keys.KeyChar >= '0' && keys.KeyChar <= '9') && cur == 8)
                        {
                            allies[nomer].job.jobstake += keys.KeyChar;
                        }
                        if (keys.Key == ConsoleKey.Backspace && cur == 8)
                        {
                            if (allies[nomer].job.jobstake.Length > 0) allies[nomer].job.jobstake = allies[nomer].job.jobstake.Substring(0, allies[nomer].job.jobstake.Length - 1);
                        }
                        //---------------------------------------------------------ДАТА-РОЖДЕНИЯ-----------------------------------------------------------------
                        if ((keys.KeyChar >= '0' && keys.KeyChar <= '9') && cur == 9 && allies[nomer].birthday.month.Length != 2)
                        {
                            allies[nomer].birthday.month += keys.KeyChar;
                        }
                        if (keys.Key == ConsoleKey.Backspace && cur == 9)
                        {
                            if (allies[nomer].birthday.month.Length > 0) allies[nomer].birthday.month = allies[nomer].birthday.month.Substring(0, allies[nomer].birthday.month.Length - 1);
                        }

                        if ((keys.KeyChar >= '0' && keys.KeyChar <= '9') && cur == 10 && allies[nomer].birthday.day.Length != 2)
                        {
                            allies[nomer].birthday.day += keys.KeyChar;
                        }
                        if (keys.Key == ConsoleKey.Backspace && cur == 10)
                        {
                            if (allies[nomer].birthday.day.Length > 0) allies[nomer].birthday.day = allies[nomer].birthday.day.Substring(0, allies[nomer].birthday.day.Length - 1);
                        }

                        if ((keys.KeyChar >= '0' && keys.KeyChar <= '9') && cur == 11 && allies[nomer].birthday.year.Length != 4)
                        {
                            allies[nomer].birthday.year += keys.KeyChar;
                        }
                        if (keys.Key == ConsoleKey.Backspace && cur == 11)
                        {
                            if (allies[nomer].birthday.year.Length > 0) allies[nomer].birthday.year = allies[nomer].birthday.year.Substring(0, allies[nomer].birthday.year.Length - 1);
                        }
                        //----------------------------------------------------ИНН-СНИЛС-ТРУДОВОЙ-ДОГОВОР--------------------------------------------------------
                        if ((keys.KeyChar >= '0' && keys.KeyChar <= '9') && cur == 12 && allies[nomer].inn.Length != 10)
                        {
                            allies[nomer].inn += keys.KeyChar;
                        }
                        if (keys.Key == ConsoleKey.Backspace && cur == 12)
                        {
                            if (allies[nomer].inn.Length > 0) allies[nomer].inn = allies[nomer].inn.Substring(0, allies[nomer].inn.Length - 1);
                        }

                        if ((keys.KeyChar >= '0' && keys.KeyChar <= '9') && cur == 13 && allies[nomer].snilsone.Length != 9)
                        {
                            allies[nomer].snilsone += keys.KeyChar;
                        }
                        if (keys.Key == ConsoleKey.Backspace && cur == 13)
                        {
                            if (allies[nomer].snilsone.Length > 0) allies[nomer].snilsone = allies[nomer].snilsone.Substring(0, allies[nomer].snilsone.Length - 1);
                        }

                        if ((keys.KeyChar >= '0' && keys.KeyChar <= '9') && cur == 14 && allies[nomer].snilstwo.Length != 2)
                        {
                            allies[nomer].snilstwo += keys.KeyChar;
                        }
                        if (keys.Key == ConsoleKey.Backspace && cur == 14)
                        {
                            if (allies[nomer].snilstwo.Length > 0) allies[nomer].snilstwo = allies[nomer].snilstwo.Substring(0, allies[nomer].snilstwo.Length - 1);
                        }

                        if ((keys.KeyChar >= '0' && keys.KeyChar <= '9') && cur == 15 && allies[nomer].truddognum.Length != 10)
                        {
                            allies[nomer].truddognum += keys.KeyChar;
                        }
                        if (keys.Key == ConsoleKey.Backspace && cur == 15)
                        {
                            if (allies[nomer].truddognum.Length > 0) allies[nomer].truddognum = allies[nomer].truddognum.Substring(0, allies[nomer].truddognum.Length - 1);
                        }
                        //---------------------------------------------------------------------------------------------------------------------------------------------

                        if (keys.Key == ConsoleKey.Enter && cur == 16)
                        {
                            if (allies[nomer].fio.lastname == "" || allies[nomer].fio.firstname == "" || allies[nomer].fio.surname == "")
                            {
                                Console.WriteLine("Неправильное ФИО");
                            }
                            else if (allies[nomer].pass.passserial.Length != 4 || allies[nomer].pass.passnum.Length != 6)
                            {
                                Console.WriteLine("Не корректный паспорт");
                            }
                            else if (educnum < Convert.ToInt32(allies[nomer].numEduc) || Convert.ToInt32(allies[nomer].numEduc) == 0)
                            {
                                Console.WriteLine("Не выбранно образование");
                            }
                            else if (allies[nomer].job.jobname == "" || !int.TryParse(allies[nomer].job.jobsalary, out _) || Convert.ToInt32(allies[nomer].job.jobsalary) == 0 || !int.TryParse(allies[nomer].job.jobstake, out _) || Convert.ToInt32(allies[nomer].job.jobstake) == 0)
                            {
                                Console.WriteLine("Ведите место работы корректней");
                            }
                            else if (!int.TryParse(allies[nomer].birthday.month, out _) || Convert.ToInt32(allies[nomer].birthday.month) < 1 || Convert.ToInt32(allies[nomer].birthday.month) > 12 || !int.TryParse(allies[nomer].birthday.day, out _) || Convert.ToInt32(allies[nomer].birthday.day) < 1 || Convert.ToInt32(allies[nomer].birthday.day) > 31 || !int.TryParse(allies[nomer].birthday.year, out _) || Convert.ToInt32(allies[nomer].birthday.year) < 1916 || Convert.ToInt32(allies[nomer].birthday.year) > 2019)
                            {
                                Console.WriteLine("Ввдеите правильную дату рождения");
                            }
                            else if (allies[nomer].inn.Length != 12 || Convert.ToInt64(allies[nomer].inn) == 0)
                            {
                                Console.WriteLine("Не правильный ИНН (12 чисел)");
                            }
                            else if (allies[nomer].snilsone.Length != 10 || allies[nomer].snilstwo.Length != 2 || Convert.ToInt32(allies[nomer].snilsone) == 0 || Convert.ToInt32(allies[nomer].snilstwo) == 0)
                            {
                                Console.WriteLine("Не правильный СНИЛС (10 чисел)");
                            }
                            else if (!int.TryParse(allies[nomer].truddognum, out _) || Convert.ToInt32(allies[nomer].truddognum) == 0)
                            {
                                Console.WriteLine("Не правильный трудовой договор");
                            }
                            else
                            {
                                using (BinaryWriter writer = new BinaryWriter(File.Open(infopath, FileMode.Append)))
                                {
                                    writer.Write(allies[nomer].fio.lastname);
                                    writer.Write(allies[nomer].fio.firstname);
                                    writer.Write(allies[nomer].fio.surname);
                                    writer.Write(allies[nomer].pass.passserial);
                                    writer.Write(allies[nomer].pass.passnum);
                                    writer.Write(allies[nomer].numEduc);
                                    for (int i = 0; i < Convert.ToInt32(allies[nomer].numEduc); i++)
                                    {
                                        writer.Write(allies[nomer].educat[i].whatEduc);
                                        writer.Write(allies[nomer].educat[i].whereEduc);
                                        writer.Write(allies[nomer].educat[i].whenEduc.month);
                                        writer.Write(allies[nomer].educat[i].whenEduc.day);
                                        writer.Write(allies[nomer].educat[i].whenEduc.year);
                                    }
                                    writer.Write(allies[nomer].job.jobname);
                                    writer.Write(allies[nomer].job.jobsalary);
                                    writer.Write(allies[nomer].job.jobstake);
                                    writer.Write(allies[nomer].birthday.month);
                                    writer.Write(allies[nomer].birthday.day);
                                    writer.Write(allies[nomer].birthday.year);
                                    writer.Write(allies[nomer].inn);
                                    writer.Write(allies[nomer].snilsone);
                                    writer.Write(allies[nomer].snilstwo);
                                    writer.Write(allies[nomer].truddognum);
                                }
                                Otdel();
                            }
                            Console.ReadKey();
                        }
                    }
                }

                if (key.Key == ConsoleKey.Enter && cur == 1)
                {
                    cur = 0;
                    if (num == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Пользователи не найдены");
                        Console.ReadKey();
                    }
                    else
                    {
                        int nomer = 0;
                        using (BinaryReader reader = new BinaryReader(File.Open(infopath, FileMode.Open)))
                        {
                            while (reader.PeekChar() != -1)
                            {
                                allies[nomer].fio.lastname = reader.ReadString();
                                allies[nomer].fio.firstname = reader.ReadString();
                                allies[nomer].fio.surname = reader.ReadString();
                                allies[nomer].pass.passserial = reader.ReadString();
                                allies[nomer].pass.passnum = reader.ReadString();
                                allies[nomer].numEduc = reader.ReadString();
                                allies[nomer].educat = new Educ[Convert.ToInt32(allies[nomer].numEduc)];

                                for (int i = 0; i < Convert.ToInt32(allies[nomer].numEduc); i++)
                                {
                                    allies[nomer].educat[i].whatEduc = reader.ReadString();
                                    allies[nomer].educat[i].whereEduc = reader.ReadString();
                                    allies[nomer].educat[i].whenEduc.month = reader.ReadString();
                                    allies[nomer].educat[i].whenEduc.day = reader.ReadString();
                                    allies[nomer].educat[i].whenEduc.year = reader.ReadString();
                                }
                                allies[nomer].job.jobname = reader.ReadString();
                                allies[nomer].job.jobsalary = reader.ReadString();
                                allies[nomer].job.jobstake = reader.ReadString();
                                allies[nomer].birthday.month = reader.ReadString();
                                allies[nomer].birthday.day = reader.ReadString();
                                allies[nomer].birthday.year = reader.ReadString();
                                allies[nomer].inn = reader.ReadString();
                                allies[nomer].snilsone = reader.ReadString();
                                allies[nomer].snilstwo = reader.ReadString();
                                allies[nomer].truddognum = reader.ReadString();
                                nomer++;
                            }
                        }
                        if (nomer == 0)
                        {
                            Console.WriteLine("Нет информации о сотрудниках");
                            Console.ReadKey();
                        }
                        else
                        {
                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("F1 - удаление пользователя");
                                if (cur < 0) cur = 0;
                                if (cur > (nomer - 1)) cur = nomer - 1;
                                for (int i = 0; i < nomer; i++)
                                {
                                    if (cur == i) Console.BackgroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("Сотрудник №" + i + " Фамилия сотрудника: " + allies[i].fio.lastname + " Имя сотрудника: " + allies[i].fio.firstname + " Отчество сотрудника: " + allies[i].fio.surname);
                                    Console.ResetColor();
                                }
                                ConsoleKeyInfo keyy = Console.ReadKey(true);
                                if (keyy.Key == ConsoleKey.DownArrow) cur++;
                                if (keyy.Key == ConsoleKey.UpArrow) cur--;
                                if (keyy.Key == ConsoleKey.Escape) Otdel();
                                if (keyy.Key == ConsoleKey.Enter)
                                {
                                    Console.Clear();
                                    int i = cur;
                                    Console.WriteLine("\tСотрудник №" + i);
                                    Console.WriteLine("Фамилия сотрудника: " + allies[i].fio.lastname);
                                    Console.WriteLine("Имя сотрудника: " + allies[i].fio.firstname);
                                    Console.WriteLine("Отчество сотрудника: " + allies[i].fio.surname);
                                    Console.WriteLine("Паспорт сотрудника: " + allies[i].pass.passserial + " " + allies[i].pass.passnum);
                                    Console.WriteLine("Количество образований: " + allies[i].numEduc);
                                    Console.WriteLine("Какое образование: ");
                                    for (int q = 0; q < Convert.ToInt32(allies[i].numEduc); q++)
                                    {
                                        Console.WriteLine((q + 1) + "." + allies[i].educat[q].whatEduc);
                                    }
                                    Console.WriteLine("Место окончания учебы: ");
                                    for (int q = 0; q < Convert.ToInt32(allies[i].numEduc); q++)
                                    {
                                        Console.WriteLine((q + 1) + "." + allies[i].educat[q].whereEduc);
                                    }
                                    Console.WriteLine("Дата окончания учебы: ");
                                    for (int q = 0; q < Convert.ToInt32(allies[i].numEduc); q++)
                                    {
                                        Console.WriteLine((q + 1) + "." + "Дата: " + allies[i].educat[q].whenEduc.day + "." + allies[i].educat[q].whenEduc.month + "." + allies[i].educat[q].whenEduc.year);
                                    }
                                    Console.WriteLine("Должность: " + allies[i].job.jobname);
                                    Console.WriteLine("Оклад: " + allies[i].job.jobsalary);
                                    Console.WriteLine("Ставка: " + allies[i].job.jobstake);
                                    Console.WriteLine("Дата рождения: " + allies[i].birthday.day + "." + allies[i].birthday.month + "." + allies[i].birthday.year);
                                    Console.WriteLine("ИНН:" + allies[i].inn);
                                    Console.WriteLine("СНИЛС:" + allies[i].snilsone + " " + allies[i].snilstwo);
                                    Console.WriteLine("Номер трудового договора: " + allies[i].truddognum);
                                    Console.ReadKey();
                                }
                                if (keyy.Key == ConsoleKey.F1)
                                {
                                    int infodel = cur;
                                    string del = "";
                                    cur = 0;
                                    while (true)
                                    {
                                        if (cur < 0) cur = 0;
                                        if (cur > 1) cur = 1;

                                        Console.Clear();
                                        Console.WriteLine("Вы уверены, что хотите удалить пользователя №" + infodel + "? (для удаления напишите delete)");

                                        if (cur == 0) Console.BackgroundColor = ConsoleColor.Blue;
                                        Console.WriteLine(del);
                                        Console.ResetColor();
                                        if (cur == 1) Console.BackgroundColor = ConsoleColor.Blue;
                                        Console.WriteLine("УДАЛИТЬ");
                                        Console.ResetColor();

                                        ConsoleKeyInfo keyd = Console.ReadKey(true);
                                        if (keyd.Key == ConsoleKey.DownArrow) cur++;
                                        if (keyd.Key == ConsoleKey.UpArrow) cur--;
                                        if (keyd.Key == ConsoleKey.Escape) Otdel();

                                        if ((keyd.KeyChar >= 'a' && keyd.KeyChar <= 'z') && cur == 0)
                                        {
                                            del += keyd.KeyChar;
                                        }

                                        if ((keyd.Key == ConsoleKey.Backspace) && cur == 0)
                                        {
                                            if (del.Length > 0)
                                                del = del.Substring(0, del.Length - 1);
                                        }
                                        if (keyd.Key == ConsoleKey.Escape) break;
                                        if ((keyd.Key == ConsoleKey.Enter && cur == 1) && (del == "delete"))
                                        {
                                            int kol = 0, kolobr;
                                            Console.Clear();

                                            using (BinaryReader reader = new BinaryReader(new FileStream(@"D:\info", FileMode.Open)))
                                            {
                                                while (reader.PeekChar() != -1)
                                                {
                                                    reader.ReadString();
                                                    reader.ReadString();
                                                    reader.ReadString();
                                                    reader.ReadString();
                                                    reader.ReadString();
                                                    kolobr = Convert.ToInt32(reader.ReadString());
                                                    for (int i = 0; i < kolobr; i++)
                                                    {
                                                        reader.ReadString();
                                                        reader.ReadString();
                                                        reader.ReadString();
                                                        reader.ReadString();
                                                        reader.ReadString();
                                                    }
                                                    reader.ReadString();
                                                    reader.ReadString();
                                                    reader.ReadString();
                                                    reader.ReadString();
                                                    reader.ReadString();
                                                    reader.ReadString();
                                                    reader.ReadString();
                                                    reader.ReadString();
                                                    reader.ReadString();
                                                    reader.ReadString();
                                                    kol++;
                                                }
                                            }

                                            using (BinaryReader reader = new BinaryReader(new FileStream(@"D:\info", FileMode.Open)))
                                            {
                                                for (int z = 0; z < kol; z++)
                                                {
                                                    allies[z].fio.lastname = reader.ReadString();
                                                    allies[z].fio.firstname = reader.ReadString();
                                                    allies[z].fio.surname = reader.ReadString();
                                                    allies[z].pass.passserial = reader.ReadString();
                                                    allies[z].pass.passnum = reader.ReadString();
                                                    allies[z].numEduc = reader.ReadString();
                                                    allies[z].educat = new Educ[Convert.ToInt32(allies[z].numEduc)];

                                                    for (int i = 0; i < Convert.ToInt32(allies[z].numEduc); i++)
                                                    {
                                                        allies[z].educat[i].whatEduc = reader.ReadString();
                                                        allies[z].educat[i].whereEduc = reader.ReadString();
                                                        allies[z].educat[i].whenEduc.month = reader.ReadString();
                                                        allies[z].educat[i].whenEduc.day = reader.ReadString();
                                                        allies[z].educat[i].whenEduc.year = reader.ReadString();
                                                    }
                                                    allies[z].job.jobname = reader.ReadString();
                                                    allies[z].job.jobsalary = reader.ReadString();
                                                    allies[z].job.jobstake = reader.ReadString();
                                                    allies[z].birthday.month = reader.ReadString();
                                                    allies[z].birthday.day = reader.ReadString();
                                                    allies[z].birthday.year = reader.ReadString();
                                                    allies[z].inn = reader.ReadString();
                                                    allies[z].snilsone = reader.ReadString();
                                                    allies[z].snilstwo = reader.ReadString();
                                                    allies[z].truddognum = reader.ReadString();
                                                }
                                            }

                                            using (BinaryWriter writer = new BinaryWriter(new FileStream(@"D:\info1", FileMode.Create)))
                                            {
                                                for (int i = 0; i < kol; i++)
                                                {
                                                    if (allies[i].fio.lastname != allies[infodel].fio.lastname)
                                                    {
                                                        writer.Write(allies[i].fio.lastname);
                                                        writer.Write(allies[i].fio.firstname);
                                                        writer.Write(allies[i].fio.surname);
                                                        writer.Write(allies[i].pass.passserial);
                                                        writer.Write(allies[i].pass.passnum);
                                                        writer.Write(allies[i].numEduc);

                                                        for (int z = 0; z < Convert.ToInt32(allies[i].numEduc); z++)
                                                        {
                                                            writer.Write(allies[i].educat[z].whatEduc);
                                                            writer.Write(allies[i].educat[z].whereEduc);
                                                            writer.Write(allies[i].educat[z].whenEduc.month);
                                                            writer.Write(allies[i].educat[z].whenEduc.day);
                                                            writer.Write(allies[i].educat[z].whenEduc.year);
                                                        }
                                                        writer.Write(allies[i].job.jobname);
                                                        writer.Write(allies[i].job.jobsalary);
                                                        writer.Write(allies[i].job.jobstake);
                                                        writer.Write(allies[i].birthday.month);
                                                        writer.Write(allies[i].birthday.day);
                                                        writer.Write(allies[i].birthday.year);
                                                        writer.Write(allies[i].inn);
                                                        writer.Write(allies[i].snilsone);
                                                        writer.Write(allies[i].snilstwo);
                                                        writer.Write(allies[i].truddognum);
                                                    }
                                                }
                                            }
                                            File.Delete(@"D:\info");
                                            File.Move(@"D:\info1", @"D:\info");

                                            Console.WriteLine("Сотрудник удален");
                                            Console.ReadKey();
                                            Otdel();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }



        static void Buhgal()  //что за операция, дата и время, сумма 
        {
            cur = 0;
            string[] arroper;
            string[] arrsumm;
            string[] arrtime;
            int dmoney = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("\t\t\t\tБухгалтерия");
                if (cur < 0) cur = 0;
                if (cur > 2) cur = 2;

                if (cur == 0) Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("Ввод операции");
                Console.ResetColor();


                if (cur == 1) Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("Просмотр операций");
                Console.ResetColor();

                ConsoleKeyInfo key1 = Console.ReadKey(true);
                if (key1.Key == ConsoleKey.DownArrow) cur++;
                if (key1.Key == ConsoleKey.UpArrow) cur--;
                if (key1.Key == ConsoleKey.Escape) Login();

                if (key1.Key == ConsoleKey.Enter && cur == 0)
                {
                    string oper = "", summ = "";
                    while (true)
                    {
                        Console.Clear();

                        if (cur < 0) cur = 0;
                        if (cur > 2) cur = 2;

                        if (cur == 0) Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Операция: " + oper);
                        Console.ResetColor();


                        if (cur == 1) Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Сумма: " + summ);
                        Console.ResetColor();

                        if (cur == 2) Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Ввести");
                        Console.ResetColor();

                        ConsoleKeyInfo key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.DownArrow) cur++;
                        if (key.Key == ConsoleKey.UpArrow) cur--;
                        if (key.Key == ConsoleKey.Escape) Buhgal();

                        if (((key.KeyChar >= 'а' && key.KeyChar <= 'я') || (key.KeyChar >= 'А' && key.KeyChar <= 'Я')) && cur == 0)
                        {
                            oper += key.KeyChar;
                        }
                        if (key.Key == ConsoleKey.Backspace && cur == 0)
                        {
                            if (oper.Length > 0)
                                oper = oper.Substring(0, oper.Length - 1);
                        }

                        if (((key.KeyChar >= '-') || (key.KeyChar >= '0' && key.KeyChar <= '9')) && cur == 1)
                        {
                            summ += key.KeyChar;
                        }
                        if (key.Key == ConsoleKey.Backspace && cur == 1)
                        {
                            if (summ.Length > 0)
                                summ = summ.Substring(0, summ.Length - 1);
                        }

                        if (key.Key == ConsoleKey.Enter && cur == 2)
                        {
                            Console.Clear();
                            if (summ == "" || oper == "" || !int.TryParse(summ, out _) || Convert.ToInt32(summ) == 0)
                            {
                                Console.WriteLine("Операция введена неправильно");
                                Console.ReadKey();
                            }
                            else
                            {
                                using (BinaryWriter writer = new BinaryWriter(new FileStream(operpath, FileMode.Append)))
                                {
                                    writer.Write(oper);
                                    writer.Write(summ);
                                    writer.Write(Convert.ToString(DateTime.Now));
                                }

                                gmoney += Convert.ToInt32(summ);
                                using (BinaryWriter writer = new BinaryWriter(new FileStream(moneypath, FileMode.Open)))
                                {
                                    writer.Write(gmoney);
                                }
                                Buhgal();
                            }
                        }
                    }
                }

                if (key1.Key == ConsoleKey.Enter && cur == 1)
                {
                    cur = 0;
                    Console.Clear();
                    int kol = 0;
                    using (BinaryReader reader = new BinaryReader(new FileStream(operpath, FileMode.Open)))
                    {
                        while (reader.PeekChar() != -1)
                        {
                            reader.ReadString();
                            reader.ReadString();
                            reader.ReadString();
                            kol++;
                        }
                    }
                    if (kol == 0)
                    {
                        Console.WriteLine("Операций нет");
                        Console.ReadKey();
                    }
                    else
                    {
                        cur = 0;
                        arroper = new string[kol];
                        arrsumm = new string[kol];
                        arrtime = new string[kol];

                        using (BinaryReader reader = new BinaryReader(new FileStream(operpath, FileMode.Open)))
                        {
                            for (int i = 0; i < kol; i++)
                            {
                                arroper[i] = reader.ReadString();
                                arrsumm[i] = reader.ReadString();
                                arrtime[i] = reader.ReadString();
                            }
                        }
                        Money();
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("Всего денег: " + gmoney + "(F1 - удалить)");
                            if (cur < 0) cur = 0;
                            if (cur > (kol - 1)) cur = kol - 1;
                            for (int i = 0; i < kol; i++)
                            {
                                if (cur == i) Console.BackgroundColor = ConsoleColor.Blue;
                                Console.WriteLine("Операция: " + arroper[i] + " Сумма: " + arrsumm[i] + " Время: " + arrtime[i]);
                                Console.ResetColor();
                            }
                            ConsoleKeyInfo keyy = Console.ReadKey(true);
                            if (keyy.Key == ConsoleKey.DownArrow) cur++;
                            if (keyy.Key == ConsoleKey.UpArrow) cur--;
                            if (keyy.Key == ConsoleKey.Escape) Buhgal();
                            if (keyy.Key == ConsoleKey.F1)
                            {

                                int operdel = cur;
                                string del = "";
                                cur = 0;
                                while (true)
                                {
                                    if (cur < 0) cur = 0;
                                    if (cur > 1) cur = 1;

                                    Console.Clear();
                                    Console.WriteLine("Вы уверены, что хотите удалить операцию: '" + arroper[operdel] + "'? (delete)");

                                    if (cur == 0) Console.BackgroundColor = ConsoleColor.Blue;
                                    Console.WriteLine(del);
                                    Console.ResetColor();
                                    if (cur == 1) Console.BackgroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("УДАЛИТЬ");
                                    Console.ResetColor();

                                    ConsoleKeyInfo keyd = Console.ReadKey(true);
                                    if (keyd.Key == ConsoleKey.DownArrow) cur++;
                                    if (keyd.Key == ConsoleKey.UpArrow) cur--;
                                    if (keyd.Key == ConsoleKey.Escape) Buhgal();

                                    if ((keyd.KeyChar >= 'a' && keyd.KeyChar <= 'z') && cur == 0)
                                    {
                                        del += keyd.KeyChar;
                                    }
                                    if ((keyd.Key == ConsoleKey.Backspace) && cur == 0)
                                    {
                                        if (del.Length > 0)
                                            del = del.Substring(0, del.Length - 1);
                                    }
                                    if ((keyd.Key == ConsoleKey.Enter && cur == 1) && (del == "delete"))
                                    {
                                        Console.Clear();

                                        gmoney = gmoney - Convert.ToInt32(arrsumm[operdel]);
                                        using (BinaryWriter writer = new BinaryWriter(new FileStream(moneypath, FileMode.Open)))
                                        {
                                            writer.Write(gmoney);
                                        }
                                        using (BinaryWriter writer = new BinaryWriter(new FileStream(@"D:\operations1", FileMode.Create)))
                                        {
                                            for (int i = 0; i < kol; i++)
                                            {
                                                if (arroper[i] != arroper[operdel])
                                                {
                                                    writer.Write(arroper[i]);
                                                    writer.Write(arrsumm[i]);
                                                    writer.Write(arrtime[i]);
                                                }
                                            }
                                        }
                                        File.Delete(@"D:\operations");
                                        File.Move(@"D:\operations1", @"D:\operations");

                                        Console.WriteLine("Операция удалена");
                                        Console.ReadKey();
                                        Buhgal();
                                    }
                                }
                            }
                        }
                    }
                }

                if (key1.Key == ConsoleKey.Enter && cur == 2)
                {
                    Console.Clear();
                    int kol = 0;
                    using (BinaryReader reader = new BinaryReader(new FileStream(operpath, FileMode.Open)))
                    {
                        while (reader.PeekChar() != -1)
                        {
                            reader.ReadString();
                            reader.ReadString();
                            reader.ReadString();
                            kol++;
                        }
                    }
                    arroper = new string[kol];
                    arrsumm = new string[kol];
                    arrtime = new string[kol];
                    if (kol == 0)
                    {
                        Console.WriteLine("Операций нет");
                        Console.ReadKey();
                        Buhgal();
                    }
                    else
                    {
                        cur = 0;

                        using (BinaryReader reader = new BinaryReader(new FileStream(operpath, FileMode.Open)))
                        {
                            for (int i = 0; i < kol; i++)
                            {
                                arroper[i] = reader.ReadString();
                                arrsumm[i] = reader.ReadString();
                                arrtime[i] = reader.ReadString();
                                dmoney += Convert.ToInt32(arrsumm[i]);
                            }
                        }
                    }
                }
            }
        }
        static void Sklad()  //код товара, название, количество(меняется), стоимость
        {
            cur = 0;
            string[] tovid;
            string[] tovname;
            string[] tovprice;
            int[] tovnum;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\t\t\t\tСклад");
                if (cur < 0) cur = 0;
                if (cur > 1) cur = 1;

                if (cur == 0) Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("Ввод товара");
                Console.ResetColor();


                if (cur == 1) Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("Просмотр склада");
                Console.ResetColor();

                ConsoleKeyInfo key1 = Console.ReadKey(true);
                if (key1.Key == ConsoleKey.DownArrow) cur++;
                if (key1.Key == ConsoleKey.UpArrow) cur--;
                if (key1.Key == ConsoleKey.Escape) Login();

                if (key1.Key == ConsoleKey.Enter && cur == 0)
                {
                    string name = "", price = "", id = "", numberstr = "";

                    while (true)
                    {
                        Console.Clear();

                        if (cur < 0) cur = 0;
                        if (cur > 4) cur = 4;

                        if (cur == 0) Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("ID: " + id);
                        Console.ResetColor();


                        if (cur == 1) Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Имя: " + name);
                        Console.ResetColor();

                        if (cur == 2) Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Цена: " + price);
                        Console.ResetColor();

                        if (cur == 3) Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Количество: " + numberstr);
                        Console.ResetColor();

                        if (cur == 4) Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Ввести");
                        Console.ResetColor();

                        ConsoleKeyInfo key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.DownArrow) cur++;
                        if (key.Key == ConsoleKey.UpArrow) cur--;
                        if (key.Key == ConsoleKey.Escape) Sklad();

                        if (((key.KeyChar >= '0' && key.KeyChar <= '9')) && cur == 0)
                        {
                            id += key.KeyChar;
                        }
                        if (key.Key == ConsoleKey.Backspace && cur == 0)
                        {
                            if (id.Length > 0)
                                id = id.Substring(0, id.Length - 1);
                        }

                        if (((key.KeyChar >= 'а' && key.KeyChar <= 'я') || (key.KeyChar >= 'А' && key.KeyChar <= 'Я')) && cur == 1)
                        {
                            name += key.KeyChar;
                        }
                        if (key.Key == ConsoleKey.Backspace && cur == 1)
                        {
                            if (name.Length > 0)
                                name = name.Substring(0, name.Length - 1);
                        }

                        if (((key.KeyChar >= '0' && key.KeyChar <= '9')) && cur == 2)
                        {
                            price += key.KeyChar;
                        }
                        if (key.Key == ConsoleKey.Backspace && cur == 2)
                        {
                            if (price.Length > 0)
                                price = price.Substring(0, price.Length - 1);
                        }

                        if (((key.KeyChar >= '0' && key.KeyChar <= '9')) && cur == 3)
                        {
                            numberstr += key.KeyChar;
                        }
                        if (key.Key == ConsoleKey.Backspace && cur == 3)
                        {
                            if (numberstr.Length > 0)
                                numberstr = numberstr.Substring(0, numberstr.Length - 1);
                        }

                        if (key.Key == ConsoleKey.Enter && cur == 4)
                        {
                            int kol = 0;
                            using (BinaryReader reader = new BinaryReader(new FileStream(storepath, FileMode.Open)))
                            {
                                while (reader.PeekChar() != -1)
                                {
                                    reader.ReadString();
                                    reader.ReadString();
                                    reader.ReadString();
                                    reader.ReadInt32();
                                    kol++;
                                }
                            }
                            string[] idsrav = new string[kol];
                            string[] namesrav = new string[kol];
                            string[] pricesrav = new string[kol];
                            int[] numbersrav = new int[kol];
                            if (kol > 0)
                            {
                                using (BinaryReader reader = new BinaryReader(new FileStream(storepath, FileMode.Open)))
                                {
                                    for (int i = 0; i < kol; i++)
                                    {
                                        idsrav[i] = reader.ReadString();
                                        namesrav[i] = reader.ReadString();
                                        pricesrav[i] = reader.ReadString();
                                        numbersrav[i] = reader.ReadInt32();
                                    }
                                }
                            }

                            Console.Clear();
                            if (id == "" || name == "" || price == "" || numberstr == "" || !int.TryParse(id, out _) || !int.TryParse(numberstr, out _) || Convert.ToInt32(id) <= 0 || Convert.ToInt32(numberstr) <= 0)
                            {
                                Console.WriteLine("Товар введен неправильно");
                                Console.ReadKey();
                            }
                            else
                            {
                                for (int i = 0; i < kol; i++)
                                {
                                    if ((id == idsrav[i] && name != namesrav[i]) || (id == idsrav[i] && name == namesrav[i] && price != pricesrav[i]))
                                    {
                                        Console.WriteLine("Товар с указанным ID уже существует");
                                        Console.ReadKey();
                                        Sklad();
                                    }

                                    else if ((id == idsrav[i] && name == namesrav[i] && price == pricesrav[i]) || (id != idsrav[i] && name == namesrav[i] && price == pricesrav[i]))
                                    {
                                        Console.Clear();
                                        numbersrav[i] += Convert.ToInt32(numberstr);

                                        using (BinaryWriter writer = new BinaryWriter(new FileStream(storepath, FileMode.Create)))
                                        {
                                            for (int z = 0; z < kol; z++)
                                            {
                                                writer.Write(idsrav[z]);
                                                writer.Write(namesrav[z]);
                                                writer.Write(pricesrav[z]);
                                                writer.Write(numbersrav[z]);
                                            }
                                        }
                                        Sklad();
                                    }
                                }
                                using (BinaryWriter writer = new BinaryWriter(new FileStream(storepath, FileMode.Append)))
                                {
                                    writer.Write(id);
                                    writer.Write(name);
                                    writer.Write(price);
                                    writer.Write(Convert.ToInt32(numberstr));
                                }
                                Sklad();
                            }
                        }
                    }
                }

                if (key1.Key == ConsoleKey.Enter && cur == 1)
                {
                    Console.Clear();
                    int kol = 0;
                    using (BinaryReader reader = new BinaryReader(new FileStream(storepath, FileMode.Open)))
                    {
                        while (reader.PeekChar() != -1)
                        {
                            reader.ReadString();
                            reader.ReadString();
                            reader.ReadString();
                            reader.ReadInt32();
                            kol++;
                        }
                    }
                    if (kol == 0)
                    {
                        Console.WriteLine("Товаров нет");
                        Console.ReadKey();
                    }
                    else
                    {
                        tovid = new string[kol];
                        tovname = new string[kol];
                        tovprice = new string[kol];
                        tovnum = new int[kol];

                        using (BinaryReader reader = new BinaryReader(new FileStream(storepath, FileMode.Open)))
                        {
                            for (int i = 0; i < kol; i++)
                            {
                                tovid[i] = reader.ReadString();
                                tovname[i] = reader.ReadString();
                                tovprice[i] = reader.ReadString();
                                tovnum[i] = reader.ReadInt32();
                            }
                        }

                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("F1 - удалить товар");
                            if (cur < 0) cur = 0;
                            if (cur > (kol - 1)) cur = kol - 1;
                            for (int i = 0; i < kol; i++)
                            {
                                if (cur == i) Console.BackgroundColor = ConsoleColor.Blue;
                                Console.WriteLine("ID# " + tovid[i] + " Имя: " + tovname[i] + " Цена: " + tovprice[i] + " Кол-во: " + tovnum[i]);
                                Console.ResetColor();
                            }
                            ConsoleKeyInfo keyy = Console.ReadKey(true);
                            if (keyy.Key == ConsoleKey.DownArrow) cur++;
                            if (keyy.Key == ConsoleKey.UpArrow) cur--;
                            if (keyy.Key == ConsoleKey.Escape) Sklad();
                            if (keyy.Key == ConsoleKey.F1)
                            {
                                int tovdel = cur;
                                string del = "";
                                cur = 0;
                                while (true)
                                {
                                    if (cur < 0) cur = 0;
                                    if (cur > 1) cur = 1;

                                    Console.Clear();
                                    Console.WriteLine("Вы уверены, что хотите удалить товар '" + tovname[tovdel] + "'? (delete)");

                                    if (cur == 0) Console.BackgroundColor = ConsoleColor.Blue;
                                    Console.WriteLine(del);
                                    Console.ResetColor();
                                    if (cur == 1) Console.BackgroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("УДАЛИТЬ");
                                    Console.ResetColor();

                                    ConsoleKeyInfo keyd = Console.ReadKey(true);
                                    if (keyd.Key == ConsoleKey.DownArrow) cur++;
                                    if (keyd.Key == ConsoleKey.UpArrow) cur--;
                                    if (keyd.Key == ConsoleKey.Escape) break;

                                    if ((keyd.KeyChar >= 'a' && keyd.KeyChar <= 'z') && cur == 0)
                                    {
                                        del += keyd.KeyChar;
                                    }
                                    if ((keyd.Key == ConsoleKey.Backspace) && cur == 0)
                                    {
                                        if (del.Length > 0)
                                            del = del.Substring(0, del.Length - 1);
                                    }
                                    if ((keyd.Key == ConsoleKey.Enter && cur == 1) && (del == "delete"))
                                    {
                                        int num = 0;
                                        Console.Clear();

                                        using (BinaryReader reader = new BinaryReader(new FileStream(@"D:\store", FileMode.Open)))
                                        {
                                            while (reader.PeekChar() != -1)
                                            {
                                                reader.ReadString();
                                                reader.ReadString();
                                                reader.ReadString();
                                                reader.ReadInt32();
                                                num++;
                                            }
                                        }
                                        using (BinaryReader reader = new BinaryReader(new FileStream(@"D:\store", FileMode.Open)))
                                        {
                                            for (int i = 0; i < kol; i++)
                                            {
                                                tovid[i] = reader.ReadString();
                                                tovname[i] = reader.ReadString();
                                                tovprice[i] = reader.ReadString();
                                                tovnum[i] = reader.ReadInt32();
                                            }
                                        }
                                        using (BinaryWriter writer = new BinaryWriter(new FileStream(@"D:\store1", FileMode.Create)))
                                        {
                                            for (int i = 0; i < kol; i++)
                                            {
                                                if (tovid[i] != tovid[tovdel])
                                                {
                                                    writer.Write(tovid[i]);
                                                    writer.Write(tovname[i]);
                                                    writer.Write(tovprice[i]);
                                                    writer.Write(tovnum[i]);
                                                }
                                            }
                                        }
                                        File.Delete(@"D:\store");
                                        File.Move(@"D:\store1", @"D:\store");

                                        Console.WriteLine("Товар удален");
                                        Console.ReadKey();
                                        Sklad();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        static void Kassa() //номер пользователя, дата и время, массив товаров(товар и в каком количестве, выводится список товаров, на + прибавляется 1 товар)
        {
            cur = 0;
            string[] tovid;
            string[] tovname;
            string[] tovprice;
            int[] tovnum;
            int[] tovkol;
            string[] prodan;
            int kol = 0;
            Money();
            using (BinaryReader reader = new BinaryReader(new FileStream(storepath, FileMode.Open)))
            {
                while (reader.PeekChar() != -1)
                {
                    reader.ReadString();
                    reader.ReadString();
                    reader.ReadString();
                    reader.ReadInt32();
                    kol++;
                }
            }
            if (kol == 0)
            {
                Console.Clear();
                Console.WriteLine("Товаров нет");
                Console.ReadKey();
                Login();
            }
            else
            {
                tovid = new string[kol];
                tovname = new string[kol];
                tovprice = new string[kol];
                tovnum = new int[kol];
                tovkol = new int[kol];
                prodan = new string[kol];

                using (BinaryReader reader = new BinaryReader(new FileStream(storepath, FileMode.Open)))
                {
                    for (int i = 0; i < kol; i++)
                    {
                        tovid[i] = reader.ReadString();
                        tovname[i] = reader.ReadString();
                        tovprice[i] = reader.ReadString();
                        tovnum[i] = reader.ReadInt32();
                    }
                }

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("\t\t\tКасса. Пользователь " + login);
                    Console.WriteLine("\t Нажмите стрелочку вправо (-->) для добавления товара или стрелочку влево (<--) для удаления товара (товар прибавляется по одному)");
                    Console.WriteLine();
                    if (cur < 0) cur = 0;
                    if (cur > kol) cur = kol;
                    for (int i = 0; i < kol; i++)
                    {
                        if (cur == i) Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Его номер: " + tovid[i] + " Имя товара: " + tovname[i] + " Цена товара: " + tovprice[i] + " Кол-во товаров: " + tovkol[i] + " (Всего товаров:" + tovnum[i] + ")");
                        Console.ResetColor();
                    }
                    Console.WriteLine();

                    if (cur == kol) Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\t\t\t\tПродать?");
                    Console.ResetColor();

                    ConsoleKeyInfo keyy = Console.ReadKey(true);
                    if (keyy.Key == ConsoleKey.DownArrow) cur++;
                    if (keyy.Key == ConsoleKey.UpArrow) cur--;
                    if (keyy.Key == ConsoleKey.Escape) Login();
                    if (keyy.Key == ConsoleKey.RightArrow && (tovkol[cur] < tovnum[cur]))
                    {
                        tovkol[cur]++;
                    }
                    if (keyy.Key == ConsoleKey.LeftArrow && (tovkol[cur] > 0))
                    {
                        tovkol[cur]--;
                    }
                    if (keyy.Key == ConsoleKey.Enter && cur == kol)
                    {
                        int tovar = 0;
                        for (int i = 0; i < kol; i++)
                        {
                            tovar += tovkol[i];
                        }
                        if (tovar == 0)
                        {
                            Console.WriteLine("Не верное кол-во товаров");
                            Console.ReadKey();
                            Kassa();
                        }
                        int allmoney = 0;
                        string prodano = "";
                        for (int i = 0; i < kol; i++)
                        {
                            if (tovkol[i] > 0)
                            {
                                prodano += " " + tovname[i] + " " + Convert.ToString(tovkol[i]);
                            }
                        }
                        for (int i = 0; i < kol; i++)
                        {
                            allmoney += Convert.ToInt32(tovprice[i]) * tovkol[i];
                            tovnum[i] = tovnum[i] - tovkol[i];
                            if (tovnum[i] == 0)
                            {
                                prodan[i] = tovid[i];
                            }
                            tovkol[i] = 0;
                        }
                        using (BinaryWriter writer = new BinaryWriter(new FileStream(operpath, FileMode.Append)))
                        {
                            writer.Write("Продажа" + prodano + " (" + login + ")");
                            writer.Write(Convert.ToString(allmoney));
                            writer.Write(Convert.ToString(DateTime.Now));
                        }
                        gmoney += allmoney;
                        using (BinaryWriter writer = new BinaryWriter(new FileStream(storepath, FileMode.Create)))
                        {
                            for (int z = 0; z < kol; z++)
                            {
                                if (tovid[z] != prodan[z])
                                {
                                    writer.Write(tovid[z]);
                                    writer.Write(tovname[z]);
                                    writer.Write(tovprice[z]);
                                    writer.Write(tovnum[z]);
                                }
                            }
                        }
                        Console.Clear();
                        Console.WriteLine("Товары проданы");
                        Console.ReadKey();
                        MoneyIn();
                        Kassa();
                    }
                }
            }
        }

        static void Money()                      //считывание денег из файла
        {
            using (BinaryReader reader = new BinaryReader(new FileStream(moneypath, FileMode.Open)))
            {
                gmoney = reader.ReadInt32();
            }
        }

        static void MoneyIn()
        {
            using (BinaryWriter writer = new BinaryWriter(new FileStream(moneypath, FileMode.Open)))
            {
                writer.Write(gmoney);
            }
        }

        static void Registration()
        {
            string login = "", password = "", rolestring = "";
            int role;
            cur = 1;

            int num = 0;
            using (BinaryReader reader = new BinaryReader(new FileStream(accpath, FileMode.Open)))
            {
                while (reader.PeekChar() != -1)
                {
                    reader.ReadString();
                    reader.ReadString();
                    reader.ReadInt32();
                    num++;
                }
            }

            logins = new string[num];
            using (BinaryReader reader = new BinaryReader(new FileStream(accpath, FileMode.Open)))
            {
                for (int i = 0; i < num; i++)
                {
                    logins[i] = reader.ReadString();
                    reader.ReadString();
                    reader.ReadInt32();
                }
            }
            while (true)
            {
                Console.Clear();

                if (cur < 1) cur = 1;
                if (cur > 4) cur = 4;

                Console.WriteLine("Роли:");
                Console.WriteLine("0 - Админ");
                Console.WriteLine("1 - Отдел кадров");
                Console.WriteLine("2 - Бухгалтерия");
                Console.WriteLine("3 - Склад");
                Console.WriteLine("4 - Касса");

                if (cur == 1) Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Логин: " + login);
                Console.ResetColor();

                if (cur == 2) Console.BackgroundColor = ConsoleColor.Green;
                Console.Write("Пароль: ");
                for (int i = 0; i < password.Length; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                Console.ResetColor();

                if (cur == 3) Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Роль: " + rolestring);
                Console.ResetColor();

                if (cur == 4) Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Зарегистрировать");
                Console.ResetColor();

                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.DownArrow) cur++;
                if (key.Key == ConsoleKey.UpArrow) cur--;


                if (((key.KeyChar >= 'a' && key.KeyChar <= 'z') || (key.KeyChar >= '0' && key.KeyChar <= '9')) && cur == 1)
                {
                    login += key.KeyChar;
                }
                if (key.Key == ConsoleKey.Backspace && cur == 0)
                {
                    if (login.Length > 0)
                        login = login.Substring(0, login.Length - 1);
                }

                if (((key.KeyChar >= 'a' && key.KeyChar <= 'z') || (key.KeyChar >= '0' && key.KeyChar <= '9')) && cur == 2)
                {
                    password += key.KeyChar;
                }

                if (((key.KeyChar >= '0' && key.KeyChar <= '9')) && cur == 3)
                {
                    rolestring += key.KeyChar;
                }

                if (key.Key == ConsoleKey.Backspace && cur == 1)
                {
                    if (login.Length > 0)
                        login = login.Substring(0, login.Length - 1);
                }
                if (key.Key == ConsoleKey.Backspace && cur == 2)
                {
                    if (password.Length > 0)
                        password = password.Substring(0, password.Length - 1);
                }
                if (key.Key == ConsoleKey.Backspace && cur == 3)
                {
                    if (rolestring.Length > 0)
                        rolestring = rolestring.Substring(0, rolestring.Length - 1);
                }
                if ((key.Key == ConsoleKey.Enter) && (cur == 4))
                {
                    if (login.Length < 1)
                    {
                        Console.WriteLine("Логин введен некорректно");
                        Console.ReadKey();
                        Registration();
                    }
                    else if (password.Length < 1 || password.Length > 10)
                    {
                        Console.WriteLine("Пароль введен некорректно");
                        Console.ReadKey();
                        Registration();
                    }
                    else if ((rolestring == "") || (Convert.ToInt32(rolestring) < 0 || Convert.ToInt32(rolestring) > 4))
                    {
                        Console.WriteLine("Роль введена некорректно");
                        Console.ReadKey();
                        Registration();
                    }
                    else
                    {
                        int reg = 1;
                        for (int i = 0; i < num; i++)
                        {
                            if (login == logins[i])
                            {
                                reg = 0;
                            }
                        }
                        if (reg == 1)
                        {
                            role = Convert.ToInt32(rolestring);
                            using (BinaryWriter writer = new BinaryWriter(File.Open(accpath, FileMode.Append)))
                            {
                                writer.Write(login);
                                writer.Write(password);
                                writer.Write(role);
                            }
                            Admin();
                        }
                        else
                        {
                            Console.WriteLine("Данный пользователь уже зарегистрирован");
                            Console.ReadKey();
                            Registration();
                        }
                    }
                }
                if (key.Key == ConsoleKey.Escape) Admin();
            }
        }

        static void Login()
        {
            int num = 0;
            string password = "";
            login = "";
            cur = 0;

            using (BinaryReader reader = new BinaryReader(new FileStream(accpath, FileMode.Open)))
            {
                while (reader.PeekChar() != -1)
                {
                    reader.ReadString();
                    reader.ReadString();
                    reader.ReadInt32();
                    num++;
                }
            }

            logins = new string[num];
            pwords = new string[num];
            roles = new int[num];

            using (BinaryReader reader = new BinaryReader(new FileStream(accpath, FileMode.Open)))
            {
                for (int i = 0; i < num; i++)
                {
                    logins[i] = reader.ReadString();
                    pwords[i] = reader.ReadString();
                    roles[i] = reader.ReadInt32();
                }
            }

            while (true)
            {
                Console.Clear();
                Console.WriteLine("\t\t\t\t Логин");
                Console.WriteLine("\t\t Нажмите F6 для активации окна админстратора.");
                if (cur < 0) cur = 0;
                if (cur > 2) cur = 2;

                if (cur == 0) Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Логин: " + login);
                Console.ResetColor();


                if (cur == 1) Console.BackgroundColor = ConsoleColor.Green;
                Console.Write("Пароль: ");
                for (int i = 0; i < password.Length; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                Console.ResetColor();

                if (cur == 2) Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Войти");
                Console.ResetColor();

                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.DownArrow) cur++;
                if (key.Key == ConsoleKey.UpArrow) cur--;
                if (key.Key == ConsoleKey.F6) Admin();      /*________________________________________________Вызов меню Админа____________________________________________________________________________*/

                if (((key.KeyChar >= 'a' && key.KeyChar <= 'z') || (key.KeyChar >= '0' && key.KeyChar <= '9')) && cur == 0)
                {
                    login += key.KeyChar;
                }
                if (key.Key == ConsoleKey.Backspace && cur == 0)
                {
                    if (login.Length > 0)
                        login = login.Substring(0, login.Length - 1);
                }

                if (((key.KeyChar >= 'a' && key.KeyChar <= 'z') || (key.KeyChar >= '0' && key.KeyChar <= '9')) && cur == 1)
                {
                    password += key.KeyChar;
                }
                if (key.Key == ConsoleKey.Backspace && cur == 1)
                {
                    if (password.Length > 0)
                        password = password.Substring(0, password.Length - 1);
                }
                int log = 0;
                if (key.Key == ConsoleKey.Enter && cur == 2)
                {
                    if (num == 0)
                    {
                        Console.WriteLine("Списка пользователей не существует");
                        Console.ReadKey();
                    }
                    else
                    {
                        for (int i = 0; i < num; i++)
                        {
                            if ((login == logins[i]) && (password == pwords[i]))
                            {
                                logrole = roles[i];
                                log = 1;
                                switch (logrole)
                                {
                                    case 0:
                                        {
                                            Admin();
                                            break;
                                        }
                                    case 1:
                                        {
                                            Otdel();
                                            break;
                                        }
                                    case 2:
                                        {
                                            Buhgal();
                                            break;
                                        }
                                    case 3:
                                        {
                                            Sklad();
                                            break;
                                        }
                                    case 4:
                                        {
                                            Kassa();
                                            break;
                                        }

                                }
                            }
                        }
                        if (log == 0)
                        {
                            Console.WriteLine("Данного пользователя не существует");
                            Console.ReadKey();
                        }
                    }
                }
            }
        }
        static void Main()
        {
            if (!File.Exists(accpath)) File.Create(accpath).Close();
            if (!File.Exists(infopath)) File.Create(infopath).Close();
            if (!File.Exists(operpath)) File.Create(operpath).Close();
            if (!File.Exists(storepath)) File.Create(storepath).Close();
            if (!File.Exists(moneypath))
            {
                File.Create(moneypath).Close();
                using (BinaryWriter writer = new BinaryWriter(new FileStream(moneypath, FileMode.Open)))
                {
                    writer.Write(0);
                }
            }

            Login();
        }
    }
}
