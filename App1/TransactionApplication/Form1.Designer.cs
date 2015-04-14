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
            this.components = new System.ComponentModel.Container();
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
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.lblLimitCurrencyTo = new System.Windows.Forms.Label();
            this.lblLimitAmountTo = new System.Windows.Forms.Label();
            this.lblEndDateTo = new System.Windows.Forms.Label();
            this.lblStartDateTo = new System.Windows.Forms.Label();
            this.lblInterestTo = new System.Windows.Forms.Label();
            this.lblPeriodTo = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnMakeGroupTransaction = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtTransactionAmount = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtTransactionCurrency = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTotalTcount = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.lblStatusTLE = new System.Windows.Forms.Label();
            this.lblAmountTLE = new System.Windows.Forms.Label();
            this.lblTypeTLE = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnChargeFee = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateTransactionAccount
            // 
            this.btnCreateTransactionAccount.Location = new System.Drawing.Point(12, 286);
            this.btnCreateTransactionAccount.Name = "btnCreateTransactionAccount";
            this.btnCreateTransactionAccount.Size = new System.Drawing.Size(156, 23);
            this.btnCreateTransactionAccount.TabIndex = 0;
            this.btnCreateTransactionAccount.Text = "Create Transaction Account";
            this.btnCreateTransactionAccount.UseVisualStyleBackColor = true;
            this.btnCreateTransactionAccount.Click += new System.EventHandler(this.btnCreateTransactionAccount_Click);
            // 
            // btnCreateDepositAccount
            // 
            this.btnCreateDepositAccount.Location = new System.Drawing.Point(184, 286);
            this.btnCreateDepositAccount.Name = "btnCreateDepositAccount";
            this.btnCreateDepositAccount.Size = new System.Drawing.Size(159, 23);
            this.btnCreateDepositAccount.TabIndex = 1;
            this.btnCreateDepositAccount.Text = "Create Deposit Account";
            this.btnCreateDepositAccount.UseVisualStyleBackColor = true;
            this.btnCreateDepositAccount.Click += new System.EventHandler(this.btnCreateDepositAccount_Click);
            // 
            // txtCurrency
            // 
            this.txtCurrency.Location = new System.Drawing.Point(12, 28);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Size = new System.Drawing.Size(100, 20);
            this.txtCurrency.TabIndex = 2;
            this.txtCurrency.Text = "MKD";
            // 
            // txtLimit
            // 
            this.txtLimit.Location = new System.Drawing.Point(135, 28);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(100, 20);
            this.txtLimit.TabIndex = 3;
            this.txtLimit.Text = "10000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Currency";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Limit";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(12, 147);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(223, 20);
            this.dtpStartDate.TabIndex = 6;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(12, 194);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(223, 20);
            this.dtpEndDate.TabIndex = 7;
            // 
            // lblsDate
            // 
            this.lblsDate.AutoSize = true;
            this.lblsDate.Location = new System.Drawing.Point(12, 131);
            this.lblsDate.Name = "lblsDate";
            this.lblsDate.Size = new System.Drawing.Size(55, 13);
            this.lblsDate.TabIndex = 8;
            this.lblsDate.Text = "Start Date";
            // 
            // lbleDate
            // 
            this.lbleDate.AutoSize = true;
            this.lbleDate.Location = new System.Drawing.Point(15, 177);
            this.lbleDate.Name = "lbleDate";
            this.lbleDate.Size = new System.Drawing.Size(52, 13);
            this.lbleDate.TabIndex = 9;
            this.lbleDate.Text = "End Date";
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(12, 67);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(100, 20);
            this.txtPeriod.TabIndex = 10;
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(12, 106);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(100, 20);
            this.txtInterestRate.TabIndex = 11;
            // 
            // lblper
            // 
            this.lblper.AutoSize = true;
            this.lblper.Location = new System.Drawing.Point(12, 51);
            this.lblper.Name = "lblper";
            this.lblper.Size = new System.Drawing.Size(37, 13);
            this.lblper.TabIndex = 12;
            this.lblper.Text = "Period";
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Location = new System.Drawing.Point(9, 90);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(65, 13);
            this.lblInterestRate.TabIndex = 13;
            this.lblInterestRate.Text = "InterestRate";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(76, 26);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 13);
            this.lblID.TabIndex = 14;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(76, 49);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(0, 13);
            this.lblNumber.TabIndex = 15;
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Location = new System.Drawing.Point(76, 74);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(0, 13);
            this.lblCurrency.TabIndex = 16;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(79, 95);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(0, 13);
            this.lblBalance.TabIndex = 17;
            // 
            // lblLimitAmount
            // 
            this.lblLimitAmount.AutoSize = true;
            this.lblLimitAmount.Location = new System.Drawing.Point(79, 122);
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
            this.cbUnitOfTime.Location = new System.Drawing.Point(135, 67);
            this.cbUnitOfTime.Name = "cbUnitOfTime";
            this.cbUnitOfTime.Size = new System.Drawing.Size(100, 21);
            this.cbUnitOfTime.TabIndex = 20;
            // 
            // cbUnitOfTime2
            // 
            this.cbUnitOfTime2.FormattingEnabled = true;
            this.cbUnitOfTime2.Items.AddRange(new object[] {
            "Day",
            "Month",
            "Year"});
            this.cbUnitOfTime2.Location = new System.Drawing.Point(135, 106);
            this.cbUnitOfTime2.Name = "cbUnitOfTime2";
            this.cbUnitOfTime2.Size = new System.Drawing.Size(100, 21);
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
            this.lblLimitCurrency.Location = new System.Drawing.Point(79, 148);
            this.lblLimitCurrency.Name = "lblLimitCurrency";
            this.lblLimitCurrency.Size = new System.Drawing.Size(0, 13);
            this.lblLimitCurrency.TabIndex = 26;
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
            this.lblPeriod.Location = new System.Drawing.Point(82, 167);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(0, 13);
            this.lblPeriod.TabIndex = 29;
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.Location = new System.Drawing.Point(83, 190);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(0, 13);
            this.lblInterest.TabIndex = 30;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(82, 214);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(0, 13);
            this.lblStartDate.TabIndex = 31;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(82, 240);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(0, 13);
            this.lblEndDate.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Period";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Interest";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 211);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Start Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 237);
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
            this.lblIDto.Location = new System.Drawing.Point(91, 16);
            this.lblIDto.Name = "lblIDto";
            this.lblIDto.Size = new System.Drawing.Size(0, 13);
            this.lblIDto.TabIndex = 38;
            // 
            // lblNumberTo
            // 
            this.lblNumberTo.AutoSize = true;
            this.lblNumberTo.Location = new System.Drawing.Point(91, 42);
            this.lblNumberTo.Name = "lblNumberTo";
            this.lblNumberTo.Size = new System.Drawing.Size(0, 13);
            this.lblNumberTo.TabIndex = 39;
            // 
            // lblCurrencyTo
            // 
            this.lblCurrencyTo.AutoSize = true;
            this.lblCurrencyTo.Location = new System.Drawing.Point(91, 66);
            this.lblCurrencyTo.Name = "lblCurrencyTo";
            this.lblCurrencyTo.Size = new System.Drawing.Size(0, 13);
            this.lblCurrencyTo.TabIndex = 40;
            // 
            // lblBalanceTo
            // 
            this.lblBalanceTo.AutoSize = true;
            this.lblBalanceTo.Location = new System.Drawing.Point(91, 89);
            this.lblBalanceTo.Name = "lblBalanceTo";
            this.lblBalanceTo.Size = new System.Drawing.Size(0, 13);
            this.lblBalanceTo.TabIndex = 41;
            // 
            // btnMakeTransaction
            // 
            this.btnMakeTransaction.Location = new System.Drawing.Point(184, 323);
            this.btnMakeTransaction.Name = "btnMakeTransaction";
            this.btnMakeTransaction.Size = new System.Drawing.Size(159, 23);
            this.btnMakeTransaction.TabIndex = 44;
            this.btnMakeTransaction.Text = "Make Transaction";
            this.btnMakeTransaction.UseVisualStyleBackColor = true;
            this.btnMakeTransaction.Click += new System.EventHandler(this.btnMakeTransaction_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblEndDate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.lblStartDate);
            this.groupBox1.Controls.Add(this.lblNumber);
            this.groupBox1.Controls.Add(this.lblInterest);
            this.groupBox1.Controls.Add(this.lblLimitCurrency);
            this.groupBox1.Controls.Add(this.lblPeriod);
            this.groupBox1.Controls.Add(this.lblCurrency);
            this.groupBox1.Controls.Add(this.lblLimitAmount);
            this.groupBox1.Controls.Add(this.lblBalance);
            this.groupBox1.Location = new System.Drawing.Point(381, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 276);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account From";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(84, 292);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(52, 13);
            this.label23.TabIndex = 37;
            this.label23.Text = "enddate1";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(9, 167);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(37, 13);
            this.label24.TabIndex = 38;
            this.label24.Text = "Period";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(8, 190);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(42, 13);
            this.label25.TabIndex = 39;
            this.label25.Text = "Interest";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(8, 213);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(55, 13);
            this.label26.TabIndex = 40;
            this.label26.Text = "Start Date";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(9, 237);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(52, 13);
            this.label27.TabIndex = 41;
            this.label27.Text = "End Date";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Controls.Add(this.label29);
            this.groupBox2.Controls.Add(this.lblLimitCurrencyTo);
            this.groupBox2.Controls.Add(this.lblLimitAmountTo);
            this.groupBox2.Controls.Add(this.lblEndDateTo);
            this.groupBox2.Controls.Add(this.lblStartDateTo);
            this.groupBox2.Controls.Add(this.lblInterestTo);
            this.groupBox2.Controls.Add(this.lblPeriodTo);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblBalanceTo);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lblCurrencyTo);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lblNumberTo);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lblIDto);
            this.groupBox2.Location = new System.Drawing.Point(634, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 275);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Account To";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(9, 112);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(70, 13);
            this.label28.TabIndex = 48;
            this.label28.Text = "Limit Amount ";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(9, 138);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(73, 13);
            this.label29.TabIndex = 49;
            this.label29.Text = "Limit Currency";
            // 
            // lblLimitCurrencyTo
            // 
            this.lblLimitCurrencyTo.AutoSize = true;
            this.lblLimitCurrencyTo.Location = new System.Drawing.Point(91, 138);
            this.lblLimitCurrencyTo.Name = "lblLimitCurrencyTo";
            this.lblLimitCurrencyTo.Size = new System.Drawing.Size(0, 13);
            this.lblLimitCurrencyTo.TabIndex = 47;
            // 
            // lblLimitAmountTo
            // 
            this.lblLimitAmountTo.AutoSize = true;
            this.lblLimitAmountTo.Location = new System.Drawing.Point(91, 112);
            this.lblLimitAmountTo.Name = "lblLimitAmountTo";
            this.lblLimitAmountTo.Size = new System.Drawing.Size(0, 13);
            this.lblLimitAmountTo.TabIndex = 46;
            // 
            // lblEndDateTo
            // 
            this.lblEndDateTo.AutoSize = true;
            this.lblEndDateTo.Location = new System.Drawing.Point(91, 237);
            this.lblEndDateTo.Name = "lblEndDateTo";
            this.lblEndDateTo.Size = new System.Drawing.Size(0, 13);
            this.lblEndDateTo.TabIndex = 45;
            // 
            // lblStartDateTo
            // 
            this.lblStartDateTo.AutoSize = true;
            this.lblStartDateTo.Location = new System.Drawing.Point(91, 211);
            this.lblStartDateTo.Name = "lblStartDateTo";
            this.lblStartDateTo.Size = new System.Drawing.Size(0, 13);
            this.lblStartDateTo.TabIndex = 44;
            // 
            // lblInterestTo
            // 
            this.lblInterestTo.AutoSize = true;
            this.lblInterestTo.Location = new System.Drawing.Point(91, 188);
            this.lblInterestTo.Name = "lblInterestTo";
            this.lblInterestTo.Size = new System.Drawing.Size(0, 13);
            this.lblInterestTo.TabIndex = 43;
            // 
            // lblPeriodTo
            // 
            this.lblPeriodTo.AutoSize = true;
            this.lblPeriodTo.Location = new System.Drawing.Point(91, 164);
            this.lblPeriodTo.Name = "lblPeriodTo";
            this.lblPeriodTo.Size = new System.Drawing.Size(0, 13);
            this.lblPeriodTo.TabIndex = 42;
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
            this.btnMakeGroupTransaction.Location = new System.Drawing.Point(12, 360);
            this.btnMakeGroupTransaction.Name = "btnMakeGroupTransaction";
            this.btnMakeGroupTransaction.Size = new System.Drawing.Size(156, 23);
            this.btnMakeGroupTransaction.TabIndex = 47;
            this.btnMakeGroupTransaction.Text = "Make Group Transaction";
            this.btnMakeGroupTransaction.UseVisualStyleBackColor = true;
            this.btnMakeGroupTransaction.Click += new System.EventHandler(this.btnMakeGroupTransaction_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Debit",
            "Credit"});
            this.comboBox1.Location = new System.Drawing.Point(247, 244);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(96, 21);
            this.comboBox1.TabIndex = 48;
            // 
            // txtTransactionAmount
            // 
            this.txtTransactionAmount.Location = new System.Drawing.Point(12, 245);
            this.txtTransactionAmount.Name = "txtTransactionAmount";
            this.txtTransactionAmount.Size = new System.Drawing.Size(100, 20);
            this.txtTransactionAmount.TabIndex = 49;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 229);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 13);
            this.label17.TabIndex = 50;
            this.label17.Text = "Amount";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(132, 229);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 13);
            this.label18.TabIndex = 51;
            this.label18.Text = "Currency";
            // 
            // txtTransactionCurrency
            // 
            this.txtTransactionCurrency.Location = new System.Drawing.Point(135, 245);
            this.txtTransactionCurrency.Name = "txtTransactionCurrency";
            this.txtTransactionCurrency.Size = new System.Drawing.Size(93, 20);
            this.txtTransactionCurrency.TabIndex = 52;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 23);
            this.button1.TabIndex = 53;
            this.button1.Text = "Create Loan Account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTotalTcount
            // 
            this.lblTotalTcount.AutoSize = true;
            this.lblTotalTcount.Location = new System.Drawing.Point(75, 96);
            this.lblTotalTcount.Name = "lblTotalTcount";
            this.lblTotalTcount.Size = new System.Drawing.Size(0, 13);
            this.lblTotalTcount.TabIndex = 54;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.lblStatusTLE);
            this.groupBox3.Controls.Add(this.lblTotalTcount);
            this.groupBox3.Controls.Add(this.lblAmountTLE);
            this.groupBox3.Controls.Add(this.lblTypeTLE);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Location = new System.Drawing.Point(381, 300);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 132);
            this.groupBox3.TabIndex = 55;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transaction Log Entry";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 96);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(61, 13);
            this.label22.TabIndex = 55;
            this.label22.Text = "Total count";
            // 
            // lblStatusTLE
            // 
            this.lblStatusTLE.AutoSize = true;
            this.lblStatusTLE.Location = new System.Drawing.Point(75, 70);
            this.lblStatusTLE.Name = "lblStatusTLE";
            this.lblStatusTLE.Size = new System.Drawing.Size(0, 13);
            this.lblStatusTLE.TabIndex = 5;
            // 
            // lblAmountTLE
            // 
            this.lblAmountTLE.AutoSize = true;
            this.lblAmountTLE.Location = new System.Drawing.Point(75, 46);
            this.lblAmountTLE.Name = "lblAmountTLE";
            this.lblAmountTLE.Size = new System.Drawing.Size(0, 13);
            this.lblAmountTLE.TabIndex = 4;
            // 
            // lblTypeTLE
            // 
            this.lblTypeTLE.AutoSize = true;
            this.lblTypeTLE.Location = new System.Drawing.Point(75, 23);
            this.lblTypeTLE.Name = "lblTypeTLE";
            this.lblTypeTLE.Size = new System.Drawing.Size(0, 13);
            this.lblTypeTLE.TabIndex = 3;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(9, 70);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(37, 13);
            this.label21.TabIndex = 2;
            this.label21.Text = "Status";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(7, 46);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(43, 13);
            this.label20.TabIndex = 1;
            this.label20.Text = "Amount";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 23);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(31, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "Type";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // btnChargeFee
            // 
            this.btnChargeFee.Location = new System.Drawing.Point(187, 360);
            this.btnChargeFee.Name = "btnChargeFee";
            this.btnChargeFee.Size = new System.Drawing.Size(156, 23);
            this.btnChargeFee.TabIndex = 56;
            this.btnChargeFee.Text = "Charge Fee";
            this.btnChargeFee.UseVisualStyleBackColor = true;
            this.btnChargeFee.Click += new System.EventHandler(this.btnChargeFee_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 453);
            this.Controls.Add(this.btnChargeFee);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTransactionCurrency);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtTransactionAmount);
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
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
        private System.Windows.Forms.TextBox txtTransactionAmount;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtTransactionCurrency;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTotalTcount;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblTypeTLE;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblStatusTLE;
        private System.Windows.Forms.Label lblAmountTLE;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label lblLimitCurrencyTo;
        private System.Windows.Forms.Label lblLimitAmountTo;
        private System.Windows.Forms.Label lblEndDateTo;
        private System.Windows.Forms.Label lblStartDateTo;
        private System.Windows.Forms.Label lblInterestTo;
        private System.Windows.Forms.Label lblPeriodTo;
        private System.Windows.Forms.Button btnChargeFee;
    }
}

