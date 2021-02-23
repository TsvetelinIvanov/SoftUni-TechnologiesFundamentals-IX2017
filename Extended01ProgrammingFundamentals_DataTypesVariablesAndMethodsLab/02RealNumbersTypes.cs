using System;

namespace _02RealNumbersTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            decimal number = decimal.Parse(Console.ReadLine());
            Console.WriteLine(number);
            //Console.WriteLine($"{Math.Round(number, n)}");
        }
    }
}
