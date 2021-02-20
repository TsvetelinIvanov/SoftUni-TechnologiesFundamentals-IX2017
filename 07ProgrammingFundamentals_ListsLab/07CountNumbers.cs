using System;
using System.Collections.Generic;
using System.Linq;

namespace _07CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int>numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            
            int[] counts = new int[numbers.Max() + 1];

            foreach (int number in numbers)
            {
                counts[number]++;
            }

            for (int i = 0; i < counts.Length; i++)
            {              
                if (counts[i] > 0)
                {
                    Console.WriteLine($"{i} -> {counts[i]}");
                }                
            }
        }
    }
}
