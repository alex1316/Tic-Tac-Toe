using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace triliza
{
    class PCChoiceClass
    {
        public static Boolean Main(object sender, Label WhoPlaysLabel, string PlayerName, int dimensions, List<string> WhatIS, Timer timer1, int seconds)
        {
            int countO = 0; //O  ypologistis paizei panta me to symbolo "O", mia ekseliksh tou programmatos tha mporouse na htan na epilegei o xristis an thelei to X h to O
            Boolean PCWins = false, PCPlays = true ;
            Button button = (Button)sender;
            button.BackgroundImage = Properties.Resources.circle;
            button.BackgroundImageLayout = ImageLayout.Stretch;
            WhoPlaysLabel.Text = PlayerName;
            button.Enabled = false;
            if (button.Tag != null)
            {
                int ButtonID = Int32.Parse(button.Tag.ToString());
                WhatIS[ButtonID] = "O";
            }
            for (int i = 0; i < WhatIS.Count; i++) //Eutheia
            {
                if (i % dimensions == 0)
                {
                    countO = 0;
                }
                if (WhatIS[i] == "O")
                {
                    countO++;
                }
                else if (WhatIS[i] != "O")
                {
                    countO = 0;
                }
                if (countO == dimensions)
                {
                    PCWins = true;
                    break;
                }
            }
            countO = 0;
            for (int i = 0; i < WhatIS.Count - dimensions; i++) //Katheta
            {
                for (int z = i; z < WhatIS.Count; z = z + dimensions)
                {
                    if (WhatIS[z] == "O")
                    {
                        countO++;
                    }
                    else if (WhatIS[z] != "O")
                    {
                        countO = 0;
                    }
                    if (countO == dimensions)
                    {
                        PCWins = true;
                        break;
                    }
                }
                if (PCWins)
                {
                    break;
                }
                countO = 0;
            }
            for (int i = 0; i < WhatIS.Count - (dimensions * (dimensions - 1)); i++) //Plagia deksia
            {
                for (int z = i; z < WhatIS.Count; z = z + dimensions + 1)
                {
                    if (WhatIS[z] == "O")
                    {
                        countO++;

                    }
                    else if (WhatIS[z] != "O")
                    {
                        countO = 0;

                    }
                    if (countO == dimensions)
                    {
                        PCWins = true;
                        break;
                    }
                }
                if (PCWins)
                {
                    break;
                }
                countO = 0;
            }
            int cases = 1;
            int counter = 0;
            for (int i = 0; i < WhatIS.Count; i++) //plagia aristera
            {
                for (int z = i; z < WhatIS.Count; z = z + (dimensions - 1))
                {
                    counter++;
                    if (!(counter > cases))
                    {
                        if (WhatIS[z] == "O")
                        {
                            countO++;
                        }
                        else if (WhatIS[z] != "O")
                        {
                            countO = 0;
                        }
                        if (countO == dimensions)
                        {
                            PCWins = true;
                            break;
                        }
                    }
                }
                if (PCWins)
                {
                    break;
                }
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
            if (PCWins)
            {
                timer1.Enabled = false;
                Win win = new Win(PlayerName, "PC", "O", seconds, dimensions,PCPlays);
                win.Show();
            }
            return PCWins;
        }
    }
}
