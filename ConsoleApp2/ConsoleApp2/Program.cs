using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = 0, mq = 0, n = 0;
            Console.Write("Длина массива: ");
            int[] arr = new int[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Массив = ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int i in arr)
            {
                foreach (int j in arr) if (i == j) q++;
                if (mq < q)
                {
                    mq = q;
                    n = i;
                    
                }
                q = i;
            }
            Console.WriteLine(" больше всего {0} их количество: {1}" ,n ,mq);
            Console.ReadKey();
        }
    }
}
