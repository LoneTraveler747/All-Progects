using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {


        public static void rep1()
        {
            Console.WriteLine("2 * c - d + Math.Sqrt(23) / a / 4 - 1;");
            Double c, d, a;
            c = Convert.ToInt32(Console.ReadKey());
            d = Convert.ToInt32(Console.ReadKey());
            a = Convert.ToInt32(Console.ReadKey());
            Console.WriteLine(2 * c - d + Math.Sqrt(23) / a / 4 - 1);


        }
        public static void rep2(double c, double d, double a)
        {
            c = Convert.ToInt32(Console.ReadKey());
            d = Convert.ToInt32(Console.ReadKey());
            a = Convert.ToInt32(Console.ReadKey());
            Console.WriteLine(2 * c - d + Math.Sqrt(23) / a / 4 - 1);

        }
        public static double rep3(double c, double d, double a)
        {
            c = Convert.ToInt32(Console.ReadKey());
            d = Convert.ToInt32(Console.ReadKey());
            a = Convert.ToInt32(Console.ReadKey());
            return ((2 * c - d + Math.Sqrt(23) / a / 4 - 1));
        }
       public static void Main(string[] args)
       {
            //Console.WriteLine(rep());


       }
    }
}
