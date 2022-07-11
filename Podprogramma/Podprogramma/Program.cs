using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podprogramma
{
    class Program
    {
        static void rep1()
        {
            Console.WriteLine("2 * c - d + Math.Sqrt(23) / a / 4 - 1;");
            double c, d, a;
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(2 * c - d + Math.Sqrt(23) / a / 4 - 1);


        }
        public static void rep2(double c, double d, double a)
        {


            Console.WriteLine(2 * c - d + Math.Sqrt(23) / a / 4 - 1);

        }
        public static double rep3(double c, double d, double a)
        {
            return 2 * c - d + Math.Sqrt(23) / a / 4 - 1;

        }
        public static void rep4(ref double answer, double a, double d, double c)
        {
            answer = 2 * c - d + Math.Sqrt(23) / a / 4 - 1;
        }
        static void Main()
        {
            int state = 1;

            while (state == 1)
            {
                Console.WriteLine("Выберите процедуру rep 1-4");
                Console.WriteLine("Не числами, а имеено rep(1-4)");

                string choise = Console.ReadLine();

                switch (choise)
                {
                    case "rep1":
                        {
                            rep1();
                            break;
                        }

                    case "rep2":
                        {
                            rep2(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
                            break;
                        }

                    case "rep3":
                        {
                            Console.WriteLine(rep3(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())));
                            break;
                        }

                    case "rep4":
                        {
                            double answer = 0;
                            double a = Convert.ToDouble(Console.ReadLine());
                            double d = Convert.ToDouble(Console.ReadLine());
                            double c = Convert.ToDouble(Console.ReadLine());
                            rep4(ref answer, a, d, c);
                            Console.WriteLine(answer);
                            break;
                        }

                    case "exit":
                        state = 0;
                        break;

                    default:
                        {
                            Console.WriteLine("Не правильно! Попробуй ещё раз.");
                            break;
                        }
                }
                Console.WriteLine();
            }
        }
    }
}