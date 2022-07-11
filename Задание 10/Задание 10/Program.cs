using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] address = { "www.quora.org", "www.reddit.com", "www.stackoverflow.de"};
            for(int i = 0; i < address.Length; i++)
            {
               Console.WriteLine(Trimer(address[i]));
            }
            Console.ReadKey();
        }
        static string Trimer(string s)
        {
            char[] begin = { 'w', '.' };
            char[] end = { 'c', 'o', 'm', 'o', 'r', 'g', 'd', 'e', '.' };
            string result = s.TrimStart(begin).TrimEnd(end);
            return result;
        }
    }
}
