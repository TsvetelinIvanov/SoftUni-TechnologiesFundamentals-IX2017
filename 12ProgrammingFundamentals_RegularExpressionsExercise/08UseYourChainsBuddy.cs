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
            string patternForTag = @"(?<=<p>).*?(?=<\/p>)";
            MatchCollection insideTagMatches = Regex.Matches(encryptedManual, patternForTag);
            List<string> manualWords = new List<string>();
            foreach (Match insideTagMatch in insideTagMatches)
            {
                string characterPattern = @"[^a-z0-9]";
                string rawManualWord = Regex.Replace(insideTagMatch.ToString(), characterPattern, " ");
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
                {
                    decoded.Append((char)(letter + 13));
                }
                else if (Regex.IsMatch(letter.ToString(), "[n-z]"))
                {
                    decoded.Append((char)(letter - 13));
                }
                else
                {
                    decoded.Append(letter);
                }
            }

            return decoded.ToString();
        }
    }
}
