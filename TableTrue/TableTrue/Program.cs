using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTrue
{
    class Program
    {
        static void Main(string[] args)
        {
            string and = "and";
            string or = "or";
            string imp = "->";
            string equ = "<->";
            string not = "!";

            string s = "A and B or C";

            string[] pars = s.Split(' ');

            for(int i = 0; i < pars.Length; i++)
            {
                Console.WriteLine(pars[i]);
            }

            List<string> operators = new List<string>();

            for (int i = 0; i < pars.Length; i++)
            {
                if(i % 2 != 0)
                {
                    operators.Add(pars[i]);
                }
            }

            for (int i = 0; i < operators.Count; i++)
            {
                Console.WriteLine(operators[i]);
            }

            int[,] table1 = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            int rowCount = table1.GetUpperBound(0) + 1;
            int columnCount = table1.GetUpperBound(1) + 1;
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    Console.Write(table1[i,j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
