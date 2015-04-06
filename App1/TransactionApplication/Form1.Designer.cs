namespace TransactionApplication
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreateTransactionAccount = new System.Windows.Forms.Button();
            this.btnCreateDepositAccount = new System.Windows.Forms.Button();
            this.txtCurrency = new System.Windows.Forms.TextBox();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblsDate = new System.Windows.Forms.Label();
            this.lbleDate = new System.Windows.Forms.Label();
            this.txtPeriod = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.lblper = new System.Windows.Forms.Label();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblLimit = new System.Windows.Forms.Label();
            this.lblLimitAmount = new System.Windows.Forms.Label();
            this.cbUnitOfTime = new System.Windows.Forms.ComboBox();
            this.cbUnitOfTime2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLimitCurrency = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.lblInterest = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblLimitCurencyInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateTransactionAccount
            // 
            this.btnCreateTransactionAccount.Location = new System.Drawing.Point(15, 12);
            this.btnCreateTransactionAccount.Name = "btnCreateTransactionAccount";
            this.btnCreateTransactionAccount.Size = new System.Drawing.Size(174, 23);
            this.btnCreateTransactionAccount.TabIndex = 0;
            this.btnCreateTransactionAccount.Text = "Create Transaction Account";
            this.btnCreateTransactionAccount.UseVisualStyleBackColor = true;
            this.btnCreateTransactionAccount.Click += new System.EventHandler(this.btnCreateTransactionAccount_Click);
            // 
            // btnCreateDepositAccount
            // 
            this.btnCreateDepositAccount.Location = new System.Drawing.Point(422, 12);
            this.btnCreateDepositAccount.Name = "btnCreateDepositAccount";
            this.btnCreateDepositAccount.Size = new System.Drawing.Size(174, 23);
            this.btnCreateDepositAccount.TabIndex = 1;
            this.btnCreateDepositAccount.Text = "Create Deposit Account";
            this.btnCreateDepositAccount.UseVisualStyleBackColor = true;
            this.btnCreateDepositAccount.Click += new System.EventHandler(this.btnCreateDepositAccount_Click);
            // 
            // txtCurrency
            // 
            this.txtCurrency.Location = new System.Drawing.Point(12, 63);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Size = new System.Drawing.Size(100, 20);
            this.txtCurrency.TabIndex = 2;
            // 
            // txtLimit
            // 
            this.txtLimit.Location = new System.Drawing.Point(126, 63);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(100, 20);
            this.txtLimit.TabIndex = 3;
          
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Currency";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Limit";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(422, 102);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 6;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(628, 102);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 7;
            // 
            // lblsDate
            // 
            this.lblsDate.AutoSize = true;
            this.lblsDate.Location = new System.Drawing.Point(419, 86);
            this.lblsDate.Name = "lblsDate";
            this.lblsDate.Size = new System.Drawing.Size(55, 13);
            this.lblsDate.TabIndex = 8;
            this.lblsDate.Text = "Start Date";
            // 
            // lbleDate
            // 
            this.lbleDate.AutoSize = true;
            this.lbleDate.Location = new System.Drawing.Point(625, 86);
            this.lbleDate.Name = "lbleDate";
            this.lbleDate.Size = new System.Drawing.Size(52, 13);
            this.lbleDate.TabIndex = 9;
            this.lbleDate.Text = "End Date";
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(422, 63);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(100, 20);
            this.txtPeriod.TabIndex = 10;
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(665, 62);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(100, 20);
            this.txtInterestRate.TabIndex = 11;
            // 
            // lblper
            // 
            this.lblper.AutoSize = true;
            this.lblper.Location = new System.Drawing.Point(419, 47);
            this.lblper.Name = "lblper";
            this.lblper.Size = new System.Drawing.Size(37, 13);
            this.lblper.TabIndex = 12;
            this.lblper.Text = "Period";
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Location = new System.Drawing.Point(662, 47);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(65, 13);
            this.lblInterestRate.TabIndex = 13;
            this.lblInterestRate.Text = "InterestRate";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(82, 109);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 13);
            this.lblID.TabIndex = 14;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(82, 136);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(0, 13);
            this.lblNumber.TabIndex = 15;
            this.lblNumber.Click += new System.EventHandler(this.lblNumber_Click);
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Location = new System.Drawing.Point(82, 159);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(0, 13);
            this.lblCurrency.TabIndex = 16;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(82, 188);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(0, 13);
            this.lblBalance.TabIndex = 17;
            // 
            // lblLimit
            // 
            this.lblLimit.AutoSize = true;
            this.lblLimit.Location = new System.Drawing.Point(12, 204);
            this.lblLimit.Name = "lblLimit";
            this.lblLimit.Size = new System.Drawing.Size(0, 13);
            this.lblLimit.TabIndex = 18;
            // 
            // lblLimitAmount
            // 
            this.lblLimitAmount.AutoSize = true;
            this.lblLimitAmount.Location = new System.Drawing.Point(94, 218);
            this.lblLimitAmount.Name = "lblLimitAmount";
            this.lblLimitAmount.Size = new System.Drawing.Size(0, 13);
            this.lblLimitAmount.TabIndex = 19;
            // 
            // cbUnitOfTime
            // 
            this.cbUnitOfTime.FormattingEnabled = true;
            this.cbUnitOfTime.Items.AddRange(new object[] {
            "Day",
            "Month",
            "Year"});
            this.cbUnitOfTime.Location = new System.Drawing.Point(533, 62);
            this.cbUnitOfTime.Name = "cbUnitOfTime";
            this.cbUnitOfTime.Size = new System.Drawing.Size(89, 21);
            this.cbUnitOfTime.TabIndex = 20;
            // 
            // cbUnitOfTime2
            // 
            this.cbUnitOfTime2.FormattingEnabled = true;
            this.cbUnitOfTime2.Items.AddRange(new object[] {
            "Day",
            "Month",
            "Year"});
            this.cbUnitOfTime2.Location = new System.Drawing.Point(790, 61);
            this.cbUnitOfTime2.Name = "cbUnitOfTime2";
            this.cbUnitOfTime2.Size = new System.Drawing.Size(97, 21);
            this.cbUnitOfTime2.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "ID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Currency";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Balance";
            // 
            // lblLimitCurrency
            // 
            this.lblLimitCurrency.AutoSize = true;
            this.lblLimitCurrency.Location = new System.Drawing.Point(97, 250);
            this.lblLimitCurrency.Name = "lblLimitCurrency";
            this.lblLimitCurrency.Size = new System.Drawing.Size(0, 13);
            this.lblLimitCurrency.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Limit Amount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Limit Currency";
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Location = new System.Drawing.Point(530, 136);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(0, 13);
            this.lblPeriod.TabIndex = 29;
          
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.Location = new System.Drawing.Point(530, 159);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(0, 13);
            this.lblInterest.TabIndex = 30;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(530, 188);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(0, 13);
            this.lblStartDate.TabIndex = 31;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(530, 218);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(0, 13);
            this.lblEndDate.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(422, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Period";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(422, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Interest";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(422, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Start Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(425, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "End Date";
            // 
            // lblLimitCurencyInfo
            // 
            this.lblLimitCurencyInfo.AutoSize = true;
            this.lblLimitCurencyInfo.Location = new System.Drawing.Point(126, 250);
            this.lblLimitCurencyInfo.Name = "lblLimitCurencyInfo";
            this.lblLimitCurencyInfo.Size = new System.Drawing.Size(0, 13);
            this.lblLimitCurencyInfo.TabIndex = 37;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 286);
            this.Controls.Add(this.lblLimitCurencyInfo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblInterest);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblLimitCurrency);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbUnitOfTime2);
            this.Controls.Add(this.cbUnitOfTime);
            this.Controls.Add(this.lblLimitAmount);
            this.Controls.Add(this.lblLimit);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblInterestRate);
            this.Controls.Add(this.lblper);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.txtPeriod);
            this.Controls.Add(this.lbleDate);
            this.Controls.Add(this.lblsDate);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLimit);
            this.Controls.Add(this.txtCurrency);
            this.Controls.Add(this.btnCreateDepositAccount);
            this.Controls.Add(this.btnCreateTransactionAccount);
            this.Name = "frmMain";
            this.Text = "Account Details Form";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateTransactionAccount;
        private System.Windows.Forms.Button btnCreateDepositAccount;
        private System.Windows.Forms.TextBox txtCurrency;
        private System.Windows.Forms.TextBox txtLimit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblsDate;
        private System.Windows.Forms.Label lbleDate;
        private System.Windows.Forms.TextBox txtPeriod;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.Label lblper;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblLimit;
        private System.Windows.Forms.Label lblLimitAmount;
        private System.Windows.Forms.ComboBox cbUnitOfTime;
        private System.Windows.Forms.ComboBox cbUnitOfTime2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblLimitCurrency;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblLimitCurencyInfo;
    }
}

