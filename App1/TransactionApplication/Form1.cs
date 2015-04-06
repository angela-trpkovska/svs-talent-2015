using App1.Accounts;
using App1.Common;
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

        public TransactionAccount taccount;
        public frmMain()
        {
            InitializeComponent();
        }

        private void lblNumber_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }


        private void populateInfoForAccount(Account account)
        {
            lblID.Text = account.ID.ToString();
            lblNumber.Text = account.Number;
            lblCurrency.Text = account.Currency;
            lblBalance.Text = account.Balance.Amount.ToString();


        }


        private void checkTransactionAccount(Account account)
        {
            if (account is TransactionAccount)
            {
                TransactionAccount ta = (TransactionAccount)account;
               
                lblLimitAmount.Text= ta.Limit.Amount.ToString();
                lblLimitCurencyInfo.Text = ta.Limit.Currency;

              

            }

            else {

                lblLimitAmount.Text = string.Empty;
                lblLimitCurrency.Text = string.Empty;
              }
        }


        private void checkDepositAccount(Account account)
        {
            if (account is DepositAccount)
            {
                DepositAccount da = (DepositAccount)account;

                lblPeriod.Text = da.Period.Period + " "+da.Period.Unit.ToString();
                lblInterest.Text = da.Interest.Percent.ToString() + " " + da.Interest.Unit.ToString();
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
            populateInfoForAccount(taccount);
            checkTransactionAccount(taccount);


        }

       

        private void btnCreateDepositAccount_Click(object sender, EventArgs e)
        {
            TimePeriod tperiod;
            UnitOfTime unit1;
            Enum.TryParse(cbUnitOfTime.SelectedItem.ToString(), out unit1);
            tperiod.Period = Convert.ToInt16(txtPeriod.Text);
            tperiod.Unit = unit1;


            InterestRate interestRate;
            UnitOfTime unit2;
            interestRate.Percent = Convert.ToDecimal(txtInterestRate.Text);
            Enum.TryParse(cbUnitOfTime2.SelectedItem.ToString(), out unit2);
            interestRate.Unit = unit2;

            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;


            DepositAccount daccount = new DepositAccount(txtCurrency.Text, tperiod, interestRate, startDate, endDate, taccount);

            populateInfoForAccount(daccount);
            checkDepositAccount(daccount);


        }


    }
}
