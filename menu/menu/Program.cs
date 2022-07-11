using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] menu = new string[]
            {
                "Первый пункт",
                "Второй пункт",
                "Третий пункт",
                "Четвертый пункт",
                "Пятый пункт",
            };
            int cur = 0;
            while(true)
            for (int i = 0; i < menu.Length; i++)
            {
                Console.Clear();
               
                    if ( i==cur)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                       
                    }
                Console.WriteLine(menu[i]);
                Console.ResetColor();
                ConsoleKeyInfo key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.DownArrow)
                    {
                        cur--;
                    }
                    if (key.Key == ConsoleKey.UpArrow)
                    {
                        cur++;
                    }
                    if (key.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
            }
            
            Console.ReadKey();
        }
        
    }
}
