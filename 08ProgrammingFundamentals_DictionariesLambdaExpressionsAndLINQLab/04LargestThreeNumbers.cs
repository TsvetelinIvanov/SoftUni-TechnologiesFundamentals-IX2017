using System;
using System.Collections.Generic;
using System.Linq;

namespace _04LargestThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            IOrderedEnumerable<int> sortedNumbers = numbers.OrderByDescending(n => n);
            
            IEnumerable<int> largestThreeNumbers = sortedNumbers.Take(3);
            Console.WriteLine(string.Join(" ", largestThreeNumbers));
        }
    }
}
