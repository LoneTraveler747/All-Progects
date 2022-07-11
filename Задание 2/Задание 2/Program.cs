using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {           
            string[] strings = { "foo", "bar", "batman", "rep"};
            int summ = 0;

            for (int i = 0; i < strings.Length; i++)
            {                              
                summ = summ + strings[i].Length;
            }

            Console.Write(summ);
            Console.ReadKey();
        }
    }
}
