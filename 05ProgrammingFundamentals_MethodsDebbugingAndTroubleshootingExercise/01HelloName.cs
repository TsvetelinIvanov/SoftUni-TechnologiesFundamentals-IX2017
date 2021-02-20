using System;

namespace _01HelloName
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string greetingByName = GreetingByName(name);
            Console.WriteLine(greetingByName);
        }

        static string GreetingByName(string name)
        {
            string greeting = $"Hello, {name}!";
            return greeting;
        }
    }
}
