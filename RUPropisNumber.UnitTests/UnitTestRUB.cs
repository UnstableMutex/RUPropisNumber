using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RuPropisNumber.UnitTests
{
    [TestClass]
    public class UnitTestRUB
    {
        [TestMethod]
        public void TestMethod1RUB()
        {
            string res = CurPhrase(103.64M);
            Assert.AreEqual(res, "Сто три рубля 64 копейки");
        }
        [TestMethod]
        public void TestMethod2RUB()
        {
            string res = CurPhrase(103236.61M);
            Assert.AreEqual(res, "Сто три тысячи двести тридцать шесть рублей 61 копейка");
        }
        private string CurPhrase(decimal sum)
        {
            return Propis.CurrencyPhrase(sum, 643);
        }
    }
}
