using System;
using System.Collections.Generic;
using System.Linq;

namespace _06SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            
            List<int> squareNumbers = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (Math.Sqrt(numbers[i]) == (int)Math.Sqrt(numbers[i]))
                {
                    squareNumbers.Add(numbers[i]);
                }
            }

            squareNumbers.Sort();
            squareNumbers.Reverse();
            Console.WriteLine(string.Join(" ", squareNumbers));
        }
    }
}
