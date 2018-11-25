namespace FinalMateus.Forms
{
    partial class ProductDetailsForm
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
            this.tbxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.pbxSave = new System.Windows.Forms.PictureBox();
            this.pbxBack = new System.Windows.Forms.PictureBox();
            this.pbxDelete = new System.Windows.Forms.PictureBox();
            this.cbxActive = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxName
            // 
            this.tbxName.BackColor = System.Drawing.Color.White;
            this.tbxName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxName.Location = new System.Drawing.Point(17, 59);
            this.tbxName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(375, 31);
            this.tbxName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblCategory.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblCategory.Location = new System.Drawing.Point(13, 203);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(91, 23);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Categoria:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblPrice.Location = new System.Drawing.Point(13, 120);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(60, 23);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Preço:";
            // 
            // tbxPrice
            // 
            this.tbxPrice.BackColor = System.Drawing.Color.White;
            this.tbxPrice.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPrice.Location = new System.Drawing.Point(17, 147);
            this.tbxPrice.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(375, 31);
            this.tbxPrice.TabIndex = 6;
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(17, 241);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(375, 31);
            this.cmbCategory.TabIndex = 10;
            // 
            // pbxSave
            // 
            this.pbxSave.BackColor = System.Drawing.Color.Transparent;
            this.pbxSave.BackgroundImage = global::FinalMateus.Properties.Resources.Save;
            this.pbxSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxSave.Location = new System.Drawing.Point(195, 372);
            this.pbxSave.Margin = new System.Windows.Forms.Padding(4);
            this.pbxSave.Name = "pbxSave";
            this.pbxSave.Size = new System.Drawing.Size(84, 57);
            this.pbxSave.TabIndex = 18;
            this.pbxSave.TabStop = false;
            this.pbxSave.Click += new System.EventHandler(this.pbxSave_Click);
            this.pbxSave.MouseEnter += new System.EventHandler(this.pbxSave_MouseEnter);
            this.pbxSave.MouseLeave += new System.EventHandler(this.pbxSave_MouseLeave);
            // 
            // pbxBack
            // 
            this.pbxBack.BackColor = System.Drawing.Color.Transparent;
            this.pbxBack.BackgroundImage = global::FinalMateus.Properties.Resources.Back;
            this.pbxBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxBack.Location = new System.Drawing.Point(17, 372);
            this.pbxBack.Name = "pbxBack";
            this.pbxBack.Size = new System.Drawing.Size(87, 57);
            this.pbxBack.TabIndex = 17;
            this.pbxBack.TabStop = false;
            this.pbxBack.Click += new System.EventHandler(this.pbxBack_Click);
            this.pbxBack.MouseEnter += new System.EventHandler(this.pbxBack_MouseEnter);
            this.pbxBack.MouseLeave += new System.EventHandler(this.pbxBack_MouseLeave);
            // 
            // pbxDelete
            // 
            this.pbxDelete.BackColor = System.Drawing.Color.Transparent;
            this.pbxDelete.BackgroundImage = global::FinalMateus.Properties.Resources.Delete_Close;
            this.pbxDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxDelete.Location = new System.Drawing.Point(287, 372);
            this.pbxDelete.Margin = new System.Windows.Forms.Padding(4);
            this.pbxDelete.Name = "pbxDelete";
            this.pbxDelete.Size = new System.Drawing.Size(90, 57);
            this.pbxDelete.TabIndex = 19;
            this.pbxDelete.TabStop = false;
            this.pbxDelete.Click += new System.EventHandler(this.pbxDelete_Click);
            this.pbxDelete.MouseEnter += new System.EventHandler(this.pbxDelete_MouseEnter);
            this.pbxDelete.MouseLeave += new System.EventHandler(this.pbxDelete_MouseLeave);
            // 
            // cbxActive
            // 
            this.cbxActive.AutoSize = true;
            this.cbxActive.BackColor = System.Drawing.Color.Transparent;
            this.cbxActive.Location = new System.Drawing.Point(74, 309);
            this.cbxActive.Margin = new System.Windows.Forms.Padding(4);
            this.cbxActive.Name = "cbxActive";
            this.cbxActive.Size = new System.Drawing.Size(15, 14);
            this.cbxActive.TabIndex = 21;
            this.cbxActive.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label7.Location = new System.Drawing.Point(20, 303);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 23);
            this.label7.TabIndex = 20;
            this.label7.Text = "Ativo:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 22;
            this.lblId.Visible = false;
            // 
            // ProductDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(399, 462);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.cbxActive);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pbxDelete);
            this.Controls.Add(this.pbxSave);
            this.Controls.Add(this.pbxBack);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.tbxPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.label1);
            this.Name = "ProductDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductDetailsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbxSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.PictureBox pbxBack;
        private System.Windows.Forms.PictureBox pbxSave;
        private System.Windows.Forms.PictureBox pbxDelete;
        private System.Windows.Forms.CheckBox cbxActive;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblId;
    }
}