namespace project_Muller_Salopek
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
            this.tabControlArticles = new System.Windows.Forms.TabControl();
            this.tabArctile1 = new System.Windows.Forms.TabPage();
            this.btnArticle2 = new System.Windows.Forms.Button();
            this.btnArticle1 = new System.Windows.Forms.Button();
            this.tabArticle2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewArticles = new System.Windows.Forms.ListView();
            this.tabProperties = new System.Windows.Forms.TabPage();
            this.tabMainControl.SuspendLayout();
            this.tabSale.SuspendLayout();
            this.tabControlArticles.SuspendLayout();
            this.tabArctile1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMainControl
            // 
            this.tabMainControl.Controls.Add(this.tabSale);
            this.tabMainControl.Controls.Add(this.tabProperties);
            this.tabMainControl.Location = new System.Drawing.Point(2, 2);
            this.tabMainControl.Name = "tabMainControl";
            this.tabMainControl.SelectedIndex = 0;
            this.tabMainControl.Size = new System.Drawing.Size(800, 448);
            this.tabMainControl.TabIndex = 0;
            // 
            // tabSale
            // 
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
            this.tabSale.Click += new System.EventHandler(this.tabSale_Click);
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
            this.btnArticle2.Text = "Article2";
            this.btnArticle2.UseVisualStyleBackColor = true;
            this.btnArticle2.Click += new System.EventHandler(this.ArticleButtonClicked);
            // 
            // btnArticle1
            // 
            this.btnArticle1.Location = new System.Drawing.Point(6, 6);
            this.btnArticle1.Name = "btnArticle1";
            this.btnArticle1.Size = new System.Drawing.Size(75, 75);
            this.btnArticle1.TabIndex = 0;
            this.btnArticle1.Text = "Article1";
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
            this.listViewArticles.Size = new System.Drawing.Size(246, 262);
            this.listViewArticles.TabIndex = 0;
            this.listViewArticles.UseCompatibleStateImageBehavior = false;
            // 
            // tabProperties
            // 
            this.tabProperties.Location = new System.Drawing.Point(4, 25);
            this.tabProperties.Name = "tabProperties";
            this.tabProperties.Padding = new System.Windows.Forms.Padding(3);
            this.tabProperties.Size = new System.Drawing.Size(792, 419);
            this.tabProperties.TabIndex = 1;
            this.tabProperties.Text = "Properties";
            this.tabProperties.UseVisualStyleBackColor = true;
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
    }
}

