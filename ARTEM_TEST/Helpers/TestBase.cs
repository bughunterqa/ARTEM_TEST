using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARTEM_TEST
{
    [TestFixture]
    public class TestBase
    {

        [SetUp]
        public void Initialize()
        {
            Browser.Initialize();
        }


        [OneTimeTearDown]
        public static void TestFixtureTearDown()
        {
            Browser.Close();
        }


        [TearDown]
        public static void TearDown()
        {
            //Browser.Goto("");

        }
    }
}
