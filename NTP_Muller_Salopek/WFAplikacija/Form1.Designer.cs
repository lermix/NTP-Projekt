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
            this.customGetRequestResponseLabel = new System.Windows.Forms.Label();
            this.sendGetRequestButton = new System.Windows.Forms.Button();
            this.customGetRequestActionTextBox = new System.Windows.Forms.TextBox();
            this.customRequestUrlLabel = new System.Windows.Forms.Label();
            this.customRequestLabel = new System.Windows.Forms.Label();
            this.checkServerResponseLabel = new System.Windows.Forms.Label();
            this.checkServerButton = new System.Windows.Forms.Button();
            this.checkServerMainLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customGetRequestBaseTextBox = new System.Windows.Forms.TextBox();
            this.tabMainControl.SuspendLayout();
            this.tabSale.SuspendLayout();
            this.tabControlArticles.SuspendLayout();
            this.tabArctile1.SuspendLayout();
            this.tabProperties.SuspendLayout();
            this.tabReports.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMainControl
            // 
            this.tabMainControl.Controls.Add(this.tabSale);
            this.tabMainControl.Controls.Add(this.tabProperties);
            this.tabMainControl.Controls.Add(this.tabReports);
            this.tabMainControl.Location = new System.Drawing.Point(2, 2);
            this.tabMainControl.Name = "tabMainControl";
            this.tabMainControl.SelectedIndex = 0;
            this.tabMainControl.Size = new System.Drawing.Size(800, 448);
            this.tabMainControl.TabIndex = 0;
            // 
            // tabSale
            // 
            this.tabSale.Controls.Add(this.btnComplete);
            this.tabSale.Controls.Add(this.tabControlArticles);
            this.tabSale.Controls.Add(this.label1);
            this.tabSale.Controls.Add(this.listViewArticles);
            this.tabSale.Location = new System.Drawing.Point(4, 25);
            this.tabSale.Name = "tabSale";
            this.tabSale.Padding = new System.Windows.Forms.Padding(3);
            this.tabSale.Size = new System.Drawing.Size(792, 419);
            this.tabSale.TabIndex = 0;
            this.tabSale.Text = "Sale";
            this.tabSale.UseVisualStyleBackColor = true;
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(308, 388);
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
            this.tabProperties.Size = new System.Drawing.Size(792, 419);
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
            this.tabReports.Controls.Add(this.customGetRequestBaseTextBox);
            this.tabReports.Controls.Add(this.label2);
            this.tabReports.Controls.Add(this.checkServerMainLabel);
            this.tabReports.Controls.Add(this.customGetRequestResponseLabel);
            this.tabReports.Controls.Add(this.sendGetRequestButton);
            this.tabReports.Controls.Add(this.customGetRequestActionTextBox);
            this.tabReports.Controls.Add(this.customRequestUrlLabel);
            this.tabReports.Controls.Add(this.customRequestLabel);
            this.tabReports.Controls.Add(this.checkServerResponseLabel);
            this.tabReports.Controls.Add(this.checkServerButton);
            this.tabReports.Location = new System.Drawing.Point(4, 25);
            this.tabReports.Name = "tabReports";
            this.tabReports.Padding = new System.Windows.Forms.Padding(3);
            this.tabReports.Size = new System.Drawing.Size(792, 419);
            this.tabReports.TabIndex = 2;
            this.tabReports.Text = "Reports";
            this.tabReports.UseVisualStyleBackColor = true;
            this.tabReports.Click += new System.EventHandler(this.tabReports_Click);
            // 
            // customGetRequestResponseLabel
            // 
            this.customGetRequestResponseLabel.AutoSize = true;
            this.customGetRequestResponseLabel.Location = new System.Drawing.Point(92, 180);
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
            // checkServerMainLabel
            // 
            this.checkServerMainLabel.AutoSize = true;
            this.checkServerMainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkServerMainLabel.Location = new System.Drawing.Point(10, 22);
            this.checkServerMainLabel.Name = "checkServerMainLabel";
            this.checkServerMainLabel.Size = new System.Drawing.Size(615, 25);
            this.checkServerMainLabel.TabIndex = 8;
            this.checkServerMainLabel.Text = "Check server status (URL: https://localhost:5001/Home/RequestTest)";
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
            // customGetRequestBaseTextBox
            // 
            this.customGetRequestBaseTextBox.Location = new System.Drawing.Point(70, 120);
            this.customGetRequestBaseTextBox.Name = "customGetRequestBaseTextBox";
            this.customGetRequestBaseTextBox.Size = new System.Drawing.Size(180, 22);
            this.customGetRequestBaseTextBox.TabIndex = 10;
            this.customGetRequestBaseTextBox.Text = "https://www.google.com";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.TabPage tabReports;
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
    }
}

