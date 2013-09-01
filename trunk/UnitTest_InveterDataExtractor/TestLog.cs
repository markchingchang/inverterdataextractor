using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using InveterDataExtractor;

namespace UnitTest_InveterDataExtractor
{
    [TestFixture]
    class TestLog
    {

        [Test]
        public void GetDate()
        {
            Log log = new Log();
            Console.WriteLine("Tester GetDate: " + Log.GetDate());
            Assert.AreEqual(DateTime.Now.Date.ToString().Substring(0,10),Log.GetDate());


        }


        [Test]
        [Ignore]
        public void DoesExists()
        {
            Log log = new Log("Test");



            Assert.IsTrue(log.FileExists());
        }

        [Test]
        public void WriteToLog()
        {
            string appName = "Test";

            Log log = new Log(appName);

            log.WriteToLog("Dette er en tester", LogCtrl.Info);
            log.WriteToLog("Dette er en tester2", LogCtrl.Info);
           

            Assert.IsTrue(true);
        }


    }
}
