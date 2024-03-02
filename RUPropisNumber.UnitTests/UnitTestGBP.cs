namespace RuPropisNumber.UnitTests
{
    [TestClass]
    public class UnitTestGBP
    {
        [TestMethod]
        public void TestMethod1GBP()
        {
            string res = CurPhrase(103.64M);
            Assert.AreEqual(res, "��� ��� ����� ���������� 64 �����");
        }
        [TestMethod]
        public void TestMethod2GBP()
        {
            string res = CurPhrase(103236.61M);
            Assert.AreEqual(res, "��� ��� ������ ������ �������� ����� ������ ���������� 61 �����");
        }
        [TestMethod]
        public void TestMethod3GBP()
        {
            string res = CurPhrase(10300842.57M);
            Assert.AreEqual(res, "������ ��������� ������ ����� ��������� ����� ��� ����� ���������� 57 ������");
        }
        private string CurPhrase(decimal sum)
        {
            return Propis.CurrencyPhrase(sum, 826);
        }
    }
}