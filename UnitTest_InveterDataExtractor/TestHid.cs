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
    public class TestHid
    {

        [SetUp]
        public void setup()
        {
            

        }


        [Test]
        public void IsWorking()
        {
            Console.WriteLine("Dette er en test");
            Assert.IsTrue(true);

            var checkString = "Fac,5003";


            Assert.AreEqual("Fac,5003",checkString);
        }

        [Test]
        public void IsNotWorking()
        {
            Console.WriteLine("Dette er en test");
            Assert.IsTrue(true);

            var checkString = "Iac,5003";

            if (checkString == "2")
            {
                int i = 2;
                i++;
            }


            Assert.AreNotEqual("Fac,5003", checkString);
        }

        [Test]
        public void sjov()
        {
            MsgHandler test = new MsgHandler();

            var check = test.getCmd(4);


            Assert.AreEqual("True",check);

        }


    }
}
