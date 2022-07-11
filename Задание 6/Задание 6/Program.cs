using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numb = { 3, 7, 0, 2, 1};
            int min = numb[0];

            for (int i = 0; i < numb.Length; i++)
            {

                if(min > numb[i])
                {
                    min = numb[i];
                }
            }

            Console.WriteLine(min);
            Console.ReadKey();
        }
    }
}
