using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextNewPara
{
    class FileManager
    {
        public bool FindLogFile(string fileName)
        {
            TestDataObject obj = new TestDataObject();

            List<string> files = obj.GetFiles();

            foreach (var file in files)
            {
                if (file.Contains(fileName))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
