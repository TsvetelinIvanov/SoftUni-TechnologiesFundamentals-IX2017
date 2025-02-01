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
                decimal yearsCount = ReadPhoenixDataAndCalculateYears();
                Console.WriteLine("{0}", yearsCount);
            }
        }

        private static decimal ReadPhoenixDataAndCalculateYears()
        {
            long bodyLength = long.Parse(Console.ReadLine());
            decimal bodyWidth = decimal.Parse(Console.ReadLine());
            long wingLength = long.Parse(Console.ReadLine());
            decimal yearsCount = (bodyLength * bodyLength) * (bodyWidth + (2 * wingLength));

            return yearsCount;
        }
    }
}
