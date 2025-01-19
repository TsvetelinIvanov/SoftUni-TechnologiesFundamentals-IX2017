using System;
using System.Collections.Generic;
using System.Linq;

namespace _04Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(new char[] { ',', ' ', '?', '!', '.' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<string> palindromes = new List<string>();
            for (int wordIndex = 0; wordIndex < words.Length; wordIndex++)
            {
                string word = words[wordIndex];
                bool isPalindrome = CheckIfPalindrome(word);
                if (isPalindrome)
                {
                    palindromes.Add(word);
                }
            }

            palindromes = palindromes.Distinct().OrderBy(p => p).ToList();
            Console.WriteLine(string.Join(", ", palindromes));
        }

        public static bool CheckIfPalindrome(string word)
        {
            string firstHalf = word.Substring(0, word.Length / 2);
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            string reversedWord = new string(charArray);
            string secondHalf = reversedWord.Substring(0, temp.Length / 2);

            return firstHalf.Equals(secondHalf);
        }
    }
}
