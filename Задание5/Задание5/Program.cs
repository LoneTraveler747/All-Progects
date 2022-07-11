using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание5
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] chisla = {5.94, 3.75, 2.95, 3.15};
            double pi = 3.14;
            int index = 0;
            double min = chisla[index] - pi;

            for(int i = 0; i < chisla.Length; ++i)
            {
                
                if(Math.Abs(chisla[i] - pi) < min)
                {
                    min = Math.Abs(chisla[i] - pi);
                    index = i;
                }
            }
            Console.WriteLine(chisla[index]);

            
            //Console.WriteLine(chisla[2]);
            
            Console.ReadKey();
        }     
    }
}
