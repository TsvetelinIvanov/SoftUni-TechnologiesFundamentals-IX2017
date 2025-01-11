using System;
using System.Collections.Generic;

namespace _02OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> counts = new Dictionary<string, int>();
            foreach (string word in words)
            {
                if (counts.ContainsKey(word))
                {
                    counts[word]++;
                }
                else
                {
                    counts[word] = 1;
                }
            }

            List<string> oddOccurrencies = new List<string>();
            foreach (KeyValuePair<string, int> word in counts)
            {
                if (word.Value % 2 != 0)
                {
                    oddOccurrencies.Add(word.Key);
                }
            }

            Console.WriteLine(string.Join(", ", oddOccurrencies));
        }
    }
}
