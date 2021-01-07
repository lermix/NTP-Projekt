﻿namespace WFAplikacija
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
            this.tabControlProperties = new System.Windows.Forms.TabControl();
            this.tabArticleManager = new System.Windows.Forms.TabPage();
            this.listBoxArticleManagerArticles = new System.Windows.Forms.ListBox();
            this.btnArticleManagerComplete = new System.Windows.Forms.Button();
            this.txtBoxArticleManagerPrice = new System.Windows.Forms.TextBox();
            this.lblArticleManagerPrice = new System.Windows.Forms.Label();
            this.txtBoxArticleManagerBtnName = new System.Windows.Forms.TextBox();
            this.lblArticleManagerbtnName = new System.Windows.Forms.Label();
            this.txtBoxArticleManagerName = new System.Windows.Forms.TextBox();
            this.lblArticleManagerName = new System.Windows.Forms.Label();
            this.txtBoxArticleManagerId = new System.Windows.Forms.TextBox();
            this.lblArticleManagerID = new System.Windows.Forms.Label();
            this.lblChoseArticle = new System.Windows.Forms.Label();
            this.lblOperation = new System.Windows.Forms.Label();
            this.cmbArticleManager = new System.Windows.Forms.ComboBox();
            this.tabproductToSale = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAddToSale = new System.Windows.Forms.ComboBox();
            this.btnAddToSale = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.listBoxAddToSale = new System.Windows.Forms.ListBox();
            this.tabControlProperties.SuspendLayout();
            this.tabArticleManager.SuspendLayout();
            this.tabproductToSale.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlProperties
            // 
            this.tabControlProperties.Controls.Add(this.tabArticleManager);
            this.tabControlProperties.Controls.Add(this.tabproductToSale);
            this.tabControlProperties.Location = new System.Drawing.Point(2, 2);
            this.tabControlProperties.Name = "tabControlProperties";
            this.tabControlProperties.SelectedIndex = 0;
            this.tabControlProperties.Size = new System.Drawing.Size(798, 436);
            this.tabControlProperties.TabIndex = 0;
            this.tabControlProperties.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tabArticleManager
            // 
            this.tabArticleManager.Controls.Add(this.listBoxArticleManagerArticles);
            this.tabArticleManager.Controls.Add(this.btnArticleManagerComplete);
            this.tabArticleManager.Controls.Add(this.txtBoxArticleManagerPrice);
            this.tabArticleManager.Controls.Add(this.lblArticleManagerPrice);
            this.tabArticleManager.Controls.Add(this.txtBoxArticleManagerBtnName);
            this.tabArticleManager.Controls.Add(this.lblArticleManagerbtnName);
            this.tabArticleManager.Controls.Add(this.txtBoxArticleManagerName);
            this.tabArticleManager.Controls.Add(this.lblArticleManagerName);
            this.tabArticleManager.Controls.Add(this.txtBoxArticleManagerId);
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
            // lblArticleManagerPrice
            // 
            this.lblArticleManagerPrice.AutoSize = true;
            this.lblArticleManagerPrice.Location = new System.Drawing.Point(9, 203);
            this.lblArticleManagerPrice.Name = "lblArticleManagerPrice";
            this.lblArticleManagerPrice.Size = new System.Drawing.Size(40, 17);
            this.lblArticleManagerPrice.TabIndex = 10;
            this.lblArticleManagerPrice.Text = "Price";
            // 
            // txtBoxArticleManagerBtnName
            // 
            this.txtBoxArticleManagerBtnName.Location = new System.Drawing.Point(9, 178);
            this.txtBoxArticleManagerBtnName.Name = "txtBoxArticleManagerBtnName";
            this.txtBoxArticleManagerBtnName.Size = new System.Drawing.Size(344, 22);
            this.txtBoxArticleManagerBtnName.TabIndex = 9;
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
            // txtBoxArticleManagerName
            // 
            this.txtBoxArticleManagerName.Location = new System.Drawing.Point(9, 133);
            this.txtBoxArticleManagerName.Name = "txtBoxArticleManagerName";
            this.txtBoxArticleManagerName.Size = new System.Drawing.Size(344, 22);
            this.txtBoxArticleManagerName.TabIndex = 7;
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
            // txtBoxArticleManagerId
            // 
            this.txtBoxArticleManagerId.Enabled = false;
            this.txtBoxArticleManagerId.Location = new System.Drawing.Point(9, 88);
            this.txtBoxArticleManagerId.Name = "txtBoxArticleManagerId";
            this.txtBoxArticleManagerId.Size = new System.Drawing.Size(344, 22);
            this.txtBoxArticleManagerId.TabIndex = 5;
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
            // tabproductToSale
            // 
            this.tabproductToSale.Controls.Add(this.label1);
            this.tabproductToSale.Controls.Add(this.cmbAddToSale);
            this.tabproductToSale.Controls.Add(this.btnAddToSale);
            this.tabproductToSale.Controls.Add(this.btnRefresh);
            this.tabproductToSale.Controls.Add(this.listBoxAddToSale);
            this.tabproductToSale.Location = new System.Drawing.Point(4, 25);
            this.tabproductToSale.Name = "tabproductToSale";
            this.tabproductToSale.Padding = new System.Windows.Forms.Padding(3);
            this.tabproductToSale.Size = new System.Drawing.Size(790, 407);
            this.tabproductToSale.TabIndex = 1;
            this.tabproductToSale.Text = "Add product to sale";
            this.tabproductToSale.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Button number";
            // 
            // cmbAddToSale
            // 
            this.cmbAddToSale.FormattingEnabled = true;
            this.cmbAddToSale.Items.AddRange(new object[] {
            "btnArticle1",
            "btnArticle2",
            "btnArticle3",
            "btnArticle4",
            "btnArticle5",
            "btnArticle6",
            "btnArticle7",
            "btnArticle8",
            "btnArticle9",
            "btnArticle10"});
            this.cmbAddToSale.Location = new System.Drawing.Point(6, 141);
            this.cmbAddToSale.Name = "cmbAddToSale";
            this.cmbAddToSale.Size = new System.Drawing.Size(121, 24);
            this.cmbAddToSale.TabIndex = 3;
            // 
            // btnAddToSale
            // 
            this.btnAddToSale.Location = new System.Drawing.Point(6, 171);
            this.btnAddToSale.Name = "btnAddToSale";
            this.btnAddToSale.Size = new System.Drawing.Size(105, 37);
            this.btnAddToSale.TabIndex = 2;
            this.btnAddToSale.Text = "Add ";
            this.btnAddToSale.UseVisualStyleBackColor = true;
            this.btnAddToSale.Click += new System.EventHandler(this.btnAddToSale_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(6, 6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(105, 36);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // listBoxAddToSale
            // 
            this.listBoxAddToSale.FormattingEnabled = true;
            this.listBoxAddToSale.ItemHeight = 16;
            this.listBoxAddToSale.Location = new System.Drawing.Point(436, 6);
            this.listBoxAddToSale.Name = "listBoxAddToSale";
            this.listBoxAddToSale.Size = new System.Drawing.Size(346, 388);
            this.listBoxAddToSale.TabIndex = 0;
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
            this.tabControlProperties.ResumeLayout(false);
            this.tabArticleManager.ResumeLayout(false);
            this.tabArticleManager.PerformLayout();
            this.tabproductToSale.ResumeLayout(false);
            this.tabproductToSale.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlProperties;
        private System.Windows.Forms.TabPage tabArticleManager;
        private System.Windows.Forms.TabPage tabproductToSale;
        private System.Windows.Forms.Label lblChoseArticle;
        private System.Windows.Forms.Label lblOperation;
        private System.Windows.Forms.ComboBox cmbArticleManager;
        private System.Windows.Forms.TextBox txtBoxArticleManagerBtnName;
        private System.Windows.Forms.Label lblArticleManagerbtnName;
        private System.Windows.Forms.TextBox txtBoxArticleManagerName;
        private System.Windows.Forms.Label lblArticleManagerName;
        private System.Windows.Forms.TextBox txtBoxArticleManagerId;
        private System.Windows.Forms.Label lblArticleManagerID;
        private System.Windows.Forms.TextBox txtBoxArticleManagerPrice;
        private System.Windows.Forms.Label lblArticleManagerPrice;
        private System.Windows.Forms.Button btnArticleManagerComplete;
        private System.Windows.Forms.ListBox listBoxArticleManagerArticles;
        private System.Windows.Forms.ListBox listBoxAddToSale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAddToSale;
        private System.Windows.Forms.Button btnAddToSale;
        private System.Windows.Forms.Button btnRefresh;
    }
}