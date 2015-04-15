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
    /// <summary>
    /// class for the deposit account
    /// </summary>
    /// 
    [AccountMetadata(AccountDescription="This is deposit account",AccountLimitations="This account is only for deposit")]
    public class DepositAccount:Account,IDepositAccount
    {
       private TimePeriod period;

        public TimePeriod Period
        {
            get { return period; }
            private set { period = value; }
        }
        private InterestRate interest;

        public InterestRate Interest
        {
             get { return interest; }
            private set { interest = value; }
        }
        private DateTime startDate;

        public DateTime StartDate
        {
            get { return startDate; }
            private set { startDate = value; }
        }
        private DateTime endDate;

        public DateTime EndDate
        {
             get { return endDate; }
            private set { endDate = value; }
        }
        private ITransactionAccount transactionAccount;

        public ITransactionAccount TransactionAccount
        {
             get { return transactionAccount; }
            private set { transactionAccount = value; }
        }

        /// <summary>
        /// constructor with parametars for the deposit account
        /// </summary>
        /// <param name="currency"></param>
        /// <param name="depositPeriod"></param>
        /// <param name="interestRate"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="transactionAccount"></param>
        public DepositAccount(string currency,TimePeriod depositPeriod,InterestRate interestRate,DateTime startDate,DateTime endDate,ITransactionAccount transactionAccount):base(currency)
        {
            this.period = depositPeriod;
            this.interest = interestRate;
            this.startDate = startDate;
            this.endDate = endDate;
            this.transactionAccount = transactionAccount;

        }


        /// <summary>
        /// method to generate account number by calling method from  AcountHelper
        /// </summary>
        /// <returns></returns>
        protected override string GenerateAccountNumber()
        {
           
           // Type depostiAccount = typeof(DepositAccount);
            //return AccountHelper.GenerateAccountNumber(depostiAccount, ID);
            return AccountHelper.GenerateAccountNumber<DepositAccount>(ID);
        }
    }
}
