using System.Runtime.Intrinsics.X86;
using static Bank_account_class_QA.Program;
namespace BankAccountTest
    
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDebitPositiveScenario()
        {
            double expected = 45;
            BankAccount b1 = new (50, "Aziz");
            b1.Debit(5);
            Assert.AreEqual(b1.balance, expected);
        }
        [TestMethod]
        public void TestDebitNegativeScenario()
        {
            string expected = "Transaction incomplete, please check your credentials.";
            BankAccount b1 = new(50, "Aziz");
            try
            {
                b1.Debit(100);
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message, expected);
            }
        }
        [TestMethod]
        public void TestCreditPositiveScenario()
        {
            double expected = 100;
            BankAccount b1 = new(50, "Aziz");
            b1.Credit(50);
            Assert.AreEqual(b1.balance, expected);
        }
        [TestMethod]
        public void TestCreditNegativeScenario()
        {
            string expected = "Transaction incomplete, please insert a valid sum";
            BankAccount b1 = new(50, "Aziz");
            try
            {
                b1.Credit(-5);
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message, expected);
            }
        }
    }
}