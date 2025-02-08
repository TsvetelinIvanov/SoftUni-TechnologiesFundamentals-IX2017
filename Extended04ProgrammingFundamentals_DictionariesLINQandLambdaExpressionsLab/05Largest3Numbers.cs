using System;
using System.Linq;

namespace _05Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse).ToArray();
            numbers = numbers.OrderByDescending(n => n).Take(3).ToArray();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
