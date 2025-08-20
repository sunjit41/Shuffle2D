using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Shuffle2D
{
    internal class GameBoard
    {
        private int[] GameValues =new int[16];
        private bool GameStarted { get; set; }
        public int GameMoves { get; set; }
        private const int EmptyPosition = 16;


        public GameBoard()
        {
            for (int i = 0; i < 15; i++)
            {
                GameValues[i] = i + 1;
            }
            GameStarted = false;
            GameMoves = 0;
        }

        public int[] Shuffle()
        {
            if (!GameStarted)
            {
                StartGame();
            }
            int i = 0, j = 0, NewRandom = 0;
            bool NumberAlreadyExists = false;

            GameMoves = 0;

            while (i < 16)
            {
                GameValues[i] = i;
                i++;
            }

            // Getting a random positions
            i = 0;
            while (i < 16)
            {
                NewRandom = new Random().Next(1, 17);
                NumberAlreadyExists = false;
                for (j = 0; j < i; j++)
                {
                    if (GameValues[j] == NewRandom)
                    {
                        NumberAlreadyExists = true;
                        break;
                    }
                }
                if (!NumberAlreadyExists)
                {
                    GameValues[i] = NewRandom;
                    i++;
                }
            }
            return GameValues;
        }

        public int CheckMove(int FromPosition)
        {
            if(GameStarted)
            {
                switch (FromPosition)
                {
                    case 1:     // Checking 2 & 5
                        if( GameValues[1] == EmptyPosition)
                        {
                            SwapValues(0, 1);
                            return 2;
                        }
                        else if( GameValues[4] == EmptyPosition)
                        {
                            SwapValues(0, 4);
                            return 5;
                        }
                        break;
                    case 2:     // Checking 1, 3 & 6
                        if (GameValues[0] == EmptyPosition)
                        {
                            SwapValues(1, 0);
                            return 1;
                        }
                        else if (GameValues[2] == EmptyPosition)
                        {
                            SwapValues(1, 2);
                            return 3;
                        }
                        else if (GameValues[5] == EmptyPosition)
                        {
                            SwapValues(1, 5);
                            return 6;
                        }

                        break;
                    case 3:    // Checking 2, 4 & 7
                        if (GameValues[1] == EmptyPosition)
                        {
                            SwapValues(2, 1);
                            return 2;
                        }
                        else if (GameValues[3] == EmptyPosition)
                        {
                            SwapValues(2, 3);
                            return 4;
                        }
                        else if (GameValues[6] == EmptyPosition)
                        {
                            SwapValues(2, 6);
                            return 7;
                        }
                        break;
                    case 4:    // Checking 3 & 8
                        if (GameValues[2] == EmptyPosition)
                        {
                            SwapValues(3, 2);
                            return 3;
                        }
                        else if (GameValues[7] == EmptyPosition)
                        {
                            SwapValues(3, 7);
                            return 8;
                        }
                        break;
                    case 5:    // Checking 1, 6 & 9
                        if (GameValues[0] == EmptyPosition)
                        {
                            SwapValues(4, 0);
                            return 1;
                        }
                        else if (GameValues[5] == EmptyPosition)
                        {
                            SwapValues(4, 5);
                            return 6;
                        }
                        else if (GameValues[8] == EmptyPosition)
                        {
                            SwapValues(4, 8);
                            return 9;
                        }
                        break;
                    case 6:    // Checking 2, 5, 7 & 10
                        if (GameValues[1] == EmptyPosition)
                        {
                            SwapValues(5, 1);
                            return 2;
                        }
                        else if (GameValues[4] == EmptyPosition)
                        {
                            SwapValues(5, 4);
                            return 5;
                        }
                        else if (GameValues[6] == EmptyPosition)
                        {
                            SwapValues(5, 6);
                            return 7;
                        }
                        else if (GameValues[9] == EmptyPosition)
                        {
                            SwapValues(5, 9);
                            return 10;
                        }
                        break;
                    case 7:    // Checking 3, 6, 8 & 11
                        if (GameValues[2] == EmptyPosition)
                        {
                            SwapValues(6, 2);
                            return 3;
                        }
                        else if (GameValues[5] == EmptyPosition)
                        {
                            SwapValues(6, 5);
                            return 6;
                        }
                        else if (GameValues[7] == EmptyPosition)
                        {
                            SwapValues(6, 7);
                            return 8;
                        }
                        else if (GameValues[10] == EmptyPosition)
                        {
                            SwapValues(6, 10);
                            return 11;
                        }
                        break;
                    case 8:    // Checking 4, 7 & 12
                        if (GameValues[3] == EmptyPosition)
                        {
                            SwapValues(7, 3);
                            return 4;
                        }
                        else if (GameValues[6] == EmptyPosition)
                        {
                            SwapValues(7, 6);
                            return 7;
                        }
                        else if (GameValues[11] == EmptyPosition)
                        {
                            SwapValues(7, 11);
                            return 12;
                        }
                        break;
                    case 9:    // Checking 5, 10 & 13
                        if (GameValues[4] == EmptyPosition)
                        {
                            SwapValues(8, 4);
                            return 5;
                        }
                        else if (GameValues[9] == EmptyPosition)
                        {
                            SwapValues(8, 9);
                            return 10;
                        }
                        else if (GameValues[12] == EmptyPosition)
                        {
                            SwapValues(8, 12);
                            return 13;
                        }
                        break;
                    case 10:   // Checking 6, 9, 11 & 14
                        if (GameValues[5] == EmptyPosition)
                        {
                            SwapValues(9, 5);
                            return 6;
                        }
                        else if (GameValues[8] == EmptyPosition)
                        {
                            SwapValues(9, 8);
                            return 9;
                        }
                        else if (GameValues[10] == EmptyPosition)
                        {
                            SwapValues(9, 10);
                            return 11;
                        }
                        else if (GameValues[13] == EmptyPosition)
                        {
                            SwapValues(9, 13);
                            return 14;
                        }
                        break;
                    case 11:   // Checking 7, 10, 12 & 15
                        if (GameValues[6] == EmptyPosition)
                        {
                            SwapValues(10, 6);
                            return 7;
                        }
                        else if (GameValues[9] == EmptyPosition)
                        {
                            SwapValues(10, 9);
                            return 10;
                        }
                        else if (GameValues[11] == EmptyPosition)
                        {
                            SwapValues(10, 11);
                            return 12;
                        }
                        else if (GameValues[14] == EmptyPosition)
                        {
                            SwapValues(10, 14);
                            return 15;
                        }
                        break;
                    case 12:   // Checking 8, 11 & 16
                        if (GameValues[7] == EmptyPosition)
                        {
                            SwapValues(11, 7);
                            return 8;
                        }
                        else if (GameValues[10] == EmptyPosition)
                        {
                            SwapValues(11, 10);
                            return 11;
                        }
                        else if (GameValues[15] == EmptyPosition)
                        {
                            SwapValues(11, 15);
                            return 16;
                        }
                        break;
                    case 13:   // Checking 9 & 14
                        if (GameValues[8] == EmptyPosition)
                        {
                            SwapValues(12, 8);
                            return 9;
                        }
                        else if (GameValues[13] == EmptyPosition)
                        {
                            SwapValues(12, 13);
                            return 14;
                        }
                        break;
                    case 14:   // Checking 10, 13 & 15
                        if (GameValues[9] == EmptyPosition)
                        {
                            SwapValues(13, 9);
                            return 10;
                        }
                        else if (GameValues[12] == EmptyPosition)
                        {
                            SwapValues(13, 12);
                            return 13;
                        }
                        else if (GameValues[14] == EmptyPosition)
                        {
                            SwapValues(13, 14);
                            return 15;
                        }
                        break;
                    case 15:   // Checking 11, 14 & 16
                        if (GameValues[10] == EmptyPosition)
                        {
                            SwapValues(14, 10);
                            return 11;
                        }
                        else if (GameValues[13] == EmptyPosition)
                        {
                            SwapValues(14, 13);
                            return 14;
                        }
                        else if (GameValues[15] == EmptyPosition)
                        {
                            SwapValues(14, 15);
                            return 16;
                        }
                        break;
                    case 16:   // Checking 12, 15
                        if (GameValues[11] == EmptyPosition)
                        {
                            SwapValues(15, 11);
                            return 12;
                        }
                        else if (GameValues[14] == EmptyPosition)
                        {
                            SwapValues(15, 14);
                            return 15;
                        }
                        break;
                }
            }
            return -1;
        }

        private void SwapValues(int SwapPosition, int EmptySpace)
        {
            int temp = GameValues[SwapPosition];
            GameValues[SwapPosition] = GameValues[EmptySpace];
            GameValues[EmptySpace] = temp;
            GameMoves++;
        }

        public void StartGame()
        {
            GameStarted = true;
        }

        private void EndGame()
        {
            GameStarted = false;
        }

        public bool CheckForWin()
        {
            int SuccessCount = 0;
            for (int i = 0; i < 15; i++)
            {
                if (GameValues[i] == (i + 1))
                {
                    SuccessCount++;
                }
            }
            if (SuccessCount == 15)
            {
                EndGame();
                return true;
            }
            return false;
        }
    }
}
