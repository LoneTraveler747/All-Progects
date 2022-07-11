using System;
using System.IO;

namespace практическая_10_со_стрелочкой
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
        static string[] logins;
        static string[] passwords;
        static int[] roles;
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
            //using (BinaryReader binaryReader = new BinaryReader(File.Open(dataPath, FileMode.Open)))
            //{
            //    while (binaryReader.PeekChar() != -1)
            //    {
            //        binaryReader.ReadString();
            //        binaryReader.ReadString();
            //        binaryReader.ReadInt32();
            //        usernumber++;
            //    }
            //}

            logins = new string[usernumber];
            passwords = new string[usernumber];
            roles = new int[usernumber];

            using (BinaryReader binaryReader = new BinaryReader(File.Open(dataPath, FileMode.Open)))
            {
                for (int i = 0; i < usernumber; i++)
                {
                    logins[i] = binaryReader.ReadString();
                    passwords[i] = binaryReader.ReadString();
                    roles[i] = binaryReader.ReadInt32();
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

                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.DownArrow && cur < 1) cur++;

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
                    }
                }
            }
        }
        static void Registration()
        {
            int usersCount = 0; //говной воняет

            string dataPath = @"C:\Users\Lone_Traveler\source\repos\Коллективынй разум 2.0 BETA\Коллективынй разум 2.0 BETA\bin\Debug\Trey\users";
            string login = "", password = "";
            string role = "";
            int arrowpos = 0;
            bool contin = false;
            Console.Clear();
                Console.WriteLine("  Логин: " + login);
                Console.Write("  Пароль: ");
                for (int i = 0; i < password.Length; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                Console.WriteLine("  Роль: " + role);
                Console.WriteLine(  "Зарегестрировать");
            while (true)
            {

                //-------------------------------------------------------

                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.DownArrow && arrowpos < 3) arrowpos++;

                if (key.Key == ConsoleKey.UpArrow && arrowpos > 0) arrowpos--;
                //ЛОГИН
                if (((key.KeyChar >= 'A' && key.KeyChar <= 'z') || (key.KeyChar >= '0' && key.KeyChar <= '9')) && arrowpos == 0)
                {
                    login += key.KeyChar;
                }

                if (key.Key == ConsoleKey.Backspace && arrowpos == 0)
                {
                    if (login.Length > 0)
                        login = login.Substring(0, login.Length - 1);
                }

                //ПАРОЛЬ
                if (((key.KeyChar >= 'A' && key.KeyChar <= 'z') || (key.KeyChar >= '0' && key.KeyChar <= '9')) && arrowpos == 1)
                {
                    password += key.KeyChar;
                }

                if (key.Key == ConsoleKey.Backspace && arrowpos == 1)
                {
                    if (password.Length > 0)
                        password = password.Substring(0, password.Length - 1);
                }

                //РОЛЬ
                if ((key.KeyChar >= '0' && key.KeyChar <= '9') && arrowpos == 2)
                {
                    role += key.KeyChar;
                }

                if (key.Key == ConsoleKey.Backspace && arrowpos == 2)
                {
                    if (role.Length > 0)
                        role = role.Substring(0, role.Length - 1);
                }

                if (key.Key == ConsoleKey.Enter && arrowpos == 3)
                {


                }

                if (key.Key == ConsoleKey.Escape) RegMenu();
                Arrow(arrowpos);
            }
        }
        static void Login()
        {

        }
        static void Main()
        {
            BinaryReader br;
            BinaryWriter bw;
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
        static void Arrow(int pos)
        {
            Console.SetCursorPosition(0, pos + 1);
            Console.Write(new string(' ', 2));
            Console.SetCursorPosition(0, pos);
            Console.Write(new string(' ', 2));

            Console.SetCursorPosition(0, pos);
            Console.Write("->");
            Console.WriteLine();
        }

    }
}