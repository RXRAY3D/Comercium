﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class ThemeColor
    {
        public static Color PrimaryColor { get; set; }
        public static Color SecondaryColor { get; set; }

        public static List<string> ColorList = new List<string> {
                                                    "#3F51B5",
                                                    "#009688",
                                                    "#FF5722",
                                                    "#607D8B",
                                                    "#FF9800",
                                                    "#9C27B0",
                                                    "#2196F3",
                                                    "#EA676C",
                                                    "#E41A4A",
                                                    "#5978BB",
                                                    "#018790",
                                                    "#0E3441",
                                                    "#00B0AD",
                                                    "#721D47",
                                                    "#EA4833",
                                                    "#F37521",
                                                    "#A12059",
                                                    "#126881",
                                                    "#8BC240",
                                                    "#364D5B",
                                                    "#C7DC5B",
                                                    "#0094BC",
                                                    "#E4126B",
                                                    "#43B76E",
                                                    "#7BCFE9",
                                                    "#B71C46"};
        public static Color ChangeColorBright(Color color, double correctionfactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            if (correctionfactor < 0)
            {
                correctionfactor = 1 + correctionfactor;
                red *= correctionfactor;
                green *= correctionfactor;
                blue *= correctionfactor;

            }
            else
            {
                red = (255 - red) * correctionfactor + red;
                green = (255 - green) * correctionfactor + green;
                blue = (255 - blue) * correctionfactor + blue;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
     }

}
