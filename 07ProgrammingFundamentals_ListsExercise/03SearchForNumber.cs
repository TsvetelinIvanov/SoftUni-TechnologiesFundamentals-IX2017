using System;
using System.Linq;

namespace _03SearchForNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] commingNumbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] instructionNumbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] takedNumbers = commingNumbers.Take(instructionNumbers[0]).ToArray();
            int[] restNumbers = takedNumbers.Skip(instructionNumbers[1]).ToArray();
            if (restNumbers.Contains(instructionNumbers[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
