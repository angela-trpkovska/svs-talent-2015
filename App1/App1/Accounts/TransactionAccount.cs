using App1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Accounts
{
    public class TransactionAccount:Account
    {
        private CurrencyAmount limit;

        public CurrencyAmount Limit
        {
            public get { return limit; }
            private set { limit = value; }
        }

        public TransactionAccount(string currency, decimal limitAmount):base(currency)
        {
            limit.Amount = limitAmount;

        }

    }
}
