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
            this.lblIDto = new System.Windows.Forms.Label();
            this.lblNumberTo = new System.Windows.Forms.Label();
            this.lblCurrencyTo = new System.Windows.Forms.Label();
            this.lblBalanceTo = new System.Windows.Forms.Label();
            this.btnMakeTransaction = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnMakeGroupTransaction = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbGTAmount = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tbGTCurrency = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateTransactionAccount
            // 
            this.btnCreateTransactionAccount.Location = new System.Drawing.Point(15, 12);
            this.btnCreateTransactionAccount.Name = "btnCreateTransactionAccount";
            this.btnCreateTransactionAccount.Size = new System.Drawing.Size(156, 23);
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
            this.txtCurrency.Text = "MKD";
            // 
            // txtLimit
            // 
            this.txtLimit.Location = new System.Drawing.Point(126, 63);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(100, 20);
            this.txtLimit.TabIndex = 3;
            this.txtLimit.Text = "10000";
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
            this.dtpEndDate.Location = new System.Drawing.Point(665, 102);
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
            this.lbleDate.Location = new System.Drawing.Point(662, 86);
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
            this.lblID.Location = new System.Drawing.Point(89, 26);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "id1";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(86, 49);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(48, 13);
            this.lblNumber.TabIndex = 15;
            this.lblNumber.Text = "number1";
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Location = new System.Drawing.Point(86, 72);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(54, 13);
            this.lblCurrency.TabIndex = 16;
            this.lblCurrency.Text = "currency1";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(86, 96);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(51, 13);
            this.lblBalance.TabIndex = 17;
            this.lblBalance.Text = "balance1";
            // 
            // lblLimitAmount
            // 
            this.lblLimitAmount.AutoSize = true;
            this.lblLimitAmount.Location = new System.Drawing.Point(86, 122);
            this.lblLimitAmount.Name = "lblLimitAmount";
            this.lblLimitAmount.Size = new System.Drawing.Size(65, 13);
            this.lblLimitAmount.TabIndex = 19;
            this.lblLimitAmount.Text = "limitamount1";
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
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "ID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Currency";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Balance";
            // 
            // lblLimitCurrency
            // 
            this.lblLimitCurrency.AutoSize = true;
            this.lblLimitCurrency.Location = new System.Drawing.Point(86, 148);
            this.lblLimitCurrency.Name = "lblLimitCurrency";
            this.lblLimitCurrency.Size = new System.Drawing.Size(71, 13);
            this.lblLimitCurrency.TabIndex = 26;
            this.lblLimitCurrency.Text = "limitcurrency1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Limit Amount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Limit Currency";
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Location = new System.Drawing.Point(75, 115);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(42, 13);
            this.lblPeriod.TabIndex = 29;
            this.lblPeriod.Text = "period1";
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.Location = new System.Drawing.Point(75, 138);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(47, 13);
            this.lblInterest.TabIndex = 30;
            this.lblInterest.Text = "interest1";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(75, 161);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(54, 13);
            this.lblStartDate.TabIndex = 31;
            this.lblStartDate.Text = "startdate1";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(75, 185);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(52, 13);
            this.lblEndDate.TabIndex = 32;
            this.lblEndDate.Text = "enddate1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Period";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Interest";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Start Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 185);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "End Date";
            // 
            // lblLimitCurencyInfo
            // 
            this.lblLimitCurencyInfo.AutoSize = true;
            this.lblLimitCurencyInfo.Location = new System.Drawing.Point(112, 240);
            this.lblLimitCurencyInfo.Name = "lblLimitCurencyInfo";
            this.lblLimitCurencyInfo.Size = new System.Drawing.Size(0, 13);
            this.lblLimitCurencyInfo.TabIndex = 37;
            // 
            // lblIDto
            // 
            this.lblIDto.AutoSize = true;
            this.lblIDto.Location = new System.Drawing.Point(75, 20);
            this.lblIDto.Name = "lblIDto";
            this.lblIDto.Size = new System.Drawing.Size(37, 13);
            this.lblIDto.TabIndex = 38;
            this.lblIDto.Text = "lblIDto";
            // 
            // lblNumberTo
            // 
            this.lblNumberTo.AutoSize = true;
            this.lblNumberTo.Location = new System.Drawing.Point(75, 42);
            this.lblNumberTo.Name = "lblNumberTo";
            this.lblNumberTo.Size = new System.Drawing.Size(67, 13);
            this.lblNumberTo.TabIndex = 39;
            this.lblNumberTo.Text = "lblNumberTo";
            // 
            // lblCurrencyTo
            // 
            this.lblCurrencyTo.AutoSize = true;
            this.lblCurrencyTo.Location = new System.Drawing.Point(75, 66);
            this.lblCurrencyTo.Name = "lblCurrencyTo";
            this.lblCurrencyTo.Size = new System.Drawing.Size(72, 13);
            this.lblCurrencyTo.TabIndex = 40;
            this.lblCurrencyTo.Text = "lblCurrencyTo";
            // 
            // lblBalanceTo
            // 
            this.lblBalanceTo.AutoSize = true;
            this.lblBalanceTo.Location = new System.Drawing.Point(75, 89);
            this.lblBalanceTo.Name = "lblBalanceTo";
            this.lblBalanceTo.Size = new System.Drawing.Size(69, 13);
            this.lblBalanceTo.TabIndex = 41;
            this.lblBalanceTo.Text = "lblBalanceTo";
            // 
            // btnMakeTransaction
            // 
            this.btnMakeTransaction.Location = new System.Drawing.Point(192, 11);
            this.btnMakeTransaction.Name = "btnMakeTransaction";
            this.btnMakeTransaction.Size = new System.Drawing.Size(159, 23);
            this.btnMakeTransaction.TabIndex = 44;
            this.btnMakeTransaction.Text = "Transfer Transaction";
            this.btnMakeTransaction.UseVisualStyleBackColor = true;
            this.btnMakeTransaction.Click += new System.EventHandler(this.btnMakeTransaction_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.lblNumber);
            this.groupBox1.Controls.Add(this.lblCurrency);
            this.groupBox1.Controls.Add(this.lblBalance);
            this.groupBox1.Controls.Add(this.lblLimitAmount);
            this.groupBox1.Controls.Add(this.lblLimitCurrency);
            this.groupBox1.Location = new System.Drawing.Point(12, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 213);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transaction Account";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.lblEndDate);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblStartDate);
            this.groupBox2.Controls.Add(this.lblBalanceTo);
            this.groupBox2.Controls.Add(this.lblInterest);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lblPeriod);
            this.groupBox2.Controls.Add(this.lblCurrencyTo);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lblNumberTo);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lblIDto);
            this.groupBox2.Location = new System.Drawing.Point(422, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 213);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Deposit Account";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 89);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Balance";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 66);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Currency";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Number";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "ID";
            // 
            // btnMakeGroupTransaction
            // 
            this.btnMakeGroupTransaction.Location = new System.Drawing.Point(665, 212);
            this.btnMakeGroupTransaction.Name = "btnMakeGroupTransaction";
            this.btnMakeGroupTransaction.Size = new System.Drawing.Size(119, 23);
            this.btnMakeGroupTransaction.TabIndex = 47;
            this.btnMakeGroupTransaction.Text = "Group Transaction";
            this.btnMakeGroupTransaction.UseVisualStyleBackColor = true;
            this.btnMakeGroupTransaction.Click += new System.EventHandler(this.btnMakeGroupTransaction_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Debit",
            "Credit"});
            this.comboBox1.Location = new System.Drawing.Point(881, 167);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(96, 21);
            this.comboBox1.TabIndex = 48;
            // 
            // tbGTAmount
            // 
            this.tbGTAmount.Location = new System.Drawing.Point(665, 170);
            this.tbGTAmount.Name = "tbGTAmount";
            this.tbGTAmount.Size = new System.Drawing.Size(89, 20);
            this.tbGTAmount.TabIndex = 49;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(665, 154);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 13);
            this.label17.TabIndex = 50;
            this.label17.Text = "Amount";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(787, 154);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 13);
            this.label18.TabIndex = 51;
            this.label18.Text = "Currency";
            // 
            // tbGTCurrency
            // 
            this.tbGTCurrency.Location = new System.Drawing.Point(772, 170);
            this.tbGTCurrency.Name = "tbGTCurrency";
            this.tbGTCurrency.Size = new System.Drawing.Size(93, 20);
            this.tbGTCurrency.TabIndex = 52;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 359);
            this.Controls.Add(this.tbGTCurrency);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.tbGTAmount);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnMakeGroupTransaction);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMakeTransaction);
            this.Controls.Add(this.lblLimitCurencyInfo);
            this.Controls.Add(this.cbUnitOfTime2);
            this.Controls.Add(this.cbUnitOfTime);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Label lblIDto;
        private System.Windows.Forms.Label lblNumberTo;
        private System.Windows.Forms.Label lblCurrencyTo;
        private System.Windows.Forms.Label lblBalanceTo;
        private System.Windows.Forms.Button btnMakeTransaction;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnMakeGroupTransaction;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tbGTAmount;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbGTCurrency;
    }
}

