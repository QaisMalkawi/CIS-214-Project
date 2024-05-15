using Project214.Utilities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project214.Forms
{
    public partial class AdminConsole : Form
    {

        public AdminConsole()
        {
            InitializeComponent();
        }

        private void AdminConsole_Load(object sender, EventArgs e)
        {
            btn_userAccountRefresh_Click(sender, e);
            btn_shopRefresh_Click(sender, e);
            btn_shopItemRefresh_Click(sender, e);
            dgv_userAccount.Columns[0].ReadOnly = true;
            dgv_shop.Columns[0].ReadOnly = true;
            dgv_shopItem.Columns[0].ReadOnly = true;
        }

        #region Refresh Tables
        private void btn_userAccountRefresh_Click(object sender, EventArgs e)
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

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM UserAccount", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgv_userAccount.DataSource = dt;
            }
        }

        private void btn_shopRefresh_Click(object sender, EventArgs e)
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

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Shop", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                DataTable dt2 = new DataTable();
                dt2.Columns.Add(new DataColumn("ID", typeof(int)));
                dt2.Columns.Add(new DataColumn("ShopName", typeof(string)));
                dt2.Columns.Add(new DataColumn("Icon", typeof(string)));
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt2.Rows.Add((int)dt.Rows[i][0], (string)dt.Rows[i][1], Encoding.ASCII.GetString((byte[])dt.Rows[i][2]));
                }

                dgv_shop.DataSource = dt2;
            }
        }

        private void btn_shopItemRefresh_Click(object sender, EventArgs e)
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

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM ShopItem", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                DataTable dt2 = new DataTable();
                dt2.Columns.Add(new DataColumn("ID", typeof(int)));
                dt2.Columns.Add(new DataColumn("ShopID", typeof(int)));
                dt2.Columns.Add(new DataColumn("Title", typeof(string)));
                dt2.Columns.Add(new DataColumn("Description", typeof(string)));
                dt2.Columns.Add(new DataColumn("Price", typeof(float)));
                dt2.Columns.Add(new DataColumn("Icon", typeof(string)));
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt2.Rows.Add((int)dt.Rows[i][0],
                        (int)dt.Rows[i][1],
                            (string)dt.Rows[i][2],
                                (string)dt.Rows[i][3],
                                    (double)dt.Rows[i][4],
                                        Encoding.ASCII.GetString((byte[])dt.Rows[i][5]));
                }

                dgv_shopItem.DataSource = dt2;
            }
        }
        #endregion

        #region Save Table

            #region Callbacks

        private void btn_shopItemSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to save the changes?\nthese changes cannot be undone once saved!") != DialogResult.OK) return;
            shopItemSave();
        }

        private void btn_shopSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to save the changes?\nthese changes cannot be undone once saved!") != DialogResult.OK) return;
            shopSave();
        }

        private void btn_userAccountSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to save the changes?\nthese changes cannot be undone once saved!") != DialogResult.OK) return;
            userAccountSave();
        }
        #endregion

            #region Save Implementation
        private void userAccountSave()
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
                for (int i = 0; i < dgv_userAccount.Rows.Count; i++)
                {
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand("UPDATE UserAccount SET Username = @Username, Email = @Email, PasswordHash = @PasswordHash, OwnedShop = @OwnedShop WHERE ID = @ID", connection))
                        {
                            cmd.Parameters.AddWithValue("ID", dgv_userAccount.Rows[i].Cells[0].Value);
                            cmd.Parameters.AddWithValue("Username", dgv_userAccount.Rows[i].Cells[1].Value);
                            cmd.Parameters.AddWithValue("Email", dgv_userAccount.Rows[i].Cells[2].Value);
                            cmd.Parameters.AddWithValue("PasswordHash", dgv_userAccount.Rows[i].Cells[3].Value);
                            cmd.Parameters.AddWithValue("OwnedShop", dgv_userAccount.Rows[i].Cells[4].Value);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        if (MessageBox.Show($"Wrong values for row with ID {dgv_userAccount.Rows[i].Cells[0].Value}\nShow stack trace?", "Saving Error", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            MessageBox.Show($"Stack trace:\n{ex}");
                        }
                        dgv_userAccount.Rows[i].Selected = true;
                    }
                }
            }
        }

        private void shopSave()
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
                for (int i = 0; i < dgv_shop.Rows.Count; i++)
                {

                    try
                    {
                        using (SqlCommand cmd = new SqlCommand("UPDATE Shop SET ShopName = @ShopName, Icon = @Icon WHERE ID = @ID", connection))
                        {
                            cmd.Parameters.AddWithValue("@ID", (int)dgv_shop.Rows[i].Cells[0].Value);
                            cmd.Parameters.AddWithValue("@ShopName", (string)dgv_shop.Rows[i].Cells[1].Value);
                            cmd.Parameters.AddWithValue("@Icon", Encoding.UTF8.GetBytes((string)dgv_shop.Rows[i].Cells[2].Value));//byte[]
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        if (MessageBox.Show($"Wrong values for row with ID {dgv_shop.Rows[i].Cells[0].Value}\nShow stack trace?", "Saving Error", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            MessageBox.Show($"Stack trace:\n{ex}");
                        }
                        dgv_shop.Rows[i].Selected = true;
                    }
                }
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
                            cmd.Parameters.AddWithValue("@ShopID", (int)dgv_shopItem.Rows[i].Cells[1].Value);
                            cmd.Parameters.AddWithValue("@Title", (string)dgv_shopItem.Rows[i].Cells[2].Value);
                            cmd.Parameters.AddWithValue("@Description", (string)dgv_shopItem.Rows[i].Cells[3].Value);
                            cmd.Parameters.AddWithValue("@Price", (float)dgv_shopItem.Rows[i].Cells[4].Value);
                            cmd.Parameters.AddWithValue("@Icon", Encoding.UTF8.GetBytes((string)dgv_shopItem.Rows[i].Cells[5].Value));//byte[]

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
        #endregion

        #endregion

        #region Delete Row
        private void btn_userAccountDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?\nthese changes cannot be undone!") != DialogResult.OK) return;
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

                foreach (DataGridViewRow row in dgv_userAccount.SelectedRows)
                {
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM UserAccount WHERE ID = @ID", connection))
                    {
                        cmd.Parameters.AddWithValue("ID", (int)row.Cells[0].Value);
                        cmd.ExecuteNonQuery();
                    }
                    dgv_userAccount.Rows.Remove(row);
                }
            }
        }
        private void btn_shopDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?\nthese changes cannot be undone!") != DialogResult.OK) return;
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

                foreach (DataGridViewRow row in dgv_shop.SelectedRows)
                {
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM Shop WHERE ID = @ID", connection))
                    {
                        cmd.Parameters.AddWithValue("ID", (int)row.Cells[0].Value);
                        cmd.ExecuteNonQuery();
                    }
                    dgv_shop.Rows.Remove(row);
                }
            }
        }

        private void btn_shopItemDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?\nthese changes cannot be undone!") != DialogResult.OK) return;
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

                foreach (DataGridViewRow row in dgv_shopItem.SelectedRows)
                {
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM ShopItem WHERE ID = @ID", connection))
                    {
                        cmd.Parameters.AddWithValue("ID", (int)row.Cells[0].Value);
                        cmd.ExecuteNonQuery();
                    }
                    dgv_shopItem.Rows.Remove(row);
                }
            }
        }
        #endregion

        #region Add Row
        private void btn_userAccountNew_Click(object sender, EventArgs e)
        {
            var dbres = MessageBox.Show("Any unsaved changes will be deleted,\n want to save before continue?", "Save changes?", MessageBoxButtons.YesNoCancel);
            if (dbres == DialogResult.Yes)
            {
                userAccountSave();
            }
            if (dbres == DialogResult.Yes || dbres == DialogResult.No)
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

                    string registerQuery = $"INSERT INTO {StaticValues.DatabaseInfo.UsersString} VALUES (@Username, @Email, @PasswordHash)";

                    using (SqlCommand insertCommand = new SqlCommand(registerQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@Username", "Username");
                        insertCommand.Parameters.AddWithValue("@Email", "Email");
                        insertCommand.Parameters.AddWithValue("@PasswordHash", "Password");


                        int rowsAffected = insertCommand.ExecuteNonQuery();
                        if (rowsAffected <= 0)
                        {
                            MessageBox.Show("Failed to register user, is the database set running properly?");
                            return;
                        }
                    }
                }

                btn_userAccountRefresh_Click(sender, e);
            }
        }

        private void btn_shopNew_Click(object sender, EventArgs e)
        {
            var dbres = MessageBox.Show("Any unsaved changes will be deleted,\n want to save before continue?", "Save changes?", MessageBoxButtons.YesNoCancel);
            if (dbres == DialogResult.Yes)
            {
                shopSave();
            }
            if (dbres == DialogResult.Yes || dbres == DialogResult.No)
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

                    string registerQuery = $"INSERT INTO {StaticValues.DatabaseInfo.ShopString} VALUES (@ShopName, @Icon)";

                    using (SqlCommand insertCommand = new SqlCommand(registerQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@ShopName", "Shop Name");
                        insertCommand.Parameters.AddWithValue("@Icon", Encoding.UTF8.GetBytes(StaticValues.DefaultShopIcon));


                        int rowsAffected = insertCommand.ExecuteNonQuery();
                        if (rowsAffected <= 0)
                        {
                            MessageBox.Show("Failed to register shop, is the database set running properly?");
                            return;
                        }
                    }
                }

                btn_shopRefresh_Click(sender, e);
            }
        }

        private void btn_shopItemNew_Click(object sender, EventArgs e)
        {
            var dbres = MessageBox.Show("Any unsaved changes will be deleted,\n want to save before continue?", "Save changes?", MessageBoxButtons.YesNoCancel);
            if (dbres == DialogResult.Yes)
            {
                shopItemSave();
            }
            if (dbres == DialogResult.Yes || dbres == DialogResult.No)
            {
                if (dgv_shop.Rows.Count == 0)
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
                        insertCommand.Parameters.AddWithValue("@ShopID", dgv_shop.Rows[0].Cells[0].Value);
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

                btn_shopItemRefresh_Click(sender, e);
            }
        }
        #endregion

        #region Image Preview
        private void btn_shopPreviewImage_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap image = GeneralUtils.Base64ToBitmap(dgv_shop.SelectedCells[0].Value.ToString());
                pbx_imagePreview.Image = image;
                tabControl1.SelectedIndex = 3;
            }
            catch
            {
                MessageBox.Show("Invalid Base64 Image data");
            }
        }

        private void btn_shopItemPreviewImage_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap image = GeneralUtils.Base64ToBitmap(dgv_shopItem.SelectedCells[0].Value.ToString());
                pbx_imagePreview.Image = image;
                tabControl1.SelectedIndex = 3;
            }
            catch
            {
                MessageBox.Show("Invalid Base64 Image data");
            }
        }


        #endregion

        private void btn_userAccountHashSelected_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in dgv_userAccount.SelectedCells)
            {
                cell.Value = GeneralUtils.HashString(cell.Value.ToString(), "Project214Password");
            }

        }

        private void btn_shopSelectImage_Click(object sender, EventArgs e)
        {
            string imageBase64 = GeneralUtils.GetImage();
            foreach (DataGridViewCell cell in dgv_shop.SelectedCells)
            {
                cell.Value = imageBase64;
            }
        }

        private void btn_shopItemSelectImage_Click(object sender, EventArgs e)
        {
            string imageBase64 = GeneralUtils.GetImage();
            foreach (DataGridViewCell cell in dgv_shopItem.SelectedCells)
            {
                cell.Value = imageBase64;
            }
        }
    }
}
