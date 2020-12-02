namespace project_Muller_Salopek
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
            this.tabControlProperties = new System.Windows.Forms.TabControl();
            this.tabArticleManager = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblOperation = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblChoseArticle = new System.Windows.Forms.Label();
            this.tabControlProperties.SuspendLayout();
            this.tabArticleManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlProperties
            // 
            this.tabControlProperties.Controls.Add(this.tabArticleManager);
            this.tabControlProperties.Controls.Add(this.tabPage2);
            this.tabControlProperties.Location = new System.Drawing.Point(2, 2);
            this.tabControlProperties.Name = "tabControlProperties";
            this.tabControlProperties.SelectedIndex = 0;
            this.tabControlProperties.Size = new System.Drawing.Size(776, 436);
            this.tabControlProperties.TabIndex = 0;
            // 
            // tabArticleManager
            // 
            this.tabArticleManager.Controls.Add(this.lblChoseArticle);
            this.tabArticleManager.Controls.Add(this.comboBox2);
            this.tabArticleManager.Controls.Add(this.lblOperation);
            this.tabArticleManager.Controls.Add(this.comboBox1);
            this.tabArticleManager.Location = new System.Drawing.Point(4, 25);
            this.tabArticleManager.Name = "tabArticleManager";
            this.tabArticleManager.Padding = new System.Windows.Forms.Padding(3);
            this.tabArticleManager.Size = new System.Drawing.Size(768, 407);
            this.tabArticleManager.TabIndex = 0;
            this.tabArticleManager.Text = "Article Manager";
            this.tabArticleManager.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 407);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Insert article",
            "Delete article",
            "Edit article"});
            this.comboBox1.Location = new System.Drawing.Point(9, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // lblOperation
            // 
            this.lblOperation.AutoSize = true;
            this.lblOperation.Location = new System.Drawing.Point(6, 3);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(71, 17);
            this.lblOperation.TabIndex = 1;
            this.lblOperation.Text = "Operation";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(9, 74);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 2;
            // 
            // lblChoseArticle
            // 
            this.lblChoseArticle.AutoSize = true;
            this.lblChoseArticle.Location = new System.Drawing.Point(9, 54);
            this.lblChoseArticle.Name = "lblChoseArticle";
            this.lblChoseArticle.Size = new System.Drawing.Size(90, 17);
            this.lblChoseArticle.TabIndex = 3;
            this.lblChoseArticle.Text = "Chose article";
            // 
            // PropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlProperties);
            this.Name = "PropertiesForm";
            this.Text = "Properties";
            this.tabControlProperties.ResumeLayout(false);
            this.tabArticleManager.ResumeLayout(false);
            this.tabArticleManager.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlProperties;
        private System.Windows.Forms.TabPage tabArticleManager;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblChoseArticle;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblOperation;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}