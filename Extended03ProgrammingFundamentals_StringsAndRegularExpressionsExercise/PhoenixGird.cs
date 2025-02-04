using System;
using System.Text.RegularExpressions;

namespace PhoenixGird
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^[^\s_]{3}(\.[^\s_]{3})*$";
            string phrase = Console.ReadLine();
            while (phrase != "ReadMe")
            {
                //if (Regex.IsMatch(phrase, pattern))
                Match match = Regex.Match(phrase, pattern);
                if (match.Success)
                {
                    //if (IsPalindrome(phrase))
                    if (IsPalindrome(match.Value))
                    {
                        Console.WriteLine("YES");
                    }
                    else
                    {
                        Console.WriteLine("NO");
                    }
                }
                else
                {
                    Console.WriteLine("NO");
                }

                phrase = Console.ReadLine();
            }
        }

        private static bool IsPalindrome(string phrase)
        {
            bool isPalindrome = true;
            for (int i = 0; i < phrase.Length / 2; i++)
            {
                if (phrase[i] == phrase[phrase.Length - 1 - i])
                {
                    isPalindrome = true;
                }
                else
                {
                    isPalindrome = false;
                    break;
                }
            }

            return isPalindrome;
        }

        //private static bool IsPalindrome(string phrase)
        //{
        //    for (int i = 0; i < phrase.Length / 2; i++)
        //    {
        //        if (phrase[i] != phrase[phrase.Length - 1 - i])
        //        {
        //            return false;
        //        }
        //    }

        //    return true;
        //}
    }
}
