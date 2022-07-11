using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    
    public class rep
    {
        public rep()
        {

        }
        public rep(string FIO, byte age = 18)
        {
            this.FIO = FIO;
            this.age = age;
        }
        public string FIO;
        public byte age;
        
        public static void SayStudent()
        {
            Console.WriteLine("Я студент");
        }

        public void SayHello()
        {
            Console.WriteLine("Привет, "+FIO);
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            rep rop = new rep();
            //{
            //    FIO = "Роп",
            //    age = 18

            //};
            
            
            rop.SayHello();
            Console.ReadKey();
        }
    }
}
