using System;
using System.Collections.Generic;
using System.Text;

namespace codeChallenges
{
    public class CreatingADictionary
    {
        public Dictionary<string, string> WordDictionary = new Dictionary<string, string>();

        public string this[string word]
        {
            get
            {
                if (WordDictionary.ContainsKey(word)) { return WordDictionary[word]; }
                throw new ArgumentException();
            }

            set
            {
                WordDictionary[word] = value;
            }
        }

        //Example for Main()
//IndexersPractice ip = new IndexersPractice();
//ip["apple"] = "A particularly delicious pomaceous fruit of the genus Malus";
//Console.WriteLine(ip["apple"]);
//ip["apple"] = "A genius fruit of the genus Malus that often  times rots and is no longer delicious";
//Console.WriteLine(ip["apple"]);
//ip["banana"] = "yellow";
//Console.WriteLine(ip["banana"]);
    }
}
