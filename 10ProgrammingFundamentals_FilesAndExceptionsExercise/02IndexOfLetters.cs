using System;
using System.IO;

namespace _02IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = File.ReadAllText("input.txt").ToLower();
            char[] alphabet = new char[26];
            for (char i = 'a'; i <= 'z'; i++)
            {
                alphabet[i - 'a'] = i;
            }

            string output = String.Empty;
            for (int i = 0; i <= word.Length - 1; i++)
            {
                for (int j = 0; j <= alphabet.Length - 1; j++)
                {
                    if (word[i] == alphabet[j])
                    {
                        output += $"{word[i]} -> {j}\r\n";
                    }
                }
            }

            File.WriteAllText("output.txt", output);
        }
    }
}
