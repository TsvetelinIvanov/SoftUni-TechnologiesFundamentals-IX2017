using System;
using System.IO;
using System.Linq;

namespace _04MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] sequence = File.ReadAllText("input.txt")
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();
            int start = 0;
            int lenght = 0;
            int longestLenght = 0;
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

            string number = sequence[0].ToString();
            string numbers = string.Empty;
            for (int i = start + 1; i <= start + longestLenght + 1; i++)
            {
                numbers += sequence[i] + " ";
            }

            if (lenght == 0)
            {
                File.WriteAllText("output.txt", number);
            }
            else
            {
                File.WriteAllText("output.txt", numbers);
            }
        }
    }
}
