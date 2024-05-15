using Project214.Utilities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project214.Forms
{
    public partial class GameOfLife : Form
    {
        bool gameRunning;
        Bitmap canvasImage;
        bool[,] gameData;

        int simulationScale = 32;

        Form parent;
        public GameOfLife(Form parent)
        {
            InitializeComponent();
            canvasImage = new Bitmap(simulationScale, simulationScale);
            gameData = new bool[simulationScale, simulationScale];

            for (int y = 0; y < gameData.GetLength(1); y++)
            {
                for (int x = 0; x < gameData.GetLength(0); x++)
                {
                    canvasImage.SetPixel(x, y, Color.Black);
                }
            }
            pbx_gameCanvas.Image = canvasImage;
            this.parent = parent;

            parent.Move += Parent_Move;
        }

        private void Parent_Move(object sender, EventArgs e)
        {
            this.Location = new Point(parent.Location.X - this.Width, parent.Location.Y);
        }

        private void btn_play_pause_Click(object sender, EventArgs e)
        {
            if(gameRunning)
                gameTimer.Stop();
            else
                gameTimer.Start();

            btn_play_pause.Text = gameRunning ? "Play" : "Pause";
            gameRunning = !gameRunning;
        }

        private void StepGame(object sender, EventArgs e)
        {
            gameData = IterateGameState(gameData);
            for (int y = 0; y < gameData.GetLength(1); y++)
            {
                for (int x = 0; x < gameData.GetLength(0); x++)
                {
                    canvasImage.SetPixel(x, y, gameData[x, y] ? Color.White : Color.Black);
                }
            }
            pbx_gameCanvas.Refresh();
        }

        bool[,] IterateGameState(bool[,] state)
        {
            int width = state.GetLength(0);
            int height = state.GetLength(1);
            bool[,] nextState = new bool[width, height];

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int liveNeighbors = CountLiveNeighbors(state, x, y);

                    // Apply rules of Conway's Game of Life
                    if (state[x, y])
                    {
                        if (liveNeighbors < 2 || liveNeighbors > 3)
                            nextState[x, y] = false; // Cell dies due to underpopulation or overpopulation
                        else
                            nextState[x, y] = true; // Cell survives
                    }
                    else
                    {
                        if (liveNeighbors == 3)
                            nextState[x, y] = true; // Cell becomes alive due to reproduction
                        else
                            nextState[x, y] = false; // Cell remains dead
                    }
                }
            }

            return nextState;
        }

        int CountLiveNeighbors(bool[,] state, int x, int y)
        {
            int width = state.GetLength(0);
            int height = state.GetLength(1);
            int liveNeighbors = 0;

            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (i == 0 && j == 0)
                        continue;

                    int neighborX = x + i;
                    int neighborY = y + j;

                    if(neighborX < 0) neighborX += width;
                    else if(neighborX >= width) neighborX -= width;

                    if (neighborY < 0) neighborY += height;
                    else if (neighborY >= width) neighborY -= height;

                    // Check if neighbor is within bounds
                    if (neighborX >= 0 && neighborX < width && neighborY >= 0 && neighborY < height)
                    {
                        if (state[neighborX, neighborY])
                            liveNeighbors++;
                    }
                }
            }

            return liveNeighbors;
        }

        private void pbx_gameCanvas_Click(object sender, EventArgs e)
        {
            if (gameRunning) return;
            Point point = new Point(MousePosition.X - this.Left, MousePosition.Y - this.Top);

            Point newPoint = GeneralUtils.Remap(point, new Point(0, 0), new Point(pbx_gameCanvas.Width, pbx_gameCanvas.Height), new Point(0, 0), new Point(gameData.GetLength(0), gameData.GetLength(1)));


            gameData[newPoint.X, newPoint.Y] = !gameData[newPoint.X, newPoint.Y];
            canvasImage.SetPixel(newPoint.X, newPoint.Y, gameData[newPoint.X, newPoint.Y] ? Color.White : Color.Black);
            pbx_gameCanvas.Refresh();

        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void GameOfLife_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Move -= Parent_Move;
            StaticValues.gameWindow = null;
        }
    }
}
