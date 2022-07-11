using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = 0, mq = 0;
            Console.Write("Длина массива: ");
            int[] arr = new int[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("массив {0} =", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach(int i in arr)
            {
                foreach (int j in arr) if (i == j) q++;
                if (mq < q)
                    mq = q;
                q = 0;
            }
            Console.WriteLine("Самое большое количество одиннаковых элементов массива : " + mq);
            Console.ReadKey();

        }
    }
}
