using System.Diagnostics;
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
            Assert.AreEqual(res, "Сто три доллара США 64 цента");
        }
        [TestMethod]
        public void TestMethod2()
        {
            string res = CurPhrase(103236.61M);
            Assert.AreEqual(res, "Сто три тысячи двести тридцать шесть долларов США 61 цент");
        }
        [TestMethod]
        public void TestMethod3()
        {
            string res = CurPhrase(10300842.57M);
            Assert.AreEqual(res, "Десять миллионов триста тысяч восемьсот сорок два доллара США 57 центов");
        }


        private string CurPhrase(decimal sum)
        {
            return Propis.CurrencyPhrase(sum, 840);
        }   
    }
}