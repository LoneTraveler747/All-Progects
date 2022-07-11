using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urok_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Введите число");
            a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {

                case 1:

                    Console.WriteLine("Понедельник");
                   // Console.WriteLine("31 день");

                    break;
                case 2:

                    Console.WriteLine("Вторник");
                   // Console.WriteLine("27");

                    break;
                case 3:

                    Console.WriteLine("Среда");

                    break;
                case 4:

                    Console.WriteLine("Четверк");

                    break;
                case 5:

                    Console.WriteLine("Пятница");

                    break;
                case 6:

                    Console.WriteLine("Суббота");

                    break;
                case 7:

                    Console.WriteLine("Воскресенье");

                    break;
               

                default:
                    
                    Console.WriteLine("Нету больше 8-ми ");
                    break;
            }
            Console.ReadKey();


        } 
    }
}
