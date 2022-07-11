using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urok2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Double c, d, a, g;
            Console.Write("c= ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("d= ");
            d = Convert.ToInt32(Console.ReadLine());
            Console.Write("a= ");
            a = Convert.ToInt32(Console.ReadLine());

            g = 2 * c - d + Math.Sqrt(23) / a / 4 - 1;


            Console.WriteLine("Результат: " + g);
            Console.ReadKey();
           


        }
    }
}
