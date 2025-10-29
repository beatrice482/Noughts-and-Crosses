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
    public partial class Form3 : Form
    {
        public Form3(int player)
        {
            InitializeComponent();
            lbl_winner.Text = "Player " + player + " Wins!";
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
