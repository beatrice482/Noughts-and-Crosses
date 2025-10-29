using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noughts_and_crosses
{
    class Gameboard
    {
        private int[] gridLayout = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private int PlayersTurn;
        private bool AI;
        private int buttonNo;

        public Gameboard(bool ai)
        {
            AI = ai;
            PlayersTurn = 1;
        }

        public int playerMove(int playersTurn, int[] gridLayout,int buttonNo)
        {
            if (gridLayout[buttonNo] == 0)
            {

                 gridLayout[buttonNo] = playersTurn;

                 return playersTurn;
                 
            }

            return 0;
            
        }

        public int AIMove(int[] gridLayout, int playersTurn)
        {
            int[] positions = { 0, 1, 2, 0, 3, 6, 0, 4, 8, 1, 4,7,2,4,6,2,5,8,3,4,5,6,7,8 };
            List<int>[] listArray = new List<int>[8];


            for (int i = 0; i < listArray.Length; i++)
            {
                listArray[i] = new List<int>();
            }

            listArray[0].Add(gridLayout[0]);
            listArray[0].Add(gridLayout[1]);
            listArray[0].Add(gridLayout[2]);

            listArray[1].Add(gridLayout[0]);
            listArray[1].Add(gridLayout[3]);
            listArray[1].Add(gridLayout[6]);

            listArray[2].Add(gridLayout[0]);
            listArray[2].Add(gridLayout[4]);
            listArray[2].Add(gridLayout[8]);

            listArray[3].Add(gridLayout[1]);
            listArray[3].Add(gridLayout[4]);
            listArray[3].Add(gridLayout[7]);

            listArray[4].Add(gridLayout[2]);
            listArray[4].Add(gridLayout[4]);
            listArray[4].Add(gridLayout[6]);

            listArray[5].Add(gridLayout[2]);
            listArray[5].Add(gridLayout[5]);
            listArray[5].Add(gridLayout[8]);

            listArray[6].Add(gridLayout[3]);
            listArray[6].Add(gridLayout[4]);
            listArray[6].Add(gridLayout[5]);

            listArray[7].Add(gridLayout[6]);
            listArray[7].Add(gridLayout[7]);
            listArray[7].Add(gridLayout[8]);

            int playerSymbolCount = 0;
            int spaceCount = 0;
            int spacePosition = 100;
            int count = 0;
            //check if you can win on this move 
            for (int i = 0; i < listArray.Length; i++)
            {
                foreach (int num in listArray[i])
                {
                    if (num == playersTurn)
                    {
                        playerSymbolCount++;
                    }
                    else if (num == 0)
                    {
                        spaceCount++;
                        spacePosition = positions[count];
                    }

                    if (spaceCount == 1 && playerSymbolCount == 2)
                    {
                        gridLayout[spacePosition] = playersTurn;
                        return spacePosition;
                    }
                    count++;
                }
                playerSymbolCount = 0;
                spaceCount = 0;
                spacePosition = 100;
            }
            //check if opponent can win on their next move 
            int opponentTurn = getOpponentsTurn();
            playerSymbolCount = 0;
            spaceCount = 0;
            spacePosition = 100;
            count = 0;

            for (int i = 0; i < listArray.Length; i++)
            {
                foreach (int num in listArray[i])
                {
                    if (num == opponentTurn)
                    {
                        playerSymbolCount++;
                    }
                    else if (num == 0)
                    {
                        spaceCount++;
                        spacePosition = positions[count];
                    }

                    if (spaceCount == 1 && playerSymbolCount == 2)
                    {
                        gridLayout[spacePosition] = playersTurn;
                        return spacePosition;
                    }
                    count++;
                }
                playerSymbolCount = 0;
                spaceCount = 0;
                spacePosition = 100;
            }
            //check if centre is available
            if (gridLayout[4] == 0)
            {
                gridLayout[4] = playersTurn;
                return 4;
            }
            //check if a corner is available 
            if (gridLayout[0] == 0)
            {
                gridLayout[0] = playersTurn;
                return 0;
            }
            else if (gridLayout[2] == 0)
            {
                gridLayout[2] = playersTurn;
                return 2;
            }
            else if (gridLayout[6] == 0)
            {
                gridLayout[6] = playersTurn;
                return 6;
            }
            else if (gridLayout[8] == 0)
            {
                gridLayout[8] = playersTurn;
                return 8;
            }
            //take a side 
            for (int i = 0; i < gridLayout.Length; i++)
            {
                if(gridLayout[i] == 0)
                {
                    gridLayout[i] = playersTurn;
                    return i;
                }
            }
            return 0;

        }

        public bool anyWinner(int[] gridLayout)
        {
            for (int i = 0; i < gridLayout.Length; i++)
            {
                if (i == 0 || i == 3 || i == 6)
                {
                    if (gridLayout[i] == gridLayout[i + 1] && gridLayout[i] == gridLayout[i + 2] && gridLayout[i] != 0)
                    {
                        return true;
                    }
                }

                if (i == 0 || i == 1 || i == 2)
                {
                    if (gridLayout[i] == gridLayout[i + 3] && gridLayout[i] == gridLayout[i + 6] && gridLayout[i] != 0)
                    {
                        return true;
                    }
                }
            }

            if (gridLayout[0] == gridLayout[4] && gridLayout[0] == gridLayout[8] && gridLayout[0] != 0)
            {
                return true;
            }

            if (gridLayout[2] == gridLayout[4] && gridLayout[2] == gridLayout[6] && gridLayout[2] != 0)
            {
                return true;
            }

            return false;
        }

        public void changePlayer()
        {
            if(PlayersTurn == 1)
            {
                PlayersTurn = 2;
            }
            else
            {
                PlayersTurn = 1;
            }
        }

        public void reset()
        {
            for (int i = 0; i < 9; i++)
            {
                gridLayout[i] = 0;
            }
            PlayersTurn = 1;
        }

        public int[] getGridLayout()
        {
            return gridLayout;
        }

        public int getPlayersTurn()
        {
            return PlayersTurn; 
        }

        public int getOpponentsTurn()
        {
            if (getPlayersTurn() == 1)
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }

        public bool getAI()
        {
            return AI;
        }
    }
}
