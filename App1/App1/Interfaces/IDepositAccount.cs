using App1.Accounts;
using App1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Interfaces
{
    public interface IDepositAccount:IAccount
    {
         TimePeriod Period
        {
            get;
        }


         InterestRate Interest
        {
            get;
        }


         DateTime StartDate
        {
            get;
        }


         DateTime EndDate
        {
            get;
        }


         ITransactionAccount TransactionAccount
        {
            get;
        }



    }
}
