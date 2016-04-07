using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RUPropisNumber.UnitTests
{
    [TestClass]
    public class UnitTestUSD
    {


        [TestMethod]
        public void TestMethod1USD()
        {
            string res = CurPhrase(103.64M);
            Assert.AreEqual(res, "��� ��� ������� ��� 64 �����");
        }
        [TestMethod]
        public void TestMethod2USD()
        {
            string res = CurPhrase(103236.61M);
            Assert.AreEqual(res, "��� ��� ������ ������ �������� ����� �������� ��� 61 ����");
        }
        [TestMethod]
        public void TestMethod3USD()
        {
            string res = CurPhrase(10300842.57M);
            Assert.AreEqual(res, "������ ��������� ������ ����� ��������� ����� ��� ������� ��� 57 ������");
        }


        private string CurPhrase(decimal sum)
        {
            return Propis.CurrencyPhrase(sum, 840);
        }   
    }
}