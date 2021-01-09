namespace WFAplikacija
{
    partial class PropertiesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PropertiesForm));
            this.tabArticleManager = new System.Windows.Forms.TabPage();
            this.listBoxArticleManagerArticles = new System.Windows.Forms.ListBox();
            this.btnArticleManagerComplete = new System.Windows.Forms.Button();
            this.txtBoxArticleManagerPrice = new System.Windows.Forms.TextBox();
            this.txtBoxArticleManagerBtnName = new System.Windows.Forms.TextBox();
            this.txtBoxArticleManagerName = new System.Windows.Forms.TextBox();
            this.txtBoxArticleManagerId = new System.Windows.Forms.TextBox();
            this.lblArticleManagerPrice = new System.Windows.Forms.Label();
            this.lblArticleManagerbtnName = new System.Windows.Forms.Label();
            this.lblArticleManagerName = new System.Windows.Forms.Label();
            this.lblArticleManagerID = new System.Windows.Forms.Label();
            this.lblChoseArticle = new System.Windows.Forms.Label();
            this.lblOperation = new System.Windows.Forms.Label();
            this.cmbArticleManager = new System.Windows.Forms.ComboBox();
            this.tabControlProperties = new System.Windows.Forms.TabControl();
            this.tabPageBillsCrypto = new System.Windows.Forms.TabPage();
            this.cmbCrypto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCryptoSet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxCrypto = new System.Windows.Forms.TextBox();
            this.btnCryptoShow = new System.Windows.Forms.Button();
            this.rtbCrypto = new System.Windows.Forms.RichTextBox();
            this.tabArticleManager.SuspendLayout();
            this.tabControlProperties.SuspendLayout();
            this.tabPageBillsCrypto.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabArticleManager
            // 
            this.tabArticleManager.Controls.Add(this.listBoxArticleManagerArticles);
            this.tabArticleManager.Controls.Add(this.btnArticleManagerComplete);
            this.tabArticleManager.Controls.Add(this.txtBoxArticleManagerPrice);
            this.tabArticleManager.Controls.Add(this.txtBoxArticleManagerBtnName);
            this.tabArticleManager.Controls.Add(this.txtBoxArticleManagerName);
            this.tabArticleManager.Controls.Add(this.txtBoxArticleManagerId);
            this.tabArticleManager.Controls.Add(this.lblArticleManagerPrice);
            this.tabArticleManager.Controls.Add(this.lblArticleManagerbtnName);
            this.tabArticleManager.Controls.Add(this.lblArticleManagerName);
            this.tabArticleManager.Controls.Add(this.lblArticleManagerID);
            this.tabArticleManager.Controls.Add(this.lblChoseArticle);
            this.tabArticleManager.Controls.Add(this.lblOperation);
            this.tabArticleManager.Controls.Add(this.cmbArticleManager);
            this.tabArticleManager.Location = new System.Drawing.Point(4, 25);
            this.tabArticleManager.Name = "tabArticleManager";
            this.tabArticleManager.Padding = new System.Windows.Forms.Padding(3);
            this.tabArticleManager.Size = new System.Drawing.Size(790, 407);
            this.tabArticleManager.TabIndex = 0;
            this.tabArticleManager.Text = global::WFAplikacija.Lang.Dictionary.PFProductManager;
            this.tabArticleManager.UseVisualStyleBackColor = true;
            // 
            // listBoxArticleManagerArticles
            // 
            this.listBoxArticleManagerArticles.AllowDrop = true;
            this.listBoxArticleManagerArticles.FormattingEnabled = true;
            this.listBoxArticleManagerArticles.HorizontalScrollbar = true;
            this.listBoxArticleManagerArticles.ItemHeight = 16;
            this.listBoxArticleManagerArticles.Location = new System.Drawing.Point(398, 26);
            this.listBoxArticleManagerArticles.Name = "listBoxArticleManagerArticles";
            this.listBoxArticleManagerArticles.Size = new System.Drawing.Size(384, 308);
            this.listBoxArticleManagerArticles.TabIndex = 13;
            this.listBoxArticleManagerArticles.SelectedIndexChanged += new System.EventHandler(this.listBoxArticleManagerArticles_SelectedIndexChanged);
            // 
            // btnArticleManagerComplete
            // 
            this.btnArticleManagerComplete.Location = new System.Drawing.Point(684, 354);
            this.btnArticleManagerComplete.Name = "btnArticleManagerComplete";
            this.btnArticleManagerComplete.Size = new System.Drawing.Size(100, 50);
            this.btnArticleManagerComplete.TabIndex = 12;
            this.btnArticleManagerComplete.Text = global::WFAplikacija.Lang.Dictionary.PFComplete;
            this.btnArticleManagerComplete.UseVisualStyleBackColor = true;
            this.btnArticleManagerComplete.Click += new System.EventHandler(this.btnArticleManagerComplete_Click);
            // 
            // txtBoxArticleManagerPrice
            // 
            this.txtBoxArticleManagerPrice.Location = new System.Drawing.Point(9, 223);
            this.txtBoxArticleManagerPrice.Name = "txtBoxArticleManagerPrice";
            this.txtBoxArticleManagerPrice.Size = new System.Drawing.Size(344, 22);
            this.txtBoxArticleManagerPrice.TabIndex = 11;
            // 
            // txtBoxArticleManagerBtnName
            // 
            this.txtBoxArticleManagerBtnName.Location = new System.Drawing.Point(9, 178);
            this.txtBoxArticleManagerBtnName.Name = "txtBoxArticleManagerBtnName";
            this.txtBoxArticleManagerBtnName.Size = new System.Drawing.Size(344, 22);
            this.txtBoxArticleManagerBtnName.TabIndex = 9;
            // 
            // txtBoxArticleManagerName
            // 
            this.txtBoxArticleManagerName.Location = new System.Drawing.Point(9, 133);
            this.txtBoxArticleManagerName.Name = "txtBoxArticleManagerName";
            this.txtBoxArticleManagerName.Size = new System.Drawing.Size(344, 22);
            this.txtBoxArticleManagerName.TabIndex = 7;
            // 
            // txtBoxArticleManagerId
            // 
            this.txtBoxArticleManagerId.Enabled = false;
            this.txtBoxArticleManagerId.Location = new System.Drawing.Point(9, 88);
            this.txtBoxArticleManagerId.Name = "txtBoxArticleManagerId";
            this.txtBoxArticleManagerId.Size = new System.Drawing.Size(344, 22);
            this.txtBoxArticleManagerId.TabIndex = 5;
            // 
            // lblArticleManagerPrice
            // 
            this.lblArticleManagerPrice.AutoSize = true;
            this.lblArticleManagerPrice.Location = new System.Drawing.Point(9, 203);
            this.lblArticleManagerPrice.Name = "lblArticleManagerPrice";
            this.lblArticleManagerPrice.Size = new System.Drawing.Size(40, 17);
            this.lblArticleManagerPrice.TabIndex = 10;
            this.lblArticleManagerPrice.Text = "Price";
            // 
            // lblArticleManagerbtnName
            // 
            this.lblArticleManagerbtnName.AutoSize = true;
            this.lblArticleManagerbtnName.Location = new System.Drawing.Point(9, 158);
            this.lblArticleManagerbtnName.Name = "lblArticleManagerbtnName";
            this.lblArticleManagerbtnName.Size = new System.Drawing.Size(88, 17);
            this.lblArticleManagerbtnName.TabIndex = 8;
            this.lblArticleManagerbtnName.Text = "Button name";
            // 
            // lblArticleManagerName
            // 
            this.lblArticleManagerName.AutoSize = true;
            this.lblArticleManagerName.Location = new System.Drawing.Point(9, 113);
            this.lblArticleManagerName.Name = "lblArticleManagerName";
            this.lblArticleManagerName.Size = new System.Drawing.Size(45, 17);
            this.lblArticleManagerName.TabIndex = 6;
            this.lblArticleManagerName.Text = "Name";
            // 
            // lblArticleManagerID
            // 
            this.lblArticleManagerID.AutoSize = true;
            this.lblArticleManagerID.Location = new System.Drawing.Point(12, 68);
            this.lblArticleManagerID.Name = "lblArticleManagerID";
            this.lblArticleManagerID.Size = new System.Drawing.Size(21, 17);
            this.lblArticleManagerID.TabIndex = 4;
            this.lblArticleManagerID.Text = "ID";
            // 
            // lblChoseArticle
            // 
            this.lblChoseArticle.AutoSize = true;
            this.lblChoseArticle.Location = new System.Drawing.Point(395, 3);
            this.lblChoseArticle.Name = "lblChoseArticle";
            this.lblChoseArticle.Size = new System.Drawing.Size(108, 17);
            this.lblChoseArticle.TabIndex = 3;
            this.lblChoseArticle.Text = "Choose product";
            // 
            // lblOperation
            // 
            this.lblOperation.AutoSize = true;
            this.lblOperation.Location = new System.Drawing.Point(6, 3);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(47, 17);
            this.lblOperation.TabIndex = 1;
            this.lblOperation.Text = "Action";
            // 
            // cmbArticleManager
            // 
            this.cmbArticleManager.FormattingEnabled = true;
            this.cmbArticleManager.Items.AddRange(new object[] {
            global::WFAplikacija.Lang.Dictionary.PFActionInsert,
            global::WFAplikacija.Lang.Dictionary.PFActionDelete,
            global::WFAplikacija.Lang.Dictionary.PFActionEdit});
            this.cmbArticleManager.Location = new System.Drawing.Point(9, 23);
            this.cmbArticleManager.Name = "cmbArticleManager";
            this.cmbArticleManager.Size = new System.Drawing.Size(121, 24);
            this.cmbArticleManager.TabIndex = 0;
            this.cmbArticleManager.SelectedIndexChanged += new System.EventHandler(this.cmbArticleManager_SelectedIndexChanged);
            // 
            // tabControlProperties
            // 
            this.tabControlProperties.Controls.Add(this.tabArticleManager);
            this.tabControlProperties.Controls.Add(this.tabPageBillsCrypto);
            this.tabControlProperties.Location = new System.Drawing.Point(2, 2);
            this.tabControlProperties.Name = "tabControlProperties";
            this.tabControlProperties.SelectedIndex = 0;
            this.tabControlProperties.Size = new System.Drawing.Size(798, 436);
            this.tabControlProperties.TabIndex = 0;
            this.tabControlProperties.Click += new System.EventHandler(this.tabControlProperties_Click);
            // 
            // tabPageBillsCrypto
            // 
            this.tabPageBillsCrypto.Controls.Add(this.rtbCrypto);
            this.tabPageBillsCrypto.Controls.Add(this.btnCryptoShow);
            this.tabPageBillsCrypto.Controls.Add(this.txtBoxCrypto);
            this.tabPageBillsCrypto.Controls.Add(this.label2);
            this.tabPageBillsCrypto.Controls.Add(this.btnCryptoSet);
            this.tabPageBillsCrypto.Controls.Add(this.label1);
            this.tabPageBillsCrypto.Controls.Add(this.cmbCrypto);
            this.tabPageBillsCrypto.Location = new System.Drawing.Point(4, 25);
            this.tabPageBillsCrypto.Name = "tabPageBillsCrypto";
            this.tabPageBillsCrypto.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBillsCrypto.Size = new System.Drawing.Size(790, 407);
            this.tabPageBillsCrypto.TabIndex = 1;
            this.tabPageBillsCrypto.Text = "Bills cryptography";
            this.tabPageBillsCrypto.UseVisualStyleBackColor = true;
            // 
            // cmbCrypto
            // 
            this.cmbCrypto.FormattingEnabled = true;
            this.cmbCrypto.Items.AddRange(new object[] {
            "AES",
            "CES"});
            this.cmbCrypto.Location = new System.Drawing.Point(6, 34);
            this.cmbCrypto.Name = "cmbCrypto";
            this.cmbCrypto.Size = new System.Drawing.Size(121, 24);
            this.cmbCrypto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Crypto function";
            // 
            // btnCryptoSet
            // 
            this.btnCryptoSet.Location = new System.Drawing.Point(6, 64);
            this.btnCryptoSet.Name = "btnCryptoSet";
            this.btnCryptoSet.Size = new System.Drawing.Size(75, 23);
            this.btnCryptoSet.TabIndex = 3;
            this.btnCryptoSet.Text = "Set";
            this.btnCryptoSet.UseVisualStyleBackColor = true;
            this.btnCryptoSet.Click += new System.EventHandler(this.btnCryptoSet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bill ID:";
            // 
            // txtBoxCrypto
            // 
            this.txtBoxCrypto.Location = new System.Drawing.Point(488, 11);
            this.txtBoxCrypto.Name = "txtBoxCrypto";
            this.txtBoxCrypto.Size = new System.Drawing.Size(100, 22);
            this.txtBoxCrypto.TabIndex = 6;
            // 
            // btnCryptoShow
            // 
            this.btnCryptoShow.Location = new System.Drawing.Point(594, 11);
            this.btnCryptoShow.Name = "btnCryptoShow";
            this.btnCryptoShow.Size = new System.Drawing.Size(75, 23);
            this.btnCryptoShow.TabIndex = 7;
            this.btnCryptoShow.Text = "Show";
            this.btnCryptoShow.UseVisualStyleBackColor = true;
            this.btnCryptoShow.Click += new System.EventHandler(this.btnCryptoShow_Click);
            // 
            // rtbCrypto
            // 
            this.rtbCrypto.Location = new System.Drawing.Point(438, 49);
            this.rtbCrypto.Name = "rtbCrypto";
            this.rtbCrypto.Size = new System.Drawing.Size(310, 239);
            this.rtbCrypto.TabIndex = 9;
            this.rtbCrypto.Text = "";
            // 
            // PropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlProperties);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PropertiesForm";
            this.Text = "Cashapp Properties";
            this.tabArticleManager.ResumeLayout(false);
            this.tabArticleManager.PerformLayout();
            this.tabControlProperties.ResumeLayout(false);
            this.tabPageBillsCrypto.ResumeLayout(false);
            this.tabPageBillsCrypto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabArticleManager;
        private System.Windows.Forms.ListBox listBoxArticleManagerArticles;
        private System.Windows.Forms.Button btnArticleManagerComplete;
        private System.Windows.Forms.TextBox txtBoxArticleManagerPrice;
        private System.Windows.Forms.TextBox txtBoxArticleManagerBtnName;
        private System.Windows.Forms.TextBox txtBoxArticleManagerName;
        private System.Windows.Forms.TextBox txtBoxArticleManagerId;
        private System.Windows.Forms.Label lblArticleManagerPrice;
        private System.Windows.Forms.Label lblArticleManagerbtnName;
        private System.Windows.Forms.Label lblArticleManagerName;
        private System.Windows.Forms.Label lblArticleManagerID;
        private System.Windows.Forms.Label lblChoseArticle;
        private System.Windows.Forms.Label lblOperation;
        private System.Windows.Forms.ComboBox cmbArticleManager;
        private System.Windows.Forms.TabControl tabControlProperties;
        private System.Windows.Forms.TabPage tabPageBillsCrypto;
        private System.Windows.Forms.Button btnCryptoSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCrypto;
        private System.Windows.Forms.Button btnCryptoShow;
        private System.Windows.Forms.TextBox txtBoxCrypto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbCrypto;
    }
}