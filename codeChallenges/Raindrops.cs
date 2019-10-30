using System;
using System.Collections.Generic;
using System.Text;

namespace codeChallenges
{
    class Raindrops
    {
        public static string Convert(int number)
        {
            string String = "";
            bool Factor = false;
            if (number % 3 == 0)
            {
                Factor = true;
                String += "Pling";
            }
            if (number % 5 == 0)
            {
                Factor = true;
                String += "Plang";
            }
            if (number % 7 == 0)
            {
                Factor = true;
                String += "Plong";
            }
            if (Factor == false) return number.ToString();
            
            return String;
        }
    }
}
