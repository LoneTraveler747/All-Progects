using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Here1
{
    class Program
    {
        static void Main(string[] args)

        {
            int a, b;
            double x ;
            Console.WriteLine("b = ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a = ");
            a = Convert.ToInt32(Console.ReadLine());
            x = Math.Sqrt(Math.Pow(b,3 + a));
            Console.WriteLine(x);
            Console.ReadKey();





        }
    }
}
