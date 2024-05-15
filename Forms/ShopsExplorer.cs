using Project214.Forms.Custom_Components;
using Project214.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Project214.Forms
{
    public partial class ShopsExplorer : Form
    {
        public Shop[] AvilableShops { get; set; }

        public ShopsExplorer(Form parent)
        {
            Location = parent.Location;
            InitializeComponent();
        }

        private void ShopsExplorer_Load(object sender, EventArgs e)
        {
            lbl_welcomeHeader.Text = "Welcome " + StaticValues.Username;
            if(HasAShop())
                btn_manageShop.Text = "Manage Shop";
            else
                btn_manageShop.Text = "Create Shop";

            PopulateShops();


            for (int i = 0; i < AvilableShops.Length; i++)
            {
                ShopCard itemCard = new ShopCard(AvilableShops[i]);
                itemCard.Width = 700;
                flg_shopItemsHolder.Controls.Add(itemCard);
                itemCard.CardClicked += (o, ea) =>
                {
                    Hide();
                    ShopContent explorer = new ShopContent(itemCard.Shop);
                    explorer.ShowDialog();
                    Close();
                };
            }
        }

        private bool HasAShop()
        {
            using (SqlConnection connection = new SqlConnection(StaticValues.DatabaseInfo.ConnectionString))
            {
                try
                {
                    connection.Open();
                }
                catch
                {
                    MessageBox.Show("Couldn't connect to the Database service, is it running?");
                    return false;
                }
                string query = "SELECT OwnedShop FROM UserAccount WHERE ID = @ID";
                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", StaticValues.UserID);

                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            try
                            {
                                int sID = (int)reader["OwnedShop"];
                                return true;
                            }
                            catch 
                            {
                                return false;
                            }
                        }
                        return false;
                    }
                }
            }
        }

        private void PopulateShops()
        {
            List<Shop> shops = new List<Shop>();
            List<int> shopsIDs = new List<int>();
            using (SqlConnection connection = new SqlConnection(StaticValues.DatabaseInfo.ConnectionString))
            {
                try
                {
                    connection.Open();
                }
                catch
                {
                    MessageBox.Show("Couldn't connect to the Database service, is it running?");
                    return;
                }

                string query = $"SELECT * FROM Shop";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            shops.Add(new Shop(
                                (string)reader["ShopName"],
                                GeneralUtils.Base64ToBitmap(Encoding.ASCII.GetString((byte[])reader["Icon"]))));

                            shopsIDs.Add((int)reader["ID"]);
                        }
                    }
                }

                for (int i = 0; i < shops.Count; i++)
                {
                    query = $"SELECT * FROM ShopItem WHERE ShopID = @ShopID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        List<ShopItem> shopItems = new List<ShopItem>();
                        command.Parameters.AddWithValue("ShopID", shopsIDs[i]);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                shopItems.Add(new ShopItem(
                                        (string)reader["Title"],
                                        (string)reader["Description"],
                                        (float)(double)reader["Price"],
                                        GeneralUtils.Base64ToBitmap(Encoding.ASCII.GetString((byte[])reader["Icon"]))
                                    ));
                            }
                        }
                        shops[i].shopItems = shopItems.ToArray();
                    }
                }
            }
            AvilableShops = shops.ToArray();
        }

        private void lbl_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lf = new Login();
            lf.ShowDialog();
            lf.Location = Location;
            StaticValues.cartItems.Clear();
            StaticValues.Username = "";
            StaticValues.UserID = -1;
        }

        private void btn_manageShop_Click(object sender, EventArgs e)
        {
            if(!HasAShop())
            {
                CreateShop();
            }
            Hide();
            ManageShop ms = new ManageShop();
            ms.ShowDialog();
            Close();
        }

        private void CreateShop()
        {
            using (SqlConnection connection = new SqlConnection(StaticValues.DatabaseInfo.ConnectionString))
            {
                try
                {
                    connection.Open();
                }
                catch
                {
                    MessageBox.Show("Couldn't connect to the Database service, is it running?");
                    return;
                }

                string query = $"INSERT INTO {StaticValues.DatabaseInfo.ShopString} VALUES (@ShopName, @Icon)";

                using (SqlCommand insertCommand = new SqlCommand(query, connection))
                {
                    insertCommand.Parameters.AddWithValue("@ShopName", StaticValues.Username + "'s Shop");
                    insertCommand.Parameters.AddWithValue("@Icon", Encoding.UTF8.GetBytes(StaticValues.DefaultShopIcon));

                    int rowsAffected = insertCommand.ExecuteNonQuery();
                    if (rowsAffected <= 0)
                    {
                        MessageBox.Show("Failed to register shop, is the database set running properly?");
                        return;
                    }
                }

                int shopID = -1;

                query = "SELECT ID FROM Shop WHERE ShopName = @ShopName";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ShopName", StaticValues.Username + "'s Shop");

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            shopID = (int)reader["ID"];
                        }
                    }
                }

                if (shopID != -1)
                {
                    query = "UPDATE UserAccount SET OwnedShop = @OwnedShop WHERE ID = @ID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@OwnedShop", shopID);
                        command.Parameters.AddWithValue("@ID", StaticValues.UserID);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
