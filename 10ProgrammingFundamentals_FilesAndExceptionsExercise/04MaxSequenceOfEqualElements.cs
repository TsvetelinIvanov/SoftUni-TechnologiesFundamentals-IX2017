using System;
using System.IO;
using System.Linq;

namespace _04MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] sequence = File.ReadAllText("input.txt").Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
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

            string numberString = sequence[0].ToString();
            string numbersString = string.Empty;
            for (int i = start + 1; i <= start + longestLength + 1; i++)
            {
                numbersString += sequence[i] + " ";
            }

            if (length == 0)
            {
                File.WriteAllText("output.txt", numberString);
            }
            else
            {
                File.WriteAllText("output.txt", numbersString);
            }
        }
    }
}
