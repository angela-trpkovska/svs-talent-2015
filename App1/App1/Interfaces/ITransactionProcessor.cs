using App1.Common;
using App1.Processors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Interfaces
{
    public interface ITransactionProcessor
    {

        TransactionLogEntry LastTransaction { get; }
        int TransactionCount { get; }
        TransactionLogEntry this[int index] { get; }

        TransactionLogger ExternalLogger { get; set; }
       



     TransactionStatus processTransaction(TransactionType transactionType, CurrencyAmount amount, IAccount accountFrom, IAccount accountTo);

     TransactionStatus ProcessGroupTransaction(TransactionType transactionType, CurrencyAmount amount, IAccount[] accounts);

     TransactionStatus ChargeProcessingFee(CurrencyAmount amount, IEnumerable<IAccount> accounts);

    }
}
