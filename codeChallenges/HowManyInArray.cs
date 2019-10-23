using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace codeChallenges
{
    class HowManyInArray
    {
        public static void Count()
        {
            int Min = 0;
            int Max = 6;
            Random randNum = new Random();
            int[] test2 = Enumerable
                .Repeat(0, 20)
                .Select(i => randNum.Next(Min, Max))
                .ToArray();

            Console.WriteLine(String.Join(" ", test2));
            int x = 3;
            int count = 0;
            foreach (int i in test2)
            {
                if (i.Equals(x))
                {
                    count++;
                }
            }
            Console.WriteLine($"{x} was in the array {count} time(s)");
        }
    }
}
