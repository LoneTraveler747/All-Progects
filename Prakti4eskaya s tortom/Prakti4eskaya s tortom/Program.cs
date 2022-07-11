using System;

namespace Prakti4eskaya_s_tortom
{
    internal class Program
    {
        private static void Main()
        {
            int state = 1;
            

            while (state == 1)
            {
                Console.WriteLine("Введите первый пункт.");
                Console.WriteLine("Второй пункт.");
                Console.WriteLine("Третий пункт.");
                Console.WriteLine("В конце можно выбрать вишинку.");
                double t = 0, c = 0, T = 0;
                string choise;
                string e, r;
                choise = Convert.ToString(Console.ReadLine());
                Console.Clear();
                switch (choise)
                {
                    case "Первый пункт":
                        {
                            Console.WriteLine("Введите форму торта");
                            e = Convert.ToString(Console.ReadLine());
                            switch (e)
                            {
                                case "Квадратная":
                                    {
                                        Console.WriteLine(" + 100 рубасов");
                                        t = t + 100;
                                       
                                    }
                                    break;
                                case "Круглая":
                                    {
                                        Console.WriteLine(" + 120 рубасов ");
                                        t = t + 120;
                                        
                                    }
                                    break;
                                case "Треугольная":
                                    {
                                        t = t + 130;
                                        
                                    }
                                    break;
                            }   
                            break;
                        }

                    case "Второй пункт":
                        {
                            Console.WriteLine("Выберите покров торта");
                            Console.WriteLine("Только шоколад");
                            r = Convert.ToString(Console.ReadLine());
                            switch (r)
                            {
                                case "Шоколадный":
                                    {
                                        Console.WriteLine(" + 150 рубасов ");
                                        c = c + 150;
                                       
                                        break;
                                    }
                            }
                        }
                        break;

                    case "Третий пункт":
                        {

                        }
                        break;

                    case "Вишинка":
                        {

                        }
                        break;

                    case "exit":

                        state = 0;

                        break;

                    default:
                        {
                            Console.WriteLine("Не правильно! Попробуй ещё раз.");
                            break;
                        }
                }
                T = c + t;
                Console.WriteLine("Сумма заказа:" + (T));
                Console.WriteLine(" ");
            }
        }
    }
}
