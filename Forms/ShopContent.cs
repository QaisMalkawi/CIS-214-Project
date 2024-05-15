using Project214.Forms.Custom_Components;
using Project214.Utilities;
using System;
using System.Windows.Forms;

namespace Project214.Forms
{
    public partial class ShopContent : Form
    {
        public Shop shop;

        public ShopContent(Shop shop)
        {
            this.shop = shop;
            InitializeComponent();
        }

        private void ShopContent_Load(object sender, EventArgs e)
        {
            if (shop.shopItems == null)
            {
                MessageBox.Show("Shop Recieved No Info");
                return;
            }
            lbl_shopName.Text = shop.ShopName;
            pbx_shopIcon.Image = shop.shopIcon;
            lbl_elementsCount.Text = shop.shopItems.Length + " elements avilable";

            for (int i = 0; i < shop.shopItems.Length; i++)
            {
                ShopItemCard itemCard = new ShopItemCard(shop.shopItems[i]);
                itemCard.Width = 700;
                flg_shopItemsHolder.Controls.Add(itemCard);
            }
        }

        private void ShopContent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            ShopsExplorer explorer = new ShopsExplorer(this);
            explorer.ShowDialog();
            this.FormClosing -= ShopContent_FormClosing;
            Close();
        }
    }
}
