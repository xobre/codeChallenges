using System;
using System.Collections.Generic;
using System.Text;

namespace codeChallenges
{
    class RNA
    {
        public static string ToRna(string nucleotide)
        {
            string result = "";
            if (nucleotide == "") return result;
            for (int i = 0; i < nucleotide.Length; i++)
            {
                if (nucleotide[i] == 'C') result += "G";
                else if (nucleotide[i] == 'G') result += "C";
                else if (nucleotide[i] == 'T') result += "A";
                else if (nucleotide[i] == 'A') result += "U";
            }
            return result;
        }
    }
}
