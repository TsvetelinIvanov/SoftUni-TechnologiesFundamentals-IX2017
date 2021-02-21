using System;
using System.Collections.Generic;
using System.Linq;

namespace _04Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(new char[] { ',', ' ', '?', '!', '.' },
                StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<string> palindromes = new List<string>();
            for (int wordIndex = 0; wordIndex < words.Length; wordIndex++)
            {
                string myString = words[wordIndex];
                bool isPalindrome = GetStatus(myString);
                if (isPalindrome)
                {
                    palindromes.Add(myString);
                }
            }

            palindromes = palindromes.Distinct().OrderBy(p => p).ToList();
            Console.WriteLine(string.Join(", ", palindromes));
        }

        public static bool GetStatus(string myString)
        {
            string firstHalf = myString.Substring(0, myString.Length / 2);
            char[] charArray = myString.ToCharArray();
            Array.Reverse(charArray);
            string temp = new string(charArray);
            string secondHalf = temp.Substring(0, temp.Length / 2);

            return firstHalf.Equals(secondHalf);
        }
    }
}
