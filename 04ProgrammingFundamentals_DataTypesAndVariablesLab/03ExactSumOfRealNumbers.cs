using System;

namespace _03ExactSumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal sum = 0m;
            for (int i = 0; i < n; i++)
            {
                decimal m = decimal.Parse(Console.ReadLine());
                sum += m;
            }
            
            Console.WriteLine(sum);
        }
    }
}
