using App1.Accounts;
using App1.Common;
using App1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Processors
{
    public class TransactionLogEntry
    {
        private TransactionType type;
        private CurrencyAmount amount;
        private IAccount[] accounts;
        private TransactionStatus status;


        public TransactionType Type
        {
          get {  return type;}
        }

        public CurrencyAmount CurrencyAmount
        {
            get { return amount; }
        
        }

        public IAccount[] Accounts {
            get { return accounts; }
          
        }

        public  TransactionStatus Status{
            get {
                return status;
            }
        }

        public TransactionLogEntry(TransactionType type, CurrencyAmount cAmount,IAccount[] accounts1, TransactionStatus status1)
        {
            // TODO: Complete member initialization
            this.type = type;
            this.amount = cAmount;
            this.accounts = accounts1;
            this.status = status1;
        }



    }
}
