namespace Project214.Forms
{
    partial class ManageShop
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tbx_shopName = new System.Windows.Forms.TextBox();
            this.btn_addElement = new System.Windows.Forms.Button();
            this.dgv_shopItem = new System.Windows.Forms.DataGridView();
            this.btn_rename = new System.Windows.Forms.Button();
            this.btn_selectImage = new System.Windows.Forms.Button();
            this.pbx_ShopIcon = new Project214.Forms.Custom_Components.ExpandedPictureBox();
            this.btn_saveChanges = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_shopItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_ShopIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_saveChanges);
            this.splitContainer1.Panel1.Controls.Add(this.btn_selectImage);
            this.splitContainer1.Panel1.Controls.Add(this.btn_rename);
            this.splitContainer1.Panel1.Controls.Add(this.btn_addElement);
            this.splitContainer1.Panel1.Controls.Add(this.tbx_shopName);
            this.splitContainer1.Panel1.Controls.Add(this.pbx_ShopIcon);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgv_shopItem);
            this.splitContainer1.Size = new System.Drawing.Size(748, 469);
            this.splitContainer1.SplitterDistance = 112;
            this.splitContainer1.TabIndex = 0;
            // 
            // tbx_shopName
            // 
            this.tbx_shopName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.tbx_shopName.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_shopName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.tbx_shopName.Location = new System.Drawing.Point(116, 22);
            this.tbx_shopName.Name = "tbx_shopName";
            this.tbx_shopName.Size = new System.Drawing.Size(252, 32);
            this.tbx_shopName.TabIndex = 1;
            // 
            // btn_addElement
            // 
            this.btn_addElement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addElement.Font = new System.Drawing.Font("Ubuntu", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addElement.Location = new System.Drawing.Point(614, 77);
            this.btn_addElement.Name = "btn_addElement";
            this.btn_addElement.Size = new System.Drawing.Size(131, 32);
            this.btn_addElement.TabIndex = 2;
            this.btn_addElement.Text = "Add Item";
            this.btn_addElement.UseVisualStyleBackColor = true;
            this.btn_addElement.Click += new System.EventHandler(this.btn_addElement_Click);
            // 
            // dgv_shopItem
            // 
            this.dgv_shopItem.AllowUserToAddRows = false;
            this.dgv_shopItem.AllowUserToDeleteRows = false;
            this.dgv_shopItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_shopItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(143)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_shopItem.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_shopItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_shopItem.Location = new System.Drawing.Point(0, 0);
            this.dgv_shopItem.Name = "dgv_shopItem";
            this.dgv_shopItem.Size = new System.Drawing.Size(748, 353);
            this.dgv_shopItem.TabIndex = 16;
            // 
            // btn_rename
            // 
            this.btn_rename.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rename.Font = new System.Drawing.Font("Ubuntu", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rename.Location = new System.Drawing.Point(374, 22);
            this.btn_rename.Name = "btn_rename";
            this.btn_rename.Size = new System.Drawing.Size(99, 32);
            this.btn_rename.TabIndex = 3;
            this.btn_rename.Text = "Rename";
            this.btn_rename.UseVisualStyleBackColor = true;
            this.btn_rename.Click += new System.EventHandler(this.btn_rename_Click);
            // 
            // btn_selectImage
            // 
            this.btn_selectImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_selectImage.Font = new System.Drawing.Font("Ubuntu", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_selectImage.Location = new System.Drawing.Point(463, 77);
            this.btn_selectImage.Name = "btn_selectImage";
            this.btn_selectImage.Size = new System.Drawing.Size(145, 32);
            this.btn_selectImage.TabIndex = 4;
            this.btn_selectImage.Text = "Select Image";
            this.btn_selectImage.UseVisualStyleBackColor = true;
            this.btn_selectImage.Click += new System.EventHandler(this.btn_selectImage_Click);
            // 
            // pbx_ShopIcon
            // 
            this.pbx_ShopIcon.Location = new System.Drawing.Point(2, 2);
            this.pbx_ShopIcon.Name = "pbx_ShopIcon";
            this.pbx_ShopIcon.Size = new System.Drawing.Size(108, 108);
            this.pbx_ShopIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_ShopIcon.TabIndex = 0;
            this.pbx_ShopIcon.TabStop = false;
            // 
            // btn_saveChanges
            // 
            this.btn_saveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saveChanges.Font = new System.Drawing.Font("Ubuntu", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveChanges.Location = new System.Drawing.Point(647, 3);
            this.btn_saveChanges.Name = "btn_saveChanges";
            this.btn_saveChanges.Size = new System.Drawing.Size(98, 32);
            this.btn_saveChanges.TabIndex = 5;
            this.btn_saveChanges.Text = "Save";
            this.btn_saveChanges.UseVisualStyleBackColor = true;
            this.btn_saveChanges.Click += new System.EventHandler(this.btn_saveChanges_Click);
            // 
            // ManageShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(748, 469);
            this.Controls.Add(this.splitContainer1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageShop";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Manage Shop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageShop_FormClosing);
            this.Load += new System.EventHandler(this.ManageShop_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_shopItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_ShopIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Custom_Components.ExpandedPictureBox pbx_ShopIcon;
        private System.Windows.Forms.TextBox tbx_shopName;
        private System.Windows.Forms.Button btn_addElement;
        private System.Windows.Forms.DataGridView dgv_shopItem;
        private System.Windows.Forms.Button btn_rename;
        private System.Windows.Forms.Button btn_selectImage;
        private System.Windows.Forms.Button btn_saveChanges;
    }
}