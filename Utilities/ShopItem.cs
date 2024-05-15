using System.Drawing;

namespace Project214.Utilities
{
    public class Shop
    {
        public string ShopName;
        public Image shopIcon;
        public ShopItem[] shopItems;

        public Shop(string shopName, Image shopIcon, ShopItem[] shopItems)
        {
            ShopName = shopName;
            this.shopIcon = shopIcon;
            this.shopItems = shopItems;
        }
        public Shop(string shopName, Image shopIcon)
        {
            ShopName = shopName;
            this.shopIcon = shopIcon;
            this.shopItems = new ShopItem[0];
        }
    }
    public class ShopItem
    {
        public string Title;
        public string Description;
        public float Price;
        public Image Icon;

        public ShopItem(string title, string description, float price, Image icon)
        {
            Title = title;
            Description = description;
            Price = price;
            Icon = icon;
        }
    }
}
