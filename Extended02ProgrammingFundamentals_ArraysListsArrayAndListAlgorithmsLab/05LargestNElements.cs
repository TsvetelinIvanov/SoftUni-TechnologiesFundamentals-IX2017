using System;
using System.Collections.Generic;
using System.Linq;

namespace _05LargestNElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());
            numbers.Sort();
            numbers.Reverse();
            for (int i = 0; i < n; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();
             
            //List<int> largestNElements = new List<int>();
            //for (int i = 0; i < n; i++)
            //{
            //    largestNElements.Add(numbers[i]);
            //}

            //Console.WriteLine(string.Join(" ", largestNElements));
        }
    }
}
