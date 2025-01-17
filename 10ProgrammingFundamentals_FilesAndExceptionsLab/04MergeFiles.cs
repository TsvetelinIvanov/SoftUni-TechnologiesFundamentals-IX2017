using System;
using System.IO;

namespace _04MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstFileLines = File.ReadAllLines("input1.txt");
            string[] secondFileLines = File.ReadAllLines("input2.txt");
            
            string text = string.Empty;
            for (int i = 0; i < Math.Min(firstFileLines.Length, secondFileLines.Length); i++)
            {
               text += firstFileLines[i] + Environment.NewLine;
               text += secondFileLines[i] + Environment.NewLine;
            }

            for (int i = Math.Min(firstFileLines.Length, secondFileLines.Length); i < Math.Max(firstFileLines.Length, secondFileLines.Length); i++)
            {
                if (firstFileLines.Length > secondFileLines.Length)
                {
                    text += firstFileLines[i] + Environment.NewLine;
                }
                else
                {
                    text += secondFileLines[i] + Environment.NewLine;
                }
            }

            File.WriteAllText("output.txt", text);
        }
    }
}
