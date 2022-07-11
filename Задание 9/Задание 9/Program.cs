using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Задание_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string apple = "jgfghfg";
            Console.WriteLine(kolixhestvo(apple));
            Console.ReadKey();
        } 
        static string Pochta(string s)
        {
            string postfix =  "@gmail.com";
            bool b = s.Contains(postfix);
            string sub = "+";
            if(b == true)
            {
                sub = s;
                return sub;
            }
            return "";        
        }
        static double Function(double s)
        {
            return s * s;
        }

        static bool Function2(string s)
        {          
            if (s.Contains('a'))
            {
                return true;               
            }
            return false;
        }

        static bool kolixhestvo(string s)
        {
            if(s.Length >= 10)
            {
                return true;
            }
            return false;
        }
    }
}
