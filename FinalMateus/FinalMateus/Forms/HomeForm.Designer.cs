namespace FinalMateus.Forms
{
    partial class HomeForm
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
            this.pbxLog = new System.Windows.Forms.PictureBox();
            this.pbxUserProfile = new System.Windows.Forms.PictureBox();
            this.pbxUser = new System.Windows.Forms.PictureBox();
            this.pbxProduct = new System.Windows.Forms.PictureBox();
            this.pbxCategory = new System.Windows.Forms.PictureBox();
            this.pbxBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUserProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxLog
            // 
            this.pbxLog.BackgroundImage = global::FinalMateus.Properties.Resources.log;
            this.pbxLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxLog.Location = new System.Drawing.Point(253, 248);
            this.pbxLog.Name = "pbxLog";
            this.pbxLog.Size = new System.Drawing.Size(100, 72);
            this.pbxLog.TabIndex = 22;
            this.pbxLog.TabStop = false;
            this.pbxLog.Click += new System.EventHandler(this.pbxLog_Click);
            this.pbxLog.MouseEnter += new System.EventHandler(this.pbxLog_MouseEnter);
            this.pbxLog.MouseLeave += new System.EventHandler(this.pbxLog_MouseLeave);
            // 
            // pbxUserProfile
            // 
            this.pbxUserProfile.BackgroundImage = global::FinalMateus.Properties.Resources.User_profile;
            this.pbxUserProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxUserProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxUserProfile.Location = new System.Drawing.Point(40, 248);
            this.pbxUserProfile.Name = "pbxUserProfile";
            this.pbxUserProfile.Size = new System.Drawing.Size(100, 72);
            this.pbxUserProfile.TabIndex = 21;
            this.pbxUserProfile.TabStop = false;
            this.pbxUserProfile.Click += new System.EventHandler(this.pbxUserProfile_Click);
            this.pbxUserProfile.MouseEnter += new System.EventHandler(this.pbxUserProfile_MouseEnter);
            this.pbxUserProfile.MouseLeave += new System.EventHandler(this.pbxUserProfile_MouseLeave);
            // 
            // pbxUser
            // 
            this.pbxUser.BackgroundImage = global::FinalMateus.Properties.Resources.User;
            this.pbxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxUser.Location = new System.Drawing.Point(147, 149);
            this.pbxUser.Name = "pbxUser";
            this.pbxUser.Size = new System.Drawing.Size(107, 65);
            this.pbxUser.TabIndex = 20;
            this.pbxUser.TabStop = false;
            this.pbxUser.Click += new System.EventHandler(this.pbxUser_Click);
            this.pbxUser.MouseEnter += new System.EventHandler(this.pbxUser_MouseEnter);
            this.pbxUser.MouseLeave += new System.EventHandler(this.pbxUser_MouseLeave);
            // 
            // pbxProduct
            // 
            this.pbxProduct.BackgroundImage = global::FinalMateus.Properties.Resources.Product;
            this.pbxProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxProduct.Location = new System.Drawing.Point(253, 53);
            this.pbxProduct.Name = "pbxProduct";
            this.pbxProduct.Size = new System.Drawing.Size(100, 68);
            this.pbxProduct.TabIndex = 19;
            this.pbxProduct.TabStop = false;
            this.pbxProduct.Click += new System.EventHandler(this.pbxProduct_Click);
            this.pbxProduct.MouseEnter += new System.EventHandler(this.pbxProduct_MouseEnter);
            this.pbxProduct.MouseLeave += new System.EventHandler(this.pbxProduct_MouseLeave);
            // 
            // pbxCategory
            // 
            this.pbxCategory.BackgroundImage = global::FinalMateus.Properties.Resources.Category;
            this.pbxCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxCategory.Location = new System.Drawing.Point(40, 53);
            this.pbxCategory.Name = "pbxCategory";
            this.pbxCategory.Size = new System.Drawing.Size(100, 68);
            this.pbxCategory.TabIndex = 18;
            this.pbxCategory.TabStop = false;
            this.pbxCategory.Click += new System.EventHandler(this.pbxCategory_Click);
            this.pbxCategory.MouseEnter += new System.EventHandler(this.pbxCategory_MouseEnter);
            this.pbxCategory.MouseLeave += new System.EventHandler(this.pbxCategory_MouseLeave);
            // 
            // pbxBack
            // 
            this.pbxBack.BackgroundImage = global::FinalMateus.Properties.Resources.Back;
            this.pbxBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxBack.Location = new System.Drawing.Point(26, 391);
            this.pbxBack.Name = "pbxBack";
            this.pbxBack.Size = new System.Drawing.Size(100, 50);
            this.pbxBack.TabIndex = 17;
            this.pbxBack.TabStop = false;
            this.pbxBack.Click += new System.EventHandler(this.pbxBack_Click);
            this.pbxBack.MouseEnter += new System.EventHandler(this.pbxBack_MouseEnter);
            this.pbxBack.MouseLeave += new System.EventHandler(this.pbxBack_MouseLeave);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(399, 462);
            this.Controls.Add(this.pbxLog);
            this.Controls.Add(this.pbxUserProfile);
            this.Controls.Add(this.pbxUser);
            this.Controls.Add(this.pbxProduct);
            this.Controls.Add(this.pbxCategory);
            this.Controls.Add(this.pbxBack);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbxLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUserProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxBack;
        private System.Windows.Forms.PictureBox pbxCategory;
        private System.Windows.Forms.PictureBox pbxProduct;
        private System.Windows.Forms.PictureBox pbxUser;
        private System.Windows.Forms.PictureBox pbxUserProfile;
        private System.Windows.Forms.PictureBox pbxLog;
    }
}