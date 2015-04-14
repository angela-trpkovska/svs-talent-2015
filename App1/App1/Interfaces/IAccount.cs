using App1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Interfaces
{
    public interface IAccount
    {
        long ID { get; }
        string Number { get; }
        string Currency { get; }
        CurrencyAmount Balance { get; }
        //Defining event based on delegate BalanceChanged
        event EventHandler<BalanceChangedEventArguments> OnBalanceChanged;


       TransactionStatus DebitAmount(CurrencyAmount Amount);
       TransactionStatus CreditAmount(CurrencyAmount Amount);

   }


}
