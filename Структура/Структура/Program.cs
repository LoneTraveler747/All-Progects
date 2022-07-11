using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Структура_1._1
{
    class Program
    {

        public static void V()
        {
            Class1.OPS();
            Class1.POL();
            Class1.Data();
            Class1.pasport();
            Class1.inn();
            Class1.Cnils();
            Class1.Obrazovanie();
            Class1.Nomera();
            Class1.Mail();
            Class1.rabota();
            Class1.save();

        }
        public static void sotr()
        {
            string path = @"C:\\Users\Lone_Traveler\Desktop\list.txt";
            using (StreamReader reader = new StreamReader(path, true))

                Console.WriteLine(reader.ReadToEnd());
            Console.ReadKey();

        }
        private static void Main()
        {
            string[] menu = { "Добавить сотрудника", "Вывести сотрудников", "Вывести сумму", "Выход" };
            int cur = 0;
            bool cikl = true;

            while (cikl)
            {
                Console.Clear();
                if (cur < 0) cur++;
                if (cur > 3) cur--;

                if (cur == 0) Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Добавить сотрудника");
                Console.ResetColor();
                if (cur == 1) Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Вывести сотрудников");
                Console.ResetColor();
                if (cur == 2) Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("Вывести сумму");
                Console.ResetColor();
                if (cur == 3) Console.BackgroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Выход");
                Console.ResetColor();
                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key == ConsoleKey.DownArrow) cur++;
                if (key.Key == ConsoleKey.UpArrow) cur--;

                if (key.Key == ConsoleKey.Enter && cur == 0) V();
                if (key.Key == ConsoleKey.Enter && cur == 1) sotr();
                if (key.Key == ConsoleKey.Enter && cur == 2) Class1.Zap();
                if (key.Key == ConsoleKey.Enter && cur == 3) cikl = false;
            }

            

        }






    }

}
