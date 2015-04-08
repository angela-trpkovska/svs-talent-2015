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
        private CurrencyAmount cAmount;
        private IAccount[] accounts1;
        private TransactionStatus status1;


        public TransactionType Type
        {
          get{   return type;}
        }



        public CurrencyAmount CurrencyAmount
        {
            get { return cAmount; }
        
        }

        public IAccount[] Accounts {
            get { return accounts1; }
          
        }

        public  TransactionStatus Status{
            get {
                return status1;
            }
        }





        public TransactionLogEntry(TransactionType type, CurrencyAmount cAmount,IAccount[] accounts1, TransactionStatus status1)
        {
            // TODO: Complete member initialization
            this.type = type;
            this.cAmount = cAmount;
            this.accounts1 = accounts1;
            this.status1 = status1;
        }



    }
}
