using System;
using System.Collections.Generic;
using System.Text;

namespace codeChallenges
{
    public static class CollatzConjecture
    {
        public static int Steps(int number, int count = 0)
        {
            if (number < 1)
            {
                throw new ArgumentException();
            }
            if (number == 1)
            {
                return (count);
            }
            else if (number % 2 == 0)
            {
                number = number / 2;
                count++;
                Steps(number, count);
            }
            else
            {
                number = number * 3 + 1;
                count++;
                Steps(number, count);
            }
            return count;
        }
    }
}
