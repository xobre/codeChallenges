using System;
using System.Collections.Generic;
using System.Text;

namespace codeChallenges
{
    class YearToCentury
    {
        public static void WhichCentury(int year)
        {
            int century;
            if (year % 100 == 0)
            {
                century = year / 100;
            }
            else
            {
                century = year / 100 + 1;
            }
            Console.WriteLine($"{year} is in the {century} century");
        }

        //static void Main()
        //{
        //    Console.Write("Year: ");
        //    int year = Convert.ToInt32(Console.ReadLine());
        //    WhichCentury(year);
        //}
    }
}
