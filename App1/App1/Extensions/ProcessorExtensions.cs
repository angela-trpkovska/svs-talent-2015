using App1.Common;
using App1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Extensions
{
    public static class ProcessorExtensions
    {
        public static TransactionStatus ChargeProcessingFee(ITransactionProcessor processor,CurrencyAmount amount,IEnumerable<IAccount> accounts)
        {
            return processor.ProcessGroupTransaction(TransactionType.Debit,amount,(IAccount[])accounts);
            
        }


    }
}
