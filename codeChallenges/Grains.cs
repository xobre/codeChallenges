using System;
using System.Collections.Generic;
using System.Text;

namespace codeChallenges
{
    public static class Grains
    {
        public static ulong Square(int n)
        {
            ulong sum = 0;
            ulong count = 0;

            if (n <= 0 || n > 64)
            {
                throw new ArgumentOutOfRangeException();
            }

            else
            {
                count = Convert.ToUInt64(n);
                for (ulong i = 1; i <= count; i++)
                {
                    sum += i;
                    --count;
                    while (count != 0)
                    {
                        sum = sum * 2;
                        --count;
                    }
                }
            }
            return sum;
        }

        public static ulong Total()
        {
            ulong newSum = 0;
            for (int i = 1; i <= 64; i ++)
            {
                newSum += Square(i) + Square(++i);
            }
            return newSum;
        }
    }
}

