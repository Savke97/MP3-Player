using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3_Player
{
    public static class ThemeColor
    {
        public static List<String> listaBoja = new List<string>()
        {
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
            "#EF937E",
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
            "#B71C46"
        };
        // Funkcija za odredjivanje osvedljenosti rendom boje koje je dotata
        public static Color PromeniOsvetljenjeBoje(Color color, double osvetljenje)
        {
                double red = color.R;
                double green = color.G;
                double blue = color.B;

            if(osvetljenje < 0)
            {
                osvetljenje = 1 + osvetljenje;
                red *= osvetljenje;
                green *= osvetljenje;
                blue *= osvetljenje;
            }
            else
            {
                red = (255 - red) * osvetljenje + red;
                green = (255 - green) * osvetljenje + green;
                blue = (255 - blue) * osvetljenje + blue;
            }

            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }
}
