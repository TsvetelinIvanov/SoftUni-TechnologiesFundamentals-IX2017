using System;
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

            int[] left = numbers.Take(k).ToArray();
            Array.Reverse(left);

            int[] right = numbers.Skip(k * 3).ToArray();
            right = right.Reverse().ToArray();

            int[] folded = left.Concat(right).ToArray();
            int[] middle = numbers.Skip(k).Take(k * 2).ToArray();

            int[] summed = folded.Select((x, i) => x + middle[i]).ToArray();
            Console.WriteLine(string.Join(" ", summed));
        }
    }
}
