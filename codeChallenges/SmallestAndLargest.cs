using System;
using System.Collections.Generic;
using System.Text;

namespace codeChallenges
{
    class SmallestAndLargest
    {
        public static void FindMinAndMax()
        {
            Console.Write("User Input #1: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("User Input #2: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("User Input #3: ");
            int z = Convert.ToInt32(Console.ReadLine());

            int max3 = Math.Max(x, Math.Max(y, z));
            Console.WriteLine($"The largest value is {max3}!");
            int min3 = Math.Min(x, Math.Min(y, z));
            Console.WriteLine($"The smallest value is {min3}!");
        }
    }
}
