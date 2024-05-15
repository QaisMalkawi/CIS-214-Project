using Project214.Utilities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project214.Forms.Custom_Components
{
    public partial class ShopCard : UserControl
    {
        public Action<object, EventArgs> CardClicked;

        public Shop Shop;
        int itemCount;

        public ShopCard(Shop shop)
        {
            InitializeComponent();

            Shop = shop;
            ShopName = shop.ShopName;
            ItemsCount = shop.shopItems.Length;
            Icon = shop.shopIcon;
        }
        private void itemClicked(object sender, EventArgs e)
        {
            CardClicked?.Invoke(this, EventArgs.Empty);
        }



        public string ShopName
        {
            get { return lbl_itemTitle.Text; }
            set { lbl_itemTitle.Text = value; }
        }

        public int ItemsCount
        {
            get { return itemCount; }
            set { lbl_itemsCount.Text = value + " Elements Avilable"; itemCount = value; }
        }
        public Image Icon
        {
            get { return pbx_ItemPicture.Image; }
            set { pbx_ItemPicture.Image = value; pbx_ItemPicture.Refresh(); }
        }
    }
}
