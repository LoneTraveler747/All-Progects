using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string InPut = Console.ReadLine();
            int t = Convert.ToInt32(Console.ReadLine());
            string s = Chetire(InPut, t);
            Console.WriteLine(s);
            Console.ReadKey();
        }
        static string Chetire(string word, int t)
        {            
            char[] chars = new char[word.Length * t];

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < t; j++)
                {
                    char simvol = word[i];
                    //chars[i * t] = simvol;
                    chars[i * t + j] = simvol;
                }
            }

            string str = new string(chars);
            return str;
        }
    }
}
