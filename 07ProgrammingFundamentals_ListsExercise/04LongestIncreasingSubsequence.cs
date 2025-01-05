using System;
using System.Collections.Generic;
using System.Linq;

namespace _04LongestIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)//Select(x => int.Parse(x))
                .ToArray();
            int[] longestIncreasingSubsequence = FindLongestIncreasingSubsequence(numbers);
            Console.WriteLine(string.Join(" ", longestIncreasingSubsequence));
        }

        public static int[] FindLongestIncreasingSubsequence(int[] sequence)
        {
            int[] lengths = new int[sequence.Length];
            int[] previouses = new int[sequence.Length];
            int maxLength = 0;
            int lastIndex = -1;
            for (int i = 0; i < sequence.Length; i++)
            {
                lengths[i] = 1;
                previouses[i] = -1;
                for (int j = 0; j < i; j++)
                {
                    if (sequence[j] < sequence[i] && lengths[j] >= lengths[i])
                    {
                        lengths[i] = 1 + lengths[j];
                        previouses[i] = j;
                    }
                }

                if (lengths[i] > maxLength)
                {
                    maxLength = lengths[i];
                    lastIndex = i;
                }
            }

            List<int> longestSequence = new List<int>();
            for (int i = 0; i < maxLength; i++)
            {
                longestSequence.Add(sequence[lastIndex]);
                lastIndex = previous[lastIndex];
            }

            //longestSequence = longestSequence.Reverse().ToList();

            return longestSequence.ToArray();
        }
    }
}
