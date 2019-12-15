using System;
using System.Collections.Generic;
using System.Text;

namespace codeChallenges
{
    public static class Etl
    {
        public static Dictionary<string, int> Transform(Dictionary<int, string[]> old)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            foreach (var el in old)
                foreach (string s in el.Value)
                    result.Add(s.ToLower(), el.Key);
            return result;
        }
    }
}
