using System;

namespace _10MultiplicationTableNext
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int timesCount = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine($"{number} X {timesCount} = {number * timesCount}");
                timesCount++;
            } while (timesCount <= 10);
        }
    }
}
