using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Provodnik
{


    internal class Program
    {
        private static string[] menu = { "C:\\", " Выход" };
        private static int currentArrowPos = 0;
        private static string arrow = "\t<<<<<<<<<<-----";
        private static void Main()
        {
            int i = 1;
            while (i == 1)
            {
                Redraw();
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.UpArrow:
                        {
                            if (currentArrowPos > 0)
                            {
                                currentArrowPos--;
                            }
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        {
                            if (currentArrowPos < menu.Length - 1)
                            {
                                currentArrowPos++;
                            }
                        }
                        break;
                    case ConsoleKey.Enter:
                        {
                            switch (currentArrowPos)
                            {
                                
                                case 0:
                                    {
                                        Console.Clear();
                                       
                                        string dirName = "C:\\";
                                        Console.WriteLine("Подкаталоги:");
                                        string[] dirs = Directory.GetDirectories(dirName);
                                        foreach (string s in dirs)
                                        {
                                            Main();
                                            Console.WriteLine(s);                                           
                                            Redraw();
                                        }
                                        Console.ReadKey();
                                    }
                                    break;
                                case 1:
                                    {
                                        Console.Clear();
                                        i = 0;


                                    }
                                    break;
                            }
                        }
                        break;
                }
            }
            Console.ReadKey();
        }


        private static void Redraw()
        {
            Console.Clear();

            for (int i = 0; i < menu.Length; i++)
            {
                if (i == currentArrowPos)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(menu[i] + arrow);
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine(menu[i]);
                }
            }
            Console.ReadKey();
        }
        
    }
    
}   
