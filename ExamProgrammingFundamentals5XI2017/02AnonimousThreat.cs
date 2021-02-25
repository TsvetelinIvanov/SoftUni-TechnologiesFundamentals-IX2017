using System;
using System.Collections.Generic;
using System.Linq;

namespace _02AnonimousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> data = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();            
            string commandLine = Console.ReadLine();
            while (commandLine != "3:1")
            {
                string[] commands = commandLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (commands[0] == "merge")
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);
                    string sumString = string.Empty;
                    if (startIndex < 0 || startIndex > data.Count - 1)
                        startIndex = 0;

                    if (endIndex < 0 || endIndex > data.Count - 1)
                        endIndex = data.Count - 1;

                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        sumString += data[i];
                    }

                    data.RemoveRange(startIndex, endIndex - startIndex + 1);
                    data.Insert(startIndex, sumString);
                }
                else if (commands[0] == "divide")
                {
                    int index = int.Parse(commands[1]);
                    int partitionsCount = int.Parse(commands[2]);
                    List<string> resultByDividing = DivideElement(data[index], partitionsCount);
                    data.RemoveAt(index);
                    data.InsertRange(index, resultByDividing);
                }

                commandLine = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", data));
        }

        private static List<string> DivideElement(string word, int divide)
        {
            int partitionLength = word.Length / divide;
            List<string> resultByDividing = new List<string>();            
            for (int i = 0; i < divide; i++)
            {
                string element = word.Substring(0, partitionLength);
                resultByDividing.Add(element);
                word = word.Substring(partitionLength);
            }

            resultByDividing[resultByDividing.Count - 1] += word;

            return resultByDividing;            
        }
    }
}
