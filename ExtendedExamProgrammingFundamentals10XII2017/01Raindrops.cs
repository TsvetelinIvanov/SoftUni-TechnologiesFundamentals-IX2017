using System;
using System.Linq;

namespace _01Raindrops
{
    class Program
    {
        static void Main(string[] args)
        {
            int regionsAmount = int.Parse(Console.ReadLine());
            decimal density = decimal.Parse(Console.ReadLine());
            
            decimal regionalCoefficient = 0;
            decimal regionalCoefficientSum = 0;
            for (int i = 0; i < regionsAmount; i++)
            {
                decimal[] regionData = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(decimal.Parse).ToArray();
                decimal raindropsCount = regionData[0];
                decimal squareMetersCount = regionData[1];

                regionalCoefficient = raindropsCount / squareMetersCount;
                regionalCoefficientSum += regionalCoefficient;
            }
            
            if (density != 0)
            {
                decimal result = regionalCoefficientSum / density;
                Console.WriteLine($"{result:f3}");
            }
            else
            {
                Console.WriteLine($"{regionalCoefficientSum:f3}");
            }
        }
    }
}
