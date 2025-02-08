using System;
using System.Collections.Generic;

namespace _01OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().ToLower().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> wordCounts = new Dictionary<string, int>();
            foreach (string word in words)
            {
                if (!wordCounts.ContainsKey(word))
                {
                    wordCounts.Add(word, 0);
                }

                wordsAndCount[word]++;
            }
            
            List<string> oddOccurrences = new List<string>();
            foreach (KeyValuePair<string, int> wordCount in wordCounts)
            {
                if (wordCount.Value % 2 != 0)
                {
                    oddOccurrences.Add(wordCount.Key);
                }
            }

            Console.WriteLine(string.Join(", ", oddOccurrences));
        }
    }
}
