using System;
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

            int[] left = numbers.Take(quarter).ToArray();
            Array.Reverse(left);

            int[] right = numbers.Skip(quarter * 3).ToArray();
            right = right.Reverse().ToArray();

            int[] folded = left.Concat(right).ToArray();
            int[] middle = numbers.Skip(quarter).Take(quarter * 2).ToArray();

            int[] summed = folded.Select((n, i) => n + middle[i]).ToArray();
            Console.WriteLine(string.Join(" ", summed));
        }
    }
}
