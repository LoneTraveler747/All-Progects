using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            for (int i = 154; i >= -25; i--)
            {
                a += i;

            }
            Console.WriteLine("Среднее арифметические = " + a / (154 + 25));
            Console.ReadKey();
        }
    }
}
