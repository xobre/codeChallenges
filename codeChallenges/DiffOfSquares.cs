using System;
using System.Collections.Generic;
using System.Text;

namespace codeChallenges
{
    class DiffOfSquares
    {
        public static int CalculateSquareOfSum(int max)
        {   //square of the sum (0 - N)^2
            int temp = 0;
            while (max > 0)
            {
                temp += max;
                max--;
            }
            int result = temp * temp;
            return result;
        }

        public static int CalculateSumOfSquares(int max)
        {   //sum of square 1^2 + - + N^2
            int temp = 0;
            while (max > 0)
            {
                temp += max * max;
                max--;
            }
            return temp;
        }

        public static int CalculateDifferenceOfSquares(int max)
        {
            return Math.Abs(CalculateSumOfSquares(max) - CalculateSquareOfSum(max));
        }
    }
}
