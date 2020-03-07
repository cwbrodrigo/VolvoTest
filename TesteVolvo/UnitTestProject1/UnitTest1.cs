using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestYearMethod()
        {
            string year = "2020";

            Assert.AreEqual(year,"2020");
        }

        public void TestName()
        {
            string name = "Caminhao";

            Assert.IsFalse(string.IsNullOrEmpty(name));
        }
    }
}
