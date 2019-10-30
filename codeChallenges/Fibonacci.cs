using System;
using System.Collections.Generic;
using System.Text;

namespace codeChallenges
{
    public static class Fibonacci
    {

        public static int Method(int x, int y, int counter, int number)
        {
            Console.WriteLine(x);
            if (counter < number) Method(y, x + y , counter + 1, number);
            return x;
        }
    }
}
