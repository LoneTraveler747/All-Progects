using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задания
{
    class Program
    {
        static void Main(string[] args)
        {
            string word ="шалаш";

            Console.WriteLine(primer(word));
            Console.ReadKey();
        }
        static bool primer(string x)
        {
            bool b = true;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] != x[x.Length - i - 1])
                {
                    b = false;
                }
            }
            return b;
        }               
    }
}
