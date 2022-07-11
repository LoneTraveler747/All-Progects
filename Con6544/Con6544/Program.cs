using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Con6544
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("  Ты учитель.Твоя задача оценить экзамень студента от 1-го до 5-ти баллов.");
            Console.WriteLine("  От того, что выберешь, будет зависеть жизнь студента!");
            a = Convert.ToInt32(Console.ReadLine());           
            switch (a)
            {
                case 1:
                    { Console.WriteLine("  Отчислен!!!!!!!11!!!!1");

                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("  Без Стипухи");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("  Ты смог выжить");
                        break;
                    }
                case 4:
                    Console.WriteLine("  Хорошо");
                    break;

                case 5:
                    Console.WriteLine("  Повышение стипухи");
                    break;
                default:
                    Console.WriteLine("  Нет такой оценки! Всё плохо, давай по новой! ");               
                    break;
            }          
            Console.ReadKey();
        }
    }
}
    

