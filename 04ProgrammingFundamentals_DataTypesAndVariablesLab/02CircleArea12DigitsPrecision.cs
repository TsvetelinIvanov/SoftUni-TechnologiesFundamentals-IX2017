using System;

namespace _02CircleArea12DigitsPrecision
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * r * r;
            Console.WriteLine("{0:f12}", area);
        }
    }
}
