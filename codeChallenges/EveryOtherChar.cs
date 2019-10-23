using System;
using System.Collections.Generic;
using System.Text;

namespace codeChallenges
{
    class EveryOtherChar
    {
        public static void SkipChar()
        {
            Console.Write("Input a string : ");
            string str = Console.ReadLine();
            string result = string.Empty;
            for (var i = 0; i < str.Length; i++)
            {
                if (i % 2 == 0) result += str[i];
            }
            Console.WriteLine(result);
        }
    }
}
