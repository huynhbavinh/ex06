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
            Assert.AreEqual(2000, acc1.balance());
        }
        [TestMethod]
        public void Testdposit()
        {
            BankAccount acc2 = new BankAccount(2000);

            Assert.AreEqual(4000, acc2.deposit(2000));
        }
        [TestMethod]
        public void TestdWithDraw()
        {
            BankAccount acc3 = new BankAccount(2000);
            Assert.AreEqual(1000, acc3.withDraw(1000));
        }
    }
}
