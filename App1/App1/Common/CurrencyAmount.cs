using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Common
{
    /// <summary>
    /// structure for currency and amount
    /// </summary>
    public struct CurrencyAmount
    {
        /// <summary>
        /// field for the amount
        /// </summary>
        public decimal amount;

        /// <summary>
        /// field for the currency
        /// </summary>
        public string currency;

       /// <summary>
        /// parameterized constructor
       /// </summary>
       /// <param name="amount">variable for the amount</param>
        /// <param name="currency">variable for the currency</param>
        public CurrencyAmount(decimal amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }
        

    }
}
