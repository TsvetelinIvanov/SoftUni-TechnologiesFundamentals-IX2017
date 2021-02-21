using System;
using System.IO;

namespace _01OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("lines.txt");
            File.Delete("odd-lines.txt");
            for (int i = 1; i < lines.Length; i += 2)
            {
                File.AppendAllText("odd-lines.txt", lines[i] + Environment.NewLine);
            }
        }
    }
}
