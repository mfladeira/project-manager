namespace FinalMateus.Forms
{
    partial class CategoryDetailsForm
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
            this.pbxDelete = new System.Windows.Forms.PictureBox();
            this.pbxSave = new System.Windows.Forms.PictureBox();
            this.pbxBack = new System.Windows.Forms.PictureBox();
            this.cbxActive = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxName
            // 
            this.tbxName.BackColor = System.Drawing.Color.White;
            this.tbxName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxName.Location = new System.Drawing.Point(17, 69);
            this.tbxName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(375, 27);
            this.tbxName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            // 
            // pbxDelete
            // 
            this.pbxDelete.BackColor = System.Drawing.Color.Transparent;
            this.pbxDelete.BackgroundImage = global::FinalMateus.Properties.Resources.Delete_Close;
            this.pbxDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxDelete.Location = new System.Drawing.Point(302, 355);
            this.pbxDelete.Margin = new System.Windows.Forms.Padding(4);
            this.pbxDelete.Name = "pbxDelete";
            this.pbxDelete.Size = new System.Drawing.Size(90, 57);
            this.pbxDelete.TabIndex = 24;
            this.pbxDelete.TabStop = false;
            this.pbxDelete.Click += new System.EventHandler(this.pbxDelete_Click);
            this.pbxDelete.MouseEnter += new System.EventHandler(this.pbxDelete_MouseEnter);
            this.pbxDelete.MouseLeave += new System.EventHandler(this.pbxDelete_MouseLeave);
            // 
            // pbxSave
            // 
            this.pbxSave.BackColor = System.Drawing.Color.Transparent;
            this.pbxSave.BackgroundImage = global::FinalMateus.Properties.Resources.Save;
            this.pbxSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxSave.Location = new System.Drawing.Point(210, 355);
            this.pbxSave.Margin = new System.Windows.Forms.Padding(4);
            this.pbxSave.Name = "pbxSave";
            this.pbxSave.Size = new System.Drawing.Size(84, 57);
            this.pbxSave.TabIndex = 23;
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
            this.pbxBack.Location = new System.Drawing.Point(21, 362);
            this.pbxBack.Name = "pbxBack";
            this.pbxBack.Size = new System.Drawing.Size(100, 50);
            this.pbxBack.TabIndex = 22;
            this.pbxBack.TabStop = false;
            this.pbxBack.Click += new System.EventHandler(this.pbxBack_Click);
            this.pbxBack.MouseEnter += new System.EventHandler(this.pbxBack_MouseEnter);
            this.pbxBack.MouseLeave += new System.EventHandler(this.pbxBack_MouseLeave);
            // 
            // cbxActive
            // 
            this.cbxActive.AutoSize = true;
            this.cbxActive.BackColor = System.Drawing.Color.Transparent;
            this.cbxActive.Location = new System.Drawing.Point(72, 135);
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
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label7.Location = new System.Drawing.Point(18, 129);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "Ativo:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 25;
            this.lblId.Visible = false;
            // 
            // CategoryDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(399, 462);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.pbxDelete);
            this.Controls.Add(this.pbxSave);
            this.Controls.Add(this.pbxBack);
            this.Controls.Add(this.cbxActive);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.label1);
            this.Name = "CategoryDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryDetailsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbxDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxDelete;
        private System.Windows.Forms.PictureBox pbxSave;
        private System.Windows.Forms.PictureBox pbxBack;
        private System.Windows.Forms.CheckBox cbxActive;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblId;
    }
}