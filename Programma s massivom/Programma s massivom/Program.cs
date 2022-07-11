using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programma_s_massivom
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            do
            {

                Console.Write("Размер массива (N) = "); 
            }

            while ((N = Convert.ToInt32(Console.ReadLine())) < 2);
            
            Random rnd = new Random();
            int i;
            int[] arr = new int[N];
            for (i = 0; i < N; i++)
            {
                arr[i] = rnd.Next(100);
                
                Console.Write(arr[i].ToString() + ' ');
            }
            Console.WriteLine();
            
            int cntr = 0;
           

            int flag = 0;
            for (i = 1; i < N; i++)
            {
                if (arr[i] < arr[i - 1])
                {
                    if (flag != 1) cntr++;
                    flag = 1;
                }
                else if (arr[i] > arr[i - 1])
                {
                    if (flag != 2) cntr++;
                    flag = 2;
                }
                else if (flag != 0)
                {
                    cntr++;
                    flag = 0;
                }
            }
           
            Console.WriteLine("Количество участков монотонности: " + cntr.ToString());
            Console.ReadLine();
        }
    }
}
