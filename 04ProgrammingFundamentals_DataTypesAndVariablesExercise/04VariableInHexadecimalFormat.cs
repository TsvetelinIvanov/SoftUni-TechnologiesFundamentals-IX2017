using System;

namespace _04VariableInHexadecimalFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int output = Convert.ToInt32(input, 16);
            Console.WriteLine(output);
        }
    }
}
