using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urok6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x;
            double a = 0;
            int k = 0;
           
                x = Convert.ToInt32(Console.ReadLine());
                if (x == 0) 
                k++;
                a += x; // a = a + x
           
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                x = Convert.ToInt32(Console.ReadLine());

                a += x;

            }
            Console.WriteLine("Summa.= " + a);

            a /= k;

            Console.WriteLine("Srediarifm =  " + a);

            Console.ReadKey();



        }
    }
}
