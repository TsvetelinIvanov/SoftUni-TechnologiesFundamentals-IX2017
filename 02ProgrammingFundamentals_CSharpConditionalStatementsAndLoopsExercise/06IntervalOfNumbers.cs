using System;

namespace _06IntervalOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            
            int startNumber = Math.Min(firstNumber, secondNumber);
            int endNumber = Math.Max(firstNumber, secondNumber);
            for (int i = startNumber; i <= endNumber; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
