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
    public partial class MainGameVSPC : Form
    {
        string PlayerName="";
        int dimensions = 0, X = 24, Y = 107, FormX = 375, FormY = 430, seconds=0, tag=0;
        Boolean PlayerPlays = true;
        List<string> WhatIS = new List<string>();
        List<Button> Buttons = new List<Button>();
        Random rnd = new Random();
        private void MainGameVSPC_Load(object sender, EventArgs e)
        {
            
            for (int i = 0; i < dimensions; i++)
            {
                for (int z = 0; z < dimensions; z++)
                {
                    Button button = new Button();
                    button.Size = new Size(102, 82);
                    button.Location = new Point(X, Y);
                    button.TabStop = false;
                    button.Tag = tag;
                    WhatIS.Add("NONE");
                    button.Click += myButton_Click;
                    Buttons.Add(button);
                    this.Controls.Add(button);
                    X = X + 108;
                    tag++;
                }
                Y = Y + 88;
                X = 24;
            }
            if (dimensions > 3)
            {
                for (int i = 0; i < dimensions - 3; i++)
                {
                    FormX = FormX + 115;
                    FormY = FormY + 86;
                }
            }
            this.Size = new Size(FormX, FormY);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
        }

        public MainGameVSPC(string Playername,int Dimensions)
        {
            InitializeComponent();
            Player1NameLabel.Text = Playername;
            WhoPlaysLabel.Text = Playername;
            this.PlayerName = Playername;
            this.dimensions = Dimensions;
        }
        void myButton_Click(object sender, EventArgs e)
        {
            Boolean XWins = false, PCWins = false; 
            if (PlayerPlays) //Praktika to if tha mporouse na min yparxei alla theorw oti etsi einai pio eukola na to diavasei kapoios
            {
                XWins = FindWinnerClass.Main(sender, WhoPlaysLabel, PlayerName, "PC", dimensions, WhatIS, timer1, seconds, "X",true);
                if (XWins)
                {
                    this.Hide();
                }
                else //An den nikise o paixtis tote paizei o ypologistis
                {
                    int select = rnd.Next(0, Buttons.Count - 1);
                    while (Buttons[select].Enabled == false && WhatIS.Contains("NONE")) //Xwris auto to while o ypologistis tha eixe to dikawma na vazei O panw se X to opoio einai lathos
                    {
                        select = rnd.Next(0, Buttons.Count - 1);
                    }
                    if (WhatIS.Contains("NONE"))
                    {
                        PCWins = PCChoiceClass.Main(Buttons[select], WhoPlaysLabel, PlayerName, dimensions, WhatIS, timer1, seconds); //Kalesma klasis pou vriskei gia to an ypologistis nikise
                        if (PCWins)
                        {
                            this.Hide();
                        }
                    }
                }
            }
            if (WhatIS.Contains("NONE") == false && !XWins && !PCWins) //isopalia
            {
                Draw draw = new Draw(PlayerName, "PC", seconds, dimensions,true);
                draw.Show();
                this.Hide();
            }
        }

            private void MainGameVSPC_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenu = new MainMenuForm();
            mainMenu.Show();
            this.Hide();
        }
    }
}
