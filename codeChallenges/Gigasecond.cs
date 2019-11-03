using System;
using System.Collections.Generic;
using System.Text;

namespace codeChallenges
{
    class Gigasecond
    {
        public static DateTime Add(DateTime moment)
        {
            return moment.AddSeconds(1000000000);
        }
    }
}
