using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using bank;

namespace UnitTestProject1
{
    [TestClass]
    public class bankTest
    {
        [TestMethod]
        public void TestMethodBankAccount()
        {
            BankAccount acc1 = new BankAccount(2000);

            Assert.IsNotNull(acc1);
            Assert.IsInstanceOfType(acc1, typeof(BankAccount));
            Assert.AreEqual(0, acc1.balance());
        }
    }
}
