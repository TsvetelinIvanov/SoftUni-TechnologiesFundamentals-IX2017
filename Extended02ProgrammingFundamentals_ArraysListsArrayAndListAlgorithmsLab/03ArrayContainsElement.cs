using System;
using System.Linq;

namespace _03ArrayContainsElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int n = int.Parse(Console.ReadLine());
            bool isFound = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == n)
                    isFound = true;
            }

            if (isFound)
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
        }
    }
}
