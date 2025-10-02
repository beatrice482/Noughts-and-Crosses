using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace noughts_and_crosses
{
    public partial class Form1 : Form
    {
        int[] gridLayout = {0,0,0,0,0,0,0,0,0}; 
        bool playersTurn; 

        public Form1()
        {
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            playersTurn = true; //player 1s turn 
            lbl_game.Text = "Player 1's Turn"; lbl_game.Refresh(); 
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if(gridLayout[0] == 0)
            {
                if(playersTurn) //player 1s turn
                {
                    gridLayout[0] = 1;
                    btn_1.Text = "X"; btn_1.Refresh();
                    if(!anyWinner(gridLayout))
                    {
                        playersTurn = false; //change to player 2's turn
                        lbl_game.Text = "Player 2's Turn"; lbl_game.Refresh();
                    }
                    else
                    {
                        lbl_game.Text = "Player 1 Wins!"; lbl_game.Refresh();
                        for (int i = 0; i < 9; i++)
                        {
                            if (gridLayout[i] == 0)
                            {
                                gridLayout[i] = 1;
                            }
                        }
                    }
                    
                }
                else //player 2s turn
                {
                    gridLayout[0] = 2;
                    btn_1.Text = "0"; btn_1.Refresh();
                    if (!anyWinner(gridLayout))
                    {
                        playersTurn = true; //change to player 1's turn
                        lbl_game.Text = "Player 1's Turn"; lbl_game.Refresh();
                    }
                    else
                    {
                        lbl_game.Text = "Player 2 Wins!"; lbl_game.Refresh();
                        for (int i = 0; i < 9; i++)
                        {
                            if (gridLayout[i] == 0)
                            {
                                gridLayout[i] = 1;
                            }
                        }
                    }
                }
            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (gridLayout[1] == 0)
            {
                if (playersTurn) //player 1s turn
                {
                    gridLayout[1] = 1;
                    btn_2.Text = "X"; btn_2.Refresh();
                    if (!anyWinner(gridLayout))
                    {
                        playersTurn = false; //change to player 2's turn
                        lbl_game.Text = "Player 2's Turn"; lbl_game.Refresh();
                    }
                    else
                    {
                        lbl_game.Text = "Player 1 Wins!"; lbl_game.Refresh();
                        for (int i = 0; i < 9; i++)
                        {
                            if (gridLayout[i] == 0)
                            {
                                gridLayout[i] = 1;
                            }
                        }
                    }
                }
                else //player 2s turn
                {
                    gridLayout[1] = 2;
                    btn_2.Text = "0"; btn_2.Refresh();
                    if (!anyWinner(gridLayout))
                    {
                        playersTurn = true; //change to player 1's turn
                        lbl_game.Text = "Player 1's Turn"; lbl_game.Refresh();
                    }
                    else
                    {
                        lbl_game.Text = "Player 2 Wins!"; lbl_game.Refresh();
                        for (int i = 0; i < 9; i++)
                        {
                            if (gridLayout[i] == 0)
                            {
                                gridLayout[i] = 1;
                            }
                        }
                    }
                }
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (gridLayout[2] == 0)
            {
                if (playersTurn) //player 1s turn
                {
                    gridLayout[2] = 1;
                    btn_3.Text = "X"; btn_3.Refresh();
                    if (!anyWinner(gridLayout))
                    {
                        playersTurn = false; //change to player 2's turn
                        lbl_game.Text = "Player 2's Turn"; lbl_game.Refresh();
                    }
                    else
                    {
                        lbl_game.Text = "Player 1 Wins!"; lbl_game.Refresh();
                        for (int i = 0; i < 9; i++)
                        {
                            if (gridLayout[i] == 0)
                            {
                                gridLayout[i] = 1;
                            }
                        }
                    }
                }
                else //player 2s turn
                {
                    gridLayout[2] = 2;
                    btn_3.Text = "0"; btn_3.Refresh();
                    if (!anyWinner(gridLayout))
                    {
                        playersTurn = true; //change to player 1's turn
                        lbl_game.Text = "Player 1's Turn"; lbl_game.Refresh();
                    }
                    else
                    {
                        lbl_game.Text = "Player 2 Wins!"; lbl_game.Refresh();
                        for (int i = 0; i < 9; i++)
                        {
                            if (gridLayout[i] == 0)
                            {
                                gridLayout[i] = 1;
                            }
                        }
                    }
                }
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (gridLayout[3] == 0)
            {
                if (playersTurn) //player 1s turn
                {
                    gridLayout[3] = 1;
                    btn_4.Text = "X"; btn_4.Refresh();
                    if (!anyWinner(gridLayout))
                    {
                        playersTurn = false; //change to player 2's turn
                        lbl_game.Text = "Player 2's Turn"; lbl_game.Refresh();
                    }
                    else
                    {
                        lbl_game.Text = "Player 1 Wins!"; lbl_game.Refresh();
                        for (int i = 0; i < 9; i++)
                        {
                            if (gridLayout[i] == 0)
                            {
                                gridLayout[i] = 1;
                            }
                        }
                    }
                }
                else //player 2s turn
                {
                    gridLayout[3] = 2;
                    btn_4.Text = "0"; btn_4.Refresh();
                    if (!anyWinner(gridLayout))
                    {
                        playersTurn = true; //change to player 1's turn
                        lbl_game.Text = "Player 1's Turn"; lbl_game.Refresh();
                    }
                    else
                    {
                        lbl_game.Text = "Player 2 Wins!"; lbl_game.Refresh();
                        for (int i = 0; i < 9; i++)
                        {
                            if (gridLayout[i] == 0)
                            {
                                gridLayout[i] = 1;
                            }
                        }
                    }
                }
            }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (gridLayout[4] == 0)
            {
                if (playersTurn) //player 1s turn
                {
                    gridLayout[4] = 1;
                    btn_5.Text = "X"; btn_5.Refresh();
                    if (!anyWinner(gridLayout))
                    {
                        playersTurn = false; //change to player 2's turn
                        lbl_game.Text = "Player 2's Turn"; lbl_game.Refresh();
                    }
                    else
                    {
                        lbl_game.Text = "Player 1 Wins!"; lbl_game.Refresh();
                        for (int i = 0; i < 9; i++)
                        {
                            if (gridLayout[i] == 0)
                            {
                                gridLayout[i] = 1;
                            }
                        }
                    }
                }
                else //player 2s turn
                {
                    gridLayout[4] = 2;
                    btn_5.Text = "0"; btn_5.Refresh();
                    if (!anyWinner(gridLayout))
                    {
                        playersTurn = true; //change to player 1's turn
                        lbl_game.Text = "Player 1's Turn"; lbl_game.Refresh();
                    }
                    else
                    {
                        lbl_game.Text = "Player 2 Wins!"; lbl_game.Refresh();
                        for (int i = 0; i < 9; i++)
                        {
                            if (gridLayout[i] == 0)
                            {
                                gridLayout[i] = 1;
                            }
                        }
                    }
                }
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (gridLayout[5] == 0)
            {
                if (playersTurn) //player 1s turn
                {
                    gridLayout[5] = 1;
                    btn_6.Text = "X"; btn_6.Refresh();
                    if (!anyWinner(gridLayout))
                    {
                        playersTurn = false; //change to player 2's turn
                        lbl_game.Text = "Player 2's Turn"; lbl_game.Refresh();
                    }
                    else
                    {
                        lbl_game.Text = "Player 1 Wins!"; lbl_game.Refresh();
                        for (int i = 0; i < 9; i++)
                        {
                            if (gridLayout[i] == 0)
                            {
                                gridLayout[i] = 1;
                            }
                        }
                    }
                }
                else //player 2s turn
                {
                    gridLayout[5] = 2;
                    btn_6.Text = "0"; btn_6.Refresh();
                    if (!anyWinner(gridLayout))
                    {
                        playersTurn = true; //change to player 1's turn
                        lbl_game.Text = "Player 1's Turn"; lbl_game.Refresh();
                    }
                    else
                    {
                        lbl_game.Text = "Player 2 Wins!"; lbl_game.Refresh();
                        for (int i = 0; i < 9; i++)
                        {
                            if (gridLayout[i] == 0)
                            {
                                gridLayout[i] = 1;
                            }
                        }
                    }
                }
            }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (gridLayout[6] == 0)
            {
                if (playersTurn) //player 1s turn
                {
                    gridLayout[6] = 1;
                    btn_7.Text = "X"; btn_7.Refresh();
                    if (!anyWinner(gridLayout))
                    {
                        playersTurn = false; //change to player 2's turn
                        lbl_game.Text = "Player 2's Turn"; lbl_game.Refresh();
                    }
                    else
                    {
                        lbl_game.Text = "Player 1 Wins!"; lbl_game.Refresh();
                        for (int i = 0; i < 9; i++)
                        {
                            if (gridLayout[i] == 0)
                            {
                                gridLayout[i] = 1;
                            }
                        }
                    }
                }
                else //player 2s turn
                {
                    gridLayout[6] = 2;
                    btn_7.Text = "0"; btn_7.Refresh();
                    if (!anyWinner(gridLayout))
                    {
                        playersTurn = true; //change to player 1's turn
                        lbl_game.Text = "Player 1's Turn"; lbl_game.Refresh();
                    }
                    else
                    {
                        lbl_game.Text = "Player 2 Wins!"; lbl_game.Refresh();
                        for (int i = 0; i < 9; i++)
                        {
                            if (gridLayout[i] == 0)
                            {
                                gridLayout[i] = 1;
                            }
                        }
                    }
                }
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (gridLayout[7] == 0)
            {
                if (playersTurn) //player 1s turn
                {
                    gridLayout[7] = 1;
                    btn_8.Text = "X"; btn_8.Refresh();
                    if (!anyWinner(gridLayout))
                    {
                        playersTurn = false; //change to player 2's turn
                        lbl_game.Text = "Player 2's Turn"; lbl_game.Refresh();
                    }
                    else
                    {
                        lbl_game.Text = "Player 1 Wins!"; lbl_game.Refresh();
                        for (int i = 0; i < 9; i++)
                        {
                            if (gridLayout[i] == 0)
                            {
                                gridLayout[i] = 1;
                            }
                        }
                    }
                }
                else //player 2s turn
                {
                    gridLayout[7] = 2;
                    btn_8.Text = "0"; btn_8.Refresh();
                    if (!anyWinner(gridLayout))
                    {
                        playersTurn = true; //change to player 1's turn
                        lbl_game.Text = "Player 1's Turn"; lbl_game.Refresh();
                    }
                    else
                    {
                        lbl_game.Text = "Player 2 Wins!"; lbl_game.Refresh();
                        for (int i = 0; i < 9; i++)
                        {
                            if (gridLayout[i] == 0)
                            {
                                gridLayout[i] = 1;
                            }
                        }
                    }
                }
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (gridLayout[8] == 0)
            {
                if (playersTurn) //player 1s turn
                {
                    gridLayout[8] = 1;
                    btn_9.Text = "X"; btn_9.Refresh();
                    if (!anyWinner(gridLayout))
                    {
                        playersTurn = false; //change to player 2's turn
                        lbl_game.Text = "Player 2's Turn"; lbl_game.Refresh();
                    }
                    else
                    {
                        lbl_game.Text = "Player 1 Wins!"; lbl_game.Refresh();
                        for (int i = 0; i < 9; i++)
                        {
                            if (gridLayout[i] == 0)
                            {
                                gridLayout[i] = 1;
                            }
                        }
                    }
                }
                else //player 2s turn
                {
                    gridLayout[8] = 2;
                    btn_9.Text = "0"; btn_9.Refresh();
                    if (!anyWinner(gridLayout))
                    {
                        playersTurn = true; //change to player 1's turn
                        lbl_game.Text = "Player 1's Turn"; lbl_game.Refresh();
                    }
                    else
                    {
                        lbl_game.Text = "Player 2 Wins!"; lbl_game.Refresh();

                        for (int i = 0; i < 9; i++)
                        {
                            if(gridLayout[i] == 0)
                            {
                                gridLayout[i] = 1;
                            }
                        }
                    }
                }
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {

            for(int i = 0; i < 9; i++)
            {
                gridLayout[i] = 0;
            }

            btn_1.Text = ""; btn_1.Refresh();
            btn_2.Text = ""; btn_2.Refresh();
            btn_3.Text = ""; btn_3.Refresh();
            btn_4.Text = ""; btn_4.Refresh();
            btn_5.Text = ""; btn_5.Refresh();
            btn_6.Text = ""; btn_6.Refresh();
            btn_7.Text = ""; btn_7.Refresh();
            btn_8.Text = ""; btn_8.Refresh();
            btn_9.Text = ""; btn_9.Refresh();

            lbl_game.Text = "Player 1's Turn"; lbl_game.Refresh();
            playersTurn = true; 
        }

        private static bool anyWinner(int[] gridLayout)
        {

            for(int i = 0; i < gridLayout.Length; i ++)
            {
                if(i == 0 || i == 3 || i == 6)
                {
                    if(gridLayout[i] == gridLayout[i+1] && gridLayout[i] == gridLayout[i+2] && gridLayout[i] != 0)
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


    }
}
