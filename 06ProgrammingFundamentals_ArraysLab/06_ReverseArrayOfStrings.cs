using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine().Split(' ');
            IEnumerable<string> reversedElements = elements.Reverse();
            Console.WriteLine(string.Join(" ", reversedElements));
        }
    }
}
