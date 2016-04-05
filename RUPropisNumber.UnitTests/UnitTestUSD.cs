using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RUPropisNumber.UnitTests
{
    [TestClass]
    public class UnitTestUSD
    {

        [TestMethod]
        public void TestMethod1()
        {
            string res = CurPhrase(103.64M);
            Assert.AreEqual(res, "Сто три доллара 64 цента");
        }
        [TestMethod]
        public void TestMethod2()
        {
            string res = CurPhrase(103236.61M);
            Assert.AreEqual(res, "Сто три тысячи двести тридцать шесть долларов 61 цент");
        }


      
        private string CurPhrase(decimal sum)
        {
            return Propis.CurrencyPhrase(sum, 840);
        }   
    }
}