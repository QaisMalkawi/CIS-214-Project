using Project214.Utilities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project214.Forms
{
    public partial class TicTacToe : Form
    {

        Form parent;
        private bool gameEnded = false;
        private Player currentPlayer = Player.X;

        public TicTacToe(Form parent)
        {
            InitializeComponent();


            this.parent = parent;
            parent.Move += Parent_Move;
        }

        private void Parent_Move(object sender, EventArgs e)
        {
            this.Location = new Point(parent.Location.X - this.Width, parent.Location.Y);
        }


        private void btn_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void TicTakToe_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Move -= Parent_Move;
            StaticValues.gameWindow = null;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            currentPlayer = Player.X;
            gameEnded = false;
            button1.Text = button2.Text = button3.Text = button4.Text = button5.Text = button6.Text = button7.Text = button8.Text = button9.Text = "";
        }
        void ButtonClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            // Check if the button is already marked or the game is over
            if (button.Text != "" || gameEnded)
                return;

            // Mark the button with the current player's symbol
            button.Text = currentPlayer == Player.X ? "X" : "O";

            Player[,] board = GetBoard();

            // Check for win or draw
            if (CheckForWin(board))
            {
                MessageBox.Show("Player " + currentPlayer + " wins!");
                gameEnded = true;
            }
            else if (CheckForDraw(board))
            {
                MessageBox.Show("It's a draw!");
                gameEnded = true;
            }
            else
            {
                // Switch to the next player
                currentPlayer = currentPlayer == Player.X ? Player.O : Player.X;
            }
        }

        private Player[,] GetBoard()
        {
            Player[,] board = new Player[3, 3];
            switch (button1.Text)
            {
                case "X":
                    board[0, 0] = Player.X;
                    break;
                case "O":
                    board[0, 0] = Player.O;
                    break;
                default:
                    board[0, 0] = Player.None;
                    break;
            }

            switch (button2.Text)
            {
                case "X":
                    board[1, 0] = Player.X;
                    break;
                case "O":
                    board[1, 0] = Player.O;
                    break;
                default:
                    board[1, 0] = Player.None;
                    break;
            }

            switch (button3.Text)
            {
                case "X":
                    board[2, 0] = Player.X;
                    break;
                case "O":
                    board[2, 0] = Player.O;
                    break;
                default:
                    board[2, 0] = Player.None;
                    break;
            }

            switch (button4.Text)
            {
                case "X":
                    board[0, 1] = Player.X;
                    break;
                case "O":
                    board[0, 1] = Player.O;
                    break;
                default:
                    board[0, 1] = Player.None;
                    break;
            }

            switch (button5.Text)
            {
                case "X":
                    board[1, 1] = Player.X;
                    break;
                case "O":
                    board[1, 1] = Player.O;
                    break;
                default:
                    board[1, 1] = Player.None;
                    break;
            }

            switch (button6.Text)
            {
                case "X":
                    board[2, 1] = Player.X;
                    break;
                case "O":
                    board[2, 1] = Player.O;
                    break;
                default:
                    board[2, 1] = Player.None;
                    break;
            }

            switch (button7.Text)
            {
                case "X":
                    board[0, 2] = Player.X;
                    break;
                case "O":
                    board[0, 2] = Player.O;
                    break;
                default:
                    board[0, 2] = Player.None;
                    break;
            }

            switch (button8.Text)
            {
                case "X":
                    board[1, 2] = Player.X;
                    break;
                case "O":
                    board[1, 2] = Player.O;
                    break;
                default:
                    board[1, 2] = Player.None;
                    break;
            }

            switch (button9.Text)
            {
                case "X":
                    board[2, 2] = Player.X;
                    break;
                case "O":
                    board[2, 2] = Player.O;
                    break;
                default:
                    board[2, 2] = Player.None;
                    break;
            }

            return board;
        }

        private bool CheckForWin(Player[,] board)
        {

            for (int row = 0; row < 3; row++)
            {
                if (board[row, 0] == board[row, 1] && board[row, 1] == board[row, 2] && board[row, 0] != Player.None)
                    return true;
            }

            for (int col = 0; col < 3; col++)
            {
                if (board[0, col] == board[1, col] && board[1, col] == board[2, col] && board[0, col] != Player.None)
                    return true;
            }

            if ((board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != Player.None) ||
                (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != Player.None))
                return true;

            return false;
        }

        private bool CheckForDraw(Player[,] board)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (board[row, col] == Player.None)
                        return false;
                }
            }

            return true;
        }

    }
}

enum Player
{
    X,
    O,
    None
}
