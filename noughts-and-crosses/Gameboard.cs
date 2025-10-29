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
    }
}
