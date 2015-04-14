using App1.Accounts;
using App1.Common;
using App1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Helpers
{
    public static class AccountHelper
    {
        /// <summary>
        /// static variable for the account id
        /// </summary>
        public static int s_AccountId;

        /// <summary>
        /// static constructor
        /// </summary>
        static AccountHelper()
        {
            s_AccountId = 0;
        }

        /// <summary>
        /// method to return int value
        /// </summary>
        /// <returns></returns>
        public static int GenerateAccountId()
        {
            return s_AccountId++;
        }

        
        public static string GenerateAccountNumber(Type accountType,long accountId)
        {
            Type transactionAccount = typeof(TransactionAccount);
            if (accountType.Equals(transactionAccount))
            {
                return "TR0000" + accountId;
            }

            Type depositAccount = typeof(DepositAccount);
            if (accountType.Equals(depositAccount))
            {
                return "DP0000" + accountId;
            }

            Type loanAccount = typeof(LoanAccount);
            if (accountType.Equals(loanAccount))
            {
                return "LN0000" + accountId;
            }

            return string.Empty;
        }

        /// <summary>
        /// overided and generic method
        /// </summary>
        /// <param name="accountID"></param>
        public static string GenerateAccountNumber<A>(long accountId) where A: IAccount
        {
            Type type = typeof(A);
            return GenerateAccountNumber(type, accountId);
        }

        /// <summary>
        /// method with logic that will check whether the amount exceeds 20000 MKD
        /// </summary>
        /// <param name="account"></param>
        /// <param name="transactionType"></param>
        /// <param name="amount"></param>
        public static void LogTransaction(IAccount account, TransactionType transactionType, CurrencyAmount amount)
        {
            if (amount.amount > 20000 && amount.currency.Equals("MKD"))
            {
                System.Console.WriteLine("{0} {1} {2} {3}",account.Number,transactionType,amount.amount,amount.currency);
                
            }
        }


        /// <summary>
        /// method to notify the national bank
        /// </summary>
        /// <param name="account"></param>
        /// <param name="transactionType"></param>
        /// <param name="amount"></param>
        public static void NotifyNationalBank(IAccount account, TransactionType transactionType, CurrencyAmount amount)
        {
           if (amount.amount > 25000 && amount.currency.Equals("MKD"))
               System.Console.WriteLine("There has been a transaction with big amount");
              
        }

        

    }
}
