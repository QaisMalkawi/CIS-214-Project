using System;

namespace Project214.Forms
{
    partial class AdminConsole
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_userAccountHashSelected = new System.Windows.Forms.Button();
            this.btn_userAccountNew = new System.Windows.Forms.Button();
            this.btn_userAccountDelete = new System.Windows.Forms.Button();
            this.btn_userAccountRefresh = new System.Windows.Forms.Button();
            this.btn_userAccountSave = new System.Windows.Forms.Button();
            this.dgv_userAccount = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_shopSelectImage = new System.Windows.Forms.Button();
            this.btn_shopPreviewImage = new System.Windows.Forms.Button();
            this.btn_shopNew = new System.Windows.Forms.Button();
            this.btn_shopDelete = new System.Windows.Forms.Button();
            this.btn_shopRefresh = new System.Windows.Forms.Button();
            this.btn_shopSave = new System.Windows.Forms.Button();
            this.dgv_shop = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_shopItemPreviewImage = new System.Windows.Forms.Button();
            this.btn_shopItemNew = new System.Windows.Forms.Button();
            this.btn_shopItemDelete = new System.Windows.Forms.Button();
            this.btn_shopItemRefresh = new System.Windows.Forms.Button();
            this.btn_shopItemSave = new System.Windows.Forms.Button();
            this.dgv_shopItem = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pbx_imagePreview = new Project214.Forms.Custom_Components.ExpandedPictureBox();
            this.btn_shopItemSelectImage = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_userAccount)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_shop)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_shopItem)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_imagePreview)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(748, 469);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.tabPage1.Controls.Add(this.btn_userAccountHashSelected);
            this.tabPage1.Controls.Add(this.btn_userAccountNew);
            this.tabPage1.Controls.Add(this.btn_userAccountDelete);
            this.tabPage1.Controls.Add(this.btn_userAccountRefresh);
            this.tabPage1.Controls.Add(this.btn_userAccountSave);
            this.tabPage1.Controls.Add(this.dgv_userAccount);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(740, 443);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "User Account";
            // 
            // btn_userAccountHashSelected
            // 
            this.btn_userAccountHashSelected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_userAccountHashSelected.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.btn_userAccountHashSelected.FlatAppearance.BorderSize = 2;
            this.btn_userAccountHashSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_userAccountHashSelected.Font = new System.Drawing.Font("Unispace", 16F, System.Drawing.FontStyle.Bold);
            this.btn_userAccountHashSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btn_userAccountHashSelected.Location = new System.Drawing.Point(261, 6);
            this.btn_userAccountHashSelected.Name = "btn_userAccountHashSelected";
            this.btn_userAccountHashSelected.Size = new System.Drawing.Size(212, 37);
            this.btn_userAccountHashSelected.TabIndex = 9;
            this.btn_userAccountHashSelected.Text = "Hash Password";
            this.btn_userAccountHashSelected.UseVisualStyleBackColor = true;
            this.btn_userAccountHashSelected.Click += new System.EventHandler(this.btn_userAccountHashSelected_Click);
            // 
            // btn_userAccountNew
            // 
            this.btn_userAccountNew.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_userAccountNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.btn_userAccountNew.FlatAppearance.BorderSize = 2;
            this.btn_userAccountNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_userAccountNew.Font = new System.Drawing.Font("Unispace", 16F, System.Drawing.FontStyle.Bold);
            this.btn_userAccountNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btn_userAccountNew.Location = new System.Drawing.Point(8, 6);
            this.btn_userAccountNew.Name = "btn_userAccountNew";
            this.btn_userAccountNew.Size = new System.Drawing.Size(86, 37);
            this.btn_userAccountNew.TabIndex = 8;
            this.btn_userAccountNew.Text = "New";
            this.btn_userAccountNew.UseVisualStyleBackColor = true;
            this.btn_userAccountNew.Click += new System.EventHandler(this.btn_userAccountNew_Click);
            // 
            // btn_userAccountDelete
            // 
            this.btn_userAccountDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_userAccountDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.btn_userAccountDelete.FlatAppearance.BorderSize = 2;
            this.btn_userAccountDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_userAccountDelete.Font = new System.Drawing.Font("Unispace", 16F, System.Drawing.FontStyle.Bold);
            this.btn_userAccountDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btn_userAccountDelete.Location = new System.Drawing.Point(100, 6);
            this.btn_userAccountDelete.Name = "btn_userAccountDelete";
            this.btn_userAccountDelete.Size = new System.Drawing.Size(109, 37);
            this.btn_userAccountDelete.TabIndex = 7;
            this.btn_userAccountDelete.Text = "Delete";
            this.btn_userAccountDelete.UseVisualStyleBackColor = true;
            this.btn_userAccountDelete.Click += new System.EventHandler(this.btn_userAccountDelete_Click);
            // 
            // btn_userAccountRefresh
            // 
            this.btn_userAccountRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_userAccountRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.btn_userAccountRefresh.FlatAppearance.BorderSize = 2;
            this.btn_userAccountRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_userAccountRefresh.Font = new System.Drawing.Font("Unispace", 16F, System.Drawing.FontStyle.Bold);
            this.btn_userAccountRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btn_userAccountRefresh.Location = new System.Drawing.Point(525, 6);
            this.btn_userAccountRefresh.Name = "btn_userAccountRefresh";
            this.btn_userAccountRefresh.Size = new System.Drawing.Size(115, 37);
            this.btn_userAccountRefresh.TabIndex = 6;
            this.btn_userAccountRefresh.Text = "Refresh";
            this.btn_userAccountRefresh.UseVisualStyleBackColor = true;
            this.btn_userAccountRefresh.Click += new System.EventHandler(this.btn_userAccountRefresh_Click);
            // 
            // btn_userAccountSave
            // 
            this.btn_userAccountSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_userAccountSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.btn_userAccountSave.FlatAppearance.BorderSize = 2;
            this.btn_userAccountSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_userAccountSave.Font = new System.Drawing.Font("Unispace", 16F, System.Drawing.FontStyle.Bold);
            this.btn_userAccountSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btn_userAccountSave.Location = new System.Drawing.Point(646, 6);
            this.btn_userAccountSave.Name = "btn_userAccountSave";
            this.btn_userAccountSave.Size = new System.Drawing.Size(86, 37);
            this.btn_userAccountSave.TabIndex = 5;
            this.btn_userAccountSave.Text = "Save";
            this.btn_userAccountSave.UseVisualStyleBackColor = true;
            this.btn_userAccountSave.Click += new System.EventHandler(this.btn_userAccountSave_Click);
            // 
            // dgv_userAccount
            // 
            this.dgv_userAccount.AllowUserToAddRows = false;
            this.dgv_userAccount.AllowUserToDeleteRows = false;
            this.dgv_userAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_userAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(143)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_userAccount.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_userAccount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_userAccount.Location = new System.Drawing.Point(3, 49);
            this.dgv_userAccount.Name = "dgv_userAccount";
            this.dgv_userAccount.Size = new System.Drawing.Size(734, 391);
            this.dgv_userAccount.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.tabPage2.Controls.Add(this.btn_shopSelectImage);
            this.tabPage2.Controls.Add(this.btn_shopPreviewImage);
            this.tabPage2.Controls.Add(this.btn_shopNew);
            this.tabPage2.Controls.Add(this.btn_shopDelete);
            this.tabPage2.Controls.Add(this.btn_shopRefresh);
            this.tabPage2.Controls.Add(this.btn_shopSave);
            this.tabPage2.Controls.Add(this.dgv_shop);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(740, 443);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Shop";
            // 
            // btn_shopSelectImage
            // 
            this.btn_shopSelectImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.btn_shopSelectImage.FlatAppearance.BorderSize = 2;
            this.btn_shopSelectImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_shopSelectImage.Font = new System.Drawing.Font("Ubuntu", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_shopSelectImage.Location = new System.Drawing.Point(371, 6);
            this.btn_shopSelectImage.Name = "btn_shopSelectImage";
            this.btn_shopSelectImage.Size = new System.Drawing.Size(148, 37);
            this.btn_shopSelectImage.TabIndex = 15;
            this.btn_shopSelectImage.Text = "Select Image";
            this.btn_shopSelectImage.UseVisualStyleBackColor = true;
            this.btn_shopSelectImage.Click += new System.EventHandler(this.btn_shopSelectImage_Click);
            // 
            // btn_shopPreviewImage
            // 
            this.btn_shopPreviewImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_shopPreviewImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.btn_shopPreviewImage.FlatAppearance.BorderSize = 2;
            this.btn_shopPreviewImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_shopPreviewImage.Font = new System.Drawing.Font("Unispace", 16F, System.Drawing.FontStyle.Bold);
            this.btn_shopPreviewImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btn_shopPreviewImage.Location = new System.Drawing.Point(215, 6);
            this.btn_shopPreviewImage.Name = "btn_shopPreviewImage";
            this.btn_shopPreviewImage.Size = new System.Drawing.Size(148, 37);
            this.btn_shopPreviewImage.TabIndex = 14;
            this.btn_shopPreviewImage.Text = "Preview Image";
            this.btn_shopPreviewImage.UseVisualStyleBackColor = true;
            this.btn_shopPreviewImage.Click += new System.EventHandler(this.btn_shopPreviewImage_Click);
            // 
            // btn_shopNew
            // 
            this.btn_shopNew.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_shopNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.btn_shopNew.FlatAppearance.BorderSize = 2;
            this.btn_shopNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_shopNew.Font = new System.Drawing.Font("Unispace", 16F, System.Drawing.FontStyle.Bold);
            this.btn_shopNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btn_shopNew.Location = new System.Drawing.Point(8, 6);
            this.btn_shopNew.Name = "btn_shopNew";
            this.btn_shopNew.Size = new System.Drawing.Size(86, 37);
            this.btn_shopNew.TabIndex = 13;
            this.btn_shopNew.Text = "New";
            this.btn_shopNew.UseVisualStyleBackColor = true;
            this.btn_shopNew.Click += new System.EventHandler(this.btn_shopNew_Click);
            // 
            // btn_shopDelete
            // 
            this.btn_shopDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_shopDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.btn_shopDelete.FlatAppearance.BorderSize = 2;
            this.btn_shopDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_shopDelete.Font = new System.Drawing.Font("Unispace", 16F, System.Drawing.FontStyle.Bold);
            this.btn_shopDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btn_shopDelete.Location = new System.Drawing.Point(100, 6);
            this.btn_shopDelete.Name = "btn_shopDelete";
            this.btn_shopDelete.Size = new System.Drawing.Size(109, 37);
            this.btn_shopDelete.TabIndex = 12;
            this.btn_shopDelete.Text = "Delete";
            this.btn_shopDelete.UseVisualStyleBackColor = true;
            this.btn_shopDelete.Click += new System.EventHandler(this.btn_shopDelete_Click);
            // 
            // btn_shopRefresh
            // 
            this.btn_shopRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_shopRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.btn_shopRefresh.FlatAppearance.BorderSize = 2;
            this.btn_shopRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_shopRefresh.Font = new System.Drawing.Font("Unispace", 16F, System.Drawing.FontStyle.Bold);
            this.btn_shopRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btn_shopRefresh.Location = new System.Drawing.Point(525, 6);
            this.btn_shopRefresh.Name = "btn_shopRefresh";
            this.btn_shopRefresh.Size = new System.Drawing.Size(115, 37);
            this.btn_shopRefresh.TabIndex = 11;
            this.btn_shopRefresh.Text = "Refresh";
            this.btn_shopRefresh.UseVisualStyleBackColor = true;
            this.btn_shopRefresh.Click += new System.EventHandler(this.btn_shopRefresh_Click);
            // 
            // btn_shopSave
            // 
            this.btn_shopSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_shopSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.btn_shopSave.FlatAppearance.BorderSize = 2;
            this.btn_shopSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_shopSave.Font = new System.Drawing.Font("Unispace", 16F, System.Drawing.FontStyle.Bold);
            this.btn_shopSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btn_shopSave.Location = new System.Drawing.Point(646, 6);
            this.btn_shopSave.Name = "btn_shopSave";
            this.btn_shopSave.Size = new System.Drawing.Size(86, 37);
            this.btn_shopSave.TabIndex = 10;
            this.btn_shopSave.Text = "Save";
            this.btn_shopSave.UseVisualStyleBackColor = true;
            this.btn_shopSave.Click += new System.EventHandler(this.btn_shopSave_Click);
            // 
            // dgv_shop
            // 
            this.dgv_shop.AllowUserToAddRows = false;
            this.dgv_shop.AllowUserToDeleteRows = false;
            this.dgv_shop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_shop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(143)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_shop.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_shop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_shop.Location = new System.Drawing.Point(3, 49);
            this.dgv_shop.Name = "dgv_shop";
            this.dgv_shop.Size = new System.Drawing.Size(734, 391);
            this.dgv_shop.TabIndex = 9;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.tabPage3.Controls.Add(this.btn_shopItemSelectImage);
            this.tabPage3.Controls.Add(this.btn_shopItemPreviewImage);
            this.tabPage3.Controls.Add(this.btn_shopItemNew);
            this.tabPage3.Controls.Add(this.btn_shopItemDelete);
            this.tabPage3.Controls.Add(this.btn_shopItemRefresh);
            this.tabPage3.Controls.Add(this.btn_shopItemSave);
            this.tabPage3.Controls.Add(this.dgv_shopItem);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(740, 443);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Shop Item";
            // 
            // btn_shopItemPreviewImage
            // 
            this.btn_shopItemPreviewImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_shopItemPreviewImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.btn_shopItemPreviewImage.FlatAppearance.BorderSize = 2;
            this.btn_shopItemPreviewImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_shopItemPreviewImage.Font = new System.Drawing.Font("Unispace", 16F, System.Drawing.FontStyle.Bold);
            this.btn_shopItemPreviewImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btn_shopItemPreviewImage.Location = new System.Drawing.Point(215, 6);
            this.btn_shopItemPreviewImage.Name = "btn_shopItemPreviewImage";
            this.btn_shopItemPreviewImage.Size = new System.Drawing.Size(145, 37);
            this.btn_shopItemPreviewImage.TabIndex = 20;
            this.btn_shopItemPreviewImage.Text = "Preview Image";
            this.btn_shopItemPreviewImage.UseVisualStyleBackColor = true;
            this.btn_shopItemPreviewImage.Click += new System.EventHandler(this.btn_shopItemPreviewImage_Click);
            // 
            // btn_shopItemNew
            // 
            this.btn_shopItemNew.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_shopItemNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.btn_shopItemNew.FlatAppearance.BorderSize = 2;
            this.btn_shopItemNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_shopItemNew.Font = new System.Drawing.Font("Unispace", 16F, System.Drawing.FontStyle.Bold);
            this.btn_shopItemNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btn_shopItemNew.Location = new System.Drawing.Point(8, 6);
            this.btn_shopItemNew.Name = "btn_shopItemNew";
            this.btn_shopItemNew.Size = new System.Drawing.Size(86, 37);
            this.btn_shopItemNew.TabIndex = 19;
            this.btn_shopItemNew.Text = "New";
            this.btn_shopItemNew.UseVisualStyleBackColor = true;
            this.btn_shopItemNew.Click += new System.EventHandler(this.btn_shopItemNew_Click);
            // 
            // btn_shopItemDelete
            // 
            this.btn_shopItemDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_shopItemDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.btn_shopItemDelete.FlatAppearance.BorderSize = 2;
            this.btn_shopItemDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_shopItemDelete.Font = new System.Drawing.Font("Unispace", 16F, System.Drawing.FontStyle.Bold);
            this.btn_shopItemDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btn_shopItemDelete.Location = new System.Drawing.Point(100, 6);
            this.btn_shopItemDelete.Name = "btn_shopItemDelete";
            this.btn_shopItemDelete.Size = new System.Drawing.Size(109, 37);
            this.btn_shopItemDelete.TabIndex = 18;
            this.btn_shopItemDelete.Text = "Delete";
            this.btn_shopItemDelete.UseVisualStyleBackColor = true;
            this.btn_shopItemDelete.Click += new System.EventHandler(this.btn_shopItemDelete_Click);
            // 
            // btn_shopItemRefresh
            // 
            this.btn_shopItemRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_shopItemRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.btn_shopItemRefresh.FlatAppearance.BorderSize = 2;
            this.btn_shopItemRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_shopItemRefresh.Font = new System.Drawing.Font("Unispace", 16F, System.Drawing.FontStyle.Bold);
            this.btn_shopItemRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btn_shopItemRefresh.Location = new System.Drawing.Point(525, 6);
            this.btn_shopItemRefresh.Name = "btn_shopItemRefresh";
            this.btn_shopItemRefresh.Size = new System.Drawing.Size(115, 37);
            this.btn_shopItemRefresh.TabIndex = 17;
            this.btn_shopItemRefresh.Text = "Refresh";
            this.btn_shopItemRefresh.UseVisualStyleBackColor = true;
            this.btn_shopItemRefresh.Click += new System.EventHandler(this.btn_shopItemRefresh_Click);
            // 
            // btn_shopItemSave
            // 
            this.btn_shopItemSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_shopItemSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.btn_shopItemSave.FlatAppearance.BorderSize = 2;
            this.btn_shopItemSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_shopItemSave.Font = new System.Drawing.Font("Unispace", 16F, System.Drawing.FontStyle.Bold);
            this.btn_shopItemSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btn_shopItemSave.Location = new System.Drawing.Point(646, 6);
            this.btn_shopItemSave.Name = "btn_shopItemSave";
            this.btn_shopItemSave.Size = new System.Drawing.Size(86, 37);
            this.btn_shopItemSave.TabIndex = 16;
            this.btn_shopItemSave.Text = "Save";
            this.btn_shopItemSave.UseVisualStyleBackColor = true;
            this.btn_shopItemSave.Click += new System.EventHandler(this.btn_shopItemSave_Click);
            // 
            // dgv_shopItem
            // 
            this.dgv_shopItem.AllowUserToAddRows = false;
            this.dgv_shopItem.AllowUserToDeleteRows = false;
            this.dgv_shopItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_shopItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(143)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_shopItem.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_shopItem.Location = new System.Drawing.Point(3, 49);
            this.dgv_shopItem.Name = "dgv_shopItem";
            this.dgv_shopItem.Size = new System.Drawing.Size(734, 391);
            this.dgv_shopItem.TabIndex = 15;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.tabPage4.Controls.Add(this.pbx_imagePreview);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(740, 443);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Image Preview";
            // 
            // pbx_imagePreview
            // 
            this.pbx_imagePreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbx_imagePreview.Location = new System.Drawing.Point(0, 0);
            this.pbx_imagePreview.Name = "pbx_imagePreview";
            this.pbx_imagePreview.Size = new System.Drawing.Size(740, 443);
            this.pbx_imagePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_imagePreview.TabIndex = 0;
            this.pbx_imagePreview.TabStop = false;
            // 
            // btn_shopItemSelectImage
            // 
            this.btn_shopItemSelectImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.btn_shopItemSelectImage.FlatAppearance.BorderSize = 2;
            this.btn_shopItemSelectImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_shopItemSelectImage.Font = new System.Drawing.Font("Ubuntu", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_shopItemSelectImage.Location = new System.Drawing.Point(374, 6);
            this.btn_shopItemSelectImage.Name = "btn_shopItemSelectImage";
            this.btn_shopItemSelectImage.Size = new System.Drawing.Size(145, 37);
            this.btn_shopItemSelectImage.TabIndex = 21;
            this.btn_shopItemSelectImage.Text = "Select Image";
            this.btn_shopItemSelectImage.UseVisualStyleBackColor = true;
            this.btn_shopItemSelectImage.Click += new System.EventHandler(this.btn_shopItemSelectImage_Click);
            // 
            // AdminConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(748, 469);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminConsole";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Admin Console";
            this.Load += new System.EventHandler(this.AdminConsole_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_userAccount)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_shop)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_shopItem)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_imagePreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgv_userAccount;
        private System.Windows.Forms.Button btn_userAccountSave;
        private System.Windows.Forms.Button btn_userAccountRefresh;
        private System.Windows.Forms.Button btn_userAccountDelete;
        private System.Windows.Forms.Button btn_userAccountNew;
        private System.Windows.Forms.Button btn_userAccountHashSelected;
        private System.Windows.Forms.Button btn_shopNew;
        private System.Windows.Forms.Button btn_shopDelete;
        private System.Windows.Forms.Button btn_shopRefresh;
        private System.Windows.Forms.Button btn_shopSave;
        private System.Windows.Forms.DataGridView dgv_shop;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btn_shopPreviewImage;
        private System.Windows.Forms.Button btn_shopItemPreviewImage;
        private System.Windows.Forms.Button btn_shopItemNew;
        private System.Windows.Forms.Button btn_shopItemDelete;
        private System.Windows.Forms.Button btn_shopItemRefresh;
        private System.Windows.Forms.Button btn_shopItemSave;
        private System.Windows.Forms.DataGridView dgv_shopItem;
        private Custom_Components.ExpandedPictureBox pbx_imagePreview;
        private System.Windows.Forms.Button btn_shopSelectImage;
        private System.Windows.Forms.Button btn_shopItemSelectImage;
    }
}