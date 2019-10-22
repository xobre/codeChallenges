using System;
using System.Collections.Generic;
using System.Text;

namespace codeChallenges
{
    static class ReverseSntnc
    {
        static void reverseTheSntnc()
        {
            Console.Write("USER INPUT: ");
            string origSntnc = Console.ReadLine();
            string[] scndSntnc = origSntnc.Split(' ');
            Console.WriteLine(origSntnc);
            Array.Reverse(scndSntnc);
            Console.WriteLine(String.Join(" ", scndSntnc));
        }
    }
}
