using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace triliza
{
    public partial class Win : Form
    {
        string Player1Name, Player2Name, XorO;
        int Seconds,minutes,Dimensions;
        Boolean PCplays = false;

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenu = new MainMenuForm();
            mainMenu.Show();
            this.Hide();
        }

        public Win(string player1,string player2,string what,int sec,int dimensions,Boolean PCPlays)
        {
            InitializeComponent();
            this.Player1Name = player1;
            this.Player2Name = player2;
            this.XorO = what;
            this.Seconds = sec;
            this.Dimensions = dimensions;
            this.PCplays = PCPlays;
            if (what == "X") //An nikise o X tote emfanizw sto label to onoma tou X
            {
                WhoWonLabel.Text = WhoWonLabel.Text + Player1Name;
            }
            else //Alliws to onoma tou O
            {
                WhoWonLabel.Text = WhoWonLabel.Text + Player2Name;
            }
            XorOlabel.Text = XorOlabel.Text + XorO;
            minutes = sec / 60; //Metatropi deuteroloptwn se lepta
            Seconds = sec % 60; //Metatropi sta deuterolepta pou apeminan apo ta lepta
            TimeLabel.Text = TimeLabel.Text + minutes.ToString() + " λεπτά και " + Seconds.ToString() + " δευτερόλεπτα"; //Emfanish tou xronou

        }

        private void PlayAgainButton_Click(object sender, EventArgs e)
        {
            if (PCplays) //Auth h metavliti yparxei gia na kseroume sto playagain koumpi an prepei na epistrepsoume sto paixnidi enantiou filou h ypologisti
            {
                MainGameVSPC mainGameVSPC = new MainGameVSPC(Player1Name, Dimensions);
                mainGameVSPC.Show();
                this.Hide();
            }
            else
            {
                MainGameVSFriend mainGameVSFriend = new MainGameVSFriend(Player1Name, Player2Name, Dimensions);
                mainGameVSFriend.Show();
                this.Hide();
            }
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Win_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
