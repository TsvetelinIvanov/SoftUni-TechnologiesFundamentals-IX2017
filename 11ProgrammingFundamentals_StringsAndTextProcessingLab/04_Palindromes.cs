using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(new char[] { ',', ' ', '?', '!', '.' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<string> palindromes = new List<string>();
            foreach (string word in words)
            {
                if (word.SequenceEqual(word.Reverse()))
                {
                    palindromes.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ", palindromes.OrderBy(p => p).Distinct()));
        }
    }
}
