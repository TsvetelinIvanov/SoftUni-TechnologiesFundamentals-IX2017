using System;

namespace _14IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer = int.Parse(Console.ReadLine());

            string hex = Convert.ToString(integer, 16).ToUpper();
            string binary = Convert.ToString(integer, 2);

            Console.WriteLine(hex);
            Console.WriteLine(binary);
        }
    }
}
