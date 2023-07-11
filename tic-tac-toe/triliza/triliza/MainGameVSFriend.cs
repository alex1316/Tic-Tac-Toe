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
    public partial class MainGameVSFriend : Form
    {
        int dimensions = 0, X = 24, Y = 107, FormX = 375, FormY = 430, tag = 0; //Oi arxikes times einai gia tin forma 3x3, stin arxi eixa valei paragonta 3x3 alla meta ton evgala, oi times eminan giati einai swstes kai pali
        int seconds = 0;
        Boolean Player1Plays = true;
        string Player1name, Player2name;
        List<string> WhatIS = new List<string>();

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++; //Metritis xronou
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenu = new MainMenuForm();
            mainMenu.Show();
            this.Hide();
        }

        int length;

        public MainGameVSFriend(string Player1Name, string Player2Name,int Dimensions)
        {
            InitializeComponent();
            Player1NameLabel.Text = Player1Name;
            Player2NameLabel.Text = Player2Name;
            WhoPlaysLabel.Text = Player1Name;
            this.dimensions = Dimensions;
            this.Player1name = Player1Name;
            this.Player2name = Player2Name;
        }

        private void MainGameVSFriend_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MainGameVSFriend_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < dimensions; i++) //Dimiourgia swstis formas me vasi tis diastaseis kai topothetisi koumpiwn
            {
                for (int z = 0; z < dimensions; z++)
                {
                    Button button = new Button();
                    button.Size = new Size(102, 82);
                    button.Location = new Point(X, Y);
                    button.TabStop = false;
                    button.Tag = tag;
                    WhatIS.Add("NONE"); //Oti koumpi den exei patithe ara den exei X h O mesa exei tin timi NONE stin lista WhatIS pou to synolo tis einai oso kai ta koumpia
                    button.Click += myButton_Click;
                    this.Controls.Add(button);
                    X = X + 108;
                    tag++; //To tag to xrisimopoiw ws ID gia na kserw pio koumpi patithike ara na kserw tin thesi tou kai mesa stin lista WhatIS
                }
                Y = Y + 88; //Swsti topothetisi twn koumpiwn
                X = 24;
            }
            length = WhatIS.Count;
            if (dimensions > 3) //Dimiourgia tis formas oso megali xreiazete me vasi tis diastaseis
            {
                for (int i = 0; i < dimensions - 3; i++)
                {
                    FormX = FormX + 115;
                    FormY = FormY + 86;
                }
            }
            this.Size = new Size(FormX, FormY);
        }
        void myButton_Click(object sender, EventArgs e)
        {
            Boolean XWins = false, OWins = false;
            if (Player1Plays)
            {
                XWins=FindWinnerClass.Main(sender, WhoPlaysLabel, Player1name, Player2name, dimensions, WhatIS, timer1, seconds,"X",false); //kalesma tis klasis pou vriskei an nikise o ekastote paixths
                Player1Plays = false;
                if (XWins)
                {
                    this.Hide();
                }
            }
            else
            {
                OWins= FindWinnerClass.Main(sender, WhoPlaysLabel, Player1name, Player2name, dimensions, WhatIS, timer1, seconds, "O",false);
                Player1Plays = true;
                if (OWins)
                {
                    this.Hide();
                }
            }
            if (WhatIS.Contains("NONE") == false && !XWins && !OWins) //An einai isopalia
            {
                Draw draw = new Draw(Player1name, Player2name, seconds, dimensions,false); //Kalesma tis formas pou vgazei oti yparxei isopalia
                draw.Show();
                this.Hide();
            }
        }
    }
}
