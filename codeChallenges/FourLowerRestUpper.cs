using System;
using System.Collections.Generic;
using System.Text;

namespace codeChallenges
{
    class FourLowerRestUpper
    {
        public static void LowerAndUpper()
        {
            Console.Write("User Input: ");
            string origSntnc = Console.ReadLine();

            if (origSntnc.Length < 4)
            {
                Console.WriteLine(origSntnc.ToUpper());
            }
            else
            {
                string newSntnc = origSntnc.Substring(0, 4);
                string newSntnc2 = origSntnc.Substring(4);

                Console.WriteLine(origSntnc);
                Console.WriteLine(newSntnc);
                Console.WriteLine(newSntnc2);


                if (newSntnc.Length == 4)
                {
                    Console.WriteLine($"{newSntnc.ToLower()}{newSntnc2}");
                }
            }
        }
    }
}
