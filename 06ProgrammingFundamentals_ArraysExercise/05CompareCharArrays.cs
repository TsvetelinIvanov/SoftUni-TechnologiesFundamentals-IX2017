using System;
using System.Linq;

namespace _05CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstArray = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse).ToArray();
            char[] secondArray = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse).ToArray();

            string firstString = string.Empty;
            for (int i = 0; i < firstArray.Length; i++)
            {
                firstString += firstArray[i];
            }

            string secondString = string.Empty;
            for (int i = 0; i < secondArray.Length; i++)
            {
                secondString += secondArray[i];
            }

            if (firstString.CompareTo(secondString) <= 0)
            {
                Console.WriteLine(firstString);
                Console.WriteLine(secondString);
            }
            else
            {
                Console.WriteLine(secondString);
                Console.WriteLine(firstString);
            }

            //If you wish to write the shorter first:            
            //if (firstArray.Length < secondArray.Length)
            //{
            //    Console.WriteLine(firstString);
            //    Console.WriteLine(secondString);
            //}
            //else if (firstArray.Length > secondArray.Length)
            //{
            //    Console.WriteLine(secondString);
            //    Console.WriteLine(firstString);
            //}
            //else
            //{
            //    if (firstString.CompareTo(secondString) <= 0)
            //    {
            //        Console.WriteLine(firstString);
            //        Console.WriteLine(secondString);
            //    }
            //    else
            //    {
            //        Console.WriteLine(secondString);
            //        Console.WriteLine(firstString);
            //    }
            //}
        }
    }
}
