using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccount;
namespace TestBank
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void creditTest()
        {
            double expected = 24;
            MyBankAccount b = new MyBankAccount("dshcb", 23);
            b.Credit(1);
            Assert.AreEqual(expected, b.GetBalance());
        }
        [TestMethod]
        public void depitTest()
        {
            double expected = 2;
            MyBankAccount b = new MyBankAccount("dshcb", 23);
            b.Debit(21);
            Assert.AreEqual(expected, b.GetBalance());
        }
    }
}
