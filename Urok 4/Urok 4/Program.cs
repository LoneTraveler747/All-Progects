using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urok_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            double t, e;
            {
                Console.WriteLine("Введитепеременные a , b , t, e");
                Console.Write("a = ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("b = ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.Write("t = ");
                t = Convert.ToInt32(Console.ReadLine());
                Console.Write("e = ");
            } e = Convert.ToInt32(Console.ReadLine());
            if (a > b)
                Console.WriteLine(Math.Sqrt((2 / 3) * a * Math.Pow(t, 3) + 3 * b * t - Math.Sin(t)));
            // else
            {
                //Console.WriteLine("Введитеa = ");
                //a = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Введитеb = ");
                //b = Convert.ToInt32(Console.ReadLine());
                // Console.WriteLine("Введитеt = ");
                // t = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Введитеe = ");
            }
            // e = Convert.ToInt32(Console.ReadLine());
            if (a < b)
                Console.WriteLine(Math.Pow(e, a + b) + Math.Pow(10, -3) * Math.Pow(t, 2));
            //else
            {
                //Console.WriteLine("Введите а = ");
                // a = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Введите  b = ");
                // b = Convert.ToInt32(Console.ReadLine());
                // Console.WriteLine(" Введите t = ");
            }
            //t = Convert.ToInt32(Console.ReadLine());
            if (a == b)
                Console.WriteLine(a * Math.Sin(Math.Pow(t, 2) + b));
            Console.ReadKey();
        }
    }
}
