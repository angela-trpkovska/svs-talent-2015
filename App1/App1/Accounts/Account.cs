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
    /// class for informations about Account
    /// </summary>
    /// 

    public abstract class Account:IAccount
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
        /// this is a filed for the balance of an account
        /// </summary>
        private CurrencyAmount balance;

        public CurrencyAmount Balance
        {
            get { return balance; }
            private set { balance = value; }
        }

       

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
            this.Balance = new CurrencyAmount(25000,currency);
        }

        /// <summary>
        /// constructor with input parametar currency
        /// </summary>
        /// <param name="currency">the currency for the account</param>
        public Account(string currency) : this(-1, "X", currency)
        {
            this.ID = AccountHelper.GenerateAccountId();
            this.Number = GenerateAccountNumber();

        }



        protected abstract string GenerateAccountNumber();
        


        #region publicMethods

        /// <summary>
        ///  method for the performing the debit operation
        /// </summary>
        /// <param name="Amount">parametar for the amount</param>
        /// <returns></returns>
        public virtual TransactionStatus DebitAmount(CurrencyAmount Amount)
        {
            if (sameCurrency(balance, Amount))
            {
                decimal result = balance.amount - Amount.amount;

                if (result > 0)
                {
                    balance.amount -= Amount.amount;
                    return TransactionStatus.Completed;
                }
                
            }
             return TransactionStatus.Failed;

        }

        /// <summary>
        /// method for the performing the credit operation
        /// </summary>
        /// <param name="amount">parametar for the amount</param>
        /// <returns></returns>
        public virtual TransactionStatus CreditAmount(CurrencyAmount Amount)
        {
            if (sameCurrency(balance,Amount))
            {
                balance.amount += Amount.amount;
                return TransactionStatus.Completed;
            }
            
            return TransactionStatus.Failed;
        }
        #endregion


        #region PrivateMethods
       
        /// <summary>
        /// private method to check if the amount provided 
        /// in the DebitAmount and CreditAmount method has the same currency as the account currency
        /// </summary>
        /// <param name="ca1">varibale for the first currency amount</param>
        /// <param name="ca2">varibale for the second currency amount</param>
        /// <returns></returns>
        private bool sameCurrency(CurrencyAmount ca1, CurrencyAmount ca2)
        {
            if (ca1.currency.Equals(ca2.currency))
                return true;
            else return false;
        }


        #endregion

    }
}


