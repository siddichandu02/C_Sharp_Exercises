using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleWindsorUnitTest
{
    public class BankAccount
    {
        private IFinancialService financialService;
        private const decimal operationLimit = 2000;
        private const decimal minimumBalanceForCreditElegibility = 30000;
        protected decimal balance=0;

        public decimal Balance => this.balance;

        public BankAccount(IFinancialService financialService)
        {
            this.financialService = financialService;
        }

        public void PutMoney(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("It is only possible to add positive values");

            this.balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > operationLimit)
                throw new InvalidOperationException();

            this.balance -= amount;
        }

        public bool IsElegibleForCredit()
        {
            return this.balance >= minimumBalanceForCreditElegibility;
        }

        public string GetFinancialScore()
        {
            return this.financialService.GetFinancialScore(this.balance);

        }
    }
}
