using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mass2
{
    class Program
    {
        static void quest1() // Дан массив размера N. Найти количество его промежутков монотонности (то есть участков, на которых его элементы возрастают или убывают).
        {
            Console.Clear();
            int N;
            do
            {

                Console.Write("Размер массива (N) = ");
            }

            while ((N = Convert.ToInt32(Console.ReadLine())) < 2);

            Random rnd = new Random();
            int i;
            int[] arr = new int[N];
            for (i = 0; i < N; i++)
            {
                arr[i] = rnd.Next(100);

                Console.Write(arr[i].ToString() + ' ');
            }
            Console.WriteLine();

            int cntr = 0;


            int flag = 0;
            for (i = 1; i < N; i++)
            {
                if (arr[i] < arr[i - 1])
                {
                    if (flag != 1) cntr++;
                    flag = 1;
                }
                else if (arr[i] > arr[i - 1])
                {
                    if (flag != 2) cntr++;
                    flag = 2;
                }
                else if (flag != 0)
                {
                    cntr++;
                    flag = 0;
                }
            }

            Console.WriteLine("Количество участков монотонности: " + cntr.ToString());
            Console.ReadLine();
        }

        static void quest2() //Дан целочисленный массив размера N. Удалить из массива все одинаковые элементы, оставив их последние вхождения.
        {
            Console.Clear();
            int[] mass;
            int[] mass2;
            int N, count, count2, rez = 0;
            Random rand = new Random();

            Console.WriteLine("Введите N...");
            while (!int.TryParse(Console.ReadLine(), out N))
            {
                Console.Clear();
                Console.WriteLine("Толькочисла!");
            }

            mass = new int[N];

            for (count = 0; count < mass.Length; count++)
            {
                mass[count] = rand.Next(1, 10);
                Console.WriteLine(mass[count]);
            }

            Console.WriteLine();

            for (count = 0; count < mass.Length; count++)
            {
                rez = 0;

                for (count2 = mass.Length - 1; count2 > -1; count2--)
                {
                    if (mass[count] == mass[count2])
                    {
                        rez++;
                    }

                    if (rez > 1)
                    {
                        mass[count] = -100;
                    }
                }
            }

            rez = 0;

            for (count = 0; count < mass.Length; count++)
            {
                if (mass[count] == -100)
                {
                    rez++;
                }
            }

            mass2 = new int[mass.Length - rez];
            Console.WriteLine(mass2.Length);
            //Console.ReadKey();

            count2 = 0;

            for (count = 0; count < mass.Length; count++)
            {
                if (mass[count] != -100)
                {
                    mass2[count2] = mass[count];
                    //Console.WriteLine(mass[count]);
                    count2++;
                }
            }

            for (count = 0; count < mass2.Length; count++)
            {
                Console.WriteLine(mass2[count]);
            }
            Console.ReadKey();

        }
        static void quest3() //Сумму элементов массива, расположенных после последнего элемента, равного нулю. 
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
        static void quest4() //Даны два массива A и B одинакового размера N. Сформировать новый массив C того же размера, каждый элемент которого равен максимальному из элементов массивов A и B с тем же индексом

        {
            Console.Clear();
            int n, i;
            Console.Write("Массив какого размера вы хотите задать? N = ");
            while (!int.TryParse(Console.ReadLine(), out n)) ;
            {
                Console.Clear();
                Console.Write("Массив какого размера вы хотите задать? N = ");
            }
            int[] a = new int[n];
            int[] b = new int[n];
            int[] c = new int[n];
            Console.WriteLine(" Введите {0} элементов массива A", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("a[{0}]=", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(" Введите {0} элементов массива B", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("b[{0}]=", i);
                b[i] = int.Parse(Console.ReadLine());
            }
            //
            for (i = 0; i < n; i++)
            {
                if (a[i] > b[i]) c[i] = a[i];
                else c[i] = b[i];
            }
            Console.WriteLine("Новый массив С");
            for (i = 0; i < n; i++)
                Console.Write("с[{0}]={1} ", i, c[i]);
            Console.ReadLine();
        }

        static void Main()
        {
            int cur = 0;
            bool cikl = true;

            while (cikl)
            {
                Console.Clear();
                if (cur < 0) cur++;
                if (cur > 4) cur--;

                if (cur == 0) Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Первое задание");
                Console.ResetColor();
                if (cur == 1) Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Второе задание");
                Console.ResetColor();
                if (cur == 2) Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("Третье задание");
                Console.ResetColor();
                if (cur == 3) Console.BackgroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Четвертое задание");
                Console.ResetColor();
                if (cur == 4) Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("Выход");
                Console.ResetColor();
                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key == ConsoleKey.DownArrow) cur++;
                if (key.Key == ConsoleKey.UpArrow) cur--;

                if (key.Key == ConsoleKey.Enter && cur == 0) quest1();
                if (key.Key == ConsoleKey.Enter && cur == 1) quest2();
                if (key.Key == ConsoleKey.Enter && cur == 2) quest3();
                if (key.Key == ConsoleKey.Enter && cur == 3) quest4();
                if (key.Key == ConsoleKey.Enter && cur == 4) cikl = false;
            }
        }
    }
}