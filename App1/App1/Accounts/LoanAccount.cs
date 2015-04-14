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
    [AccountMetadata(AccountDescription = "This is Loan account", AccountLimitations = "This account is only for loan")]
    public sealed class LoanAccount:DepositAccount,ILoanAccount
    {

        private CurrencyAmount balance;

        public CurrencyAmount Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        

        public LoanAccount(string currency, TimePeriod depositPeriod, InterestRate interestRate, DateTime startDate, DateTime endDate, ITransactionAccount transactionAccount)
            : base(currency, depositPeriod, interestRate, startDate, endDate, transactionAccount)
        {
            balance = base.Balance;
        }



         public  override  TransactionStatus DebitAmount(CurrencyAmount Amount)
        {
            if (Amount.currency.Equals(balance.currency))
            {
               balance.amount += Amount.amount;
                return TransactionStatus.Completed;
            }
            return TransactionStatus.Failed;
        }


         public  override  TransactionStatus CreditAmount(CurrencyAmount Amount)
        {
            if (Amount.currency.Equals(balance.currency))
            {
                balance.amount -= Amount.amount;
                return TransactionStatus.Completed;
            }
            return TransactionStatus.Failed;
        }


         protected override string GenerateAccountNumber()
         {
             //Type ta = typeof(LoanAccount);
             //return AccountHelper.GenerateAccountNumber(ta, ID);
             return AccountHelper.GenerateAccountNumber<LoanAccount>(ID);

         }
    }
}
