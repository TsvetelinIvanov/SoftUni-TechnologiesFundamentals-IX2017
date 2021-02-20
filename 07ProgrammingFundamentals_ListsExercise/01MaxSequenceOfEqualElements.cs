using System;
using System.Linq;

namespace _01MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] sequence = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();
            int start = 0;
            int lenght = 0;
            int longestLenght = 0;
            {
                for (int i = 0; i < sequence.Length - 1; i++)
                {
                    if (sequence[i] == sequence[i + 1])
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

                if (lenght == 0)
                {
                    Console.WriteLine(sequence[0]);
                }
                else
                {
                    for (int i = start + 1; i <= start + longestLenght + 1; i++)
                    {
                        Console.Write(sequence[i] + " ");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
