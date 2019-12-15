using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace codeChallenges
{
    public class PhoneNumber
    {
        public static string Clean(string phoneNumber)
        {
            string result = Regex.Replace(phoneNumber, @"[^\d]", "");
            if (result.Length < 10 || result.Length > 11) throw new ArgumentException();
            if (result.Length == 11)
            {
                if (result[0] != '1')
                    throw new ArgumentException();
                else result = result.Remove(0, 1);
            }
            if (result[0] == '0' || result[0] == '1')
                throw new ArgumentException();
            if (result[3] == '0' || result[3] == '1')
                throw new ArgumentException();
            return result;
        }
    }
}
