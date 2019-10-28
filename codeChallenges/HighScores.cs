using System;
using System.Collections.Generic;
using System.Text;

namespace codeChallenges
{
    class HighScores
    {
        public List<int> hsList;
        public HighScores(List<int> list)
        {
            hsList = list;
        }

        public List<int> Scores()
        {
            return hsList;
        }

        public int Latest()
        {
            int last = hsList[hsList.Count - 1];
            return last;
        }

        public int PersonalBest()
        {
            int best = 0;
            for (int i = 0; hsList.Count - 1 > i; i++)
            {
                if (best < hsList[i])
                {
                    best = hsList[i];
                }
            }
            return best;

        }

        public List<int> PersonalTopThree()
        {
            int i, j;
            int N = hsList.Count;

            for (j = N - 1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    if (hsList[i] < hsList[i + 1])
                    {
                        int temporary;

                        temporary = hsList[i];
                        hsList[i] = hsList[i + 1];
                        hsList[i + 1] = temporary;
                    }
                }
            }
            if (hsList.Count >= 3)
            {
                List<int> topthree = new List<int> { hsList[0], hsList[1], hsList[2] };
                return topthree;
            }
            else if (hsList.Count == 2)
            {
                List<int> topthree = new List<int> { hsList[0], hsList[1] };
                return topthree;
            }
            else if (hsList.Count == 1)
            {
                List<int> topthree = new List<int> { hsList[0] };
                return topthree;
            }
            return null;
        }
    }
}
