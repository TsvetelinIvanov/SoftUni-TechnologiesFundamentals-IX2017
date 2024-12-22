using System;

namespace _09MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int timesCount = 1;
            while (timesCount <= 10)
            {
                Console.WriteLine($"{number} X {timesCount} = {number * timesCount}");
                timesCount++;
            }
        }
    }
}
