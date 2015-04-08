using App1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Interfaces
{
    public interface ITransactionProcessor
    {
     TransactionStatus processTransaction(TransactionType transactionType, CurrencyAmount amount, IAccount accountFrom, IAccount accountTo);

     TransactionStatus ProcessGroupTransaction(TransactionType transactionType, CurrencyAmount amount, IAccount[] accounts);


    }
}
