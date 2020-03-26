﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CastleWindsorUnitTesting
{
    public class BankAccount
    {
        private IFinancialService financialService;
        private const decimal operationLimit = 2000;
        private const decimal minimumBalanceForCreditElegibility = 30000;
        protected decimal balance;

        public decimal Balance => this.balance;

        public BankAccount(IFinancialService financialService, decimal balance = 0)
        {
            this.financialService = financialService;
            this.balance = balance;
        }

        public void PutMoney(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("It is only possible to add positive values");

            this.balance += amount;
        }

        public virtual void Withdraw(decimal amount)
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
