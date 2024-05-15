using Project214.Forms;
using System.Collections.Generic;

namespace Project214.Utilities
{
    public static class StaticValues
    {
        public static GameOfLife gameWindow;
        public static List<ShopItem> cartItems = new List<ShopItem>();
        public static string Username = "";
        public static int UserID = -1;
        public static readonly string DefaultShopIcon = "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAAACXBIWXMAAA7EAAAOxAGVKw4bAAACUklEQVRYhc2Xz0tVURDHP14eISHyeEhEhIi4kBYhEqERFeKqhYswBKFNm/4DV25a9hdIi4j+gBZBhkkQUVGioWJEKQVtahFEgj0iXs8WZ867c8dzL+929drAYeZ9Z+453zNnzo/XQSzngGtAJA2lra2lmYJn+e4BLyz4DNgtqS2FZtWdMZP9lq4QgcUSCSx4o8M4akAFR6wiWKge2pGm0Q2xG8D3EIFh4AZwhGQhavFYVuG1Q2wOeG0dzymvCF/ZGQFUC8wqr9Qs0AlsU14GfqJ2AsCkON4Ag9JGgD+CX1K4Py9uKmyWOLWngNPABTXgeRW7JNi0JnBfwFmF+Q6+mWwtC35dYdOCrZvYr4KPKWxGsHlwNVAFLovzkQo8K/q96fS46LrCfhmfl3eiRxT2UPQ4UIuACVwNfAHWVOBogEAE9Ii9o3BPxp8jlsCowT7htvtkBEyJY5Hk/j4jekthVSEL8aw1gQrJCv8gepikPBF9NQL65MdHFdAD9Ir9Q+G9yu5MsfuU7bN0Ajim8M+iBwH6gSvAY1z1VoE7xBW8AQxIBw8U/lIInSR5k87jaqEfWFX4Xel7CHiKW/ohRYoN8u3lIs0vTe4LZt9FEyhyweSV1liVlIA6cBH4bT8IyDrxRNaIn3UQ36oRbt277MdpBBrASsagaVIH3mb0uUf+qxo4aAku42FloEWmzF2QKwOlZeawCATPAZuibvY+rW1M4WVLI3AU90ZsZ7B2s9UM2VkZ+NeBcpHRne4EAg9KWmPpDNzCPT6KzHQzw7dA/Af4tgf/Aimb6YCN1Uh+AAAAAElFTkSuQmCC";

        public static readonly string DefaultShopItemIcon = "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";

        public static class DatabaseInfo
        {
            public static readonly string ConnectionString = "Data Source=QAIS-MALKAWI\\SQLEXPRESS;Initial Catalog=Project214; Integrated Security=true";

            public static readonly string UsersString = "UserAccount(Username, Email, PasswordHash)";
            public static readonly string ShopString = "Shop(ShopName, Icon)";
            public static readonly string ShopItemFullString = "ShopItem(ShopID, Title, Description, Price, Icon)";
        }
    }
}

//  CREATE DATABASE Project214;
//  GO

//  USE Project214;
//  GO

//  CREATE TABLE Shop(
//      ID INT IDENTITY(1,1) PRIMARY KEY,
//      ShopName VARCHAR(100),
//      Icon VARBINARY(max),
//   );

//  CREATE TABLE ShopItem(
//      ID INT IDENTITY(1,1) PRIMARY KEY,
//   	ShopID INT NOT NULL,
//      Title VARCHAR(100),
//      Description VARCHAR(155),
//      Price FLOAT,
//      Icon VARBINARY(max),
//      FOREIGN KEY(ShopID) REFERENCES Shop(ID)
//   );

//  CREATE TABLE UserAccount(
//      ID int IDENTITY(1,1) PRIMARY KEY,
//      Username varchar(100),
//      Email varchar(100),
//      PasswordHash varchar(100),
//      OwnedShop INT,
//      FOREIGN KEY(OwnedShop) REFERENCES Shop(ID)
//   );