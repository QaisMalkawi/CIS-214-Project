namespace Project214.Forms
{
    partial class ShopContent
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
            this.lbl_elementsCount = new System.Windows.Forms.Label();
            this.lbl_shopName = new System.Windows.Forms.Label();
            this.pbx_shopIcon = new System.Windows.Forms.PictureBox();
            this.flg_shopItemsHolder = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_shopIcon)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.lbl_elementsCount);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_shopName);
            this.splitContainer1.Panel1.Controls.Add(this.pbx_shopIcon);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flg_shopItemsHolder);
            this.splitContainer1.Size = new System.Drawing.Size(748, 469);
            this.splitContainer1.SplitterDistance = 100;
            this.splitContainer1.TabIndex = 0;
            // 
            // lbl_elementsCount
            // 
            this.lbl_elementsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_elementsCount.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_elementsCount.Location = new System.Drawing.Point(112, 62);
            this.lbl_elementsCount.Name = "lbl_elementsCount";
            this.lbl_elementsCount.Size = new System.Drawing.Size(296, 33);
            this.lbl_elementsCount.TabIndex = 2;
            this.lbl_elementsCount.Text = "16 elements avilable";
            // 
            // lbl_shopName
            // 
            this.lbl_shopName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_shopName.Font = new System.Drawing.Font("Ubuntu", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shopName.Location = new System.Drawing.Point(112, 13);
            this.lbl_shopName.Name = "lbl_shopName";
            this.lbl_shopName.Size = new System.Drawing.Size(624, 49);
            this.lbl_shopName.TabIndex = 1;
            this.lbl_shopName.Text = "The Best Shop";
            // 
            // pbx_shopIcon
            // 
            this.pbx_shopIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pbx_shopIcon.Location = new System.Drawing.Point(5, 5);
            this.pbx_shopIcon.Name = "pbx_shopIcon";
            this.pbx_shopIcon.Size = new System.Drawing.Size(100, 90);
            this.pbx_shopIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_shopIcon.TabIndex = 0;
            this.pbx_shopIcon.TabStop = false;
            // 
            // flg_shopItemsHolder
            // 
            this.flg_shopItemsHolder.AutoScroll = true;
            this.flg_shopItemsHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flg_shopItemsHolder.Location = new System.Drawing.Point(0, 0);
            this.flg_shopItemsHolder.Name = "flg_shopItemsHolder";
            this.flg_shopItemsHolder.Size = new System.Drawing.Size(748, 365);
            this.flg_shopItemsHolder.TabIndex = 0;
            // 
            // ShopContent
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
            this.Name = "ShopContent";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Shop Content";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShopContent_FormClosing);
            this.Load += new System.EventHandler(this.ShopContent_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_shopIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pbx_shopIcon;
        private System.Windows.Forms.Label lbl_shopName;
        private System.Windows.Forms.Label lbl_elementsCount;
        private System.Windows.Forms.FlowLayoutPanel flg_shopItemsHolder;
    }
}