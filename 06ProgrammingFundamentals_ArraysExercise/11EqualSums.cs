using System;
using System.Linq;

namespace _11EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            bool isFound = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                int[] left = numbers.Take(i).ToArray();
                int[] right = numbers.Skip(i + 1).ToArray();
                if (left.Sum() == right.Sum())
                {
                    Console.WriteLine(i);
                    isFound = true;
                }
            }

            if (!isFound)
                Console.WriteLine("no");
        }
    }
}
