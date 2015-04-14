using App1.Accounts;
using App1.Common;
using App1.Extensions;
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

        
        public TimePeriod tperiod;
        public UnitOfTime unit1;
        public InterestRate interestRate;
        public UnitOfTime unit2;
        public ITransactionAccount taccount;
        public IDepositAccount depositAccount;
        public ILoanAccount loanAccount;
        public ITransactionProcessor transactionProcessor;


        public frmMain()
        {
            InitializeComponent();
            cbUnitOfTime.SelectedIndex = 0;
            cbUnitOfTime2.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;

            
        }

        private Dictionary<CreateAccountType, IAccount> CreateAccounts(CreateAccountType[] accountTypesToCreate, ITransactionAccount transactionAccount)
        {

            Dictionary<CreateAccountType, IAccount> dictionary = new Dictionary<CreateAccountType, IAccount>();

            foreach (CreateAccountType accountType in accountTypesToCreate)
            {

                if ((accountType & CreateAccountType.TransactionAccount) == CreateAccountType.TransactionAccount)
                {
                    taccount = CreateTransactionAccount();
                    dictionary.Add(accountType, taccount);
                }

                if ((accountType & CreateAccountType.LoanAccount) == CreateAccountType.LoanAccount)
                {
                    loanAccount = CreateLoanAccount();
                    dictionary.Add(accountType, loanAccount);
                }

                if ((accountType & CreateAccountType.DepositAccount) == CreateAccountType.DepositAccount)
                {
                    depositAccount = CreateDepositAccount();
                    dictionary.Add(accountType, depositAccount);
                }
            }
            return dictionary;

        }




        /// <summary>
        /// method to populate common fields for account
        /// </summary>
        /// <param name="account"></param>
        private void populateInfoForAccount(IAccount account)
        {
            lblID.Text = account.ID.ToString();
            lblNumber.Text = account.Number;
            lblCurrency.Text = account.Currency;
            lblBalance.Text = account.Balance.amount.ToString();
        }


        /// <summary>
        /// method to populate common fields for account
        /// </summary>
        /// <param name="account"></param>
        private void populateInfoForAccountTo(IAccount account)
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
                IDepositAccount depositAccount = (IDepositAccount)account;
                lblPeriod.Text = depositAccount.Period.period + " "+depositAccount.Period.unit.ToString();
                lblInterest.Text = depositAccount.Interest.percent.ToString() + " " + depositAccount.Interest.unit.ToString();
                lblStartDate.Text = depositAccount.StartDate.ToString();
                lblEndDate.Text = depositAccount.EndDate.ToString();
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
            ITransactionAccount taccount = CreateTransactionAccount();
            DisplayAccountDetails(taccount);

         }

       

        private void btnCreateDepositAccount_Click(object sender, EventArgs e)
        {
            depositAccount = CreateDepositAccount();
            populateInfoForAccount(depositAccount);
            CheckTransactionAccount(depositAccount);
            CheckDepositAccount(depositAccount);

        }

        


        private void btnMakeTransaction_Click(object sender, EventArgs e)
        {

            string _errorMsg=string.Empty;
            bool _errorOccurred = false;

            ITransactionAccount transactionAccount = CreateTransactionAccount();
            IDepositAccount depositAccount = CreateDepositAccount();
            ILoanAccount loanAccount = CreateLoanAccount();
          
            transactionProcessor = TransactionProcessor.GetTransactionProcessor();
            CurrencyAmount currencyAmount=new CurrencyAmount(Convert.ToDecimal(txtTransactionAmount.Text),txtTransactionCurrency.Text);

            try
            {
                transactionProcessor.processTransaction(TransactionType.Transfer, currencyAmount, transactionAccount, loanAccount);
                // tprocessor.processTransaction(TransactionType.Transfer, currencyAmount, transactionAccount,depositAccount);

                populateInfoForAccount(transactionAccount);
                CheckTransactionAccount(transactionAccount);
                //CheckDepositAccount(transactionAccount);

                populateInfoForAccountTo(loanAccount);
                // CheckTransactionAccount(loanAccount);
                CheckDepositAccount(loanAccount);

                //populateInfoForAccountTo(depositAccount);
                //CheckDepositAccount(depositAccount);

                DisplayLastTransactionDetails(transactionProcessor);


            }

            catch (CurrencyMismatchException exception)
            {
                _errorOccurred = true;
                _errorMsg = exception.Message;
                System.Console.WriteLine(_errorMsg);
            }
            catch (ApplicationException exception)
            {
                //_errorOccurred = true;
                //_errorMsg = exception.Message;
                //System.Console.WriteLine(_errorMsg);
                throw;
            }

            finally{

                if (_errorOccurred)
                {
                    MessageBox.Show(_errorMsg);
                }

            }

           

        }


        private void CheckDepositAccountTo(IAccount account)
        {
            if (account is DepositAccount)
            {
                IDepositAccount depositAccount = (IDepositAccount)account;
                lblPeriodTo.Text = depositAccount.Period.period + " " + depositAccount.Period.unit.ToString();
                lblInterestTo.Text = depositAccount.Interest.percent.ToString() + " " + depositAccount.Interest.unit.ToString();
                lblStartDateTo.Text = depositAccount.StartDate.ToString();
                lblEndDateTo.Text = depositAccount.EndDate.ToString();
            }
            else
            {
                lblPeriodTo.Text = string.Empty;
                lblInterestTo.Text = string.Empty;
                lblStartDateTo.Text = string.Empty;
                lblEndDateTo.Text = string.Empty;
            }
        
        }


        private void CheckTransactionAccountTo(IAccount account)
        {
            if (account is TransactionAccount)
            {
                ITransactionAccount ta = (ITransactionAccount)account;
                lblLimitAmountTo.Text = ta.Limit.amount.ToString();
                lblLimitCurrencyTo.Text = ta.Limit.currency;
            }
            else
            {
                lblLimitAmountTo.Text = string.Empty;
                lblLimitCurrencyTo.Text = string.Empty;
            }
        
        }


        private void CheckLoanAccount(IAccount account)
        {
            if (account is LoanAccount)
            {
                ILoanAccount loanAccount = (ILoanAccount)account;
                lblPeriod.Text = loanAccount.Period.period + " " + loanAccount.Period.unit.ToString();
                lblInterest.Text = loanAccount.Interest.percent.ToString() + " " + loanAccount.Interest.unit.ToString();
                lblStartDate.Text = loanAccount.StartDate.ToString();
                lblEndDate.Text = loanAccount.EndDate.ToString();
            }
            else
            {
                lblPeriod.Text = string.Empty;
                lblInterest.Text = string.Empty;
                lblStartDate.Text = string.Empty;
                lblEndDate.Text = string.Empty;
            }
         }



        private void CheckLoanAccountTo(IAccount account)
        {
            if (account is LoanAccount)
            {
                ILoanAccount loanAccount = (ILoanAccount)account;
                lblPeriodTo.Text = loanAccount.Period.period + " " + loanAccount.Period.unit.ToString();
                lblInterestTo.Text = loanAccount.Interest.percent.ToString() + " " + loanAccount.Interest.unit.ToString();
                lblStartDateTo.Text = loanAccount.StartDate.ToString();
                lblEndDateTo.Text = loanAccount.EndDate.ToString();
            }
            else
            {
                lblPeriodTo.Text = string.Empty;
                lblInterestTo.Text = string.Empty;
                lblStartDateTo.Text = string.Empty;
                lblEndDateTo.Text = string.Empty;
            }
        
        
        }

        public void DisplayAccountDetails(IAccount account)
        {
            populateInfoForAccount(account);
            CheckTransactionAccount(account);
            CheckDepositAccount(account);
            CheckLoanAccount(account);
        }


        public void DisplayAccountDetailsTo(IAccount account)
        {
            populateInfoForAccountTo(account);
            CheckTransactionAccountTo(account);
            CheckDepositAccountTo(account);
            CheckLoanAccountTo(account);
        }



        private void btnMakeGroupTransaction_Click(object sender, EventArgs e)
        {
            Dictionary<CreateAccountType, IAccount> dictionary;

            IAccount[] accounts = new IAccount[2];
            //use the method CreateAccounts,first call it to create only the transaction account
            //And then with one call to create Deposit and Loan account
            CreateAccountType[] catype1=new CreateAccountType[3];
            catype1[0]=CreateAccountType.TransactionAccount;
            dictionary = CreateAccounts(catype1, taccount);
            catype1[1] = CreateAccountType.DepositAccount;
            catype1[2] = CreateAccountType.LoanAccount;
            dictionary = CreateAccounts(catype1, taccount);



            //if we have created depositAccount than use that
            if (depositAccount != null)
              accounts[0] = depositAccount;
            
            //if we have created loanAccount use that
            if (loanAccount != null)
                accounts[1] = loanAccount;

             transactionProcessor = TransactionProcessor.GetTransactionProcessor();

            //TransactionType transactionType;
            // Enum.TryParse(comboBox1.SelectedItem.ToString(), out transactionType);
               
            CurrencyAmount currencyAmount = new CurrencyAmount(Convert.ToDecimal(txtTransactionAmount.Text), txtTransactionCurrency.Text);

            transactionProcessor.ProcessGroupTransaction(TransactionType.Debit, currencyAmount, accounts);

            //DisplayLastTransactionDetails();

            if (accounts[0] != null && accounts[1] != null)
            {
                populateInfoForAccount(accounts[0]);
                CheckTransactionAccount(accounts[0]);
                CheckDepositAccount(accounts[0]);
                DisplayAccountDetailsTo(accounts[1]);
            }
            DisplayLastTransactionDetails(transactionProcessor);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loanAccount = CreateLoanAccount();
            DisplayAccountDetails(loanAccount);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private TransactionAccount CreateTransactionAccount()
        {
            string currency = txtCurrency.Text;
            decimal limitAmount = Convert.ToDecimal(txtLimit.Text);
            return  new TransactionAccount(currency, limitAmount);
            
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private DepositAccount CreateDepositAccount()
        {
            UnitOfTime unit1;
            UnitOfTime unit2;
            InterestRate interRate=new InterestRate();
            Enum.TryParse(cbUnitOfTime.SelectedItem.ToString(), out unit1);
            TimePeriod timePeriod=new TimePeriod();
            if (txtPeriod.Text == string.Empty)
                errorProvider1.SetError(txtPeriod, "Period can't be empty!");
            else
            {
                errorProvider1.SetError(txtPeriod, "");
                timePeriod = new TimePeriod(Convert.ToInt16(txtPeriod.Text), unit1);
                
            }

            if (txtInterestRate.Text == string.Empty)
                errorProvider2.SetError(txtInterestRate, "Interest rate can't be empty!");
            else
            {
                errorProvider2.SetError(txtInterestRate, "");
                Enum.TryParse(cbUnitOfTime2.SelectedItem.ToString(), out unit2);
                interRate = new InterestRate(Convert.ToDecimal(txtInterestRate.Text), unit2);
             }

            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;

            return new DepositAccount(txtCurrency.Text, timePeriod, interRate, startDate, endDate,taccount);
        }



        public LoanAccount CreateLoanAccount()
        {
           UnitOfTime unit1;
           UnitOfTime unit2;
           InterestRate interRate = new InterestRate();
           Enum.TryParse(cbUnitOfTime.SelectedItem.ToString(), out unit1);
           TimePeriod timePeriod = new TimePeriod();
           if (txtPeriod.Text == string.Empty)
               errorProvider1.SetError(txtPeriod, "Period can't be empty!");
           else
           {
               errorProvider1.SetError(txtPeriod, "");
               timePeriod = new TimePeriod(Convert.ToInt16(txtPeriod.Text), unit1);

           }

           if (txtInterestRate.Text == string.Empty)
               errorProvider2.SetError(txtInterestRate, "Interest rate can't be empty!");
           else
           {
               errorProvider2.SetError(txtInterestRate, "");
               Enum.TryParse(cbUnitOfTime2.SelectedItem.ToString(), out unit2);
               interRate = new InterestRate(Convert.ToDecimal(txtInterestRate.Text), unit2);
           }

           DateTime startDate = dtpStartDate.Value;
           DateTime endDate = dtpEndDate.Value;

           return new LoanAccount(txtCurrency.Text,timePeriod, interRate, startDate, endDate, taccount);


             
        }

    

        /// <summary>
        /// method to display details about last transaction log
        /// </summary>
        /// <param name="tprocessor"></param>
        private void DisplayLastTransactionDetails(ITransactionProcessor tprocessor)
        {
            //TransactionLogEntry entry = tprocessor.LastTransaction;
            TransactionLogEntry entry = tprocessor[tprocessor.TransactionCount-1];
            lblTypeTLE.Text = entry.Type.ToString();
            lblAmountTLE.Text = entry.CurrencyAmount.amount.ToString() +" "+ entry.CurrencyAmount.currency;
            lblStatusTLE.Text = entry.Status.ToString();
            lblTotalTcount.Text = tprocessor.TransactionCount.ToString();

            
        
        }


        /// <summary>
        /// charge a 15 MKD fee on a Deposit and Loan account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChargeFee_Click(object sender, EventArgs e)
        {
            transactionProcessor = TransactionProcessor.GetTransactionProcessor();
            IAccount[] accounts={CreateDepositAccount(),CreateLoanAccount()};
            CurrencyAmount amount=new CurrencyAmount(15,"MKD");

            ProcessorExtensions.ChargeProcessingFee(transactionProcessor, amount, accounts);
            DisplayLastTransactionDetails(transactionProcessor);

        }


        


    }
}
