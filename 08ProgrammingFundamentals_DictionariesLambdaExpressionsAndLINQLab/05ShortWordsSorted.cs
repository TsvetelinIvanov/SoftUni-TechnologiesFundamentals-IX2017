using System;
using System.Collections.Generic;
using System.Linq;

namespace _05ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = { '.', ',', ':', ';', '(', ')', '[', ']', '\\', '\"', '\'', '/', '!', '?', ' ' };
            string sentence = Console.ReadLine().ToLower();
            string[] words = sentence.Split(separators);
            IEnumerable<string> result = words.Where(w => w != "").Where(w => w.Length < 5).OrderBy(w => w).Distinct();
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
