using System;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace проводник

{
    class Program
    {
        public static string str, str2, savedrive;
        public static DirectoryInfo posdir;
        public static ConsoleKeyInfo key;
        public static int i, y = 0;

        public static void Dirves()
        {
            y = 0;
            DriveInfo[] drive = DriveInfo.GetDrives();
            
            while (true)
            {
                for (i = 0; i < drive.Length; i++)
                {
                    Console.SetCursorPosition(2, 0);
                    Console.WriteLine("Название");
                    Console.SetCursorPosition(0, 1 + i);
                    Console.WriteLine("  " + drive[i].Name);


                }

                Console.SetCursorPosition(0, y);
                Console.WriteLine("  ");
                Console.SetCursorPosition(0, y + 1);
                Console.WriteLine("-");
                key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.UpArrow)
                {
                    y--;
                }
                if (key.Key == ConsoleKey.DownArrow)
                {
                    y++;
                }
                if (key.Key == ConsoleKey.F12)
                {
                    Console.SetCursorPosition(2, 0);
                    Console.WriteLine("Название");
                    Console.SetCursorPosition(0, 1 + y);
                    Console.WriteLine("  " + drive[y].Name);
                    Console.SetCursorPosition(13, 0);
                    Console.WriteLine("Тип");
                    Console.SetCursorPosition(11, 1 + y);
                    Console.WriteLine("  " + drive[y].DriveType);
                    Console.SetCursorPosition(22, 0);
                    if (drive[y].IsReady)
                    {
                        Console.WriteLine("Всего памяти");
                        Console.SetCursorPosition(20, 1 + y);
                        Console.WriteLine("  " + drive[y].TotalSize / 1024 / 1024);

                        Console.SetCursorPosition(37, 0);
                        Console.WriteLine("Свободно");
                        Console.SetCursorPosition(35, 1 + y);
                        Console.WriteLine("  " + drive[y].TotalFreeSpace / 1024 / 1024);

                        Console.SetCursorPosition(52, 0);
                        Console.WriteLine("Занято");
                        Console.SetCursorPosition(50, 1 + y);
                        Console.WriteLine("  " + (drive[y].TotalSize - drive[y].TotalFreeSpace) / 1024 / 1024);
                        Console.SetCursorPosition(0, drive.Length + 1);
                    }
                    else
                    {
                        Console.WriteLine("Устройство еще не готово");

                    }
                    Console.SetCursorPosition(0, y);
                    Console.WriteLine("                                                         ");
                    Console.SetCursorPosition(0, y + 1);
                    Console.WriteLine("-");
                    Thread.Sleep(2000);
                    Console.SetCursorPosition(5, 0);
                    Console.WriteLine("                                                         ");
                    Console.SetCursorPosition(0, y + 1);
                    Console.WriteLine("                                                         ");
                }
                if (y < 0)
                {
                    y = drive.Length - 1;
                }
                if (y + 1 > drive.Length)
                {
                    y = 0;
                }
                if (key.Key == ConsoleKey.Enter)
                {
                    str = drive[y].Name;
                    savedrive = drive[y].Name;
                    y = 1;
                    break;
                }
            }
        }
        public static void Directories()
        {
            Console.Clear();
            DirectoryInfo[] dir = new DirectoryInfo(str).GetDirectories();
            FileInfo[] file = new DirectoryInfo(str).GetFiles();
            int y2;
            y = 1;
            int d = 0;
            string str3 = "Delete";

            for (int i = 0; i < dir.Length; i++)
            {
                Console.SetCursorPosition(2, 1 + i);
                Console.WriteLine(dir[i].Name);
            }
            for (int i = 0; i < file.Length; i++)
            {
                Console.SetCursorPosition(2, dir.Length + 1 + i);
                Console.WriteLine(file[i].Name);
            }

            while (true)
            {
                string[] len = new string[file.Length + dir.Length];

                Console.SetCursorPosition(0, y - 1);
                Console.WriteLine("  ");
                Console.SetCursorPosition(0, y);
                Console.WriteLine("-");
                Console.SetCursorPosition(0, y + 1);
                Console.WriteLine("  ");

                key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.UpArrow)
                {
                    y--;

                }

                if (key.Key == ConsoleKey.DownArrow)
                {
                    y++;
                }


                if (key.Key == ConsoleKey.Enter)
                {
                    try
                    {
                        if (y <= dir.Length)
                        {

                            str = dir[y - 1].FullName;
                            if (Directory.Exists(str))
                            {
                                Console.Clear();
                                Directories();
                            }
                        }
                        if (y > dir.Length)
                        {
                            str2 = file[y - dir.Length - 1].FullName;
                            if (File.Exists(str2))
                            {
                                Process.Start(file[y - dir.Length - 1].FullName);

                                
                            }
                        }
                    }
                    catch (Exception)
                    {
                        if (str != savedrive)
                        {
                            posdir = new DirectoryInfo(str);
                            str = posdir.Parent.FullName;
                            Console.Clear();
                            Directories();
                            break;
                        }
                        if (str == savedrive)
                        {
                            Console.Clear();
                            Main();
                            break;
                        }
                        break;
                    }
                }
                if (key.Key == ConsoleKey.Escape)
                {
                    
                    if (str != savedrive)
                    {
                        posdir = new DirectoryInfo(str);
                        str = posdir.Parent.FullName;
                        Console.Clear();
                        Directories();
                        break;
                    }
                    if (str == savedrive)
                    {
                        Console.Clear();
                        Main();
                        break;
                    }
                    break;

                }
                if (key.Key == ConsoleKey.Delete)
                {
                    try
                    {
                        if (y <= dir.Length)
                        {

                            str2 = dir[y - 1].FullName;
                            if (Directory.Exists(str2))
                            {

                                dir[y - 1].Delete(true);
                                Directories();
                                break;
                            }
                        }
                        if (y > dir.Length)
                        {
                            str2 = file[y - dir.Length - 1].FullName;


                            file[y - dir.Length - 1].Delete();
                            Directories();
                            break;
                        }
                    }
                    catch (Exception)
                    {

                    }
                }
                if (key.Key == ConsoleKey.F1)
                {
                    Console.Clear();
                    Console.Write("Введите название папки: ");
                    Directory.CreateDirectory(Path.Combine(str + @"\" + Console.ReadLine()));
                    Console.Clear();
                    Directories();                   
                }
                if (key.Key == ConsoleKey.F2)
                {
                    Console.Clear();
                    Console.Write("Введите название файла: ");
                    File.Create(dir[y - 1].Parent.FullName + @"\" + Console.ReadLine());
                    Console.Clear();
                    Directories();                  
                }
                if (key.Key == ConsoleKey.F3)
                {
                    Console.Clear();
                    Console.Write("Введите новое имя папки или новое раположение папки: ");
                    try
                    {

                        dir[y - 1].MoveTo(Console.ReadLine() + @"\" + dir[y - 1].Name);

                        Directories();
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine(dir[y - 1].Parent.FullName);
                        Console.ReadKey();
                        Directories();
                        break;
                    }
                }
                if (key.Key == ConsoleKey.F4)
                {
                    Console.Clear();
                    Console.Write("Введите новое имя папки или новое раположение папки: ");
                    try
                    {

                        dir[y - 1].MoveTo(dir[y - 1].Parent.FullName + @"\" + Console.ReadLine());

                        Directories();
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine(dir[y - 1].Parent.FullName);
                        Console.ReadKey();
                        Directories();
                        break;
                    }
                }
                if (key.Key == ConsoleKey.F12)
                {
                    if (y <= dir.Length)
                    {
                        Console.SetCursorPosition(32, 0);
                        Console.WriteLine("Дата");
                        Console.SetCursorPosition(30, y);
                        Console.WriteLine("  " + dir[y - 1].CreationTimeUtc);
                        Thread.Sleep(2000);
                        Console.SetCursorPosition(30, y);
                        Console.WriteLine("                                                         ");
                        Console.SetCursorPosition(30, 0);
                        Console.WriteLine("                       ");

                    }
                    if (y > dir.Length)
                    {
                        Console.SetCursorPosition(32, 0);
                        Console.WriteLine("Дата");
                        Console.SetCursorPosition(30, y);
                        Console.WriteLine("  " + file[y - dir.Length - 1].CreationTimeUtc);
                        Console.SetCursorPosition(50, 0);
                        Console.WriteLine("Размер");
                        Console.SetCursorPosition(50, y);
                        Console.WriteLine("  " + (file[y - dir.Length - 1].Length / 1024));
                        Thread.Sleep(2000);
                        Console.SetCursorPosition(30, y);
                        Console.WriteLine("                                                         ");
                        Console.SetCursorPosition(30, 0);
                        Console.WriteLine("                       ");

                        Console.SetCursorPosition(40, 0);
                        Console.WriteLine("                       ");
                    }
                }
                if (y > len.Length)
                {
                    Console.SetCursorPosition(0, len.Length);
                    Console.WriteLine("  ");
                    y = 1;
                }
                if (y < 1)
                {
                    Console.SetCursorPosition(0, 1);
                    Console.WriteLine("  ");
                    y = len.Length;
                }
            }
        }
        static void Main()
        {
            Dirves();
            Console.Clear();
            Directories();
        }
    }
}
