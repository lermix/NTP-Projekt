namespace WFAplikacija
{
    partial class Form1
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
            this.tabProperties = new System.Windows.Forms.TabPage();
            this.lblAdminLogin = new System.Windows.Forms.Label();
            this.lblAdminPass = new System.Windows.Forms.Label();
            this.lblAdminUsername = new System.Windows.Forms.Label();
            this.tBoxAdminPass = new System.Windows.Forms.TextBox();
            this.tBoxAdminUsername = new System.Windows.Forms.TextBox();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.tabReports = new System.Windows.Forms.TabPage();
            this.dtReports = new System.Windows.Forms.DataGridView();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tabDatabase = new System.Windows.Forms.TabPage();
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
            this.programmableButton = new System.Windows.Forms.Button();
            this.tabMainControl.SuspendLayout();
            this.tabSale.SuspendLayout();
            this.tabControlArticles.SuspendLayout();
            this.tabArctile1.SuspendLayout();
            this.tabProperties.SuspendLayout();
            this.tabReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtReports)).BeginInit();
            this.tabDatabase.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMainControl
            // 
            this.tabMainControl.Controls.Add(this.tabSale);
            this.tabMainControl.Controls.Add(this.tabProperties);
            this.tabMainControl.Controls.Add(this.tabReports);
            this.tabMainControl.Controls.Add(this.tabDatabase);
            this.tabMainControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMainControl.Location = new System.Drawing.Point(0, 0);
            this.tabMainControl.Name = "tabMainControl";
            this.tabMainControl.SelectedIndex = 0;
            this.tabMainControl.Size = new System.Drawing.Size(800, 478);
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
            this.tabSale.Size = new System.Drawing.Size(792, 449);
            this.tabSale.TabIndex = 0;
            this.tabSale.Text = "Sale";
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
            this.btnComplete.Text = "Complete";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // tabControlArticles
            // 
            this.tabControlArticles.Controls.Add(this.tabArctile1);
            this.tabControlArticles.Controls.Add(this.tabArticle2);
            this.tabControlArticles.Location = new System.Drawing.Point(308, 27);
            this.tabControlArticles.Name = "tabControlArticles";
            this.tabControlArticles.SelectedIndex = 0;
            this.tabControlArticles.Size = new System.Drawing.Size(431, 262);
            this.tabControlArticles.TabIndex = 3;
            // 
            // tabArctile1
            // 
            this.tabArctile1.Controls.Add(this.btnArticle2);
            this.tabArctile1.Controls.Add(this.btnArticle1);
            this.tabArctile1.Location = new System.Drawing.Point(4, 25);
            this.tabArctile1.Name = "tabArctile1";
            this.tabArctile1.Padding = new System.Windows.Forms.Padding(3);
            this.tabArctile1.Size = new System.Drawing.Size(423, 233);
            this.tabArctile1.TabIndex = 0;
            this.tabArctile1.Text = "tabArctile1";
            this.tabArctile1.UseVisualStyleBackColor = true;
            // 
            // btnArticle2
            // 
            this.btnArticle2.Location = new System.Drawing.Point(87, 6);
            this.btnArticle2.Name = "btnArticle2";
            this.btnArticle2.Size = new System.Drawing.Size(75, 75);
            this.btnArticle2.TabIndex = 1;
            this.btnArticle2.Text = "Sprite";
            this.btnArticle2.UseVisualStyleBackColor = true;
            this.btnArticle2.Click += new System.EventHandler(this.ArticleButtonClicked);
            // 
            // btnArticle1
            // 
            this.btnArticle1.Location = new System.Drawing.Point(6, 6);
            this.btnArticle1.Name = "btnArticle1";
            this.btnArticle1.Size = new System.Drawing.Size(75, 75);
            this.btnArticle1.TabIndex = 0;
            this.btnArticle1.Text = "CocaCola";
            this.btnArticle1.UseVisualStyleBackColor = true;
            this.btnArticle1.Click += new System.EventHandler(this.ArticleButtonClicked);
            // 
            // tabArticle2
            // 
            this.tabArticle2.Location = new System.Drawing.Point(4, 25);
            this.tabArticle2.Name = "tabArticle2";
            this.tabArticle2.Padding = new System.Windows.Forms.Padding(3);
            this.tabArticle2.Size = new System.Drawing.Size(423, 233);
            this.tabArticle2.TabIndex = 1;
            this.tabArticle2.Text = "tabArticle2";
            this.tabArticle2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "RACUN";
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
            // tabProperties
            // 
            this.tabProperties.Controls.Add(this.lblAdminLogin);
            this.tabProperties.Controls.Add(this.lblAdminPass);
            this.tabProperties.Controls.Add(this.lblAdminUsername);
            this.tabProperties.Controls.Add(this.tBoxAdminPass);
            this.tabProperties.Controls.Add(this.tBoxAdminUsername);
            this.tabProperties.Controls.Add(this.btnAdminLogin);
            this.tabProperties.Location = new System.Drawing.Point(4, 25);
            this.tabProperties.Name = "tabProperties";
            this.tabProperties.Padding = new System.Windows.Forms.Padding(3);
            this.tabProperties.Size = new System.Drawing.Size(792, 449);
            this.tabProperties.TabIndex = 1;
            this.tabProperties.Text = "Properties";
            this.tabProperties.UseVisualStyleBackColor = true;
            // 
            // lblAdminLogin
            // 
            this.lblAdminLogin.AutoSize = true;
            this.lblAdminLogin.Location = new System.Drawing.Point(346, 90);
            this.lblAdminLogin.Name = "lblAdminLogin";
            this.lblAdminLogin.Size = new System.Drawing.Size(98, 17);
            this.lblAdminLogin.TabIndex = 5;
            this.lblAdminLogin.Text = "ADMIN LOGIN";
            // 
            // lblAdminPass
            // 
            this.lblAdminPass.AutoSize = true;
            this.lblAdminPass.Location = new System.Drawing.Point(293, 197);
            this.lblAdminPass.Name = "lblAdminPass";
            this.lblAdminPass.Size = new System.Drawing.Size(69, 17);
            this.lblAdminPass.TabIndex = 4;
            this.lblAdminPass.Text = "Password";
            // 
            // lblAdminUsername
            // 
            this.lblAdminUsername.AutoSize = true;
            this.lblAdminUsername.Location = new System.Drawing.Point(289, 142);
            this.lblAdminUsername.Name = "lblAdminUsername";
            this.lblAdminUsername.Size = new System.Drawing.Size(73, 17);
            this.lblAdminUsername.TabIndex = 3;
            this.lblAdminUsername.Text = "Username";
            // 
            // tBoxAdminPass
            // 
            this.tBoxAdminPass.Location = new System.Drawing.Point(368, 194);
            this.tBoxAdminPass.Name = "tBoxAdminPass";
            this.tBoxAdminPass.Size = new System.Drawing.Size(100, 22);
            this.tBoxAdminPass.TabIndex = 2;
            // 
            // tBoxAdminUsername
            // 
            this.tBoxAdminUsername.Location = new System.Drawing.Point(368, 142);
            this.tBoxAdminUsername.Name = "tBoxAdminUsername";
            this.tBoxAdminUsername.Size = new System.Drawing.Size(100, 22);
            this.tBoxAdminUsername.TabIndex = 1;
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.Location = new System.Drawing.Point(349, 244);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(75, 23);
            this.btnAdminLogin.TabIndex = 0;
            this.btnAdminLogin.Text = "Login";
            this.btnAdminLogin.UseVisualStyleBackColor = true;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // tabReports
            // 
            this.tabReports.Controls.Add(this.dtReports);
            this.tabReports.Controls.Add(this.radioButton3);
            this.tabReports.Controls.Add(this.radioButton2);
            this.tabReports.Controls.Add(this.radioButton1);
            this.tabReports.Location = new System.Drawing.Point(4, 25);
            this.tabReports.Name = "tabReports";
            this.tabReports.Padding = new System.Windows.Forms.Padding(3);
            this.tabReports.Size = new System.Drawing.Size(792, 449);
            this.tabReports.TabIndex = 3;
            this.tabReports.Text = "Reports";
            this.tabReports.UseVisualStyleBackColor = true;
            // 
            // dtReports
            // 
            this.dtReports.AllowUserToAddRows = false;
            this.dtReports.AllowUserToDeleteRows = false;
            this.dtReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtReports.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtReports.Location = new System.Drawing.Point(119, 6);
            this.dtReports.Name = "dtReports";
            this.dtReports.RowHeadersWidth = 51;
            this.dtReports.RowTemplate.Height = 24;
            this.dtReports.Size = new System.Drawing.Size(667, 432);
            this.dtReports.TabIndex = 4;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(3, 60);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(110, 21);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 33);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(75, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Articles";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 6);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(54, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "BIlls";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // tabDatabase
            // 
            this.tabDatabase.Controls.Add(this.programmableButton);
            this.tabDatabase.Controls.Add(this.programmableButtonLabel);
            this.tabDatabase.Controls.Add(this.sampleLoginExampleBodyLabel);
            this.tabDatabase.Controls.Add(this.sampleLoginExampleTitleLabel);
            this.tabDatabase.Controls.Add(this.sampleLoginUsernameTextBox);
            this.tabDatabase.Controls.Add(this.sampleLoginPasswordLabel);
            this.tabDatabase.Controls.Add(this.sampleLoginResponseLabel);
            this.tabDatabase.Controls.Add(this.sendSampleLoginButton);
            this.tabDatabase.Controls.Add(this.sampleLoginPasswordTextBox);
            this.tabDatabase.Controls.Add(this.sampleLoginUsernameLabel);
            this.tabDatabase.Controls.Add(this.sampleLoginLabel);
            this.tabDatabase.Controls.Add(this.customGetRequestBaseTextBox);
            this.tabDatabase.Controls.Add(this.label2);
            this.tabDatabase.Controls.Add(this.checkServerMainLabel);
            this.tabDatabase.Controls.Add(this.customGetRequestResponseLabel);
            this.tabDatabase.Controls.Add(this.sendGetRequestButton);
            this.tabDatabase.Controls.Add(this.customGetRequestActionTextBox);
            this.tabDatabase.Controls.Add(this.customRequestUrlLabel);
            this.tabDatabase.Controls.Add(this.customRequestLabel);
            this.tabDatabase.Controls.Add(this.checkServerResponseLabel);
            this.tabDatabase.Controls.Add(this.checkServerButton);
            this.tabDatabase.Location = new System.Drawing.Point(4, 25);
            this.tabDatabase.Name = "tabDatabase";
            this.tabDatabase.Padding = new System.Windows.Forms.Padding(3);
            this.tabDatabase.Size = new System.Drawing.Size(792, 449);
            this.tabDatabase.TabIndex = 2;
            this.tabDatabase.Text = "Playground";
            this.tabDatabase.UseVisualStyleBackColor = true;
            this.tabDatabase.Click += new System.EventHandler(this.tabReports_Click);
            // 
            // programmableButtonLabel
            // 
            this.programmableButtonLabel.AutoSize = true;
            this.programmableButtonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.programmableButtonLabel.Location = new System.Drawing.Point(11, 411);
            this.programmableButtonLabel.Name = "programmableButtonLabel";
            this.programmableButtonLabel.Size = new System.Drawing.Size(349, 25);
            this.programmableButtonLabel.TabIndex = 20;
            this.programmableButtonLabel.Text = "Debug button (Attach any function to it)";
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
            this.sampleLoginPasswordLabel.Location = new System.Drawing.Point(13, 274);
            this.sampleLoginPasswordLabel.Name = "sampleLoginPasswordLabel";
            this.sampleLoginPasswordLabel.Size = new System.Drawing.Size(73, 17);
            this.sampleLoginPasswordLabel.TabIndex = 16;
            this.sampleLoginPasswordLabel.Text = "Password:";
            // 
            // sampleLoginResponseLabel
            // 
            this.sampleLoginResponseLabel.AutoSize = true;
            this.sampleLoginResponseLabel.Location = new System.Drawing.Point(92, 307);
            this.sampleLoginResponseLabel.Name = "sampleLoginResponseLabel";
            this.sampleLoginResponseLabel.Size = new System.Drawing.Size(184, 17);
            this.sampleLoginResponseLabel.TabIndex = 15;
            this.sampleLoginResponseLabel.Text = "Press Send to get response";
            // 
            // sendSampleLoginButton
            // 
            this.sendSampleLoginButton.Location = new System.Drawing.Point(15, 305);
            this.sendSampleLoginButton.Name = "sendSampleLoginButton";
            this.sendSampleLoginButton.Size = new System.Drawing.Size(75, 23);
            this.sendSampleLoginButton.TabIndex = 14;
            this.sendSampleLoginButton.Text = "Send";
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
            this.sampleLoginUsernameLabel.Size = new System.Drawing.Size(77, 17);
            this.sampleLoginUsernameLabel.TabIndex = 12;
            this.sampleLoginUsernameLabel.Text = "Username:";
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
            this.label2.Location = new System.Drawing.Point(13, 147);
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
            this.checkServerMainLabel.Size = new System.Drawing.Size(502, 25);
            this.checkServerMainLabel.TabIndex = 8;
            this.checkServerMainLabel.Text = "Check server status (URL: https://localhost:5001/Status)";
            // 
            // customGetRequestResponseLabel
            // 
            this.customGetRequestResponseLabel.AutoSize = true;
            this.customGetRequestResponseLabel.Location = new System.Drawing.Point(92, 180);
            this.customGetRequestResponseLabel.MaximumSize = new System.Drawing.Size(500, 34);
            this.customGetRequestResponseLabel.Name = "customGetRequestResponseLabel";
            this.customGetRequestResponseLabel.Size = new System.Drawing.Size(184, 17);
            this.customGetRequestResponseLabel.TabIndex = 6;
            this.customGetRequestResponseLabel.Text = "Press Send to get response";
            // 
            // sendGetRequestButton
            // 
            this.sendGetRequestButton.Location = new System.Drawing.Point(15, 178);
            this.sendGetRequestButton.Name = "sendGetRequestButton";
            this.sendGetRequestButton.Size = new System.Drawing.Size(75, 23);
            this.sendGetRequestButton.TabIndex = 5;
            this.sendGetRequestButton.Text = "Send";
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
            this.customRequestLabel.Size = new System.Drawing.Size(344, 25);
            this.customRequestLabel.TabIndex = 2;
            this.customRequestLabel.Text = "Custom GET request (write to textbox)";
            // 
            // checkServerResponseLabel
            // 
            this.checkServerResponseLabel.AutoSize = true;
            this.checkServerResponseLabel.Location = new System.Drawing.Point(93, 53);
            this.checkServerResponseLabel.Name = "checkServerResponseLabel";
            this.checkServerResponseLabel.Size = new System.Drawing.Size(214, 17);
            this.checkServerResponseLabel.TabIndex = 1;
            this.checkServerResponseLabel.Text = "Press button to get server status";
            // 
            // checkServerButton
            // 
            this.checkServerButton.Location = new System.Drawing.Point(10, 50);
            this.checkServerButton.Name = "checkServerButton";
            this.checkServerButton.Size = new System.Drawing.Size(81, 23);
            this.checkServerButton.TabIndex = 0;
            this.checkServerButton.Text = "Send";
            this.checkServerButton.UseVisualStyleBackColor = true;
            this.checkServerButton.Click += new System.EventHandler(this.checkServerButton_Click);
            // 
            // programmableButton
            // 
            this.programmableButton.BackColor = System.Drawing.Color.Red;
            this.programmableButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.programmableButton.Location = new System.Drawing.Point(363, 410);
            this.programmableButton.Name = "programmableButton";
            this.programmableButton.Size = new System.Drawing.Size(30, 30);
            this.programmableButton.TabIndex = 21;
            this.programmableButton.UseVisualStyleBackColor = false;
            this.programmableButton.Click += new System.EventHandler(this.programmableButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.tabMainControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabMainControl.ResumeLayout(false);
            this.tabSale.ResumeLayout(false);
            this.tabSale.PerformLayout();
            this.tabControlArticles.ResumeLayout(false);
            this.tabArctile1.ResumeLayout(false);
            this.tabProperties.ResumeLayout(false);
            this.tabProperties.PerformLayout();
            this.tabReports.ResumeLayout(false);
            this.tabReports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtReports)).EndInit();
            this.tabDatabase.ResumeLayout(false);
            this.tabDatabase.PerformLayout();
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
        private System.Windows.Forms.TabPage tabProperties;
        private System.Windows.Forms.Label lblAdminLogin;
        private System.Windows.Forms.Label lblAdminPass;
        private System.Windows.Forms.Label lblAdminUsername;
        private System.Windows.Forms.TextBox tBoxAdminPass;
        private System.Windows.Forms.TextBox tBoxAdminUsername;
        private System.Windows.Forms.Button btnAdminLogin;
        private System.Windows.Forms.TabPage tabDatabase;
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
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridView dtReports;
        private Syncfusion.Pdf.PdfConfig pdfConfig1;
        private System.Windows.Forms.Label programmableButtonLabel;
        private System.Windows.Forms.Button programmableButton;
    }
}

