using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04CubicMessages
{
    class Program
    {
        static void Main(string[] args)
        {            
            string input = Console.ReadLine();
            while (input != "Over!")
            {
                int m = int.Parse(Console.ReadLine());
                string pattern = @"^(\d+)([a-zA-Z]{" + m + @"})([^a-zA-Z]*)$";
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    string indexesString = match.Groups[1].Value;
                    MatchCollection matchIndexes = Regex.Matches(match.Groups[3].Value, @"\d");
                    for (int i = 0; i < matchIndexes.Count; i++)
                    {
                        indexesString += matchIndexes[i];
                    }

                    string indexesStringAndSpaces = string.Empty;
                    for (int i = 0; i < indexesString.Length; i++)
                    {
                        indexesStringAndSpaces += indexesString[i] + " ";
                    }

                    indexesStringAndSpaces = indexesStringAndSpaces.Trim();
                    int[] indexes = indexesStringAndSpaces.Split().Select(int.Parse).ToArray();
                    string message = match.Groups[2].Value;
                    Console.Write(message + " == ");
                    for (int i = 0; i < indexes.Length; i++)
                    {
                        if (indexes[i] >= message.Length)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write(message[indexes[i]]);
                        }
                    }

                    Console.WriteLine();
                }

                input = Console.ReadLine();
            }
        }
    }
}
