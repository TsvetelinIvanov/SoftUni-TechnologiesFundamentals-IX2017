using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _08UseYourChainsBuddy
{
    class Program
    {
        static void Main(string[] args)
        {
            string encryptedManual = Console.ReadLine();
            string patternForTags = @"(?<=<p>).*?(?=<\/p>)";
            MatchCollection matchesBetweenTags = Regex.Matches(encryptedManual, patternForTags);
            List<string> manualWords = new List<string>();
            foreach (Match matchBetweenTags in matchesBetweenTags)
            {
                string patternForCharacters = @"[^a-z0-9]";
                string rawManualWord = Regex.Replace(matchBetweenTags.ToString(), patternForCharacters, " ");
                rawManualWord = Regex.Replace(rawManualWord, @"\s+", " ");
                string manualWord = DecodeLetters(rawManualWord);
                manualWords.Add(manualWord);
            }

            Console.WriteLine(string.Join("", manualWords));
        }

        private static string DecodeLetters(string rawManualWord)
        {
            StringBuilder decoded = new StringBuilder();
            foreach (char letter in rawManualWord)
            {
                if (Regex.IsMatch(letter.ToString(), "[a-m]"))
                    decoded.Append((char)(letter + 13));
                else if (Regex.IsMatch(letter.ToString(), "[n-z]"))
                    decoded.Append((char)(letter - 13));
                else
                    decoded.Append(letter);
            }

            return decoded.ToString();
        }
    }
}
