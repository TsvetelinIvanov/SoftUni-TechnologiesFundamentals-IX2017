using System;

namespace _03LastKNumbersSumsSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] sequence = new long[n];
            sequence[0] = 1;
            for (int i = 1; i < sequence.Length; i++)
            {
                int start = Math.Max(0, i - k);
                int end = i - 1;
                long sum = 0;
                for (int j = start; j <= end; j++)
                {
                    sum += sequence[j]; 
                }

                sequence[i] = sum;
            }

            for (int i = 0; i < sequence.Length; i++)
            {
                Console.Write(sequence[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
