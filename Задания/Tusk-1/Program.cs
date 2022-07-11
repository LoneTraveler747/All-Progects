using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tusk_1
{
    class Program
    {
        // Метод принимает массив чисел, возвращает количество четных элементов.
        static void Main(string[] args)
        {
            int[] numbers = { 2, 2, 3 };

            Console.WriteLine(CountEvenNumbers(numbers));            
            Console.ReadKey();
        }
        static int CountEvenNumbers(int[] numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] % 2 != 0)
                {
                    ++count; 
                }
            }
            
            return count;
        }
    }
}
