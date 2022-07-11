using System;
using System.Text.RegularExpressions;

namespace SharpConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string cond = @"(\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)";
            string email = @"Bruce_Wayne@gmail.com";
            if (Regex.IsMatch(email, cond))
                Console.WriteLine(email);
        }
    }
}
