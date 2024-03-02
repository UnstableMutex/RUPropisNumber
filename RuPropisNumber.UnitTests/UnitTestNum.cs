namespace RuPropisNumber.UnitTests
{
    [TestClass]
    public class UnitTestNums
    {
        [TestMethod]
        public void TestMethod5Nums()
        {
            string res = Propis.NumPhrase(42, true);
            Assert.AreEqual(res, "Сорок два");
        }
        [TestMethod]
        public void TestMethod6Nums()
        {
            string res = Propis.NumPhrase(42, false);
            Assert.AreEqual(res, "Сорок две");
        }
    }
}
