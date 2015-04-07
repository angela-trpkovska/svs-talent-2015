using App1.Common;
using App1.Helpers;
using App1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Accounts
{
    public sealed class LoanAccount:DepositAccount,ILoanAccount
    {

        public CurrencyAmount balance;
        

        public LoanAccount(string currency, TimePeriod depositPeriod, InterestRate interestRate, DateTime startDate, DateTime endDate, ITransactionAccount transactionAccount)
            : base(currency, depositPeriod, interestRate, startDate, endDate, transactionAccount)
        {
            balance = base.Balance;
        }



         public  override  TransactionStatus DebitAmount(CurrencyAmount Amount)
        {
            balance.amount += Amount.amount;
            return TransactionStatus.Completed;
        }


         public  override  TransactionStatus CreditAmount(CurrencyAmount Amount)
        {
            balance.amount -= Amount.amount;
            return TransactionStatus.Completed;
        
        }


         protected override string GenerateAccountNumber()
         {
             Type ta = typeof(LoanAccount);
             return AccountHelper.GenerateAccountNumber(ta, ID);

         }
    }
}
