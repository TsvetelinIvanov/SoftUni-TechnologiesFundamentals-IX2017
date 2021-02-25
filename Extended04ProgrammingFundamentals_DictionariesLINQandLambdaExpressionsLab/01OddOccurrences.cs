using System;
using System.Collections.Generic;

namespace _01OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().ToLower()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> wordsAndCount = new Dictionary<string, int>();
            foreach (string word in words)
            {
                if (!wordsAndCount.ContainsKey(word))
                {
                    wordsAndCount.Add(word, 0);
                }

                wordsAndCount[word]++;
            }
            List<string> results = new List<string>();
            foreach (KeyValuePair<string, int> wordAndCount in wordsAndCount)
            {
                if (wordAndCount.Value % 2 != 0)
                    results.Add(wordAndCount.Key);
            }

            Console.WriteLine(string.Join(", ", results));
        }
    }
}
