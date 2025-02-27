using System;
using System.Text.RegularExpressions;

namespace Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            string bojoPattern = @"([A-Za-z]+\-[A-Za-z]+)";
            string didiPattern = @"([^A-Za-z-]+)";
            
            string input = Console.ReadLine();
            while (true)
            {                
                Match didiMatch = Regex.Match(input, didiPattern);
                if (didiMatch.Success)
                {
                    Console.WriteLine(didiMatch.Value);
                    input = input.Substring(input.IndexOf(didiMatch.Value) + didiMatch.Value.Length);
                }
                else
                {
                    break;
                }

                Match bojoMatch = Regex.Match(input, bojoPattern);
                if (bojoMatch.Success)
                {
                    Console.WriteLine(bojoMatch.Value);
                    input = input.Substring(input.IndexOf(bojoMatch.Value) + bojoMatch.Value.Length);
                }
                else
                {
                    break;
                }

                //If we wish to remove the match and remain the remainder before the match:
                //Match didiMatch = Regex.Match(input, didiPattern);
                //if (didiMatch.Success)
                //{
                //    Console.WriteLine(didiMatch.Value);
                //    input = input.Remove(input.IndexOf(didiMatch.Value), didiMatch.Value.Length);
                //}
                //else
                //{
                //    break;
                //}

                //Match bojoMatch = Regex.Match(input, bojoPattern);
                //if (bojoMatch.Success)
                //{
                //    Console.WriteLine(bojoMatch.Value);
                //    input = input.Remove(input.IndexOf(bojoMatch.Value), bojoMatch.Value.Length);
                //}
                //else
                //{
                //    break;
                //}
            }
        }
    }
}
