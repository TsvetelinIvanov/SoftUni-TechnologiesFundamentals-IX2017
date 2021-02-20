using System;
using System.Linq;

namespace _05CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr1 = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();
            char[] arr2 = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();

            string str1 = string.Empty;
            for (int i = 0; i < arr1.Length; i++)
            {
                str1 += arr1[i];
            }

            string str2 = string.Empty;
            for (int i = 0; i < arr2.Length; i++)
            {
                str2 += arr2[i];
            }

            if (str1.CompareTo(str2) <= 0)
            {
                Console.WriteLine(str1);
                Console.WriteLine(str2);
            }
            else
            {
                Console.WriteLine(str2);
                Console.WriteLine(str1);
            }

            //if you wish to write the shorter first:            
            //if (arr1.Length < arr2.Length)
            //{
            //    Console.WriteLine(str1);
            //    Console.WriteLine(str2);
            //}
            //else if (arr1.Length > arr2.Length)
            //{
            //    Console.WriteLine(str2);
            //    Console.WriteLine(str1);
            //}
            //else
            //{
            //    if (str1.CompareTo(str2) <= 0)
            //    {
            //        Console.WriteLine(str1);
            //        Console.WriteLine(str2);
            //    }
            //    else
            //    {
            //        Console.WriteLine(str2);
            //        Console.WriteLine(str1);
            //    }
            //}
        }
    }
}
