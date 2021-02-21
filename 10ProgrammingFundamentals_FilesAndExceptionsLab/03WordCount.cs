using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = File.ReadAllText("words.txt").ToLower().Split();
            string[] text = File.ReadAllText("input.txt").ToLower()
                .Split(new char[] { '\n', '\r', ' ', '.', ',', '!', '?', '-' },
                StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> wordCount = new Dictionary<string, int>();
            foreach (string word in words)
            {
                wordCount[word] = 0;
            }

            foreach (string word in text)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
            }

            string output = string.Empty;
            foreach (KeyValuePair<string, int> word in wordCount.OrderByDescending(w => w.Value))
            {
                if (words.Contains(word.Key))
                {
                    if (word.Value == 0)
                        continue;

                   output += $"{word.Key} - {word.Value}\r\n";
                }
            }

            File.WriteAllText("output.txt", output);
            Console.WriteLine(output);
        }
    }
}
