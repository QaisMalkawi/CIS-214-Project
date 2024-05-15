using Project214.Forms;
using Project214.Utilities;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Project214
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {

            if (!GeneralUtils.RegexName(tbx_username.Text))
            {
                MessageBox.Show("Username not correct: Minimum three characters, accepts only characters, numbers and _");
                return;
            }

            if (!GeneralUtils.RegexEmail(tbx_email.Text))
            {
                MessageBox.Show("Email not correct: example@domain.successor");
                return;
            }

            if (!GeneralUtils.RegexPassword(tbx_password.Text))
            {
                MessageBox.Show("Password not correct: Minimum eight characters, at least one uppercase letter, one lowercase letter, one number and one special character");
                return;

            }
            if (tbx_rePassword.Text != tbx_password.Text)
            {
                MessageBox.Show("Passwords doesn't match!");
                return;
            }

            



            using(SqlConnection connection = new SqlConnection(StaticValues.DatabaseInfo.ConnectionString))
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

                if (GeneralUtils.UsernameUsed(connection, tbx_username.Text))
                {
                    MessageBox.Show("This Username is already used!");
                    return;
                }
                if (GeneralUtils.EmailUsed(connection, tbx_email.Text))
                {
                    MessageBox.Show("This Email is already used!");
                    return;
                }

                string registerQuery = $"INSERT INTO {StaticValues.DatabaseInfo.UsersString} VALUES (@Username, @Email, @PasswordHash)";

                using (SqlCommand insertCommand = new SqlCommand(registerQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@Username", tbx_username.Text);
                    insertCommand.Parameters.AddWithValue("@Email", tbx_email.Text);
                    insertCommand.Parameters.AddWithValue("@PasswordHash", GeneralUtils.HashString(tbx_password.Text, "Project214Password"));


                    int rowsAffected = insertCommand.ExecuteNonQuery();
                    if (rowsAffected <= 0)
                    {
                        MessageBox.Show("Failed to register user, is the database set running properly?");
                        return;
                    }

                    MessageBox.Show("Account Registered Successfully!");
                }
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Login()).ShowDialog();
            this.Close();
        }
        Form gameInstance;
        private void btn_playAGame_Click(object sender, EventArgs e)
        {
            if (gameInstance == null || gameInstance.IsDisposed)
            {
                Form game;

                if (DateTime.Now.Ticks % 2 == 0)
                    game = new GameOfLife(this);
                else
                    game = new TicTacToe(this);

                game.Show();
                game.Location = new Point(this.Location.X - game.Width, this.Location.Y);
                gameInstance = game;
            }
        }


        private void cbx_passVisible_CheckedChanged(object sender, EventArgs e)
        {
            tbx_password.PasswordChar = cbx_passVisible.Checked ? '\0' : '*';
        }
        private void cbx_rePassVisible_CheckedChanged(object sender, EventArgs e)
        {
            tbx_rePassword.PasswordChar = cbx_rePassVisible.Checked ? '\0' : '*';

        }
    }
}
