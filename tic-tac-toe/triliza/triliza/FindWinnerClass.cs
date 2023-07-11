using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace triliza
{
    public class FindWinnerClass
    {
        public static Boolean Main(object sender,Label WhoPlaysLabel, string Player1name, string Player2name,int dimensions,List<string> WhatIS,Timer timer1,int seconds,string XorO,Boolean PCplays)
        {
            int countX = 0, countO = 0;
            Boolean XWins = false, OWins = false,PCPlays = PCplays;
            Button button = (Button)sender;
            if (XorO == "X") //Elegxos gia ton an paizei to X h to O
            {
                button.BackgroundImage = Properties.Resources.x; //Topethetisi tis swstis eikonas sto koumpi
            }
            else
            {
                button.BackgroundImage = Properties.Resources.circle;
            }
            button.BackgroundImageLayout = ImageLayout.Stretch;
            if (XorO == "X")
            {
                WhoPlaysLabel.Text = Player2name;
            }
            else
            {
                WhoPlaysLabel.Text = Player1name;
            }
            button.Enabled = false; //To kanw disable to koumpi giati einai enas tropos wste na mhn mporei na ksana patithei
            if (button.Tag != null)
            {
                int ButtonID = Int32.Parse(button.Tag.ToString()); //Twra pleon kserw tin thesi tou sygkekrimeno koympiou stin lista pou periexei to periexomeno (X h O h NONE) olwn twn koumpiwn
                WhatIS[ButtonID] = XorO; //Kai topothetw se auti tin lista kai stin swsti thesi pleon to X h to O
            }
            for (int i = 0; i < WhatIS.Count; i++) //Vriskw gia to an nikise eutheia
            {
                if (i % dimensions == 0)
                {
                    if (XorO == "X")
                    {
                        countX = 0;
                    }
                    else
                    {
                        countO = 0;
                    }
                }
                if (WhatIS[i] == XorO)
                {
                    if (XorO == "X")
                    {
                        countX++;
                    }
                    else
                    {
                        countO++;
                    }
                    
                }
                else if (WhatIS[i] != XorO)
                {
                    if (XorO == "X")
                    {
                        countX = 0;
                    }
                    else
                    {
                        countO = 0;
                    }
                }
                if (countX == dimensions || countO == dimensions)
                {
                    if (XorO == "X")
                    {
                        XWins = true;
                    }
                    else
                    {
                        OWins = true;
                    }
                    break;
                }
            }
            countX = 0;
            countO = 0;
            for (int i = 0; i < WhatIS.Count - dimensions; i++) //An nikise katheta
            {
                for (int z = i; z < WhatIS.Count; z = z + dimensions)
                {
                    if (WhatIS[z] == XorO)
                    {
                        if (XorO == "X")
                        {
                            countX++;
                        }
                        else
                        {
                            countO++;
                        }
                    }
                    else if (WhatIS[z] != XorO)
                    {
                        if (XorO == "X")
                        {
                            countX = 0;
                        }
                        else
                        {
                            countO = 0;
                        }
                    }
                    if (countX == dimensions || countO == dimensions)
                    {
                        if (XorO == "X")
                        {
                            XWins = true;
                        }
                        else
                        {
                            OWins = true;
                        }
                        break;
                    }
                }
                if (XWins || OWins)
                {
                    break;
                }
                countX = 0;
                countO = 0;
            }
            for (int i = 0; i < WhatIS.Count - (dimensions * (dimensions - 1)); i++) //An nikise plagia deksia
            {
                for (int z = i; z < WhatIS.Count; z = z + dimensions + 1)
                {
                    if (WhatIS[z] == XorO)
                    {
                        if (XorO == "X")
                        {
                            countX++;
                        }
                        else
                        {
                            countO++;
                        }
                        
                    }
                    else if (WhatIS[z] != XorO)
                    {
                        if (XorO == "X")
                        {
                            countX = 0;
                        }
                        else
                        {
                            countO = 0;
                        }

                    }
                    if (countX == dimensions || countO == dimensions)
                    {
                        if (XorO == "X")
                        {
                            XWins = true;
                        }
                        else
                        {
                            OWins = true;
                        }
                        break;
                    }
                }
                if (XWins || OWins)
                {
                    break;
                }
                countX = 0;
                countO = 0;
            }
            int cases = 1;
            int counter = 0;
            for (int i = 0; i < WhatIS.Count; i++) //An nikise plagia aristera
            {
                for (int z = i; z < WhatIS.Count; z = z + (dimensions - 1))
                {
                    counter++;
                    if (!(counter > cases))
                    {
                        if (WhatIS[z] == XorO)
                        {
                            if (XorO == "X")
                            {
                                countX++;
                            }
                            else
                            {
                                countO++;
                            }
                            
                        }
                        else if (WhatIS[z] != XorO)
                        {
                            if (XorO == "X")
                            {
                                countX = 0;
                            }
                            else
                            {
                                countO = 0;
                            }
                        }
                        if (countX == dimensions || countO == dimensions)
                        {
                            if (XorO == "X")
                            {
                                XWins = true;
                            }
                            else
                            {
                                OWins = true;
                            }
                            break;
                        }
                    }
                }
                if (XWins || OWins)
                {
                    break;
                }
                countX = 0;
                countO = 0;
                counter = 0;
                if (cases % (dimensions) == 0)
                {
                    cases = 1;
                }
                else
                {
                    cases++;
                }
            }
            if (XWins || OWins) //An exei kerdisei
            {
                timer1.Enabled = false; //Kleinw kai ton timer giati den yparxei pleon logos na metraei
                if (XorO == "X") //Tote emfanizw tin forma pou deixnei oti nikise
                {
                    Win win = new Win(Player1name, Player2name, "X", seconds, dimensions,PCPlays);
                    win.Show();
                }
                else
                {
                    Win win = new Win(Player1name, Player2name, "O", seconds, dimensions,PCPlays);
                    win.Show();
                }
            }
            if (XorO == "X")
            {
                return XWins;
            }
            else
            {
                return OWins;
            }
            
        }
    }
}
