using System;
using System.Linq;

namespace _06MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            
            int start = 0;
            int length = 0;
            int longestLength = 0;

            for (int i = 0; i < sequence.Length - 1; i++)
            {
                if (sequence[i] == sequence[i + 1])
                {
                    length++;
                    if (length > longestLength)
                    {
                        start = i - length;
                        longestLength = length;
                    }
                }
                else
                {
                    length = 0;
                }
            }

            for (int i = start + 1; i <= start + longestLength + 1; i++)
            {
                Console.Write(sequence[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
