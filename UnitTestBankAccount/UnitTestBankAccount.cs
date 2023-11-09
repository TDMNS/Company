using BankAccount;

namespace UnitTestBankAccount
{
    [TestClass]
    public class UnitTestBankAccount
    {
        [TestMethod]
        public void TestCreateAcccount()
        {
            string customer = "Иванов Иван";
            double balance = 150.0;
            Account account = new Account(customer, balance);
            Assert.AreEqual(account.Customer, customer);
            Assert.AreEqual(account.Balance, balance);
        }

        [TestMethod]
        public void TestCredit()
        {
            string customer = "Иванов Иван";
            double balance = 150.0;
            Account account = new Account(customer, balance);
            double delta = 0.01;
            double amount = 12.52;
            double actualResult = 162.52;
            account.Credit(amount);
            double result = account.Balance;
            Assert.AreEqual(actualResult, result, delta);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestCreditWithAmountLessThanZero()
        {
            string customer = "Иванов Иван";
            double balance = 150.0;
            Account account = new Account(customer, balance);
            double delta = 0.01;
            double amount = -12.52;
            account.Credit(amount);
        }
    }
}
