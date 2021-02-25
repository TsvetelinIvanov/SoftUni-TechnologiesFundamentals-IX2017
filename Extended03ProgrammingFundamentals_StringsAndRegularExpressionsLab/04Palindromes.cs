using System;
using System.Collections.Generic;
using System.Linq;

namespace _04Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> palindromes = new List<string>();
            foreach (string word in words)
            {
                string reversedWord = ReverseWord(word);
                if (word == reversedWord)
                    palindromes.Add(word);
            }

            palindromes = palindromes.Distinct().ToList();
            palindromes.Sort();
            Console.WriteLine(string.Join(", ", palindromes));
        }

        private static string ReverseWord(string word)
        {
            char[] chars = word.ToCharArray();
            chars = chars.Reverse().ToArray();
            string reversedWord = new string(chars);

            return reversedWord;
        }
    }
}
