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
       

        public Form1()
        {
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

  
            
        }

        private void btn_2Player_Click(object sender, EventArgs e)
        {
            Form2 play = new Form2(false);
            this.Hide();
            play.ShowDialog();
           
        }

        private void btn_AI_Click(object sender, EventArgs e)
        {
            Form2 play = new Form2(true);
            this.Hide();
            play.ShowDialog();
        }
    }
}
