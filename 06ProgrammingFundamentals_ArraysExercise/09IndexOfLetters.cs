using System;

namespace _09IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            char[] alphabet = new char[26];
            for (char i = 'a'; i <= 'z'; i++)
            {
                alphabet[i - 'a'] = i;
            }

            for (int i = 0; i <= word.Length - 1; i++)
            {
                for (int j = 0; j <= alphabet.Length - 1; j++)
                {
                    if (word[i] == alphabet[j])
                    {
                        Console.WriteLine($"{word[i]} -> {j}");
                    }
                }
            }            
        }
    }
}
