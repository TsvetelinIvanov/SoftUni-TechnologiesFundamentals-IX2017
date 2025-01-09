using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            numbers.Sort();
            int next = 0;
            while (next < numbers.Count)
            {
                int number = numbers[next], count = 1;
                while (next + count < numbers.Count && numbers[next + count] == number)
                {
                    count++;
                }

                next += count;
                Console.WriteLine($"{number} -> {count}");
            }
        }
    }
}
