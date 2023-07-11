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
    public partial class Draw : Form //Gia isopalia
    {
        string Player1Name, Player2Name;
        int Seconds, minutes, Dimensions;
        Boolean PCplays = false;

        private void PlayAgainButton_Click(object sender, EventArgs e)
        {
            if (PCplays)
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

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenu = new MainMenuForm();
            mainMenu.Show();
            this.Hide();
        }

        public Draw(string player1, string player2, int sec, int dimensions,Boolean PCPlays)
        {
            InitializeComponent();
            this.Player1Name = player1;
            this.Player2Name = player2;
            this.Seconds = sec;
            this.Dimensions = dimensions;
            this.PCplays = PCPlays;
            minutes = sec / 60;
            Seconds = sec % 60;
            TimeLabel.Text = TimeLabel.Text + minutes.ToString() + " λεπτά και " + Seconds.ToString() + " δευτερόλεπτα";
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
