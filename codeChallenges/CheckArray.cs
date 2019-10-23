using System;
using System.Collections.Generic;
using System.Text;

namespace codeChallenges
{
    class CheckArray
    {
        public static void IfOdd()
        {
            int[] origArray = { 2, 4, 7, 8, 6 };
            int count = 0;
            for (int i = 0; i < origArray.Length; i++)
            {
                if (origArray[i] % 2 != 0)
                {
                    count++;
                }
            }
            if (count >= 1)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
