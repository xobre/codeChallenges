using System;
using System.Collections.Generic;
using System.Text;

namespace codeChallenges
{
    class Armstrong
    {
        public static bool IsArmstrongNumber(int number)
        {
            List<int> remainders = new List<int>();
            int sum = 0;
            int count = 0;
            int n = number;

            while (n > 0)
            {
                remainders.Add(n % 10);
                n /= 10;
                count++;
            }

            foreach (var el in remainders)
            {
                sum += (int)Math.Pow(el, count);
            }

            if (sum == number)
            {
                return true;
            }
            return false;
        }
    }
}
