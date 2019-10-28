using System;
using System.Collections.Generic;
using System.Text;

namespace codeChallenges
{
    class Hamming
    {
        public static int Distance(string firstStrand, string secondStrand)
        {
            int difference = 0;
            if (firstStrand.Length != secondStrand.Length)
            {
                throw new ArgumentException();
            }
            for (int i = 0; i < firstStrand.Length; i++)
            {
                if (firstStrand[i] != secondStrand[i])
                {
                    difference++;
                }
            }
            return difference;
        }
    }
}
