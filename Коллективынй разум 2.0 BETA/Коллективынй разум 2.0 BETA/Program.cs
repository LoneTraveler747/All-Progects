using System;
using System.IO;

namespace ConsoleApp6
{

    /*
     * Запись информации в файл(логин, пароль, роль)
     * Чтение из файла
     * Отдел кадров
     * Бухгалтерия
     * Касса
      //написать собственное ПО для магазина 
//. Автоматизация покупки и продажи товаров, 
//Пользователь: логин и пароль, номер пользователя, роль(профессия)(роль - цифра, которая позволяет пользоватся складом или отделом кадров и тд) (админ управляет только пользователями(удаляет, изменяет и создает)) 
//Отдел кадров: (номер договора) ФИО, дата рождения, паспортные данные, СНИЛС, ИНН, Должности (максимум 2), оклад (со всех должностей, учитывая налоги), образования 
//Бухгалтерия: что за операция? дата и время, сумма (если выплата зп, то отрицательная, если продажа товара - положительная) 
//Склад: код товара, название, количество (меняется), стоимость 
//Касса: номер пользователя, дата и время, массив товаров(товар и в каком количестве) (выводится список товаров, на "+" прибавляется 1 товар) 
//добавление, удаление, изменение, поиск и фильтрация везде
//сделать диаграмму в бухгалтерию через консоль (в декабре выплачена зп 100 тыс, куплено товаров 50 тыс, сделать диаграмму за декабрь)(всего 10 палочек(тип 100%), если там всего 100тыс, убыток 50тыс, то это 5 палок вниз, получил 25 тыс, 2 палок вверх и тд)

     */


    class Program
    {
        static string login = "", password = "";
        static string role = "";
        static string[] logins;
        static string[] passwords;
        static string[] roles;
        //struct Users
        //{
        //    public string login;
        //    public string password;
        //    public int role;
        //}
        static void RegMenu()
        {
            int cur = 0;
            int usernumber = 0;
            string dataPath = @"C:\Users\Lone_Traveler\source\repos\Коллективынй разум 2.0 BETA\Коллективынй разум 2.0 BETA\bin\Debug\Trey\users";
            using (BinaryReader binaryReader = new BinaryReader(File.Open(dataPath, FileMode.Open))) //этот кусок отвечаетза запись из файла в массивы
            {
                while (binaryReader.PeekChar() != -1)

                {
                    binaryReader.ReadString(); //здесь вылезает ошибка что пикчар = -1, поэтому невозможно писать данные в пустой файл (даже если он не пустой)
                    binaryReader.ReadString(); //в теории, программа записывает в binary reader данные из файла в последовательности "логин", "пароль", "роль"
                    //binaryReader.ReadInt32();
                    binaryReader.ReadString();
                    usernumber++; //usernumber считает сколько всего информации о пользователях хранится в файле (пробежался 1 раз - 1 человек, 2 раза - 2 человека)

                    Console.ReadKey();
                    break;
                }
            }
            using (BinaryReader binaryReader = new BinaryReader(File.Open(dataPath, FileMode.Open))) //этот кусок отвечаетза запись из файла в массивы
            {
                logins = new string[usernumber]; //массивы такой же длины сколько и кол-во человек
                passwords = new string[usernumber];
                roles = new string[usernumber];

                for (int i = 0; i < usernumber; i++) //сюда программа вписывает данные из переменных выше в массив
                {
                    logins[i] = binaryReader.ReadString();
                    passwords[i] = binaryReader.ReadString();
                    roles[i] = binaryReader.ReadString();
                }
            }

            //------------------------------------------------------

            while (true)
            {

                Console.Clear();
                if (cur == 0) Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Войти");
                Console.ResetColor();

                if (cur == 1) Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Зарегистрировать");
                Console.ResetColor();

                if (cur == 2) Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Вывод сотрудников");
                Console.ResetColor();

                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.DownArrow && cur < 2) cur++;

                if (key.Key == ConsoleKey.UpArrow && cur > 0) cur--;

                if (key.Key == ConsoleKey.Enter)
                {
                    switch (cur)
                    {
                        case 0:
                            Login();
                            break;
                        case 1:
                            Registration();
                            break;
                        case 2:
                            TestingOutput();
                            break;
                    }
                }
            }
        }

