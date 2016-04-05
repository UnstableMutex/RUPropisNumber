using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RUPropisNumber.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string res = CurPhrase(103.64M);
            Assert.AreEqual(res, "Сто три рубля 64 копейки");
        }
        [TestMethod]
        public void TestMethod2()
        {
            string res = CurPhrase(103236.61M);
            Assert.AreEqual(res, "Сто три тысячи двести тридцать шесть рублей 61 копейка");
        }

        [TestMethod]
        public void TestMethod3()
        {
            string res = Propis.NumPhrase(103456,true);
            Assert.AreEqual(res, "Сто три тысячи четыреста пятьдесят шесть");
        }

        [TestMethod]
        public void TestMethod4()
        {
            string res = Propis.NumPhrase(103456,true);
            Assert.AreEqual(res, "Сто три тысячи четыреста пятьдесят шесть");
        }
        [TestMethod]
        public void TestMethod5()
        {
            string res = Propis.NumPhrase(42,true);
            Assert.AreEqual(res, "Сорок два");
        }
        [TestMethod]
        public void TestMethod6()
        {
            string res = Propis.NumPhrase(42,false);
            Assert.AreEqual(res, "Сорок две");
        }
        private string CurPhrase(decimal sum)
        {
            return Propis.CurrencyPhrase(sum, 643);
        }
    }
}
