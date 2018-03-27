using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI1
{
    public partial class Form1 : Form
    {

        bool turn = true; //x turn = true , 0 turn = false; 
        int turn_count = 0;
        public Form1()
        {
            InitializeComponent();
        
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A game for two players, X and O, who take turns marking the spaces in a 3×3 grid. The player who succeeds in placing three of their marks in a horizontal, vertical, or diagonal row wins the game. Have fun!", "RULES");


        }

   

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Click(object sender, EventArgs e)
        {
            
            Button button = (Button)sender;
            if (turn==true)
            {
                button.Text = "X";
            }
            else
            {
                button.Text = "0";
            }

            turn = !turn;
            turn_count++;
            button.Enabled = false;


            CheckWinner();
          
        }


        private void CheckWinner()
        {
            bool winner = false;

            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                winner = true;
            else
           if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                winner = true;
            else
            if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                winner = true;
            else
             if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                winner = true;
            else
            if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                winner = true;
            else
            if
                ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                winner = true;

            else
            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                winner = true;
            else
            if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled))
                winner = true;

           if (winner == true)
            {
                DisableAllButtons();
                string winnerName = "";

                if (turn == true)
                    winnerName = "0";
                else
                    winnerName = "X";

                MessageBox.Show(winnerName + " Won! Yey!");

            }
            else
            {
                if (turn_count == 9)
                {
                    MessageBox.Show("Tie");
                }
            }
           
        }

        private void DisableAllButtons()
        {
            try
            {

                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;

            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
            }
            catch { }

        }
    }
}
