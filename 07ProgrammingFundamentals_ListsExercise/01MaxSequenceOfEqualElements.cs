using System;
using System.Linq;

namespace _01MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] sequence = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse).ToArray();
            
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

            if (length == 0)
            {
                Console.WriteLine(sequence[0]);
            }
            else
            {
                for (int i = start + 1; i <= start + longestLength + 1; i++)
                {
                    Console.Write(sequence[i] + " ");
                }

                Console.WriteLine();
            }            
        }
    }
}
