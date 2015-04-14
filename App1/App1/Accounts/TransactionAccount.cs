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
    /// class for the transaction account
    /// </summary>
    /// 
    [AccountMetadata(AccountDescription = "This is transaction account", AccountLimitations = "This account is only for transaction")]
    public class TransactionAccount:Account,ITransactionAccount
    {
        private CurrencyAmount limit;

        public CurrencyAmount Limit
        {
            get { return limit; }
            private set { limit = value; }
        }

        /// <summary>
        /// conustructor with two parametars for the transaction account
        /// </summary>
        /// <param name="currency">parametar for the currency</param>
        /// <param name="limitAmount">parametar for the limit amount</param>
        public TransactionAccount(string currency, decimal limitAmount):base(currency)
        {
           limit = new CurrencyAmount(limitAmount, currency);
        }



        /// <summary>
        /// method to generate account number by calling method from  AcountHelper
        /// </summary>
        /// <returns></returns>
        protected override string GenerateAccountNumber()
        {
            //Type ta = typeof(TransactionAccount);
            //return AccountHelper.GenerateAccountNumber<TransactionAccount>(ta,ID);
            return AccountHelper.GenerateAccountNumber<TransactionAccount>(ID);
        }
    }
}
