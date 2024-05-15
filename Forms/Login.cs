using Project214.Utilities;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Project214.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            bool inputIsEmail = false;
            if (GeneralUtils.RegexEmail(tbx_username.Text))
            {
                inputIsEmail = true;
            }
            else if (!GeneralUtils.RegexName(tbx_username.Text))
            {
                MessageBox.Show("Username not correct: Minimum three characters, accepts only characters, numbers and _, or you can use Email");
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

                string loginQuery = $"SELECT * FROM UserAccount WHERE ";
                if(inputIsEmail)
                    loginQuery += "Email = @Email";
                else
                    loginQuery += "Username = @Username";

                using (SqlCommand selectCommand = new SqlCommand(loginQuery, connection))
                {

                    if (inputIsEmail)
                        selectCommand.Parameters.AddWithValue("@Email", tbx_username.Text);
                    else
                        selectCommand.Parameters.AddWithValue("@Username", tbx_username.Text);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (!reader.HasRows) // Account not found.
                        {
                            MessageBox.Show("Failed to login, Account not found");
                            return;
                        }

                        reader.Read();
                        string passwordFromDb = reader["PasswordHash"].ToString();
                        if (!passwordFromDb.Equals(GeneralUtils.HashString(tbx_password.Text, "Project214Password"))) // Password is incorrect.
                        {
                            MessageBox.Show("Password is incorrect");
                            return;
                        }

                        StaticValues.Username = (string)reader["Username"];
                        StaticValues.UserID = (int)reader["ID"];

                        LoginSucceed();
                    }
                }
            }
        }
        
        private void LoginSucceed()
        {
            Hide();
            ShopsExplorer explorer = new ShopsExplorer(this);
            explorer.ShowDialog();
            Close();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Register()).ShowDialog();
            this.Close();
        }

        Form gameInstance;
        private void btn_playAGame_Click(object sender, EventArgs e)
        {
            if (gameInstance == null || gameInstance.IsDisposed)
            {
                Form game;

                if(DateTime.Now.Ticks % 2 == 0)
                    game = new GameOfLife(this);
                else
                    game = new TicTacToe(this);

                game.Show();
                game.Location = new Point(this.Location.X - game.Width, this.Location.Y);
                gameInstance = game;
            }
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            if (tbx_username.Text != "admin")
            {
                MessageBox.Show("Wrong admin username");
                return;
            }
            if (GeneralUtils.HashString(tbx_password.Text, "Project214Password") != "64F243FBBB9258CF5DCB9F545DC5D53D0AB7048FEC68E7DF8E77E9DB853D780F")//Project214Admin
            {
                MessageBox.Show("Wrong admin password");
                return;
            }

            this.Hide();
            (new AdminConsole()).ShowDialog();
            this.Close();
        }

        private void cbx_passVisible_CheckedChanged(object sender, EventArgs e)
        {
            tbx_password.PasswordChar = cbx_passVisible.Checked ? '\0' : '*';
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
