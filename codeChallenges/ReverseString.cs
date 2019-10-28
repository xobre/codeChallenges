using System;
using System.Collections.Generic;
using System.Text;

namespace codeChallenges
{
    class ReverseString
    {
        public static string Reverse(string input)
        {        
            if (input == null) return null;
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string (charArray);
        }
    }
}
