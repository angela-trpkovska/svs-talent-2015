using App1.Accounts;
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





    }
}
