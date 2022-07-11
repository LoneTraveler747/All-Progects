using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7
/*
    Задача №1
    Завести массив строк:
    "google", "yandex", "bing", "duckduckgo", "yahoo", "rambler-shit"

    Найти строку с наибольшей длинной, вывести эту строку и её длину на консоль.
*/
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = { "google", "yandex", "bing", "duckduckgo", "yahoo", "rambler-shit"};
            int index = 0;
            int max = strings[index].Length;

            for(int i = 0; i < strings.Length; i++)
            {
                if(max < strings[i].Length)
                {
                    max = strings[i].Length;
                    index = i;
                }
            }

            Console.WriteLine(max + " " + strings[index]);
            Console.ReadKey();
        }
    }
}
