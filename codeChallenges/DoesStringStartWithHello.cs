using System;
using System.Collections.Generic;
using System.Text;

namespace codeChallenges
{
    static class DoesStringStartWithHello
    {
        static void StartWithHello()
        {
            Console.Write("User Input: ");
            string origSntnc = Console.ReadLine();
            string[] scndSntnc = origSntnc.Split(' ');
            string[] array = { "Hello" };
            if (scndSntnc[0] == array[0])
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }

        //Correct Answer
        //string str;
        //Console.Write("Input a string : ");
        //str = Console.ReadLine();
        //Console.WriteLine((str.Length < 6 && str.Equals("Hello")) || (str.StartsWith("Hello") && str[5] == ' '));

    }
}
