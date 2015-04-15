using App1.Common;
using App1.Interfaces;
using App1.Helpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Processors
{
   public  class TransactionProcessor:ITransactionProcessor
    {
       //public IList _transactionLog;
       public IList<TransactionLogEntry> _transactionLog;
       //private TransactionLogEntry lastTransaction;
       //private int transactionCount;
       //instance for the singelton pattern
       private static TransactionProcessor instance;

       public int TransactionCount
       {
           get { return _transactionLog.Count; }
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
                   return _transactionLog[index];
              }
       }

       TransactionLogger tlogger;


       //implement this property??

       public TransactionLogger ExternalLogger
       {
           get { return tlogger; }
           set { }
       }






       private TransactionProcessor()
      {
        _transactionLog = new List<TransactionLogEntry>();
        TransactionLogger tl1 = new TransactionLogger(AccountHelper.LogTransaction);
        TransactionLogger tl2 = new TransactionLogger(AccountHelper.NotifyNationalBank);
        tlogger = (TransactionLogger)Delegate.Combine(tl1, tl2);
      }

       
       /// <summary>
       /// method that will create an instance of the TransactionLogEntry class and add this instance in the _transactionLog collection
       /// </summary>
       /// <param name="type"></param>
       /// <param name="cAmount"></param>
       /// <param name="accounts"></param>
       /// <param name="status"></param>
     private void LogTransaction(TransactionType type, CurrencyAmount cAmount, IAccount[] accounts,TransactionStatus status)
       {
          _transactionLog.Add(new TransactionLogEntry(type, cAmount, accounts, status));
       }
      

       /// <summary>
       /// method to procees transaction between two accounts
       /// </summary>
       /// <param name="transactionType"></param>
       /// <param name="amount"></param>
       /// <param name="accountFrom"></param>
       /// <param name="accountTo"></param>
       /// <returns></returns>
        public  TransactionStatus processTransaction(TransactionType transactionType, CurrencyAmount amount, IAccount accountFrom, IAccount accountTo)
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
                    //delegate method
                    CallExternalLogger(accountFrom, TransactionType.Debit, amount);
                   //
                    accounts[0] = accountFrom;
                    LogTransaction(transactionType, amount, accounts, TransactionStatus.Completed);
                    
                    return TransactionStatus.Completed;

                case TransactionType.Credit:
                    accountFrom.CreditAmount(amount);
                    //delegate method
                    CallExternalLogger(accountFrom, TransactionType.Credit, amount);
                    //
                    accounts[0] = accountFrom;
                    LogTransaction(transactionType, amount, accounts, TransactionStatus.Completed);
                    return TransactionStatus.Completed;

                default:
                   return TransactionStatus.Failed;
            }
        }



       /// <summary>
       /// method to process group transactions from array of accounts
       /// </summary>
       /// <param name="transactionType"></param>
       /// <param name="amount"></param>
       /// <param name="accounts"></param>
       /// <returns></returns>
        public TransactionStatus ProcessGroupTransaction(TransactionType transactionType, CurrencyAmount amount, IAccount[] accounts)
        {
            //if (!transactionType.Equals(TransactionType.Credit) || !(transactionType.Equals(TransactionType.Debit)))
             //return TransactionStatus.Failed;
            //else
            //{
                foreach (IAccount element in accounts)
                {
                    if (transactionType == TransactionType.Credit)
                    {
                        element.CreditAmount(amount);
                        CallExternalLogger(element, transactionType, amount);
                    }
                    else
                    {
                        //then is debit account
                        element.DebitAmount(amount);
                        CallExternalLogger(element, transactionType, amount);
                    }
                }
                LogTransaction(transactionType, amount, accounts, TransactionStatus.Completed);
                return TransactionStatus.Completed;
           //}
       }


       /// <summary>
        /// create an instance that implements the ITransactionProcesor interface using the Singleton pattern
       /// </summary>
       /// <returns></returns>
       public static  ITransactionProcessor GetTransactionProcessor()
       {
           if (instance == null)
           {
               instance = new TransactionProcessor();
           }
           return instance;
        }


       private void CallExternalLogger(IAccount account,TransactionType type,CurrencyAmount currencyAmount)
       {

           tlogger.Invoke(account, type, currencyAmount);
       }








       public TransactionStatus ChargeProcessingFee(CurrencyAmount amount, IEnumerable<IAccount> accounts)
       {
           throw new NotImplementedException();
       }
    }
}
