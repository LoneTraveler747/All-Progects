using System;
using System.Runtime.InteropServices;

internal class Program
{
    //Добавление сотрудников, просмотр всех сотрудников, средняя ЗП всех сотрудников, нужно меню
    /*ФИО
    Серия и номер паспорта
    Образование (какое, что закончил, когда закончил, возможность указать несколько образований)
    Должность(название, оклад, ставка)
    Дата рождения
    ИНН
    СНИЛС
    Место жительства(регистрации и фактический)
    Номер телефона(рабочий, домашний)
    Номер трудового договора
    Электронная почта
    Пол
    Дети(ФИО, возраст(<14 - номер свидетельства, >=14 серия и номер паспорта
    */


    private static string[] menu = { "Количество сотрудников", "Добавить сотрудника", "Список сотрудников", "Средняя зарплата" };
    private static int currentArrowPos = 0;
    private static string arrow = "\t<--";
    private static int number = 0;
    private static int nomer = 0;
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
        public string whenEduc;
        public string whereEduc;
    }

    struct Job
    {
        public string jobname;
        public int jobsalary;
        public int jobstake;
    }

    struct Passport
    {
        public int passnum;
        public int passserial;
    }

    struct Child
    {
        public FIO childfio;
        public int childage;
        public int numsvid;
        public Passport childpass;
    }

    struct ally
    {
        public FIO fio;
        public Job job;
        public Passport pass;
        public int numEduc;
        public Educ[] educat;
        public string birthday;
        public int inn;
        public string snils;
        public string lplace;
        public string rplace;
        public string pronum;
        public string homenum;
        public int truddognum;
        public string email;
        public string sex;
        public int numchild;
        public Child[] child;
    }

    private static void Main()
    {
        while (true)
        {
            Redraw();
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.UpArrow:
                    {
                        if (currentArrowPos > 0)
                        {
                            currentArrowPos--;
                        }
                    }
                    break;
                case ConsoleKey.DownArrow:
                    {
                        if (currentArrowPos < menu.Length - 1)
                        {
                            currentArrowPos++;
                        }
                    }
                    break;
                case ConsoleKey.Enter:
                    {
                        switch (currentArrowPos)
                        {
                            case 0:
                                {
                                    Console.Clear();
                                    Console.Write("Введите количество сотрудников: ");
                                    while (!int.TryParse(Console.ReadLine(), out number)) ;
                                    allies = new ally[number];
                                    nomer = 0;
                                }
                                break;
                            case 1:
                                {
                                    if (nomer >= number)
                                    {
                                        Console.WriteLine("Вы ввели всех сотрудников");
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\tСотрудник №" + (nomer + 1));
                                        Console.Write("Фамилия: ");
                                        allies[nomer].fio.lastname = Console.ReadLine();
                                        while (allies[nomer].fio.lastname == "")
                                        {
                                            Console.Write("Фамилия: ");
                                            allies[nomer].fio.lastname = Console.ReadLine();
                                        }
                                        Console.Write("Имя: ");
                                        allies[nomer].fio.firstname = Console.ReadLine();
                                        while (allies[nomer].fio.firstname == "")
                                        {
                                            Console.Write("Имя: ");
                                            allies[nomer].fio.firstname = Console.ReadLine();
                                        }
                                        Console.Write("Отчество: ");
                                        allies[nomer].fio.surname = Console.ReadLine();
                                        while (allies[nomer].fio.surname == "")
                                        {
                                            Console.Write("Отчество: ");
                                            allies[nomer].fio.surname = Console.ReadLine();
                                        }

                                        Console.Write("Серия пасспорта: ");
                                        while (!int.TryParse(Console.ReadLine(), out allies[nomer].pass.passserial)) ;
                                        while (Convert.ToString(allies[nomer].pass.passserial).Length != 4)
                                            while (!int.TryParse(Console.ReadLine(), out allies[nomer].pass.passserial)) ;
                                        Console.Write("Номер пасспорта: ");
                                        while (!int.TryParse(Console.ReadLine(), out allies[nomer].pass.passnum)) ;
                                        while (Convert.ToString(allies[nomer].pass.passnum).Length != 6)
                                            while (!int.TryParse(Console.ReadLine(), out allies[nomer].pass.passnum)) ;

                                        Console.Write("Сколько образований: ");
                                        while (!int.TryParse(Console.ReadLine(), out allies[nomer].numEduc)) ;
                                        if (allies[nomer].numEduc <= 0)
                                        {
                                            Console.WriteLine("Глупый или что-то?");
                                        }
                                        else
                                        {
                                            allies[nomer].educat = new Educ[allies[nomer].numEduc];

                                            for (int i = 0; i < allies[nomer].numEduc; i++)
                                            {
                                                Console.Write("Какое образование: ");
                                                allies[nomer].educat[i].whatEduc = Console.ReadLine();
                                                while (allies[nomer].educat[i].whatEduc == "")
                                                    allies[nomer].educat[i].whatEduc = Console.ReadLine();
                                                Console.Write("Что закончил: ");
                                                allies[nomer].educat[i].whereEduc = Console.ReadLine();
                                                while (allies[nomer].educat[i].whereEduc == "")
                                                    allies[nomer].educat[i].whereEduc = Console.ReadLine();
                                                Console.Write("Когда закончил(дд,мм,гг): ");
                                                allies[nomer].educat[i].whenEduc = Console.ReadLine();
                                                while (allies[nomer].educat[i].whenEduc == "")
                                                    allies[nomer].educat[i].whenEduc = Console.ReadLine();
                                            }
                                        }

                                        Console.Write("Должность: ");
                                        allies[nomer].job.jobname = Console.ReadLine();
                                        while (allies[nomer].job.jobname == "")
                                            allies[nomer].job.jobname = Console.ReadLine();
                                        Console.Write("Оклад: ");
                                        while (!int.TryParse(Console.ReadLine(), out allies[nomer].job.jobsalary)) ;
                                        while (allies[nomer].job.jobsalary < 0)
                                            while (!int.TryParse(Console.ReadLine(), out allies[nomer].job.jobsalary)) ;
                                        Console.Write("Ставка: ");
                                        while (!int.TryParse(Console.ReadLine(), out allies[nomer].job.jobstake)) ;
                                        while (allies[nomer].job.jobstake < 0)
                                            while (!int.TryParse(Console.ReadLine(), out allies[nomer].job.jobstake)) ;
                                        Console.Write("Дата рождения: ");
                                        allies[nomer].birthday = Console.ReadLine();
                                        while (allies[nomer].birthday == "")
                                            allies[nomer].birthday = Console.ReadLine();
                                        Console.Write("ИНН (10 чисел): ");
                                        while (!int.TryParse(Console.ReadLine(), out allies[nomer].inn)) ;
                                        while (Convert.ToString(allies[nomer].inn).Length != 10)
                                            while (!int.TryParse(Console.ReadLine(), out allies[nomer].inn)) ;
                                        Console.Write("СНИЛС (14 знаков, считая пробел): ");
                                        allies[nomer].snils = Console.ReadLine();
                                        while (allies[nomer].snils.Length != 14)
                                            allies[nomer].snils = Console.ReadLine();
                                        Console.Write("Место жительства(регистрация): ");
                                        allies[nomer].rplace = Console.ReadLine();
                                        while (allies[nomer].rplace == "")
                                            allies[nomer].rplace = Console.ReadLine();
                                        Console.Write("Место жительства(фактическое): ");
                                        allies[nomer].lplace = Console.ReadLine();
                                        while (allies[nomer].lplace == "")
                                            allies[nomer].lplace = Console.ReadLine();
                                        Console.WriteLine("Номер телефона(рабочий): ");
                                        allies[nomer].pronum = Console.ReadLine();
                                        while (allies[nomer].pronum.Length != 11)
                                            allies[nomer].pronum = Console.ReadLine();
                                        Console.WriteLine("Номер телефона(домашний): ");
                                        allies[nomer].homenum = Console.ReadLine();
                                        while (allies[nomer].homenum.Length != 11)
                                            allies[nomer].homenum = Console.ReadLine();
                                        Console.WriteLine("Номер трудового договора: ");
                                        while (!int.TryParse(Console.ReadLine(), out allies[nomer].truddognum)) ;

                                        Console.WriteLine("Электронная почта: ");
                                        allies[nomer].email = Console.ReadLine();
                                        while (allies[nomer].email == "")
                                            allies[nomer].email = Console.ReadLine();

                                        Console.WriteLine("Пол: ");
                                        allies[nomer].sex = Console.ReadLine();
                                        while (allies[nomer].sex == "")
                                            allies[nomer].sex = Console.ReadLine();
                                        int chinum = 1;
                                        Console.WriteLine("Количество детей: ");
                                        while (!int.TryParse(Console.ReadLine(), out allies[nomer].numchild)) ;
                                        if (allies[nomer].numchild > 0)
                                        {
                                            allies[nomer].child = new Child[allies[nomer].numchild];
                                            for (int i = 0; i < allies[nomer].numchild; i++)
                                            {
                                                Console.WriteLine("\tРебенок №" + chinum);
                                                Console.Write("Фамилия: ");
                                                allies[nomer].child[i].childfio.lastname = Console.ReadLine();
                                                while (allies[nomer].child[i].childfio.lastname == "")
                                                {
                                                    Console.Write("Фамилия: ");
                                                    allies[nomer].child[i].childfio.lastname = Console.ReadLine();
                                                }
                                                Console.Write("Имя: ");
                                                allies[nomer].child[i].childfio.firstname = Console.ReadLine();
                                                while (allies[nomer].child[i].childfio.firstname == "")
                                                {
                                                    Console.Write("Имя: ");
                                                    allies[nomer].child[i].childfio.firstname = Console.ReadLine();
                                                }
                                                Console.Write("Отчество: ");
                                                allies[nomer].child[i].childfio.surname = Console.ReadLine();
                                                while (allies[nomer].child[i].childfio.surname == "")
                                                {
                                                    Console.Write("Отчество: ");
                                                    allies[nomer].child[i].childfio.surname = Console.ReadLine();
                                                }
                                                Console.Write("Возраст: ");
                                                while (!int.TryParse(Console.ReadLine(), out allies[nomer].child[i].childage)) ;
                                                while (allies[nomer].child[i].childage < 0)
                                                    while (!int.TryParse(Console.ReadLine(), out allies[nomer].child[i].childage)) ;
                                                if (allies[nomer].child[i].childage < 14)
                                                {
                                                    Console.Write("Номер свидетельства рождения: ");
                                                    while (!int.TryParse(Console.ReadLine(), out allies[nomer].child[i].numsvid)) ;
                                                    while (Convert.ToString(allies[nomer].child[i].numsvid).Length != 6)
                                                        while (!int.TryParse(Console.ReadLine(), out allies[nomer].child[i].numsvid)) ;
                                                }
                                                else
                                                {
                                                    Console.Write("Серия пасспорта: ");
                                                    while (!int.TryParse(Console.ReadLine(), out allies[nomer].child[i].childpass.passserial)) ;
                                                    while (Convert.ToString(allies[nomer].child[i].childpass.passserial).Length != 4)
                                                        while (!int.TryParse(Console.ReadLine(), out allies[nomer].child[i].childpass.passserial)) ;
                                                    Console.Write("Номер пасспорта: ");
                                                    while (!int.TryParse(Console.ReadLine(), out allies[nomer].child[i].childpass.passnum)) ;
                                                    while (Convert.ToString(allies[nomer].child[i].childpass.passnum).Length != 6)
                                                        while (!int.TryParse(Console.ReadLine(), out allies[nomer].child[i].childpass.passnum)) ;
                                                }
                                                chinum++;
                                            }
                                        }


                                        Console.ReadKey();
                                        nomer++;
                                    }
                                }
                                break;
                            case 2:
                                {
                                    Console.Clear();
                                    if (number == 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Количество сотрудников равно нулю");
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        for (int i = 0; i < nomer; i++)
                                        {
                                            Console.WriteLine("\tСотрудник №" + (i + 1));
                                            Console.Write("Фамилия сотрудника: ");
                                            Console.WriteLine(allies[i].fio.lastname);
                                            Console.Write("Имя сотрудника: ");
                                            Console.WriteLine(allies[i].fio.firstname);
                                            Console.Write("Отчество сотрудника: ");
                                            Console.WriteLine(allies[i].fio.surname);
                                            Console.Write("Паспорт сотрудника: ");
                                            Console.WriteLine(allies[i].pass.passserial + " " + allies[i].pass.passnum);
                                            Console.Write("Количество образований: ");
                                            Console.WriteLine(allies[i].numEduc);
                                            Console.WriteLine("Какое образование: ");
                                            for (int q = 0; q < allies[i].numEduc; q++)
                                            {
                                                Console.WriteLine((q + 1) + "." + allies[i].educat[q].whatEduc);
                                            }
                                            Console.WriteLine("Что закончил: ");
                                            for (int q = 0; q < allies[i].numEduc; q++)
                                            {
                                                Console.WriteLine((q + 1) + "." + allies[i].educat[q].whereEduc);
                                            }
                                            Console.WriteLine("Когда закончил: ");
                                            for (int q = 0; q < allies[i].numEduc; q++)
                                            {
                                                Console.WriteLine((q + 1) + "." + allies[i].educat[q].whenEduc);
                                            }
                                            Console.Write("Должность: ");
                                            Console.WriteLine(allies[i].job.jobname);
                                            Console.Write("Оклад: ");
                                            Console.WriteLine(allies[i].job.jobsalary);
                                            Console.Write("Ставка: ");
                                            Console.WriteLine(allies[i].job.jobstake);
                                            Console.Write("Дата рождения: ");
                                            Console.WriteLine(allies[i].birthday);
                                            Console.Write("ИНН:");
                                            Console.WriteLine(allies[i].inn);
                                            Console.Write("СНИЛС:");
                                            Console.WriteLine(allies[i].snils);
                                            Console.WriteLine("Место жительства");
                                            Console.WriteLine("Регистрация: " + allies[i].rplace);
                                            Console.WriteLine("Фактический: " + allies[i].lplace);
                                            Console.Write("Номер телефона");
                                            Console.WriteLine("Рабочий: " + allies[i].pronum);
                                            Console.WriteLine("Домашний: " + allies[i].homenum);
                                            Console.WriteLine("Номер трудового договора: " + allies[i].truddognum);
                                            Console.WriteLine("Электронная почта: " + allies[i].email);
                                            Console.WriteLine("Пол: " + allies[i].sex);
                                            int shin = 1;
                                            Console.WriteLine("Количество детей: " + allies[i].numchild);
                                            if (allies[i].numchild > 0)
                                            {
                                                for (int w = 0; w < allies[i].numchild; w++)
                                                {
                                                    Console.WriteLine("\tРебенок№" + shin);
                                                    Console.WriteLine("Фамилия: " + allies[i].child[w].childfio.lastname);
                                                    Console.WriteLine("Имя: " + allies[i].child[w].childfio.firstname);
                                                    Console.WriteLine("Отчество: " + allies[i].child[w].childfio.surname);
                                                    Console.WriteLine("Возраст: " + allies[i].child[w].childage);
                                                    if (allies[i].child[w].childage < 14)
                                                        Console.WriteLine("Номер свидетельства о рождении: " + allies[i].child[w].numsvid);
                                                    else
                                                        Console.WriteLine("Паспорт: " + allies[i].child[w].childpass.passserial + "" + allies[i].child[w].childpass.passnum);
                                                    shin++;
                                                }
                                            }
                                        }
                                        Console.ReadKey();

                                    }
                                }
                                break;
                            case 3:
                                {
                                    int money = 0;
                                    Console.Clear();
                                    if (number == 0)
                                    {
                                        Console.WriteLine("Количество сотрудников равно нулю");
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        for (int i = 0; i < number; i++)
                                        {
                                            money += allies[i].job.jobsalary;
                                        }
                                        Console.WriteLine("Средняя ЗП = " + (money / number));
                                        Console.ReadKey();
                                    }
                                }
                                break;
                        }
                    }
                    break;
            }
        }
    }

    private static void Redraw()
    {
        Console.Clear();

        for (int i = 0; i < menu.Length; i++)
        {
            if (i == currentArrowPos)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(menu[i] + arrow);
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine(menu[i]);
            }
        }
    }
}