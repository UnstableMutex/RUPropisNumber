using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PretentionCreator.StringFormatter;

namespace RUPropisNumber.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string res = CurPhrase(103.64M);
        }

        private string CurPhrase(decimal sum)
        {
            return Propis.CurPhrase(sum, PropisList.Big643, PropisList.Small643);
        }
    }
}
