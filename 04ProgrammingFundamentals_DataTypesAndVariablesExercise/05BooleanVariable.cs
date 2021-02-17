using System;

namespace _05BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool isTrue = Convert.ToBoolean(input);
            Console.WriteLine(isTrue ? "Yes" : "No");
        }
    }
}
