using System;
using System.Collections.Generic;
using System.Text;

namespace codeChallenges
{
    static class MultiSameElementArray
    {
        public static void multiCorrespondingElements()
        {
        int[] Array1 = { 1, 3, -5, 4 };
        int[] Array2 = { 1, 4, -5, -2 };

        int zeroSum = Array1[0] * Array2[0];
        Console.WriteLine(zeroSum);
        int firstSum = Array1[1] * Array2[1];
        Console.WriteLine(firstSum);
        int secondSum = Array1[2] * Array2[2];
        Console.WriteLine(secondSum);
        int thirdSum = Array1[3] * Array2[3];
        Console.WriteLine(thirdSum);
        }
    }
}
