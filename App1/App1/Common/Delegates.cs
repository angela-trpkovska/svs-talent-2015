using App1.Common;
using App1.Interfaces;
using System;
public delegate void TransactionLogger(IAccount account,TransactionType transactionType,CurrencyAmount amount);

public delegate void BalanceChanged(System.Object sender,BalanceChangedEventArguments bceArgs);

public class BalanceChangedEventArguments : EventArgs
{
    private IAccount account;
    private CurrencyAmount currencyAmount;


    public IAccount Account { get { return account; } private set { account = value; } }
    public CurrencyAmount Change { get { return currencyAmount; } private set { currencyAmount = value; } }

    public BalanceChangedEventArguments(IAccount account, CurrencyAmount change)
    {
        Account = account;
        Change = change;
    }

}
