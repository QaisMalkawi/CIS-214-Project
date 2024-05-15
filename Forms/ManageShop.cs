using Project214.Utilities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project214.Forms
{
    public partial class ManageShop : Form
    {
        public ManageShop()
        {
            InitializeComponent();
        }

        int shopID;
        string shopName;
        private void ManageShop_Load(object sender, EventArgs e)
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

                string query = $"SELECT * FROM Shop WHERE ID = (SELECT OwnedShop FROM UserAccount WHERE ID = @ID)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", StaticValues.UserID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            shopID = (int)reader["ID"];
                            tbx_shopName.Text = shopName = (string)reader["ShopName"];
                            pbx_ShopIcon.Image = GeneralUtils.Base64ToBitmap(Encoding.ASCII.GetString((byte[])reader["Icon"]));
                        }
                    }
                }
            }
            LoadShopItems();
        }

        private void LoadShopItems()
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

                SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM ShopItem WHERE ShopID = {shopID}", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                DataTable dt2 = new DataTable();
                dt2.Columns.Add(new DataColumn("ID", typeof(int)));
                dt2.Columns.Add(new DataColumn("Title", typeof(string)));
                dt2.Columns.Add(new DataColumn("Description", typeof(string)));
                dt2.Columns.Add(new DataColumn("Price", typeof(float)));
                dt2.Columns.Add(new DataColumn("Icon", typeof(string)));
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt2.Rows.Add((int)dt.Rows[i][0],
                            (string)dt.Rows[i][2],
                                (string)dt.Rows[i][3],
                                    (double)dt.Rows[i][4],
                                        Encoding.ASCII.GetString((byte[])dt.Rows[i][5]));
                }

                dgv_shopItem.DataSource = dt2;
            }
            dgv_shopItem.Columns[0].ReadOnly = true;
        }

        private void ManageShop_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            ShopsExplorer explorer = new ShopsExplorer(this);
            explorer.ShowDialog();
            this.FormClosing -= ManageShop_FormClosing;
            Close();
        }

        private void btn_addElement_Click(object sender, EventArgs e)
        {
            var dbres = MessageBox.Show("Any unsaved changes will be deleted,\n want to save before continue?", "Save changes?", MessageBoxButtons.YesNoCancel);
            if (dbres == DialogResult.Yes)
            {
                shopItemSave();
            }
            if (dbres == DialogResult.Yes || dbres == DialogResult.No)
            {
                if (dgv_shopItem.Rows.Count == 0)
                {
                    MessageBox.Show("You need to have atleast 1 shop to create an item");
                    return;
                }
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

                    string registerQuery = $"INSERT INTO {StaticValues.DatabaseInfo.ShopItemFullString} VALUES (@ShopID, @Title, @Description, @Price, @Icon)";

                    using (SqlCommand insertCommand = new SqlCommand(registerQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@ShopID", shopID);
                        insertCommand.Parameters.AddWithValue("@Title", "Item Title");
                        insertCommand.Parameters.AddWithValue("@Description", "Item Description");
                        insertCommand.Parameters.AddWithValue("@Price", 0f);
                        insertCommand.Parameters.AddWithValue("@Icon", Encoding.UTF8.GetBytes(StaticValues.DefaultShopItemIcon));


                        int rowsAffected = insertCommand.ExecuteNonQuery();
                        if (rowsAffected <= 0)
                        {
                            MessageBox.Show("Failed to register shop item, is the database set running properly?");
                            return;
                        }
                    }
                }
                LoadShopItems();
            }
        }

        private void shopItemSave()
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
                for (int i = 0; i < dgv_shopItem.Rows.Count; i++)
                {
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand("UPDATE ShopItem SET Title = @Title, Description = @Description, Price = @Price, Icon = @Icon, ShopID = @ShopID WHERE ID = @ID", connection))
                        {
                            cmd.Parameters.AddWithValue("@ID", (int)dgv_shopItem.Rows[i].Cells[0].Value);
                            cmd.Parameters.AddWithValue("@ShopID", shopID);
                            cmd.Parameters.AddWithValue("@Title", (string)dgv_shopItem.Rows[i].Cells[1].Value);
                            cmd.Parameters.AddWithValue("@Description", (string)dgv_shopItem.Rows[i].Cells[2].Value);
                            cmd.Parameters.AddWithValue("@Price", (float)dgv_shopItem.Rows[i].Cells[3].Value);
                            cmd.Parameters.AddWithValue("@Icon", Encoding.UTF8.GetBytes((string)dgv_shopItem.Rows[i].Cells[4].Value));//byte[]

                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        if (MessageBox.Show($"Wrong values for row with ID {dgv_shopItem.Rows[i].Cells[0].Value}\nShow stack trace?", "Saving Error", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            MessageBox.Show($"Stack trace:\n{ex}");
                        }
                        dgv_shopItem.Rows[i].Selected = true;
                    }
                }
            }
        }

        private void btn_rename_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_shopName.Text) || string.IsNullOrWhiteSpace(tbx_shopName.Text))
            {
                tbx_shopName.Text = shopName;
                return;
            }


            shopName = tbx_shopName.Text;
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

                string query = "UPDATE Shop SET ShopName = @ShopName WHERE ID = @ID";
                using(var command =  new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ShopName", shopName);
                    command.Parameters.AddWithValue("@ID", shopID);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void btn_selectImage_Click(object sender, EventArgs e)
        {
            string imageBase64 = GeneralUtils.GetImage();
            foreach (DataGridViewCell cell in dgv_shopItem.SelectedCells)
            {
                cell.Value = imageBase64;
            }
        }

        private void btn_saveChanges_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to save the changes?\nthese changes cannot be undone once saved!") != DialogResult.OK) return;
            shopItemSave();
        }
    }
}