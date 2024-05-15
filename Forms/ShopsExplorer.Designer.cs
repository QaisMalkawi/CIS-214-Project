namespace Project214.Forms
{
    partial class ShopsExplorer
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_manageShop = new System.Windows.Forms.Button();
            this.lbl_logout = new System.Windows.Forms.Button();
            this.lbl_welcomeHeader = new System.Windows.Forms.Label();
            this.flg_shopItemsHolder = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.btn_manageShop);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_logout);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_welcomeHeader);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flg_shopItemsHolder);
            this.splitContainer1.Size = new System.Drawing.Size(748, 469);
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_manageShop
            // 
            this.btn_manageShop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.btn_manageShop.FlatAppearance.BorderSize = 2;
            this.btn_manageShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_manageShop.Font = new System.Drawing.Font("Unispace", 10F, System.Drawing.FontStyle.Bold);
            this.btn_manageShop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btn_manageShop.Location = new System.Drawing.Point(3, 3);
            this.btn_manageShop.Name = "btn_manageShop";
            this.btn_manageShop.Size = new System.Drawing.Size(131, 47);
            this.btn_manageShop.TabIndex = 8;
            this.btn_manageShop.Text = "Create Shop";
            this.btn_manageShop.UseVisualStyleBackColor = true;
            this.btn_manageShop.Click += new System.EventHandler(this.btn_manageShop_Click);
            // 
            // lbl_logout
            // 
            this.lbl_logout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.lbl_logout.FlatAppearance.BorderSize = 2;
            this.lbl_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_logout.Font = new System.Drawing.Font("Unispace", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.lbl_logout.Location = new System.Drawing.Point(655, 3);
            this.lbl_logout.Name = "lbl_logout";
            this.lbl_logout.Size = new System.Drawing.Size(90, 47);
            this.lbl_logout.TabIndex = 7;
            this.lbl_logout.Text = "Logout";
            this.lbl_logout.UseVisualStyleBackColor = true;
            this.lbl_logout.Click += new System.EventHandler(this.lbl_logout_Click);
            // 
            // lbl_welcomeHeader
            // 
            this.lbl_welcomeHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_welcomeHeader.Font = new System.Drawing.Font("Ubuntu", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcomeHeader.Location = new System.Drawing.Point(0, 0);
            this.lbl_welcomeHeader.Name = "lbl_welcomeHeader";
            this.lbl_welcomeHeader.Size = new System.Drawing.Size(748, 50);
            this.lbl_welcomeHeader.TabIndex = 0;
            this.lbl_welcomeHeader.Text = "Welcome User!";
            this.lbl_welcomeHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flg_shopItemsHolder
            // 
            this.flg_shopItemsHolder.AutoScroll = true;
            this.flg_shopItemsHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flg_shopItemsHolder.Location = new System.Drawing.Point(0, 0);
            this.flg_shopItemsHolder.Name = "flg_shopItemsHolder";
            this.flg_shopItemsHolder.Size = new System.Drawing.Size(748, 415);
            this.flg_shopItemsHolder.TabIndex = 0;
            // 
            // ShopsExplorer
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
            this.Name = "ShopsExplorer";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Shops Explorer";
            this.Load += new System.EventHandler(this.ShopsExplorer_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flg_shopItemsHolder;
        private System.Windows.Forms.Label lbl_welcomeHeader;
        private System.Windows.Forms.Button lbl_logout;
        private System.Windows.Forms.Button btn_manageShop;
    }
}