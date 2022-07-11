using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassiviPrakt
{
    class Program
    {
        static void nomer1() //Дан массив размера N. Найти номер его последнего локального максимума 
        {
            Console.Clear();
            int n;
            Console.WriteLine("Введите N");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0) ;

            int[] mass = new int[n];
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write("Введите элемент массива[" + i + "] = ");
                while (!int.TryParse(Console.ReadLine(), out mass[i])) ;
            }

            int nom = 0;

            for (int i = 0; i < mass.Length; i++)
            {
                for (int z = 0; z < mass.Length; z++)
                {
                    if (mass[i] < mass[z])
                    {
                        nom = z;
                    }
                }
            }

            Console.WriteLine("Наибольшее значение массива = mass[" + nom + "]");
            Console.ReadKey();
        }

        static void nomer2() //Дан массив размера N. Перед каждым положительным элементом массива вставить элемент с нулевым значением. 
        {
            Console.Clear();
            int n = 5;
            var mass = new List<int>();
            var rand = new Random();

            for (int i = 0; i < n; i++)
            {
                int z = rand.Next(-100, 101) % 30 - 10;
                if (z > 0) mass.Add(0);
                mass.Add(z);
            }

            Console.WriteLine(string.Join(" ", mass));
            Console.ReadKey();

        }
        static void nomer3() //Сумму элементов массива, расположенных после последнего элемента, равного нулю. 
        {
            Console.Clear();
            int n;
            Console.WriteLine("Введите N");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0) ;

            int[] mass = new int[n];
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write("Введите элемент массива[" + i + "] = ");
                while (!int.TryParse(Console.ReadLine(), out mass[i])) ;
            }

            int sum = 0;
            for (int i = (mass.Length - 1); i > 0; i--)
            {
                if (mass[i] != 0) sum += mass[i];
                else break;
            }
            Console.WriteLine(sum);
            Console.ReadLine();

        }
        static void nomer4() //Даны массивы A и B одинакового размера N. 
                             //Поменять местами их содержимое и вывести вначале элементы преобразованного массива A, а затем — элементы преобразованного массива B 
        {
            Console.Clear();
            int n;
            Console.WriteLine("Введите N");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0) ;

            int[] massa = new int[n];
            for (int i = 0; i < massa.Length; i++)
            {
                Console.Write("Введите элемент массива a[" + i + "] = ");
                while (!int.TryParse(Console.ReadLine(), out massa[i])) ;
            }
            Console.WriteLine();
            int[] massb = new int[n];
            for (int i = 0; i < massb.Length; i++)
            {
                Console.Write("Введите элемент массива b[" + i + "] = ");
                while (!int.TryParse(Console.ReadLine(), out massb[i])) ;
            }


            Console.Write("Массив А: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(massa[i] + " ");
            }

            Console.Write("Массив В: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(massb[i] + " ");
            }

            for (int i = 0; i < n; i++)
            {
                int temp = massa[i];
                massa[i] = massb[i];
                massb[i] = temp;
            }
            Console.WriteLine();

            Console.Write("Массив А: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(massa[i] + " ");
            }

            Console.Write("Массив В: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(massb[i] + " ");
            }

            Console.ReadKey();
        }

        static void Main()
        {
            int cur = 0;

            while (true)
            {
                Console.Clear();
                if (cur < 0) cur++;
                if (cur > 3) cur--;

                if (cur == 0) Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Первое задание");
                Console.ResetColor();
                if (cur == 1) Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Второе задание");
                Console.ResetColor();
                if (cur == 2) Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Третье задание");
                Console.ResetColor();
                if (cur == 3) Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Четвертое задание");
                Console.ResetColor();

                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key == ConsoleKey.DownArrow) cur++;
                if (key.Key == ConsoleKey.UpArrow) cur--;

                if (key.Key == ConsoleKey.Enter && cur == 0) nomer1();
                if (key.Key == ConsoleKey.Enter && cur == 1) nomer2();
                if (key.Key ==

                ConsoleKey.Enter && cur == 2) nomer3();
                if (key.Key == ConsoleKey.Enter && cur == 3) nomer4();

            }
        }
    }
}