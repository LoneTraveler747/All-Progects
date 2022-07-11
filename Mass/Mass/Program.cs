using System;

namespace Mass
{
    class Program
    {
        static void Main()
        {
            int n,i,d= 0;
            double q;
            n = Convert.ToInt32(Console.ReadLine());
            d = n;
            int[] c = new int[n];
            
            for (i = 0; i < n; n+= n)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine(n / d);
            Console.ReadKey();
        }
    }
}
