using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mine_Sweeper
{
    class NumberGrid
    {
        public short[,] grid = new short[Game.sideHeight, Game.sideWidth]; //Grid that contain actual numbers
        public short[] bombs = new short[Game.bombCount];
        short bombsCount = 0; //Bombs count that set while runing the game first time
        Random rndm = new Random();

        public NumberGrid()
        {
            for (short i = 0; i < Game.bombCount; i++)
            {
                setOneBomb();
            }
        }

        private void setOneBomb()
        {
            short theBomb = (short)rndm.Next(0, Game.sideHeight * Game.sideWidth - 1);

            #region Avoid Repeatition of Bombs
            for (int i = 0; i < bombsCount; i++)
            {
                if (bombs[i] == theBomb)
                {
                    setOneBomb();
                    return;
                }
            }
            #endregion

            bombs[bombsCount] = (short) theBomb;
            setGrid();
            bombsCount++; //Add bombs after set grid
        }

        private void setGrid()
        {
            short row = (short)(bombs[bombsCount] / Game.sideWidth);
            short col = (short) (bombs[bombsCount] % Game.sideWidth);

            grid[row, col] = 99; //Set bomb as 99

            #region Set values arround the Bomb
            for (short i = -1; i <= 1; i++)
            {
                for (short j = -1; j <= 1; j++)
                {
                    try
                    {
                        grid[row + i, col + j]++;
                    }
                    catch (IndexOutOfRangeException) { }
                }
            }
            #endregion
        }
    }
}
