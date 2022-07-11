using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string InPut = Console.ReadLine();
            string s = DoubleCharactersInAString(InPut);          
            Console.WriteLine(s);
            Console.ReadKey();
        }

        // Pupkun@mail.ru
        // Ivanov@mail.ru
        // SendMail(string s)
        // SendMail(Pupkin@mail.ru; Ivanov@mail.ru)

        static string MyMethod(string a, int b)
        {
            return a + b;
        }

        static string DoubleCharactersInAString(string word)
        {
            char[] rep = new char[word.Length * 2];

            for (int i = 0; i < word.Length; i++)
            {
                char simvol = word[i];
                rep[i * 2] = simvol;
                rep[i * 2 + 1] = simvol;
            }

            string str = new string(rep);
            return str;
        }
    }
}
