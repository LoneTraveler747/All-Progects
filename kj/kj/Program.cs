using System;

namespace kj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввдеите кол-во переменных: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int CountOperators = n - 1;
            string[] operators = new string[CountOperators];
            string[] vars = { "A", "B", "C", "D" };

            for(int i = 0; i < CountOperators; i++)
            {
                Console.WriteLine("Введите " + i + " оператор: ");
                Console.WriteLine("1) and; выберите 2)or.");
                int choice = Convert.ToInt32(Console.ReadLine());
                if(choice == 1)
                {
                    operators[i] = "and";
                }
                if(choice == 2)
                {
                    operators[i] = "or";
                }
            }

            for(int i = 0; i < operators.Length; i++)
            {
                Console.WriteLine(operators[i]);
            }

            Console.WriteLine(vars[0] + " " + operators[0] + " " + vars[1] + " " + operators [1] + " " + vars[2]);

            bool A = false;
            bool B = true;
            bool C = false;
            bool result = false;
            if(operators[0] == "and")
            {
                result = A && B;
            }

            if(operators[1] == "or")
            {
                result = result || C;
            }
                
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
