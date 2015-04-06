using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Common
{
    /// <summary>
    /// structure for currency amount
    /// </summary>
    public struct CurrencyAmount
    {
        /// <summary>
        /// field for the amount
        /// </summary>
        public decimal Amount;

        /// <summary>
        /// field for the currency
        /// </summary>
        public string Currency;


        public CurrencyAmount(decimal a, string c)
        {
            Amount = a;
            Currency = c;
        }
        

    }
}
