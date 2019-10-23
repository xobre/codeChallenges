using System;
using System.Collections.Generic;
using System.Text;

namespace codeChallenges
{
    class CheckPalindrome
    {
        public static void Palindrome()
        {
            Console.WriteLine("User Input: ");
            string pali = Console.ReadLine();
            char[] c = pali.ToCharArray();
            Array.Reverse(c);
            Console.WriteLine(new string(c).Equals(pali));
        }
    }
}
