using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RUPropisNumber.UnitTests
{
    [TestClass]
    public class UnitTestFormatter
    {
        [TestMethod]
        public void TestFormatter()
        {
            var f=new PropisFormatProvider();
            string res = string.Format(f, "({0:643})", 456);
            Assert.AreEqual(res, "(Четыреста пятьдесят шесть рублей 00 копеек)");
        }
    }
}