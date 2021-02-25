using System;
using System.Collections.Generic;
using System.Linq;

namespace _04SumMinMaxAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers.Add(number);
            }

            int sum = numbers.Sum();
            int min = numbers.Min();
            int max = numbers.Max();
            double average = numbers.Average();

            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Min = " + min);
            Console.WriteLine("Max = " + max);
            Console.WriteLine("Average = " + average);
            //or
            //Console.WriteLine("Sum = " + numbers.Sum());
            //Console.WriteLine("Min = " + numbers.Min());
            //Console.WriteLine("Max = " + numbers.Max());
            //Console.WriteLine("Average = " + numbers.Average());
        }
    }
}
