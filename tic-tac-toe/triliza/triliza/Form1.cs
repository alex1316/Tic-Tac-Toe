using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//Antonis Ekatommatis | P18039

namespace triliza
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void FriendSelect_CheckedChanged(object sender, EventArgs e)
        {
            SetNamePlayer2Label.Visible = true;
            Player2Name.Visible = true;

        }

        private void PCSelect_CheckedChanged(object sender, EventArgs e)
        {
            SetNamePlayer2Label.Visible = false; //Ennalagi an o xristis epileksei na paiksei enantion PC na min emfanizete to na valei onoma 2ou paixth
            Player2Name.Visible = false;
        }

        private void DimensionText_TextChanged(object sender, EventArgs e)
        {
            DimensionMirror.Text = DimensionText.Text; 
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            var isNumeric = int.TryParse(DimensionText.Text, out int number);
            Boolean isOK = true;
            if (PCSelect.Checked) //Elegxos gia to an epelekse na paiksei enantion ypologisth kai elegxos akaireotitas dedomenwn
            {
                if (Player1Name.Text == "" || DimensionText.Text == "")
                {
                    MessageBox.Show("Προσοχή! Κάποιο πεδίο είναι κενό!");
                }
                else if (isNumeric)
                {
                    if (number <= 3)
                    {
                        MessageBox.Show("Οι διαστάσεις είναι λάθος! Δώσε αριθμό μεγαλύτερο του 3!");
                        isOK = false;
                    }
                    else if (number % 2 == 0)
                    {
                        MessageBox.Show("Οι διαστάσεις είναι λάθος! Δώσε περιττό αριθμό! (π.χ. 5, 7, κ.λπ)");
                        isOK = false;
                    }
                    else if (isOK)
                    {
                        MainGameVSPC mainGameVSPC = new MainGameVSPC(Player1Name.Text,number);
                        mainGameVSPC.Show();
                        this.Hide();
                    }
                }
            }
            else if (FriendSelect.Checked) //elegxos gia an epelkse o xristis na paiksei enantion filou
            {
                if (Player1Name.Text == "" || DimensionText.Text == "" || Player2Name.Text == "")
                {
                    MessageBox.Show("Προσοχή! Κάποιο πεδίο είναι κενό!");
                }
                else if (isNumeric)
                {
                    if (number <= 3)
                    {
                        MessageBox.Show("Οι διαστάσεις είναι λάθος! Δώσε αριθμό μεγαλύτερο του 3!");
                        isOK = false;
                    }
                    else if (number % 2 == 0)
                    {
                        MessageBox.Show("Οι διαστάσεις είναι λάθος! Δώσε περιττό αριθμό! (π.χ. 5, 7, κ.λπ)");
                        isOK = false;
                    }
                    else if (isOK)
                    {
                        MainGameVSFriend mainGameVSFriend = new MainGameVSFriend(Player1Name.Text,Player2Name.Text,number);
                        mainGameVSFriend.Show();
                        this.Hide();
                    }
                }
            }
        }

        private void εναντίονΦίλουToolStripMenuItem_Click(object sender, EventArgs e) //MenuStrip
        {
            FriendSelect.Checked = true;
        }

        private void εναντίονΥπολογιστήToolStripMenuItem1_Click(object sender, EventArgs e) //MenuStrip
        {
            PCSelect.Checked = true;
        }
    }
}
