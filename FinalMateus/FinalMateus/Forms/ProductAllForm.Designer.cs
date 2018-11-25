namespace FinalMateus.Forms
{
    partial class ProductAllForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductAllForm));
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxAdd = new System.Windows.Forms.PictureBox();
            this.pbxEdit = new System.Windows.Forms.PictureBox();
            this.pbxDelete = new System.Windows.Forms.PictureBox();
            this.pbxBack = new System.Windows.Forms.PictureBox();
            this.pbxClean = new System.Windows.Forms.PictureBox();
            this.pbxSearch = new System.Windows.Forms.PictureBox();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.pbxClean1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClean1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxSearch
            // 
            this.tbxSearch.BackColor = System.Drawing.Color.White;
            this.tbxSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearch.Location = new System.Drawing.Point(105, 23);
            this.tbxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(375, 27);
            this.tbxSearch.TabIndex = 42;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 41;
            this.label1.Text = "Pesquisar:";
            // 
            // pbxAdd
            // 
            this.pbxAdd.BackgroundImage = global::FinalMateus.Properties.Resources.Add;
            this.pbxAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxAdd.Location = new System.Drawing.Point(341, 459);
            this.pbxAdd.Name = "pbxAdd";
            this.pbxAdd.Size = new System.Drawing.Size(92, 51);
            this.pbxAdd.TabIndex = 48;
            this.pbxAdd.TabStop = false;
            this.pbxAdd.Click += new System.EventHandler(this.pbxAdd_Click);
            this.pbxAdd.MouseEnter += new System.EventHandler(this.pbxAdd_MouseEnter);
            this.pbxAdd.MouseLeave += new System.EventHandler(this.pbxAdd_MouseLeave);
            // 
            // pbxEdit
            // 
            this.pbxEdit.BackgroundImage = global::FinalMateus.Properties.Resources.Edit;
            this.pbxEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxEdit.Location = new System.Drawing.Point(439, 459);
            this.pbxEdit.Name = "pbxEdit";
            this.pbxEdit.Size = new System.Drawing.Size(92, 51);
            this.pbxEdit.TabIndex = 47;
            this.pbxEdit.TabStop = false;
            this.pbxEdit.Click += new System.EventHandler(this.pbxEdit_Click);
            this.pbxEdit.MouseEnter += new System.EventHandler(this.pbxEdit_MouseEnter);
            this.pbxEdit.MouseLeave += new System.EventHandler(this.pbxEdit_MouseLeave);
            // 
            // pbxDelete
            // 
            this.pbxDelete.BackColor = System.Drawing.Color.Transparent;
            this.pbxDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxDelete.BackgroundImage")));
            this.pbxDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxDelete.Location = new System.Drawing.Point(538, 460);
            this.pbxDelete.Margin = new System.Windows.Forms.Padding(4);
            this.pbxDelete.Name = "pbxDelete";
            this.pbxDelete.Size = new System.Drawing.Size(90, 50);
            this.pbxDelete.TabIndex = 46;
            this.pbxDelete.TabStop = false;
            this.pbxDelete.Click += new System.EventHandler(this.pbxDelete_Click);
            this.pbxDelete.MouseEnter += new System.EventHandler(this.pbxDelete_MouseEnter);
            this.pbxDelete.MouseLeave += new System.EventHandler(this.pbxDelete_MouseLeave);
            // 
            // pbxBack
            // 
            this.pbxBack.BackgroundImage = global::FinalMateus.Properties.Resources.Back;
            this.pbxBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxBack.Location = new System.Drawing.Point(23, 459);
            this.pbxBack.Name = "pbxBack";
            this.pbxBack.Size = new System.Drawing.Size(92, 51);
            this.pbxBack.TabIndex = 45;
            this.pbxBack.TabStop = false;
            this.pbxBack.Click += new System.EventHandler(this.pbxBack_Click);
            this.pbxBack.MouseEnter += new System.EventHandler(this.pbxBack_MouseEnter);
            this.pbxBack.MouseLeave += new System.EventHandler(this.pbxBack_MouseLeave);
            // 
            // pbxClean
            // 
            this.pbxClean.BackgroundImage = global::FinalMateus.Properties.Resources.Clean;
            this.pbxClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxClean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxClean.Location = new System.Drawing.Point(644, -22);
            this.pbxClean.Name = "pbxClean";
            this.pbxClean.Size = new System.Drawing.Size(64, 43);
            this.pbxClean.TabIndex = 44;
            this.pbxClean.TabStop = false;
            // 
            // pbxSearch
            // 
            this.pbxSearch.BackgroundImage = global::FinalMateus.Properties.Resources.Search;
            this.pbxSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxSearch.Location = new System.Drawing.Point(501, 15);
            this.pbxSearch.Name = "pbxSearch";
            this.pbxSearch.Size = new System.Drawing.Size(64, 43);
            this.pbxSearch.TabIndex = 43;
            this.pbxSearch.TabStop = false;
            this.pbxSearch.Click += new System.EventHandler(this.pbxSearch_Click);
            this.pbxSearch.MouseEnter += new System.EventHandler(this.pbxSearch_MouseEnter);
            this.pbxSearch.MouseLeave += new System.EventHandler(this.pbxSearch_MouseLeave);
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.AllowUserToResizeColumns = false;
            this.dgvProduct.AllowUserToResizeRows = false;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProduct.Location = new System.Drawing.Point(23, 86);
            this.dgvProduct.MultiSelect = false;
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(595, 335);
            this.dgvProduct.TabIndex = 50;
            // 
            // pbxClean1
            // 
            this.pbxClean1.BackgroundImage = global::FinalMateus.Properties.Resources.Clean;
            this.pbxClean1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxClean1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxClean1.Location = new System.Drawing.Point(571, 15);
            this.pbxClean1.Name = "pbxClean1";
            this.pbxClean1.Size = new System.Drawing.Size(64, 43);
            this.pbxClean1.TabIndex = 51;
            this.pbxClean1.TabStop = false;
            this.pbxClean1.Click += new System.EventHandler(this.pbxClean1_Click);
            this.pbxClean1.MouseEnter += new System.EventHandler(this.pbxClean1_MouseEnter);
            this.pbxClean1.MouseLeave += new System.EventHandler(this.pbxClean1_MouseLeave);
            // 
            // ProductAllForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(641, 520);
            this.Controls.Add(this.pbxClean1);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.pbxAdd);
            this.Controls.Add(this.pbxEdit);
            this.Controls.Add(this.pbxDelete);
            this.Controls.Add(this.pbxBack);
            this.Controls.Add(this.pbxClean);
            this.Controls.Add(this.pbxSearch);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.label1);
            this.Name = "ProductAllForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductAllForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClean1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxAdd;
        private System.Windows.Forms.PictureBox pbxEdit;
        private System.Windows.Forms.PictureBox pbxDelete;
        private System.Windows.Forms.PictureBox pbxBack;
        private System.Windows.Forms.PictureBox pbxClean;
        private System.Windows.Forms.PictureBox pbxSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.PictureBox pbxClean1;
    }
}