using System;
using System.Text.RegularExpressions;

namespace _02ExtractSentencesByKeyWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyword = $@"\b{Console.ReadLine()}\b";
            string[] sentences = Console.ReadLine().Split('.', '!', '?');
            Regex regex = new Regex(keyword);
            foreach (string sentence in sentences)
            {
                bool containsKeyword = regex.IsMatch(sentence);
                if (containsKeyword)
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
        }
    }
}
