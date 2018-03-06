using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mine_Sweeper
{
    public partial class Game : Form
    {
        public static short sideWidth = 10; //Columns Count
        public static short sideHeight = 10; //Rows Count
        public static short bombCount = 10; //Bomb count
        public static string gameType = "Easy";

        public Home senderForm;

        NumberGrid numGrid = new NumberGrid();
        short freeCellsCount = 0;
        Button[,] cells = new Button[sideHeight, sideWidth];
        TimeSpan playTime = new TimeSpan(0, 0, 0);
        NewGameRetry loseMsg = new NewGameRetry();
        bool retry = false;

        public Game()
        {
            InitializeComponent();
            this.Size = new Size(sideWidth * 40 + 16, sideHeight * 40 + GamePanel.Height + 39);
            PausePanel.Size = new Size(sideWidth * 40, sideHeight * 40);
            InitializeGrid(); //Initialize Cell (Buttons)
            InitializeProperties(); //Initialize Properties which is used to set default again.
        }

        private void InitializeGrid()
        {
            Size sizeCell = new Size(40, 40);
            Point locationCell = new Point(0, GamePanel.Height);
            Font fontCell = new Font("Calibri", 18);
            //Initialize Grid
            for (int row = 0; row < sideHeight; row++)
            {
                for (short col = 0; col < sideWidth; col++)
                {
                    #region Cells Properties
                    cells[row, col] = new Button();
                    cells[row, col].Name = "Cell" + (row * sideWidth + col);
                    cells[row, col].Font = fontCell;
                    cells[row, col].Size = sizeCell;
                    cells[row, col].Location = locationCell;
                    cells[row, col].FlatStyle = FlatStyle.Flat;
                    cells[row, col].BackColor = Color.Green;
                    cells[row, col].BackgroundImageLayout = ImageLayout.Stretch;
                    cells[row, col].MouseDown += new System.Windows.Forms.MouseEventHandler(CellButton_MouseClick);
                    #endregion

                    Controls.Add(cells[row, col]);
                    locationCell.X += 40;
                }
                locationCell.X = 0;
                locationCell.Y += 40;
            }
        }

        private void InitializeProperties()
        {
            ShowBombCount.Text = bombCount.ToString();
            freeCellsCount = 0;
        }

        private void CellButton_MouseClick(object sender, MouseEventArgs e)
        {
            Button cell = (Button)sender;

            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (cell.BackgroundImage == null && cell.Text == "")
                {
                    cell.BackgroundImage = Properties.Resources.Flag;
                    ShowBombCount.Text = (short.Parse(ShowBombCount.Text) - 1).ToString();
                }
                else
                {
                    cell.BackgroundImage = null;
                    ShowBombCount.Text = (short.Parse(ShowBombCount.Text) + 1).ToString();
                }
            }
            else
            {
                PlayTimeTimer.Enabled = true;
                cellClick(cell); //Show numbers from NumberGrid class
            }
        }

        private void cellClick(Button cell)
        {
            short value = short.Parse(cell.Name.Substring(4, cell.Name.Length - 4)); //value = row * sideWidth + col......
            short row = (short)(value / sideWidth);
            short col = (short)(value % sideWidth);
            short cellValue = numGrid.grid[row, col];

            if (cellValue == 0) //No any bomb surround
            {
                freeCellsCount++;
                clearZeroCells(row, col);
                checkWin();
            }
            else if (cellValue >= 99) //Clicked on a bomb
            {
                if (freeCellsCount == 0 && !retry) //First click
                {
                    numGrid = new NumberGrid();
                    cellClick(cell);
                    return;
                }

                //Not the first click (Defeat - Lose the game)
                loseTheGame();
            }
            else //Not 0 or not a bomb
            {
                showNumberOnCell(cell, cellValue);
                freeCellsCount++;
            }

            checkWin();
        }

        private void showNumberOnCell(Button cell, short cellValue)
        {
            cell.Text = cellValue.ToString(); //Set Value of the cell
            cell.Enabled = false;
            cell.BackColor = Color.LimeGreen;
        }

        private void clearZeroCells(short row, short col)
        {
            cells[row, col].Enabled = false;
            cells[row, col].BackColor = Color.LimeGreen;

            for (short i = -1; i <= 1; i++)
            {
                for (short j = -1; j <= 1; j++)
                {
                    try
                    {
                        if (cells[row + i, col + j].Enabled && numGrid.grid[row + i, col + j] == 0)
                        {
                            clearZeroCells((short)(row + i), (short)(col + j));
                            freeCellsCount++;
                        }
                        else if (cells[row + i, col + j].Enabled)
                        {
                            showNumberOnCell(cells[row + i, col + j], numGrid.grid[row + i, col + j]);
                            freeCellsCount++;
                        }
                    }
                    catch (IndexOutOfRangeException) { }
                }
            }
        }

        private void showBombs()
        {
            for (int i = 0; i < bombCount; i++)
            {
                Button cell = cells[numGrid.bombs[i] / sideWidth, numGrid.bombs[i] % sideWidth];
                cell.Image = Properties.Resources.Bomb;
                cell.BackColor = Color.Red;
            }
        }

        private void checkWin()
        {
            if (freeCellsCount == sideHeight * sideWidth - bombCount)
            {
                PlayTimeTimer.Enabled = false;
                showBombs();
                MessageBox.Show("You win the game......................\n" +
                    "...................................", "You Win.", MessageBoxButtons.OK);

                ResultSheet score = new ResultSheet();
                score.setDetails(gameType, playTime);
                score.ShowDialog();

                Close();
            }
        }

        private void loseTheGame()
        {
            PlayTimeTimer.Enabled = false;
            showBombs();

            DialogResult retryOrCancel = loseMsg.ShowDialog();

            //New Game
            if (retryOrCancel == DialogResult.OK)
            {
                removeCells();
                InitializeGrid();
                InitializeProperties();
                numGrid = new NumberGrid();
                TimeShow.Text = "00:00:00";
                playTime = TimeSpan.FromSeconds(0);
                retry = false;
            }

            //Retry
            else if (retryOrCancel == DialogResult.Retry)
            {
                removeCells();
                InitializeGrid();
                InitializeProperties();
                retry = true;
            }

            //Cancel
            else
            {
                Close();
            }
        }

        private void PlayTimeTimer_Tick(object sender, EventArgs e)
        {
            playTime += TimeSpan.FromSeconds(1);
            TimeShow.Text = playTime.ToString();
        }

        private void removeCells()
        {
            for (int i = 0; i < sideHeight; i++)
            {
                for (int j = 0; j < sideWidth; j++)
                {
                    this.Controls.Remove(cells[i, j]);
                }
            }
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            PausePanel.Visible = true;
            PlayTimeTimer.Enabled = false;
            PauseButton.Visible = false;
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            PausePanel.Visible = false;
            if (freeCellsCount != 0) PlayTimeTimer.Enabled = true;
            PauseButton.Visible = true;
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            senderForm.SetResultValues();
            senderForm.Show();
        }
    }
}
