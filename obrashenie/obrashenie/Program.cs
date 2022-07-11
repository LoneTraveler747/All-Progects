using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace obrashenie
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dainilovloh = new DirectoryInfo("C:\\loh\\");
            FileInfo[] files = dainilovloh.GetFiles();
            for (int i = 0; i < files.Length; i++)
                Console.WriteLine(files[i].Name);
            // dainilovloh.MoveTo("C:\\loh\\dainilovloh");
           //if (dainilovloh.Exists)
           // {
           //     dainilovloh.Delete(true);
           // }
            Console.ReadKey();
        }
    }
}
