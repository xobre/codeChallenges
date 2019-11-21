using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace codeChallenges
{
    class Pangram
    {
        public static bool IsPangram(string input)
        {
            if (input == "") return false;
            input = input.ToLower();
            Regex rgx = new Regex("[^a-z]");
            input = rgx.Replace(input, "");
            HashSet<char> hash = new HashSet<char>(input);
            if (hash.Count < 26) return false;
            else return true;
        }
    }
}
