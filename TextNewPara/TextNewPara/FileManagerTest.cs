using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextNewPara
{
    [TestFixture]
    class FileManagerTest
    {
        [Test]
        public void FindLogFileTest1()
        {
            FileManager mgr = new FileManager();
            Assert.IsTrue(mgr.FindLogFile("file2.log"));
        }
    }
}
