using System;
using System.Collections.Generic;
using System.Linq;

namespace _06FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int k = numbers.Length / 4;
            int[] upperRowLeft = numbers.Take(k).Reverse().ToArray();
            int[] upperRowRight = numbers.Reverse().Take(k).ToArray();
            int[] upperRow = upperRowLeft.Concat(upperRowRight).ToArray();
            int[] downRow = numbers.Skip(k).Take(2 * k).ToArray();
            IEnumerable<int> foldetAndSummed = upperRow.Select((x, index) => x + downRow[index]);
            Console.WriteLine(string.Join(" ", foldetAndSummed));
        }
    }
}
