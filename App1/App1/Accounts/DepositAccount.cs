using App1.Common;
using App1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Accounts
{
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
        private TransactionAccount transactionAccount;

        public TransactionAccount TransactionAccount
        {
             get { return transactionAccount; }
            private set { transactionAccount = value; }
        }

        
        public DepositAccount(string currency,TimePeriod depositPeriod,InterestRate interestRate,DateTime startDate,DateTime endDate,TransactionAccount transactionAccount):base(currency)
        {
            this.period = depositPeriod;
            this.interest = interestRate;
            this.startDate = startDate;
            this.endDate = endDate;
            this.transactionAccount = transactionAccount;

        }
            

    }
}
