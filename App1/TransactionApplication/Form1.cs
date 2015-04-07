using App1.Accounts;
using App1.Common;
using App1.Interfaces;
using App1.Processors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransactionApplication
{
    public partial class frmMain : Form
    {

        public ITransactionAccount taccount;
        public TimePeriod tperiod;
        public UnitOfTime unit1;
        public InterestRate interestRate;
        public UnitOfTime unit2;


        public frmMain()
        {
            InitializeComponent();
        }

       
        /// <summary>
        /// method to populate info for transaction account
        /// </summary>
        /// <param name="account"></param>

        private void PopulateInfoForTransactionAccount(IAccount account)
        {
            lblID.Text = account.ID.ToString();
            lblNumber.Text = account.Number;
            lblCurrency.Text = account.Currency;
            lblBalance.Text = account.Balance.amount.ToString();

        }


        /// <summary>
        /// method to populate info for deposit account
        /// </summary>
        /// <param name="account"></param>

        private void PopulateInfoForDepositAccount(IAccount account)
        {
            lblIDto.Text = account.ID.ToString();
            lblNumberTo.Text = account.Number;
            lblCurrencyTo.Text = account.Currency;
            lblBalanceTo.Text = account.Balance.amount.ToString();
        }


        /// <summary>
        /// method to check if the account is transaction and write information in the labels
        /// </summary>
        /// <param name="account"></param>
        private void CheckTransactionAccount(IAccount account)
        {
            if (account is TransactionAccount)
            {
                ITransactionAccount ta = (ITransactionAccount)account;
                lblLimitAmount.Text= ta.Limit.amount.ToString();
                lblLimitCurrency.Text = ta.Limit.currency;
             
            }
            else {
                lblLimitAmount.Text = string.Empty;
                lblLimitCurrency.Text = string.Empty;
              }
        }




        /// <summary>
        /// method to check if the account is deposit and write information in the labels
        /// </summary>
        /// <param name="account">the parametar for the account that we check</param>
        private void CheckDepositAccount(IAccount account)
        {
            if (account is DepositAccount)
            {
                IDepositAccount da = (IDepositAccount)account;
                lblPeriod.Text = da.Period.period + " "+da.Period.unit.ToString();
                lblInterest.Text = da.Interest.percent.ToString() + " " + da.Interest.unit.ToString();
                lblStartDate.Text = da.StartDate.ToString();
                lblEndDate.Text = da.EndDate.ToString();
            }
            else
            {
                lblPeriod.Text = string.Empty;
                lblInterest.Text = string.Empty;
                lblStartDate.Text = string.Empty;
                lblEndDate.Text = string.Empty;
             }
        }


        private void btnCreateTransactionAccount_Click(object sender, EventArgs e)
        {
            string currency = txtCurrency.Text;
            decimal limitAmount =Convert.ToDecimal(txtLimit.Text);
            taccount = new TransactionAccount(currency, limitAmount);
          
            PopulateInfoForTransactionAccount(taccount);
            CheckTransactionAccount(taccount);
         }

       

        private void btnCreateDepositAccount_Click(object sender, EventArgs e)
        {
            
            Enum.TryParse(cbUnitOfTime.SelectedItem.ToString(), out unit1);
            tperiod.period = Convert.ToInt16(txtPeriod.Text);
            tperiod.unit = unit1;
            
            interestRate.percent = Convert.ToDecimal(txtInterestRate.Text);
            Enum.TryParse(cbUnitOfTime2.SelectedItem.ToString(), out unit2);
            interestRate.unit = unit2;

            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;

            IDepositAccount daccount = new DepositAccount(txtCurrency.Text, tperiod, interestRate, startDate, endDate, taccount);
            
            PopulateInfoForDepositAccount(daccount);
            CheckDepositAccount(daccount);


        }


        


        private void btnMakeTransaction_Click(object sender, EventArgs e)
        {
            string currency = txtCurrency.Text;
            decimal limitAmount = Convert.ToDecimal(txtLimit.Text);
            ITransactionAccount transactionAccount= new TransactionAccount(currency, limitAmount);

            Enum.TryParse(cbUnitOfTime.SelectedItem.ToString(), out unit1);
            tperiod.period = Convert.ToInt16(txtPeriod.Text);
            tperiod.unit = unit1;
            
            interestRate.percent = Convert.ToDecimal(txtInterestRate.Text);
            Enum.TryParse(cbUnitOfTime2.SelectedItem.ToString(), out unit2);
            interestRate.unit = unit2;

            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;

            //IDepositAccount depositAccount = new DepositAccount(txtCurrency.Text, tperiod, interestRate, startDate, endDate, transactionAccount);
            ILoanAccount loanAccount = new LoanAccount(txtCurrency.Text, tperiod, interestRate, startDate, endDate, transactionAccount);

            ITransactionProcessor tprocessor = new TransactionProcessor();
            CurrencyAmount currencyAmount=new CurrencyAmount(20000,"MKD");
            tprocessor.processTransaction(TransactionType.Transfer, currencyAmount, transactionAccount,loanAccount);

            //tprocessor.processTransaction(TransactionType.Transfer, currencyAmount, transactionAccount,depositAccount);
            PopulateInfoForTransactionAccount(transactionAccount);
            //populateInfoForDepositAccount(depositAccount);
            PopulateInfoForDepositAccount(loanAccount);

            //checkDepositAccount(depositAccount);
            CheckDepositAccount(loanAccount);
            CheckTransactionAccount(transactionAccount);


        }

    


    }
}
