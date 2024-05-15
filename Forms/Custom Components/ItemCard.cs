using Project214.Utilities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project214.Forms.Custom_Components
{
    public partial class ShopItemCard : UserControl
    {
        public Action<object, EventArgs> CardClicked;

        ShopItem CartItem;
        float price;

        public ShopItemCard(ShopItem item)
        {
            InitializeComponent();

            CartItem = item;
            Title = item.Title;
            Description = item.Description;
            Price = item.Price;
            Icon = item.Icon;
        }
        private void itemClicked(object sender, EventArgs e)
        {
            CardClicked?.Invoke(this, EventArgs.Empty);
        }



        public string Title
        {
            get { return lbl_itemTitle.Text; }
            set { lbl_itemTitle.Text = value; }
        }
        public string Description
        {
            get { return lbl_description.Text; }
            set { lbl_description.Text = value; }
        }
        public float Price
        {
            get { return price; }
            set { lbl_price.Text = value + "$"; price = value; }
        }
        public Image Icon
        {
            get { return pbx_ItemPicture.Image; }
            set { pbx_ItemPicture.Image = value; pbx_ItemPicture.Refresh(); }
        }
    }
}
