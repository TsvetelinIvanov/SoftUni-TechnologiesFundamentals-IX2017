using System;
using System.Collections.Generic;
using System.Linq;

namespace _05ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();            
            string[] commandLine = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();            
            string command = commandLine[0];
            while (command != "print")
            {
                if (command == "add")
                {
                    int index = int.Parse(commandLine[1]);
                    string value = commandLine[2];
                    list.Insert(index, value);
                }

                if (command == "addMany")
                {
                    int index = int.Parse(commandLine[1]);
                    IEnumerable<string> elements = commandLine.Skip(2);
                    list.InsertRange(index, elements);
                }

                if (command == "contains")
                {
                    string value = commandLine[1];
                    int index = list.IndexOf(value);
                    Console.WriteLine(index);
                }

                if (command == "remove")
                {
                    int index = int.Parse(commandLine[1]);
                    list.RemoveAt(index);
                }

                if (command == "shift")
                {
                    int shiftsCount = int.Parse(commandLine[1]);
                    for (int i = 0; i < shiftsCount; i++)
                    {
                        string old = list[0];
                        list.RemoveAt(0);
                        list.Add(old);
                    }
                }

                if (command == "sumPairs")
                {
                    for (int i = 0; i < list.Count - 1; i++)
                    {
                        list[i] = (int.Parse(list[i]) + int.Parse(list[i + 1])).ToString();
                        list.RemoveAt(i + 1);
                    }
                }

                commandLine = Console.ReadLine().Split(' ').ToArray();
                command = commandLine[0];
            }

            Console.WriteLine("[" + string.Join(", ", list) + "]");
        }
    }
}
