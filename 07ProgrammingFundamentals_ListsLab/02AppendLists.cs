using System;
using System.Collections.Generic;
using System.Linq;

namespace _02AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] input = Console.ReadLine().Split('|');            
            
            List<int> output = new List<int>();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                int[] onGoing = input[i]
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                output.AddRange(onGoing);                
            }
            
            Console.WriteLine(string.Join(" ", output));
        }
    }
}
