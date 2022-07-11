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
            double h = 0; 
            double  n;
            Console.WriteLine("Введите переменные n ");
            n = Convert.ToInt32(Console.ReadLine());           
            for (double X=1; X<=n;X++)
            {
                h += Math.Pow(-1, n) * Math.Pow(X, n) / n;
                Console.WriteLine(h);
            }
            Console.ReadKey();
        }
    }
}
