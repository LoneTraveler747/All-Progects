using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numb = { 5, 3, 2, 6, 0 };
            int max = numb[0];

            for(int i = 0; i < numb.Length; i++)
            {
                if(max < numb[i])
                {
                    max = numb[i];
                }
            }

            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}
