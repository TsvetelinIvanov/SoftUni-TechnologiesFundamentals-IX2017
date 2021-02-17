using System;

namespace _11OddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int oddNumber = int.Parse(Console.ReadLine());
            while (oddNumber % 2 == 0)
            {
                Console.WriteLine("Please write an odd number.");
                oddNumber = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The number is: {0}", Math.Abs(oddNumber));
        }
    }
}
