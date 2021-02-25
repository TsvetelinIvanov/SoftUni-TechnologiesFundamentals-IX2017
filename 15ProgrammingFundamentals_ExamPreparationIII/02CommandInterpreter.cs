using System;
using System.Collections.Generic;
using System.Linq;

namespace _02CommandInterpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] inputs = input.Split(' ');
                if (inputs[0] == "reverse")
                {
                    bool isParsedStart = int.TryParse(inputs[2], out int start);
                    bool isParsedCount = int.TryParse(inputs[4], out int count);
                    if (!isParsedStart || !isParsedCount || count < 0 || count > items.Count - start || start < 0 || start >= items.Count)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        input = Console.ReadLine();
                        continue;
                    }

                    List<string> reversed = items.Skip(start).Take(count).Reverse().ToList();
                    items.RemoveRange(start, count);
                    items.InsertRange(start, reversed);
                }
                else if (inputs[0] == "sort")
                {
                    bool isParsedStart = int.TryParse(inputs[2], out int start);
                    bool isParsedCount = int.TryParse(inputs[4], out int count);
                    if (!isParsedStart || !isParsedCount || count < 0 || count > items.Count - start || start < 0 || start >= items.Count)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        input = Console.ReadLine();
                        continue;
                    }

                    List<string> sorted = items.Skip(start).Take(count).OrderBy(x => x).ToList();
                    items.RemoveRange(start, count);
                    items.InsertRange(start, sorted);
                }
                else if (inputs[0] == "rollLeft")
                {
                    bool isParsedCount = int.TryParse(inputs[1], out int count);
                    if (!isParsedCount || count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        input = Console.ReadLine();
                        continue;
                    }

                    for (int i = 0; i < count % items.Count; i++)
                    {
                        string element = items[0];
                        items.RemoveAt(0);
                        items.Add(element);
                    }
                }
                else if (inputs[0] == "rollRight")
                {
                    bool isParsedCount = int.TryParse(inputs[1], out int count);
                    if (!isParsedCount || count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        input = Console.ReadLine();
                        continue;
                    }

                    for (int i = 0; i < count % items.Count; i++)
                    {
                        string element = items[items.Count - 1];
                        items.RemoveAt(items.Count - 1);
                        items.Insert(0, element);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("[" + string.Join(", ", items) + "]");
        }
    }
}
