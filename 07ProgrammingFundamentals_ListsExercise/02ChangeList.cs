using System;
using System.Collections.Generic;
using System.Linq;

namespace _02ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<string> commands = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (commands[0] != "Odd" && commands[0] != "Even")
            {
                if (commands[0] == "Delete")
                {
                    int number = int.Parse(commands[1]);
                    numbers.RemoveAll(i => i == number);
                }
                else if (commands[0] == "Insert")
                {
                    int element = int.Parse(commands[1]);
                    int position = int.Parse(commands[2]);
                    numbers.Insert(position, element);
                }

                commands = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            }

            if (commands[0] == "Odd")
            {
                foreach (int number in numbers)
                {
                    if (number % 2 != 0)
                    {
                        Console.Write("{0} ", number);
                    }
                }
            }
            else
            {
                foreach (int number in numbers)
                {
                    if (number % 2 == 0)
                    {
                        Console.Write("{0} ", number);
                    }
                }
            }

            Console.WriteLine();
        }
    }
}
