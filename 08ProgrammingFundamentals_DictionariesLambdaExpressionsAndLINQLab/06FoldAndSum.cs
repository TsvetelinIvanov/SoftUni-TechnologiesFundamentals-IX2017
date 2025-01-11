using System;
using System.Collections.Generic;
using System.Linq;

namespace _06FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            
            int quarter = numbers.Length / 4;
            int[] upperRowLeft = numbers.Take(quarter).Reverse().ToArray();
            int[] upperRowRight = numbers.Reverse().Take(quarter).ToArray();
            int[] upperRow = upperRowLeft.Concat(upperRowRight).ToArray();            
            int[] downRow = numbers.Skip(quarter).Take(2 * quarter).ToArray();
            
            IEnumerable<int> foldetAndSummed = upperRow.Select((number, index) => number + downRow[index]);
            Console.WriteLine(string.Join(" ", foldetAndSummed));
        }
    }
}
