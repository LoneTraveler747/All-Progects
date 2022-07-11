using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tortik
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,i = 1;
            
            n =  Convert.ToInt32(Console.ReadLine());
            if (n < 1900 || n > 2000)
            {
                while(i == 1)
                {
                    n = Convert.ToInt32(Console.ReadLine());
                }

            } 
            else
            {
                i = 0;
                Console.WriteLine(n);
            }
            Console.ReadKey();
        }      
    }   
}
