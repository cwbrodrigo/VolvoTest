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

        [TestMethod]
        public void TestName()
        {
            string name = "Caminhao";

            Assert.IsFalse(string.IsNullOrEmpty(name));
        }

        [TestMethod]
        public void ModelYearTest()
        {
            string year = "2020";

            Assert.IsTrue(ModelYearTestCompare(year));
        }

        public bool ModelYearTestCompare(string year)
        {
            if (string.Equals(year, "2020") || string.Equals(year, "2021"))
                return true;

            return false;
        }
    }
}
