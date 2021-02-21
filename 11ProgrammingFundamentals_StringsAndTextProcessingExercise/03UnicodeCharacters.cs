using System;
using System.Collections.Generic;
using System.Linq;

namespace _03UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            IEnumerable<string> chars = input.Select(c => (int)c).Select(c => $@"\u{c:x4}");
            string result = string.Concat(chars);
            Console.WriteLine(result);
        }
    }
}
