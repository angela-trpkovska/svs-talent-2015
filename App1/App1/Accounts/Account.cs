using App1.Common;
using App1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Accounts
{
    /// <summary>
    /// class for info about Account
    /// </summary>
    /// 

    public abstract class Account :IAccount
    {
        /// <summary>
        /// this is a field for the id of an account
        /// </summary>
        private long id;

        public long ID
        {
             get { return id; }
            private set { id = value; }
        }

        /// <summary>
        /// this is a field for the number of an account
        /// </summary>
        private string number;

        public string Number
        {
            get { return number; }
            private set { number = value; }
        }

        /// <summary>
        /// this is the field for a currency of an account
        /// </summary>
        private string currency;

        public string Currency
        {
             get; private set;
        }

        /// <summary>
        /// 
        /// </summary>
        private CurrencyAmount balance;

        public CurrencyAmount Balance
        {
            get { return balance; }
            private set { balance = value; }
        }


        

        //public CurrencyAmount Balance { get { return balance; } private set { balance = value; } }


        /// <summary>
        /// this is the constructor with three arguments
        /// </summary>
        /// <param name="id">the id for the account</param>
        /// <param name="number">the number of account</param>
        /// <param name="currency">the currency for the account</param>
        public Account(long id, string number, string currency)
        {
            this.ID = id;
            this.Number = number;
            this.Currency = currency;
            this.Balance = new CurrencyAmount();
            
        }

        /// <summary>
        /// constructor with input parametar currency
        /// </summary>
        /// <param name="currency">the currency for the account</param>
        public Account(string currency) : this(-1, "X", currency)
        {
        }

        //public Account()
        //{ 
        //}

#region PublicMethods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public  virtual TransactionStatus DebitAmount(CurrencyAmount amount)
        {
            if (sameCurrency(balance, amount))
            {
                decimal result = balance.Amount - amount.Amount;

                if (result > 0)
                {
                    balance.Amount -= amount.Amount;
                    return TransactionStatus.Completed;
                }
                else
                    return TransactionStatus.Failed;
            }
            return TransactionStatus.InProcess;

         }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public virtual TransactionStatus CreditAmount(CurrencyAmount amount)
        {
            if (sameCurrency(balance,amount))
            {
                balance.Amount += amount.Amount;
                return TransactionStatus.Completed;
                }
                else
                    return TransactionStatus.Failed;
        }
#endregion


        #region PrivateMethods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ca1"></param>
        /// <param name="ca2"></param>
        /// <returns></returns>
        private bool sameCurrency(CurrencyAmount ca1, CurrencyAmount ca2)
        {
            if (ca1.Currency.Equals(ca2.Currency))
                return true;
            else return false;
        }


        #endregion

    }
}


