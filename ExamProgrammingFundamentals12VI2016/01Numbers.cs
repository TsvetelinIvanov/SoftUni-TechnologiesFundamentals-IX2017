using System;
using System.Collections.Generic;
using System.Linq;

namespace _01Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            List<int> top5GreaterThanAverageNumbers = new List<int>(numbers.Where(n => n > numbers.Average())
                .OrderByDescending(n => n).Take(5));
            if (top5GreaterThanAverageNumbers.Count > 0)
            {
                Console.WriteLine(string.Join(" ", top5GreaterThanAverageNumbers));
            }
            else
            {
                Console.WriteLine("No");
            }                
        }
    }
}
