using System;

namespace _03MilesToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles = double.Parse(Console.ReadLine());
            double kilometers = miles * 1.60934;
            Console.WriteLine("{0:f2}", kilometers);
        }
    }
}
