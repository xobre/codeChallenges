using System;
using System.Collections.Generic;
using System.Text;

namespace codeChallenges
{
    class ResistorColors
    {
        enum ColorEnum { black, brown, red, orange, yellow, green, blue, violet, grey, white };
        public static int ColorCode(string color)
        {
            return (int)Enum.Parse(typeof(ColorEnum), color, true);
        }

        public static string[] Colors()
        {
            string[] ColorArray = Enum.GetNames(typeof(ColorEnum));
            return ColorArray;
        }
    }
}
