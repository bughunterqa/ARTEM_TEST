using NUnit.Framework;

namespace ARTEM_TEST
{
    public class Tests : TestBase
    {

        [Test]
        public void Setup()
        {
            Pages.Login
                .EnterLogin("Art`v");
                

        }


    }
}