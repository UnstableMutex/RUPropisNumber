namespace RuPropisNumber.UnitTests
{
    [TestClass]
    public class UnitTestGBP
    {
        [TestMethod]
        public void TestMethod1GBP()
        {
            string res = CurPhrase(103.64M);
            Assert.AreEqual(res, "Сто три фунта стерлингов 64 пенса");
        }
        [TestMethod]
        public void TestMethod2GBP()
        {
            string res = CurPhrase(103236.61M);
            Assert.AreEqual(res, "Сто три тысячи двести тридцать шесть фунтов стерлингов 61 пенни");
        }
        [TestMethod]
        public void TestMethod3GBP()
        {
            string res = CurPhrase(10300842.57M);
            Assert.AreEqual(res, "Десять миллионов триста тысяч восемьсот сорок два фунта стерлингов 57 пенсов");
        }
        private string CurPhrase(decimal sum)
        {
            return Propis.CurrencyPhrase(sum, 826);
        }
    }
}