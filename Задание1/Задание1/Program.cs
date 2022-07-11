using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] var = { 0, 2, 3, 7, 11, 12, 6, 4, 10 };
            for (int i = 0; i < var.Length; i++)
            {
                if(var[i] % 2 != 0)
                {
                    Console.WriteLine(var[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
