namespace Project214.Forms.Custom_Components
{
    partial class ShopItemCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbx_ItemPicture = new System.Windows.Forms.PictureBox();
            this.lbl_itemTitle = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_ItemPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_ItemPicture
            // 
            this.pbx_ItemPicture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pbx_ItemPicture.Location = new System.Drawing.Point(5, 5);
            this.pbx_ItemPicture.Name = "pbx_ItemPicture";
            this.pbx_ItemPicture.Size = new System.Drawing.Size(100, 90);
            this.pbx_ItemPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_ItemPicture.TabIndex = 0;
            this.pbx_ItemPicture.TabStop = false;
            this.pbx_ItemPicture.DoubleClick += new System.EventHandler(this.itemClicked);
            // 
            // lbl_itemTitle
            // 
            this.lbl_itemTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_itemTitle.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemTitle.Location = new System.Drawing.Point(111, 5);
            this.lbl_itemTitle.Name = "lbl_itemTitle";
            this.lbl_itemTitle.Size = new System.Drawing.Size(236, 30);
            this.lbl_itemTitle.TabIndex = 1;
            this.lbl_itemTitle.Text = "The Title";
            this.lbl_itemTitle.DoubleClick += new System.EventHandler(this.itemClicked);
            // 
            // lbl_description
            // 
            this.lbl_description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_description.Font = new System.Drawing.Font("Ubuntu", 8F);
            this.lbl_description.Location = new System.Drawing.Point(113, 35);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(103, 60);
            this.lbl_description.TabIndex = 2;
            this.lbl_description.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor in" +
    "cididunt ut labore et dolore magna aliqua.";
            this.lbl_description.DoubleClick += new System.EventHandler(this.itemClicked);
            // 
            // lbl_price
            // 
            this.lbl_price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_price.Font = new System.Drawing.Font("Ubuntu", 18F);
            this.lbl_price.Location = new System.Drawing.Point(222, 35);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(125, 60);
            this.lbl_price.TabIndex = 3;
            this.lbl_price.Text = "00$";
            this.lbl_price.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_price.DoubleClick += new System.EventHandler(this.itemClicked);
            // 
            // ShopItemCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.lbl_itemTitle);
            this.Controls.Add(this.pbx_ItemPicture);
            this.Name = "ShopItemCard";
            this.Size = new System.Drawing.Size(350, 100);
            this.DoubleClick += new System.EventHandler(this.itemClicked);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_ItemPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pbx_ItemPicture;
        public System.Windows.Forms.Label lbl_itemTitle;
        public System.Windows.Forms.Label lbl_description;
        public System.Windows.Forms.Label lbl_price;
    }
}
