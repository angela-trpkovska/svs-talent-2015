using App1.Common;
using App1.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Processors
{
   public class TransactionProcessor:ITransactionProcessor
    {


       public IList<TransactionLogEntry> _transactionLog;
       private TransactionLogEntry lastTransaction;
       private int transactionCount = 0;
       //instance for the singelton pattern
       private static TransactionProcessor instance;


       public int TransactionCount
       {
           get { return _transactionLog.Count; }

          private  set {
              transactionCount = _transactionLog.Count;
           }
       }



       public TransactionLogEntry LastTransaction
       {
           get {
               if (_transactionLog.Count == 0)
                   return null;
               else
                   return _transactionLog[_transactionLog.Count-1];
           
           }
       }


       public TransactionLogEntry this[int index]
       {
           get {
               if (index > _transactionLog.Count)
                   return null;

               else
                   return (TransactionLogEntry)_transactionLog[index];
           
           }
       }


   


       private TransactionProcessor()
       {
           _transactionLog = new ArrayList();

        
       }







       private void LogTransaction(TransactionType type, CurrencyAmount cAmount, IAccount[] accounts,TransactionStatus status)
       {
           TransactionLogEntry tLogEntry = new TransactionLogEntry(type,cAmount,accounts,status);

           _transactionLog.Add(tLogEntry);

           

        
          
       
       }


        public TransactionStatus processTransaction(TransactionType transactionType, CurrencyAmount amount, IAccount accountFrom, IAccount accountTo)
        {

            IAccount[] accounts=new IAccount[2];

           switch (transactionType)
            {
                case TransactionType.Transfer:
                    accountFrom.DebitAmount(amount);
                    accountTo.CreditAmount(amount);
                    accounts[0]=accountFrom;
                    accounts[1]=accountTo;
                    LogTransaction(transactionType, amount, accounts,TransactionStatus.Completed);

                    return TransactionStatus.Completed;

                case TransactionType.Debit:
                    accountFrom.DebitAmount(amount);
                    accounts[0] = accountFrom;
                    LogTransaction(transactionType, amount, accounts, TransactionStatus.Completed);
                    return TransactionStatus.Completed;

                case TransactionType.Credit:
                    accountFrom.CreditAmount(amount);
                   accounts[0] = accountFrom;
                    LogTransaction(transactionType, amount, accounts, TransactionStatus.Completed);
                    return TransactionStatus.Completed;

                default:
                    
                    return TransactionStatus.Failed;
            }


        }








        public TransactionStatus ProcessGroupTransaction(TransactionType transactionType, CurrencyAmount amount, IAccount[] accounts)
        {
            if (transactionType != TransactionType.Credit || transactionType != TransactionType.Debit)
                return TransactionStatus.Failed;
            else
            {
                foreach (IAccount element in accounts)
                {
                    if (transactionType == TransactionType.Credit)
                        element.CreditAmount(amount);
                    else
                        //then is debit account
                        element.DebitAmount(amount);
              }


                LogTransaction(transactionType, amount, accounts, TransactionStatus.Completed);
                return TransactionStatus.Completed;
           }
       }



       public static  ITransactionProcessor GetTransactionProcessor()
       {
           if (instance == null)
           {
               instance = new TransactionProcessor();
           }

           return instance;
         }


       


        
    }
}