        static void TestingOutput() //эта хрень нужна чтобы проверить, записались ли в массивы данные, можете ее не юзать она чисто для красоты так сказать
        {
            Console.Clear();
            for (int i = 0; i < logins.Length; i++)
            {
                Console.WriteLine(logins[i]);
                Console.WriteLine(passwords[i]);
                Console.WriteLine(roles[i]);
                Console.WriteLine();
            }
            ConsoleKeyInfo key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.Escape) RegMenu();

        }
        static void Registration()
        {
            int usersCount = 0; //говной воняет (по факту)

            string dataPath = @"C:\Users\Lone_Traveler\source\repos\Коллективынй разум 2.0 BETA\Коллективынй разум 2.0 BETA\bin\Debug\Trey\users";
            int cur = 0;

            while (true)
            {
                Console.Clear();
                if (cur == 0) Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Логин: " + login);
                Console.ResetColor();

                if (cur == 1) Console.BackgroundColor = ConsoleColor.Red;
                Console.Write("Пароль: ");
                for (int i = 0; i < password.Length; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                Console.ResetColor();

                if (cur == 2) Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Роль: " + role);
                Console.ResetColor();

                if (cur == 3) Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Зарегестрировать");
                Console.ResetColor();

                //-------------------------------------------------------

                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.DownArrow && cur < 3) cur++;

                if (key.Key == ConsoleKey.UpArrow && cur > 0) cur--;
                //ЛОГИН
                if (((key.KeyChar >= 'A' && key.KeyChar <= 'z') || (key.KeyChar >= '0' && key.KeyChar <= '9')) && cur == 0)
                {
                    login += key.KeyChar;
                }

                if (key.Key == ConsoleKey.Backspace && cur == 0)
                {
                    if (login.Length > 0)
                        login = login.Substring(0, login.Length - 1);
                }

                //ПАРОЛЬ
                if (((key.KeyChar >= 'A' && key.KeyChar <= 'z') || (key.KeyChar >= '0' && key.KeyChar <= '9')) && cur == 1)
                {
                    password += key.KeyChar;
                }

                if (key.Key == ConsoleKey.Backspace && cur == 1)
                {
                    if (password.Length > 0)
                        password = password.Substring(0, password.Length - 1);
                }

                //РОЛЬ
                if ((key.KeyChar >= '0' && key.KeyChar <= '9') && cur == 2)
                {
                    role += key.KeyChar;
                }

                if (key.Key == ConsoleKey.Backspace && cur == 2)
                {
                    if (role.Length > 0)
                        role = role.Substring(0, role.Length - 1);
                }

                if (key.Key == ConsoleKey.Enter && cur == 3) //здесь происходит запись данных в файл. переменные последовательно записываются в бинарном файле на пути dataPath начиная с конца файла
                                                             //чтобы записать в конец файла нужно использовать FileMode.Append
                {

                    //for (int i = 0; i < logins.Length; i++)
                    //{
                    //    if (logins[i] == login)
                    //    {
                    //        Console.WriteLine("Пользователь с таким логином уже зарегестрирован");
                    //        contin = false;
                    //        break;
                    //    }
                    //}
                    using (BinaryWriter writer = new BinaryWriter(File.Open(dataPath, FileMode.Append)))
                    {
                        writer.Write(login);
                        writer.Write(password);
                        writer.Write(role);
                    }
                    break;

                }

                if (key.Key == ConsoleKey.Escape) RegMenu(); //выход обратно в меню выбора (войти, регистрация, отобразить)
            }

            login = "";
            password = "";
            role = "";

        }
        static void Login()
        {
            int kol = 0;
            //string dataPath = @"C:\Users\Lone_Traveler\Desktop\users";
            string dataPath = @"C:\Users\Lone_Traveler\source\repos\Коллективынй разум 2.0 BETA\Коллективынй разум 2.0 BETA\bin\Debug\Trey\users";
            int cur = 0;

            using (BinaryReader reader = new BinaryReader(new FileStream(dataPath, FileMode.Open)))
            //BinaryReader reader = new BinaryReader(new FileStream(dataPath, FileMode.Open));

            {
                while (reader.PeekChar() != -1)
                {
                    reader.ReadString();
                    reader.ReadString();
                    //reader.ReadInt32();
                    reader.ReadString();
                    kol++;

                }
            }

            //reader.Close();

            logins = new string[kol];
            passwords = new string[kol];
            roles = new string[kol];

            using (BinaryReader reader = new BinaryReader(new FileStream(dataPath, FileMode.Open)))
            {
                //reader = new BinaryReader(new FileStream(dataPath, FileMode.Open));

                //Console.WriteLine(kol);
                //Console.ReadKey(true);

                for (int i = 0; i < kol; i++)
                {
                    logins[i] = reader.ReadString();
                    passwords[i] = reader.ReadString();
                    roles[i] = reader.ReadString();
                    //reader.ReadString();
                    //Console.WriteLine(i);
                    //Console.ReadKey(true);

                }
            }


            while (true)
            {
                Console.Clear();
                if (cur == 0) Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Логин: " + login);
                Console.ResetColor();

                if (cur == 1) Console.BackgroundColor = ConsoleColor.Red;
                Console.Write("Пароль: ");
                for (int i = 0; i < password.Length; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                Console.ResetColor();

                if (cur == 2) Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Роль: " + role);
                Console.ResetColor();

                if (cur == 3) Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Войти");
                Console.ResetColor();

                //-------------------------------------------------------

                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.DownArrow && cur < 3) cur++;

                if (key.Key == ConsoleKey.UpArrow && cur > 0) cur--;
                //ЛОГИН
                if (((key.KeyChar >= 'A' && key.KeyChar <= 'z') || (key.KeyChar >= '0' && key.KeyChar <= '9')) && cur == 0)
                {
                    login += key.KeyChar;
                }

                if (key.Key == ConsoleKey.Backspace && cur == 0)
                {
                    if (login.Length > 0)
                        login = login.Substring(0, login.Length - 1);
                }

                //ПАРОЛЬ
                if (((key.KeyChar >= 'A' && key.KeyChar <= 'z') || (key.KeyChar >= '0' && key.KeyChar <= '9')) && cur == 1)
                {
                    password += key.KeyChar;
                }

                if (key.Key == ConsoleKey.Backspace && cur == 1)
                {
                    if (password.Length > 0)
                        password = password.Substring(0, password.Length - 1);
                }

                //РОЛЬ
                if ((key.KeyChar >= '0' && key.KeyChar <= '9') && cur == 2)
                {
                    role += key.KeyChar;
                }

                if (key.Key == ConsoleKey.Backspace && cur == 2)
                {
                    if (role.Length > 0)
                        role = role.Substring(0, role.Length - 1);
                }

                if (key.Key == ConsoleKey.Enter && cur == 3) //здесь происходит запись данных в файл. переменные последовательно записываются в бинарном файле на пути dataPath начиная с конца файла
                                                             //чтобы записать в конец файла нужно использовать FileMode.Append
                {

                    if(kol == 0)
                    {
                        Console.WriteLine("Вы не можете войти, т.к. учеток нет.");
                        Console.ReadKey();
                    }
                    //Console.WriteLine(kol);
                    //Console.ReadKey();

                    //for (int i = 0; i < logins.Length; i++)
                    //{
                    //    if (logins[i] == login)
                    //    {
                    //        Console.WriteLine("Пользователь с таким логином уже зарегестрирован");
                    //        contin = false;
                    //        break;
                    //    }
                    //}

                    /*
                    using (BinaryReader reader = new BinaryReader(new FileStream(dataPath, FileMode.Open)))
                    //BinaryReader reader = new BinaryReader(new FileStream(dataPath, FileMode.Open));

                    {
                        while (reader.PeekChar() != -1)
                        {
                            reader.ReadString();
                            reader.ReadString();
                            //reader.ReadInt32();
                            reader.ReadString();
                            kol++;
                            
                        }
                    }

                    //reader.Close();

                    logins = new string[kol];
                    passwords = new string[kol];
                    roles = new string[kol];

                    using (BinaryReader reader = new BinaryReader(new FileStream(dataPath, FileMode.Open)))
                    {
                        //reader = new BinaryReader(new FileStream(dataPath, FileMode.Open));

                        //Console.WriteLine(kol);
                        //Console.ReadKey(true);

                    for (int i = 0; i < kol; i++)
                        {
                            logins[i] = reader.ReadString();
                            passwords[i] = reader.ReadString();
                            roles[i] = reader.ReadString();
                            //reader.ReadString();
                            //Console.WriteLine(i);
                            //Console.ReadKey(true);

                        }
                    }         
                    */
                    //reader.Close();
                    for (int i = 0; i < kol; i++)
                    {
                        if ((login == logins[i]) && (password == passwords[i]))
                        {
                            Console.WriteLine("Вы вошли");
                            Console.WriteLine(roles[i]);
                            Console.ReadKey();
                            //return;
                        }
                        else
                        {
                            Console.WriteLine("Не верный логин или пароль");
                            Console.ReadKey();
                            
                        }
                    }

                    //break;
                    //    if (login != reader.ReadString())
                    //    {
                    //    //login = reader.ReadString();
                    //    //password = reader.ReadString();
                    //    //role = reader.ReadString();
                }
                if (key.Key == ConsoleKey.Escape) RegMenu(); //выход обратно в меню выбора (войти, регистрация, отобразить)
            }
        }


        static void Main() //в мейне проверяется наличие папок и файлов, и если не находит таковые, создает, а потом запускает меню 
        {
            if (!Directory.Exists(@"C:\Users\Lone_Traveler\source\repos\Коллективынй разум 2.0 BETA\Коллективынй разум 2.0 BETA\bin\Debug\Trey"))
            {
                Directory.CreateDirectory(@"C:\Users\Lone_Traveler\source\repos\Коллективынй разум 2.0 BETA\Коллективынй разум 2.0 BETA\bin\Debug\Trey");
            }

            if (!File.Exists(@"C:\Users\Lone_Traveler\source\repos\Коллективынй разум 2.0 BETA\Коллективынй разум 2.0 BETA\bin\Debug\Trey\users"))
            {
                File.Create(@"C:\Users\Lone_Traveler\source\repos\Коллективынй разум 2.0 BETA\Коллективынй разум 2.0 BETA\bin\Debug\Trey\users").Close();
            }

            RegMenu();
        }
    }
}