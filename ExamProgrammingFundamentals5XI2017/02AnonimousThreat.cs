using System;
using System.Collections.Generic;
using System.Linq;

namespace _02AnonimousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> data = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();            
            string commandLine = Console.ReadLine();
            while (commandLine != "3:1")
            {
                string[] commandData = commandLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (commandData[0] == "merge")
                {
                    int startIndex = int.Parse(commandData[1]);
                    int endIndex = int.Parse(commandData[2]);
                    string dataForMerge = string.Empty;
                    if (startIndex < 0 || startIndex > data.Count - 1)
                    {
                        startIndex = 0;
                    }

                    if (endIndex < 0 || endIndex > data.Count - 1)
                    {
                        endIndex = data.Count - 1;
                    }

                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        dataForMerge += data[i];
                    }

                    data.RemoveRange(startIndex, endIndex - startIndex + 1);
                    data.Insert(startIndex, dataForMerge);
                }
                else if (commandData[0] == "divide")
                {
                    int index = int.Parse(commandData[1]);
                    int partitionsCount = int.Parse(commandData[2]);
                    List<string> elementPartitions = DivideElement(data[index], partitionsCount);
                    
                    data.RemoveAt(index);
                    data.InsertRange(index, elementPartitions);
                }

                commandLine = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", data));
        }

        private static List<string> DivideElement(string word, int divisor)
        {
            int partitionLength = word.Length / divisor;
            List<string> resultByDividing = new List<string>();            
            for (int i = 0; i < divisor; i++)
            {
                string partition = word.Substring(0, partitionLength);
                resultByDividing.Add(partition);
                word = word.Substring(partitionLength);
            }

            resultByDividing[resultByDividing.Count - 1] += word;

            return resultByDividing;            
        }
    }
}
