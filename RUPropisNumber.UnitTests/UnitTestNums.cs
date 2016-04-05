using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RUPropisNumber.UnitTests
{
    [TestClass]
    public class UnitTestNums
    {
        [TestMethod]
        public void TestMethod5()
        {
            string res = Propis.NumPhrase(42, true);
            Assert.AreEqual(res, "Сорок два");
        }
        [TestMethod]
        public void TestMethod6()
        {
            string res = Propis.NumPhrase(42, false);
            Assert.AreEqual(res, "Сорок две");
        }
    }
}