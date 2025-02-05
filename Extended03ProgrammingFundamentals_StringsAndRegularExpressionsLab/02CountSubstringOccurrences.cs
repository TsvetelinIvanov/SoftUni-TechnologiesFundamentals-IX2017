using System;

namespace _02CountSubstringOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string pattern = Console.ReadLine().ToLower();
            
            int counter = 0;
            int index = text.IndexOf(pattern);
            while (index != - 1)
            {
                counter++;
                index = text.IndexOf(pattern, index + 1);
                //If you wont to count only the whole occurences:
                //index = text.IndexOf(pattern, index + pattern.Length);
            }

            Console.WriteLine(counter);
        }
    }
}
