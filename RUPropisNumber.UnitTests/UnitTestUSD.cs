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
            Assert.AreEqual(res, "��� ��� ������� 64 �����");
        }
        [TestMethod]
        public void TestMethod2()
        {
            string res = CurPhrase(103236.61M);
            Assert.AreEqual(res, "��� ��� ������ ������ �������� ����� �������� 61 ����");
        }


      
        private string CurPhrase(decimal sum)
        {
            return Propis.CurrencyPhrase(sum, 840);
        }   
    }
}