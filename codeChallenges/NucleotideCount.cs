using System;
using System.Collections.Generic;
using System.Text;

namespace codeChallenges
{
    public static class NucleotideCount
    {
        public static IDictionary<char, int> Count(string sequence)
        {
            Dictionary<char, int> nucleoDict =
               new Dictionary<char, int>();
            nucleoDict['A'] = 0;
            nucleoDict['C'] = 0;
            nucleoDict['G'] = 0;
            nucleoDict['T'] = 0;

            foreach (char ele in sequence)
            {
                if (nucleoDict.ContainsKey(ele))
                {
                    nucleoDict[ele]++;
                }
                else throw new ArgumentException();
            }
            return nucleoDict;
        }
    }
}
