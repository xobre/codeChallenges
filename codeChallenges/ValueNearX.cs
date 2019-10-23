using System;
using System.Collections.Generic;
using System.Text;

namespace codeChallenges
{
    class ValueNearX
    {
        public static void Closest()
        {
            Console.WriteLine("User Input #1: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("User Input #2: ");
            int y = Convert.ToInt32(Console.ReadLine());

            int xX = Math.Abs(x - 20);
            int yY = Math.Abs(y - 20);

            if (xX < yY)
            {
                Console.WriteLine($"{x} is closer to 20 than {y}.");
            }
            else if (yY < xX)
            {
                Console.WriteLine($"{y} is closer to 20 than {x}.");
            }
            else if (y == x)
            {
                Console.WriteLine($"{x} & {y} are the same number dumb dumb.");
            }
            else if (yY == xX)
            {
                Console.WriteLine($"{x} & {y} are the same distance from 20 dumb dumb.");
            }
        }
    }
}
