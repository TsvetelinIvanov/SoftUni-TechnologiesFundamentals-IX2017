using System;
using System.Linq;

namespace _03SearchForNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] comingNumbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int[] instructionNumbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int[] takedNumbers = comingNumbers.Take(instructionNumbers[0]).ToArray();
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
