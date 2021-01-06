﻿namespace WFAplikacija
{
    partial class AppForm
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

        public void RemoveAdminTab()
        {
            this.tabMainControl.Controls.Remove(this.tabAdmin);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.tabMainControl = new System.Windows.Forms.TabControl();
            this.tabSale = new System.Windows.Forms.TabPage();
            this.lblTotalNum = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnComplete = new System.Windows.Forms.Button();
            this.tabControlArticles = new System.Windows.Forms.TabControl();
            this.tabArctile1 = new System.Windows.Forms.TabPage();
            this.btnArticle2 = new System.Windows.Forms.Button();
            this.btnArticle1 = new System.Windows.Forms.Button();
            this.tabArticle2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewArticles = new System.Windows.Forms.ListView();
            this.tabReports = new System.Windows.Forms.TabPage();
            this.tBoxFilter = new System.Windows.Forms.TextBox();
            this.cmbFilterFunction = new System.Windows.Forms.ComboBox();
            this.cmbFilterColumn = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.btnReportsSave = new System.Windows.Forms.Button();
            this.dtReports = new System.Windows.Forms.DataGridView();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tabAdmin = new System.Windows.Forms.TabPage();
            this.testABLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openPropertiesButton = new System.Windows.Forms.Button();
            this.programmableButton = new System.Windows.Forms.Button();
            this.programmableButtonLabel = new System.Windows.Forms.Label();
            this.sampleLoginExampleBodyLabel = new System.Windows.Forms.Label();
            this.sampleLoginExampleTitleLabel = new System.Windows.Forms.Label();
            this.sampleLoginUsernameTextBox = new System.Windows.Forms.TextBox();
            this.sampleLoginPasswordLabel = new System.Windows.Forms.Label();
            this.sampleLoginResponseLabel = new System.Windows.Forms.Label();
            this.sendSampleLoginButton = new System.Windows.Forms.Button();
            this.sampleLoginPasswordTextBox = new System.Windows.Forms.TextBox();
            this.sampleLoginUsernameLabel = new System.Windows.Forms.Label();
            this.sampleLoginLabel = new System.Windows.Forms.Label();
            this.customGetRequestBaseTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkServerMainLabel = new System.Windows.Forms.Label();
            this.customGetRequestResponseLabel = new System.Windows.Forms.Label();
            this.sendGetRequestButton = new System.Windows.Forms.Button();
            this.customGetRequestActionTextBox = new System.Windows.Forms.TextBox();
            this.customRequestUrlLabel = new System.Windows.Forms.Label();
            this.customRequestLabel = new System.Windows.Forms.Label();
            this.checkServerResponseLabel = new System.Windows.Forms.Label();
            this.checkServerButton = new System.Windows.Forms.Button();
            this.pdfConfig1 = new Syncfusion.Pdf.PdfConfig();
            this.btnFilter = new System.Windows.Forms.Button();
            this.tabMainControl.SuspendLayout();
            this.tabSale.SuspendLayout();
            this.tabControlArticles.SuspendLayout();
            this.tabArctile1.SuspendLayout();
            this.tabReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtReports)).BeginInit();
            this.tabAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMainControl
            // 
            this.tabMainControl.Controls.Add(this.tabSale);
            this.tabMainControl.Controls.Add(this.tabReports);
            this.tabMainControl.Controls.Add(this.tabAdmin);
            this.tabMainControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMainControl.Location = new System.Drawing.Point(0, 0);
            this.tabMainControl.Name = "tabMainControl";
            this.tabMainControl.SelectedIndex = 0;
            this.tabMainControl.Size = new System.Drawing.Size(1085, 571);
            this.tabMainControl.TabIndex = 0;
            // 
            // tabSale
            // 
            this.tabSale.Controls.Add(this.lblTotalNum);
            this.tabSale.Controls.Add(this.lblTotal);
            this.tabSale.Controls.Add(this.btnComplete);
            this.tabSale.Controls.Add(this.tabControlArticles);
            this.tabSale.Controls.Add(this.label1);
            this.tabSale.Controls.Add(this.listViewArticles);
            this.tabSale.Location = new System.Drawing.Point(4, 25);
            this.tabSale.Name = "tabSale";
            this.tabSale.Padding = new System.Windows.Forms.Padding(3);
            this.tabSale.Size = new System.Drawing.Size(1077, 542);
            this.tabSale.TabIndex = 0;
            this.tabSale.Text = global::WFAplikacija.Lang.Dictionary.AFTabSale;
            this.tabSale.UseVisualStyleBackColor = true;
            // 
            // lblTotalNum
            // 
            this.lblTotalNum.AutoSize = true;
            this.lblTotalNum.Location = new System.Drawing.Point(71, 419);
            this.lblTotalNum.Name = "lblTotalNum";
            this.lblTotalNum.Size = new System.Drawing.Size(16, 17);
            this.lblTotalNum.TabIndex = 6;
            this.lblTotalNum.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(7, 419);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(58, 17);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "TOTAL:";
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(312, 393);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(75, 23);
            this.btnComplete.TabIndex = 4;
            this.btnComplete.Text = global::WFAplikacija.Lang.Dictionary.AFButtonComplete;
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // tabControlArticles
            // 
            this.tabControlArticles.Controls.Add(this.tabArctile1);
            this.tabControlArticles.Controls.Add(this.tabArticle2);
            this.tabControlArticles.Location = new System.Drawing.Point(468, 7);
            this.tabControlArticles.Name = "tabControlArticles";
            this.tabControlArticles.SelectedIndex = 0;
            this.tabControlArticles.Size = new System.Drawing.Size(606, 306);
            this.tabControlArticles.TabIndex = 3;
            // 
            // tabArctile1
            // 
            this.tabArctile1.Controls.Add(this.btnArticle2);
            this.tabArctile1.Controls.Add(this.btnArticle1);
            this.tabArctile1.Location = new System.Drawing.Point(4, 25);
            this.tabArctile1.Name = "tabArctile1";
            this.tabArctile1.Padding = new System.Windows.Forms.Padding(3);
            this.tabArctile1.Size = new System.Drawing.Size(598, 277);
            this.tabArctile1.TabIndex = 0;
            this.tabArctile1.Text = global::WFAplikacija.Lang.Dictionary.AFProductTypeDrink;
            this.tabArctile1.UseVisualStyleBackColor = true;
            // 
            // btnArticle2
            // 
            this.btnArticle2.Location = new System.Drawing.Point(87, 6);
            this.btnArticle2.Name = "btnArticle2";
            this.btnArticle2.Size = new System.Drawing.Size(75, 75);
            this.btnArticle2.TabIndex = 1;
            this.btnArticle2.Text = global::WFAplikacija.Lang.Dictionary.AFProductSprite;
            this.btnArticle2.UseVisualStyleBackColor = true;
            this.btnArticle2.Click += new System.EventHandler(this.ArticleButtonClicked);
            // 
            // btnArticle1
            // 
            this.btnArticle1.Location = new System.Drawing.Point(6, 6);
            this.btnArticle1.Name = "btnArticle1";
            this.btnArticle1.Size = new System.Drawing.Size(75, 75);
            this.btnArticle1.TabIndex = 0;
            this.btnArticle1.Text = global::WFAplikacija.Lang.Dictionary.AFProductCocaCola;
            this.btnArticle1.UseVisualStyleBackColor = true;
            this.btnArticle1.Click += new System.EventHandler(this.ArticleButtonClicked);
            // 
            // tabArticle2
            // 
            this.tabArticle2.Location = new System.Drawing.Point(4, 25);
            this.tabArticle2.Name = "tabArticle2";
            this.tabArticle2.Padding = new System.Windows.Forms.Padding(3);
            this.tabArticle2.Size = new System.Drawing.Size(598, 277);
            this.tabArticle2.TabIndex = 1;
            this.tabArticle2.Text = global::WFAplikacija.Lang.Dictionary.AFProductTypeFood;
            this.tabArticle2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "BILL";
            // 
            // listViewArticles
            // 
            this.listViewArticles.HideSelection = false;
            this.listViewArticles.Location = new System.Drawing.Point(6, 27);
            this.listViewArticles.Name = "listViewArticles";
            this.listViewArticles.Size = new System.Drawing.Size(296, 389);
            this.listViewArticles.TabIndex = 0;
            this.listViewArticles.UseCompatibleStateImageBehavior = false;
            // 
            // tabReports
            // 
            this.tabReports.Controls.Add(this.btnFilter);
            this.tabReports.Controls.Add(this.tBoxFilter);
            this.tabReports.Controls.Add(this.cmbFilterFunction);
            this.tabReports.Controls.Add(this.cmbFilterColumn);
            this.tabReports.Controls.Add(this.lblFilter);
            this.tabReports.Controls.Add(this.btnReportsSave);
            this.tabReports.Controls.Add(this.dtReports);
            this.tabReports.Controls.Add(this.radioButton2);
            this.tabReports.Controls.Add(this.radioButton1);
            this.tabReports.Location = new System.Drawing.Point(4, 25);
            this.tabReports.Name = "tabReports";
            this.tabReports.Padding = new System.Windows.Forms.Padding(3);
            this.tabReports.Size = new System.Drawing.Size(1077, 542);
            this.tabReports.TabIndex = 3;
            this.tabReports.Text = global::WFAplikacija.Lang.Dictionary.AFTabReports;
            this.tabReports.UseVisualStyleBackColor = true;
            // 
            // tBoxFilter
            // 
            this.tBoxFilter.Location = new System.Drawing.Point(8, 192);
            this.tBoxFilter.Name = "tBoxFilter";
            this.tBoxFilter.Size = new System.Drawing.Size(121, 22);
            this.tBoxFilter.TabIndex = 9;
            // 
            // cmbFilterFunction
            // 
            this.cmbFilterFunction.FormattingEnabled = true;
            this.cmbFilterFunction.Items.AddRange(new object[] {
            "Is equal to",
            "Is greater than",
            "Is less than",
            "Is not equal to",
            "Starts with"});
            this.cmbFilterFunction.Location = new System.Drawing.Point(8, 149);
            this.cmbFilterFunction.Name = "cmbFilterFunction";
            this.cmbFilterFunction.Size = new System.Drawing.Size(121, 24);
            this.cmbFilterFunction.TabIndex = 8;
            // 
            // cmbFilterColumn
            // 
            this.cmbFilterColumn.FormattingEnabled = true;
            this.cmbFilterColumn.Location = new System.Drawing.Point(8, 108);
            this.cmbFilterColumn.Name = "cmbFilterColumn";
            this.cmbFilterColumn.Size = new System.Drawing.Size(121, 24);
            this.cmbFilterColumn.TabIndex = 7;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(8, 83);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(74, 17);
            this.lblFilter.TabIndex = 6;
            this.lblFilter.Text = "FILTER by";
            // 
            // btnReportsSave
            // 
            this.btnReportsSave.Location = new System.Drawing.Point(3, 511);
            this.btnReportsSave.Name = "btnReportsSave";
            this.btnReportsSave.Size = new System.Drawing.Size(75, 23);
            this.btnReportsSave.TabIndex = 5;
            this.btnReportsSave.Text = "SAVE";
            this.btnReportsSave.UseVisualStyleBackColor = true;
            this.btnReportsSave.Click += new System.EventHandler(this.btnReportsSave_Click);
            // 
            // dtReports
            // 
            this.dtReports.AllowUserToAddRows = false;
            this.dtReports.AllowUserToDeleteRows = false;
            this.dtReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtReports.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtReports.Location = new System.Drawing.Point(161, 6);
            this.dtReports.Name = "dtReports";
            this.dtReports.RowHeadersWidth = 51;
            this.dtReports.RowTemplate.Height = 24;
            this.dtReports.Size = new System.Drawing.Size(910, 528);
            this.dtReports.TabIndex = 4;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 33);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = global::WFAplikacija.Lang.Dictionary.AFButtonProducts;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 6);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(54, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = global::WFAplikacija.Lang.Dictionary.AFButtonBills;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.testABLabel);
            this.tabAdmin.Controls.Add(this.label3);
            this.tabAdmin.Controls.Add(this.openPropertiesButton);
            this.tabAdmin.Controls.Add(this.programmableButton);
            this.tabAdmin.Controls.Add(this.programmableButtonLabel);
            this.tabAdmin.Controls.Add(this.sampleLoginExampleBodyLabel);
            this.tabAdmin.Controls.Add(this.sampleLoginExampleTitleLabel);
            this.tabAdmin.Controls.Add(this.sampleLoginUsernameTextBox);
            this.tabAdmin.Controls.Add(this.sampleLoginPasswordLabel);
            this.tabAdmin.Controls.Add(this.sampleLoginResponseLabel);
            this.tabAdmin.Controls.Add(this.sendSampleLoginButton);
            this.tabAdmin.Controls.Add(this.sampleLoginPasswordTextBox);
            this.tabAdmin.Controls.Add(this.sampleLoginUsernameLabel);
            this.tabAdmin.Controls.Add(this.sampleLoginLabel);
            this.tabAdmin.Controls.Add(this.customGetRequestBaseTextBox);
            this.tabAdmin.Controls.Add(this.label2);
            this.tabAdmin.Controls.Add(this.checkServerMainLabel);
            this.tabAdmin.Controls.Add(this.customGetRequestResponseLabel);
            this.tabAdmin.Controls.Add(this.sendGetRequestButton);
            this.tabAdmin.Controls.Add(this.customGetRequestActionTextBox);
            this.tabAdmin.Controls.Add(this.customRequestUrlLabel);
            this.tabAdmin.Controls.Add(this.customRequestLabel);
            this.tabAdmin.Controls.Add(this.checkServerResponseLabel);
            this.tabAdmin.Controls.Add(this.checkServerButton);
            this.tabAdmin.Location = new System.Drawing.Point(4, 25);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdmin.Size = new System.Drawing.Size(1077, 542);
            this.tabAdmin.TabIndex = 2;
            this.tabAdmin.Text = global::WFAplikacija.Lang.Dictionary.AFTabAdmin;
            this.tabAdmin.UseVisualStyleBackColor = true;
            this.tabAdmin.Click += new System.EventHandler(this.tabReports_Click);
            // 
            // testABLabel
            // 
            this.testABLabel.AutoSize = true;
            this.testABLabel.Location = new System.Drawing.Point(735, 67);
            this.testABLabel.Name = "testABLabel";
            this.testABLabel.Size = new System.Drawing.Size(49, 17);
            this.testABLabel.TabIndex = 24;
            this.testABLabel.Text = "testAB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(612, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Current language: English";
            // 
            // openPropertiesButton
            // 
            this.openPropertiesButton.Location = new System.Drawing.Point(675, 6);
            this.openPropertiesButton.Name = "openPropertiesButton";
            this.openPropertiesButton.Size = new System.Drawing.Size(109, 35);
            this.openPropertiesButton.TabIndex = 22;
            this.openPropertiesButton.Text = global::WFAplikacija.Lang.Dictionary.AFButtonProperties;
            this.openPropertiesButton.UseVisualStyleBackColor = true;
            this.openPropertiesButton.Click += new System.EventHandler(this.openPropertiesButton_Click);
            // 
            // programmableButton
            // 
            this.programmableButton.BackColor = System.Drawing.Color.Red;
            this.programmableButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.programmableButton.Location = new System.Drawing.Point(15, 410);
            this.programmableButton.Name = "programmableButton";
            this.programmableButton.Size = new System.Drawing.Size(30, 30);
            this.programmableButton.TabIndex = 21;
            this.programmableButton.UseVisualStyleBackColor = false;
            this.programmableButton.Click += new System.EventHandler(this.programmableButton_Click);
            // 
            // programmableButtonLabel
            // 
            this.programmableButtonLabel.AutoSize = true;
            this.programmableButtonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.programmableButtonLabel.Location = new System.Drawing.Point(51, 411);
            this.programmableButtonLabel.Name = "programmableButtonLabel";
            this.programmableButtonLabel.Size = new System.Drawing.Size(198, 25);
            this.programmableButtonLabel.TabIndex = 20;
            this.programmableButtonLabel.Text = "Programmable button";
            // 
            // sampleLoginExampleBodyLabel
            // 
            this.sampleLoginExampleBodyLabel.AutoSize = true;
            this.sampleLoginExampleBodyLabel.Location = new System.Drawing.Point(274, 264);
            this.sampleLoginExampleBodyLabel.Name = "sampleLoginExampleBodyLabel";
            this.sampleLoginExampleBodyLabel.Size = new System.Drawing.Size(119, 34);
            this.sampleLoginExampleBodyLabel.TabIndex = 19;
            this.sampleLoginExampleBodyLabel.Text = "Username: admin\nPassword: 123";
            // 
            // sampleLoginExampleTitleLabel
            // 
            this.sampleLoginExampleTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sampleLoginExampleTitleLabel.Location = new System.Drawing.Point(274, 247);
            this.sampleLoginExampleTitleLabel.Name = "sampleLoginExampleTitleLabel";
            this.sampleLoginExampleTitleLabel.Size = new System.Drawing.Size(119, 17);
            this.sampleLoginExampleTitleLabel.TabIndex = 18;
            this.sampleLoginExampleTitleLabel.Text = "Sample user";
            this.sampleLoginExampleTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sampleLoginUsernameTextBox
            // 
            this.sampleLoginUsernameTextBox.Location = new System.Drawing.Point(88, 247);
            this.sampleLoginUsernameTextBox.Name = "sampleLoginUsernameTextBox";
            this.sampleLoginUsernameTextBox.Size = new System.Drawing.Size(180, 22);
            this.sampleLoginUsernameTextBox.TabIndex = 17;
            this.sampleLoginUsernameTextBox.Text = "admin";
            // 
            // sampleLoginPasswordLabel
            // 
            this.sampleLoginPasswordLabel.AutoSize = true;
            this.sampleLoginPasswordLabel.Location = new System.Drawing.Point(12, 274);
            this.sampleLoginPasswordLabel.Name = "sampleLoginPasswordLabel";
            this.sampleLoginPasswordLabel.Size = new System.Drawing.Size(73, 17);
            this.sampleLoginPasswordLabel.TabIndex = 16;
            this.sampleLoginPasswordLabel.Text = "Password:";
            // 
            // sampleLoginResponseLabel
            // 
            this.sampleLoginResponseLabel.AutoSize = true;
            this.sampleLoginResponseLabel.Location = new System.Drawing.Point(96, 307);
            this.sampleLoginResponseLabel.Name = "sampleLoginResponseLabel";
            this.sampleLoginResponseLabel.Size = new System.Drawing.Size(79, 17);
            this.sampleLoginResponseLabel.TabIndex = 15;
            this.sampleLoginResponseLabel.Text = "Press send";
            // 
            // sendSampleLoginButton
            // 
            this.sendSampleLoginButton.Location = new System.Drawing.Point(15, 305);
            this.sendSampleLoginButton.Name = "sendSampleLoginButton";
            this.sendSampleLoginButton.Size = new System.Drawing.Size(75, 23);
            this.sendSampleLoginButton.TabIndex = 14;
            this.sendSampleLoginButton.Text = global::WFAplikacija.Lang.Dictionary.AFButtonSend;
            this.sendSampleLoginButton.UseVisualStyleBackColor = true;
            this.sendSampleLoginButton.Click += new System.EventHandler(this.sendSampleLoginButton_Click);
            // 
            // sampleLoginPasswordTextBox
            // 
            this.sampleLoginPasswordTextBox.Location = new System.Drawing.Point(88, 272);
            this.sampleLoginPasswordTextBox.Name = "sampleLoginPasswordTextBox";
            this.sampleLoginPasswordTextBox.Size = new System.Drawing.Size(180, 22);
            this.sampleLoginPasswordTextBox.TabIndex = 13;
            this.sampleLoginPasswordTextBox.Text = "123";
            // 
            // sampleLoginUsernameLabel
            // 
            this.sampleLoginUsernameLabel.AutoSize = true;
            this.sampleLoginUsernameLabel.Location = new System.Drawing.Point(12, 250);
            this.sampleLoginUsernameLabel.Name = "sampleLoginUsernameLabel";
            this.sampleLoginUsernameLabel.Size = new System.Drawing.Size(73, 17);
            this.sampleLoginUsernameLabel.TabIndex = 12;
            this.sampleLoginUsernameLabel.Text = "Username";
            // 
            // sampleLoginLabel
            // 
            this.sampleLoginLabel.AutoSize = true;
            this.sampleLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sampleLoginLabel.Location = new System.Drawing.Point(10, 217);
            this.sampleLoginLabel.Name = "sampleLoginLabel";
            this.sampleLoginLabel.Size = new System.Drawing.Size(125, 25);
            this.sampleLoginLabel.TabIndex = 11;
            this.sampleLoginLabel.Text = "Sample login";
            // 
            // customGetRequestBaseTextBox
            // 
            this.customGetRequestBaseTextBox.Location = new System.Drawing.Point(70, 120);
            this.customGetRequestBaseTextBox.Name = "customGetRequestBaseTextBox";
            this.customGetRequestBaseTextBox.Size = new System.Drawing.Size(180, 22);
            this.customGetRequestBaseTextBox.TabIndex = 10;
            this.customGetRequestBaseTextBox.Text = "https://www.google.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Action:";
            // 
            // checkServerMainLabel
            // 
            this.checkServerMainLabel.AutoSize = true;
            this.checkServerMainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkServerMainLabel.Location = new System.Drawing.Point(10, 22);
            this.checkServerMainLabel.Name = "checkServerMainLabel";
            this.checkServerMainLabel.Size = new System.Drawing.Size(435, 25);
            this.checkServerMainLabel.TabIndex = 8;
            this.checkServerMainLabel.Text = "Check server (URL: http://localhost:5001/Status)";
            // 
            // customGetRequestResponseLabel
            // 
            this.customGetRequestResponseLabel.AutoSize = true;
            this.customGetRequestResponseLabel.Location = new System.Drawing.Point(96, 180);
            this.customGetRequestResponseLabel.MaximumSize = new System.Drawing.Size(500, 34);
            this.customGetRequestResponseLabel.Name = "customGetRequestResponseLabel";
            this.customGetRequestResponseLabel.Size = new System.Drawing.Size(79, 17);
            this.customGetRequestResponseLabel.TabIndex = 6;
            this.customGetRequestResponseLabel.Text = "Press send";
            // 
            // sendGetRequestButton
            // 
            this.sendGetRequestButton.Location = new System.Drawing.Point(15, 178);
            this.sendGetRequestButton.Name = "sendGetRequestButton";
            this.sendGetRequestButton.Size = new System.Drawing.Size(75, 23);
            this.sendGetRequestButton.TabIndex = 5;
            this.sendGetRequestButton.Text = global::WFAplikacija.Lang.Dictionary.AFButtonSend;
            this.sendGetRequestButton.UseVisualStyleBackColor = true;
            this.sendGetRequestButton.Click += new System.EventHandler(this.sendGetRequestButton_Click);
            // 
            // customGetRequestActionTextBox
            // 
            this.customGetRequestActionTextBox.Location = new System.Drawing.Point(70, 145);
            this.customGetRequestActionTextBox.Name = "customGetRequestActionTextBox";
            this.customGetRequestActionTextBox.Size = new System.Drawing.Size(180, 22);
            this.customGetRequestActionTextBox.TabIndex = 4;
            // 
            // customRequestUrlLabel
            // 
            this.customRequestUrlLabel.AutoSize = true;
            this.customRequestUrlLabel.Location = new System.Drawing.Point(12, 123);
            this.customRequestUrlLabel.Name = "customRequestUrlLabel";
            this.customRequestUrlLabel.Size = new System.Drawing.Size(44, 17);
            this.customRequestUrlLabel.TabIndex = 3;
            this.customRequestUrlLabel.Text = "Base:";
            // 
            // customRequestLabel
            // 
            this.customRequestLabel.AutoSize = true;
            this.customRequestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.customRequestLabel.Location = new System.Drawing.Point(10, 90);
            this.customRequestLabel.Name = "customRequestLabel";
            this.customRequestLabel.Size = new System.Drawing.Size(208, 25);
            this.customRequestLabel.TabIndex = 2;
            this.customRequestLabel.Text = "Custom REST request";
            // 
            // checkServerResponseLabel
            // 
            this.checkServerResponseLabel.AutoSize = true;
            this.checkServerResponseLabel.Location = new System.Drawing.Point(96, 53);
            this.checkServerResponseLabel.Name = "checkServerResponseLabel";
            this.checkServerResponseLabel.Size = new System.Drawing.Size(79, 17);
            this.checkServerResponseLabel.TabIndex = 1;
            this.checkServerResponseLabel.Text = "Press send";
            // 
            // checkServerButton
            // 
            this.checkServerButton.Location = new System.Drawing.Point(15, 50);
            this.checkServerButton.Name = "checkServerButton";
            this.checkServerButton.Size = new System.Drawing.Size(75, 23);
            this.checkServerButton.TabIndex = 0;
            this.checkServerButton.Text = global::WFAplikacija.Lang.Dictionary.AFButtonSend;
            this.checkServerButton.UseVisualStyleBackColor = true;
            this.checkServerButton.Click += new System.EventHandler(this.checkServerButton_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(54, 239);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 10;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 571);
            this.Controls.Add(this.tabMainControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AppForm";
            this.Text = "Cashapp";
            this.tabMainControl.ResumeLayout(false);
            this.tabSale.ResumeLayout(false);
            this.tabSale.PerformLayout();
            this.tabControlArticles.ResumeLayout(false);
            this.tabArctile1.ResumeLayout(false);
            this.tabReports.ResumeLayout(false);
            this.tabReports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtReports)).EndInit();
            this.tabAdmin.ResumeLayout(false);
            this.tabAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.TabControl tabMainControl;
        private System.Windows.Forms.TabPage tabSale;
        private System.Windows.Forms.TabControl tabControlArticles;
        private System.Windows.Forms.TabPage tabArctile1;
        private System.Windows.Forms.Button btnArticle2;
        private System.Windows.Forms.Button btnArticle1;
        private System.Windows.Forms.TabPage tabArticle2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewArticles;
        private System.Windows.Forms.TabPage tabAdmin;
        private System.Windows.Forms.Button checkServerButton;
        private System.Windows.Forms.Label checkServerResponseLabel;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Label customRequestLabel;
        private System.Windows.Forms.Label customRequestUrlLabel;
        private System.Windows.Forms.TextBox customGetRequestActionTextBox;
        private System.Windows.Forms.Label customGetRequestResponseLabel;
        private System.Windows.Forms.Button sendGetRequestButton;
        private System.Windows.Forms.Label checkServerMainLabel;
        private System.Windows.Forms.TextBox customGetRequestBaseTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sampleLoginExampleTitleLabel;
        private System.Windows.Forms.TextBox sampleLoginUsernameTextBox;
        private System.Windows.Forms.Label sampleLoginPasswordLabel;
        private System.Windows.Forms.Label sampleLoginResponseLabel;
        private System.Windows.Forms.Button sendSampleLoginButton;
        private System.Windows.Forms.TextBox sampleLoginPasswordTextBox;
        private System.Windows.Forms.Label sampleLoginUsernameLabel;
        private System.Windows.Forms.Label sampleLoginLabel;
        private System.Windows.Forms.Label sampleLoginExampleBodyLabel;
        private System.Windows.Forms.Label lblTotalNum;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TabPage tabReports;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridView dtReports;
        private Syncfusion.Pdf.PdfConfig pdfConfig1;
        private System.Windows.Forms.Label programmableButtonLabel;
        private System.Windows.Forms.Button programmableButton;
        private System.Windows.Forms.Button openPropertiesButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label testABLabel;
        private System.Windows.Forms.Button btnReportsSave;
        private System.Windows.Forms.ComboBox cmbFilterColumn;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cmbFilterFunction;
        private System.Windows.Forms.TextBox tBoxFilter;
        private System.Windows.Forms.Button btnFilter;
    }
}
