using System;
using System.Collections.Generic;
using System.Text;

namespace codeChallenges
{
    class Series
    {
        public static string[] Slices(string numbers, int sliceLength)
        {
            List<string> slices = new List<string>();
            if (sliceLength > numbers.Length || sliceLength == null || numbers == null || sliceLength <= 0)
            {
                throw new ArgumentException();
            }
            else
            {
                for (int i = 0; i < (numbers.Length - (sliceLength - 1)); i++)
                {
                    slices.Add(numbers.Substring(i, sliceLength));
                }
            }
            string[] array = slices.ToArray();

            return array;
        }
    }
}
