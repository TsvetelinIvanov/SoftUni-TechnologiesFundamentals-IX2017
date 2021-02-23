using System;

namespace _04Resurrection
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());            
            for (int i = 0; i < n; i++)
            {
                decimal totalYears = ReadPhoenixDataAndFindTotalYears();
                Console.WriteLine("{0}", totalYears);
            }
        }

        private static decimal ReadPhoenixDataAndFindTotalYears()
        {
            long bodyLength = long.Parse(Console.ReadLine());
            decimal bodyWidth = decimal.Parse(Console.ReadLine());
            long wingLength = long.Parse(Console.ReadLine());
            decimal totalYears = (bodyLength * bodyLength) * (bodyWidth + (2 * wingLength));

            return totalYears;
        }
    }
}
