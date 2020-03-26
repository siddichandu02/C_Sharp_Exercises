using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace CastleWindsorUnitTest
{
    [TestClass]
    public class UnitTest
    {
        BankAccount bankAccount;
        [TestInitialize]
       public void SetUp()
        {
            var container = new WindsorContainer();

            container.Register(Component.For<IFinancialService>().ImplementedBy<FinancialService>());

            container.Register(Component.For<BankAccount>());
            bankAccount = container.Resolve<BankAccount>();

        }
        
        [TestMethod]
        public void GetFinancialScoreTests()
        {
            // Arrange
            decimal balance = 1000;
            string expected = "Bad";

             
            bankAccount.PutMoney(balance);

            // Act
            string actual = bankAccount.GetFinancialScore();

            // Assert
            Assert.AreEqual(actual, expected);
        }
    
    }
}
