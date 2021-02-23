using System;
using System.Text.RegularExpressions;

namespace _02ExtractSentencesByKeyWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyWord = $@"\b{Console.ReadLine()}\b";
            string[] sentences = Console.ReadLine().Split('.', '!', '?');
            Regex regex = new Regex(keyWord);
            foreach (string sentence in sentences)
            {
                bool isContainsKeyWord = regex.IsMatch(sentence);
                if (isContainsKeyWord)
                    Console.WriteLine(sentence.Trim());
            }
        }
    }
}
