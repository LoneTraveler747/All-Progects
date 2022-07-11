using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strukture
{
    class Program
    {
      struct FIO
      {
            public string LastName;
            public string FirstName;
            public string surName;
      }
      struct student
      {
            public  FIO fio;
            public int kurs;
            public string group;
      }
        static void Main(string[] args)
        {
            student danilivloh = new student();
            Console.WriteLine(" Введите ФИО ");
            Console.Write(" Фамилия: ");
            danilivloh.fio.LastName = Console.ReadLine();
            Console.Write(" Имя: ");
            danilivloh.fio.FirstName = Console.ReadLine();
            Console.Write(" Отчество: ");
            danilivloh.fio.surName = Console.ReadLine();
            Console.Write(" Введите курс: ");
            while (!int.TryParse(Console.ReadLine(), out danilivloh.kurs)) Console.WriteLine("Ошибка");
            Console.WriteLine(" Введите группу ");
            danilivloh.group = Console.ReadLine();
            Console.WriteLine(" ФИО: " + danilivloh.fio.LastName + " " + danilivloh.fio.FirstName + " " + danilivloh.fio.surName);
            Console.WriteLine(" Курс: " + danilivloh.kurs);
            Console.WriteLine(" Группа: " + danilivloh.group);
                     
        }
    }
}
