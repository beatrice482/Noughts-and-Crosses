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
    public partial class Form2 : Form
    {
        private Gameboard gameboard;


        public Form2(bool AI)
        {
            InitializeComponent();
            gameboard = new Gameboard(AI);
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            int[] gridLayout = gameboard.getGridLayout();
            int playersTurn = gameboard.getPlayersTurn();
            int temp = gameboard.playerMove(playersTurn, gridLayout, 0);

            if (temp != 0)
            {
                if (temp == 1)
                {
                    btn_1.Text = "X";
                }
                else
                {
                    btn_1.Text = "0";
                }

                gridLayout = gameboard.getGridLayout();

                if (gameboard.getAI())
                {
                    gameboard.changePlayer();
                    playersTurn = gameboard.getPlayersTurn();
                    int choice = gameboard.AIMove(gridLayout, playersTurn);
                    makeAIMove(choice, playersTurn);
                 
                }

                if (gameboard.anyWinner(gridLayout))
                {
                    Form3 playerWon = new Form3(playersTurn);
                    playerWon.ShowDialog();
                    reset();
                }
                else 
                {
                    gameboard.changePlayer();
                }

              
            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            int[] gridLayout = gameboard.getGridLayout();
            int playersTurn = gameboard.getPlayersTurn();
            int temp = gameboard.playerMove(playersTurn, gridLayout, 1);

            if (temp != 0)
            {
                if (temp == 1)
                {
                    btn_2.Text = "X";
                }
                else
                {
                    btn_2.Text = "0";
                }
                gridLayout = gameboard.getGridLayout();

                if (gameboard.getAI())
                {
                    gameboard.changePlayer();
                    playersTurn = gameboard.getPlayersTurn();
                    int choice = gameboard.AIMove(gridLayout, playersTurn);
                    makeAIMove(choice, playersTurn);
                  
                }

                if (gameboard.anyWinner(gridLayout))
                {
                    Form3 playerWon = new Form3(playersTurn);
                    playerWon.ShowDialog();
                    reset();
                }
                else 
                {
                    gameboard.changePlayer();
                }

            
            }
           
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            int[] gridLayout = gameboard.getGridLayout();
            int playersTurn = gameboard.getPlayersTurn();
            int temp = gameboard.playerMove(playersTurn, gridLayout, 2);

            if (temp != 0)
            {
                if (temp == 1)
                {
                    btn_3.Text = "X";
                }
                else
                {
                    btn_3.Text = "0";
                }
                gridLayout = gameboard.getGridLayout();
                if (gameboard.getAI())
                {
                    gameboard.changePlayer();
                    playersTurn = gameboard.getPlayersTurn();
                    int choice = gameboard.AIMove(gridLayout, playersTurn);
                    makeAIMove(choice, playersTurn);
                  
                }

                if (gameboard.anyWinner(gridLayout))
                {
                    Form3 playerWon = new Form3(playersTurn);
                    playerWon.ShowDialog();
                    reset();
                }
                else
                {
                    gameboard.changePlayer();
                }

              
            }
           
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            int[] gridLayout = gameboard.getGridLayout();
            int playersTurn = gameboard.getPlayersTurn();
            int temp = gameboard.playerMove(playersTurn, gridLayout, 3);

            if (temp!= 0)
            {
                if (temp == 1)
                {
                    btn_4.Text = "X";
                }
                else
                {
                    btn_4.Text = "0";
                }
                gridLayout = gameboard.getGridLayout();
                if (gameboard.getAI())
                {
                    gameboard.changePlayer();
                    playersTurn = gameboard.getPlayersTurn();
                    int choice = gameboard.AIMove(gridLayout, playersTurn);
                    makeAIMove(choice, playersTurn);
    
                }

                if (gameboard.anyWinner(gridLayout))
                {
                    Form3 playerWon = new Form3(playersTurn);
                    playerWon.ShowDialog();
                    reset();
                }
                else 
                {
                    gameboard.changePlayer();
                }

            
            }
           
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            int[] gridLayout = gameboard.getGridLayout();
            int playersTurn = gameboard.getPlayersTurn();
            int temp = gameboard.playerMove(playersTurn, gridLayout, 4);

            if (temp != 0)
            {
                if (temp == 1)
                {
                    btn_5.Text = "X";
                }
                else
                {
                    btn_5.Text = "0";
                }
                gridLayout = gameboard.getGridLayout();
                if (gameboard.getAI())
                {
                    gameboard.changePlayer();
                    playersTurn = gameboard.getPlayersTurn();
                    int choice = gameboard.AIMove(gridLayout, playersTurn);
                    makeAIMove(choice, playersTurn);
              
                }

                if (gameboard.anyWinner(gridLayout))
                {
                    Form3 playerWon = new Form3(playersTurn);
                    playerWon.ShowDialog();
                    reset();
                }
                else 
                {
                    gameboard.changePlayer();
                }

             
            }
          
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            int[] gridLayout = gameboard.getGridLayout();
            int playersTurn = gameboard.getPlayersTurn();
            int temp = gameboard.playerMove(playersTurn, gridLayout, 5);

            if (temp != 0)
            {
                if (temp == 1)
                {
                    btn_6.Text = "X";
                }
                else
                {
                    btn_6.Text = "0";
                }
                gridLayout = gameboard.getGridLayout();
                if (gameboard.getAI())
                {
                    gameboard.changePlayer();
                    playersTurn = gameboard.getPlayersTurn();
                    int choice = gameboard.AIMove(gridLayout, playersTurn);
                    makeAIMove(choice, playersTurn);
                 
                }

                if (gameboard.anyWinner(gridLayout))
                {
                    Form3 playerWon = new Form3(playersTurn);
                    playerWon.ShowDialog();
                    reset();
                }
                else 
                {
                    gameboard.changePlayer();
                }


            }
         
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            int[] gridLayout = gameboard.getGridLayout();
            int playersTurn = gameboard.getPlayersTurn();
            int temp = gameboard.playerMove(playersTurn, gridLayout, 6);

            if ( temp != 0)
            {
                if (temp == 1)
                {
                    btn_7.Text = "X";
                }
                else
                {
                    btn_7.Text = "0";
                }
                gridLayout = gameboard.getGridLayout();

                if (gameboard.getAI())
                {
                    gameboard.changePlayer();
                    playersTurn = gameboard.getPlayersTurn();
                    int choice = gameboard.AIMove(gridLayout, playersTurn);
                    makeAIMove(choice, playersTurn);
                  
                }

                if (gameboard.anyWinner(gridLayout))
                {
                    Form3 playerWon = new Form3(playersTurn);
                    playerWon.ShowDialog();
                    reset();
                }
                else 
                {
                    gameboard.changePlayer();
                }

            }
            
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            int[] gridLayout = gameboard.getGridLayout();
            int playersTurn = gameboard.getPlayersTurn();
            int temp = gameboard.playerMove(playersTurn, gridLayout, 7);

            if (temp != 0)
            {
                if (temp == 1)
                {
                    btn_8.Text = "X";
                }
                else
                {
                    btn_8.Text = "0";
                }
                gridLayout = gameboard.getGridLayout();
                if (gameboard.getAI())
                {
                    gameboard.changePlayer();
                    playersTurn = gameboard.getPlayersTurn();
                    int choice = gameboard.AIMove(gridLayout, playersTurn);
                    makeAIMove(choice, playersTurn);
                  
                }

                if (gameboard.anyWinner(gridLayout))
                {
                    Form3 playerWon = new Form3(playersTurn);
                    playerWon.ShowDialog();
                    reset();
                }
                else 
                {
                    gameboard.changePlayer();
                }


            }
            
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            int[] gridLayout = gameboard.getGridLayout();
            int playersTurn = gameboard.getPlayersTurn();
            int temp = gameboard.playerMove(playersTurn, gridLayout, 8);

            if (temp != 0)
            {
                if (temp == 1)
                {
                    btn_9.Text = "X";
                }
                else
                {
                    btn_9.Text = "0";
                }
                gridLayout = gameboard.getGridLayout();
                if (gameboard.getAI())
                {
                    gameboard.changePlayer();
                    playersTurn = gameboard.getPlayersTurn();
                    int choice = gameboard.AIMove(gridLayout, playersTurn);
                    makeAIMove(choice, playersTurn);
                   
                }

                if (gameboard.anyWinner(gridLayout))
                {
                    Form3 playerWon = new Form3(playersTurn);
                    playerWon.ShowDialog();
                    reset();
                }
                else 
                {
                    gameboard.changePlayer();
                }

             
            }
         
        }

        private void reset()
        {
            btn_1.Text = ""; btn_1.Refresh();
            btn_2.Text = ""; btn_2.Refresh();
            btn_3.Text = ""; btn_3.Refresh();
            btn_4.Text = ""; btn_4.Refresh();
            btn_5.Text = ""; btn_5.Refresh();
            btn_6.Text = ""; btn_6.Refresh();
            btn_7.Text = ""; btn_7.Refresh();
            btn_8.Text = ""; btn_8.Refresh();
            btn_9.Text = ""; btn_9.Refresh();

            gameboard.reset();
        }

        private void makeAIMove(int choice, int playersTurn)
        {
            string symbol; 

            if (playersTurn == 1)
            {
                symbol = "X";
            }
            else
            {
                symbol = "0";
            }

            if (choice == 0)
            {
                btn_1.Text = symbol;
            }
            else if (choice == 1)
            {
                btn_2.Text = symbol;
            }
            else if (choice == 2)
            {
                btn_3.Text = symbol; 
            }
            else if (choice == 3)
            {
                btn_4.Text = symbol;
            }
            else if (choice == 4)
            {
                btn_5.Text = symbol;
            }
            else if (choice == 5)
            {
                btn_6.Text = symbol;
            }
            else if (choice == 6)
            {
                btn_7.Text = symbol;
            }
            else if (choice == 7)
            {
                btn_8.Text = symbol;
            }
            else if (choice == 8)
            {
                btn_9.Text = symbol;
            }

        }
    }
}
