using System;
using System.Linq;

namespace MaxSequenceOfIncreasingElementsVII
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int start = 0;
            int lenght = 0;
            int longestLenght = 0;

            for (int i = 0; i < sequence.Length - 1; i++)
            {
                if (sequence[i] < sequence[i + 1])
                {
                    lenght++;
                    if (lenght > longestLenght)
                    {
                        start = i - lenght;
                        longestLenght = lenght;
                    }
                }
                else
                {
                    lenght = 0;
                }
            }

            for (int i = start + 1; i <= start + longestLenght + 1; i++)
            {
                Console.Write(sequence[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
