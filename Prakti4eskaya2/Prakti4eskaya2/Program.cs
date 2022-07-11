using System;

internal class Program
{
    private static string[] menu = { "Количество сотрудников", "Добавить сотрудника", "Список сотрудников", "Средняя зарплата", "Выход из архива"};
    private static int currentArrowPos = 0;
    private static string arrow = "\t<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<";
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
                                    Console.ReadLine();
                                    Console.ReadKey();
                                }
                                break;
                            case 1:
                                {
                                    Console.Clear();
                                    Console.ReadKey();
                                }
                                break;
                            case 2:
                                {
                                    Console.Clear();
                                    Console.Clear();
                                    Console.ReadKey();

                                }
                                break;
                            case 3:
                                {
                                    Console.Clear();
                                    Console.ReadKey();
                                }
                                break;
                            case 4:
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
    }
}