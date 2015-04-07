using App1.Common;
using App1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Processors
{
   public class TransactionProcessor:ITransactionProcessor
    {


        public TransactionStatus processTransaction(TransactionType transactionType, CurrencyAmount amount, IAccount accountFrom, IAccount accountTo)
        {
            switch (transactionType)
            {
                case TransactionType.Transfer:
                    accountFrom.DebitAmount(amount);
                    accountTo.CreditAmount(amount);
                    return TransactionStatus.Completed;

                case TransactionType.Debit:
                    accountFrom.DebitAmount(amount);
                    return TransactionStatus.Completed;

                case TransactionType.Credit:
                    accountFrom.CreditAmount(amount);
                    return TransactionStatus.Completed;

                default:
                    return TransactionStatus.Failed;
            }

           
        }
    }
}
