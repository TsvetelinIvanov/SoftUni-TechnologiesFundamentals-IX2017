using System;
using System.Linq;

namespace _05RoundingNumbersAwayFromZero
{
    class Program
    {
        static void Main(string[] args)
        {
            string values = Console.ReadLine();
            double[] numbers = values.Split(' ').Select(double.Parse).ToArray();

            foreach (double number in numbers)
            {
                Console.WriteLine($"{number} => {Math.Round(number, 0, MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
