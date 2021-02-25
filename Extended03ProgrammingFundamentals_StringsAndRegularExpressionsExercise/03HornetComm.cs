using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _03HornetComm
{
    class Program
    {
        static void Main(string[] args)
        {
            string messagePattern = @"^(\d+) <-> ([a-zA-Z0-9]+)$";
            string broadcastPattern = @"^([^0-9]+) <-> ([a-zA-Z0-9]+)$";
            List<string> messages = new List<string>();
            List<string> broadcasts = new List<string>();

            string queries = Console.ReadLine();
            while (queries != "Hornet is Green")
            {
                if (Regex.IsMatch(queries, messagePattern))
                {
                    Match match = Regex.Match(queries, messagePattern);
                    string recipient = match.Groups[1].Value;
                    recipient = Reverse(recipient);
                    string message = match.Groups[2].Value;
                    string privateMessage = recipient + " -> " + message;
                    messages.Add(privateMessage);
                }
                else if (Regex.IsMatch(queries, broadcastPattern))
                {
                    Match match = Regex.Match(queries, broadcastPattern);
                    string frequency = match.Groups[2].Value;
                    frequency = SwapCapitalAndSmallLetters(frequency);
                    string message = match.Groups[1].Value;
                    string broadcast = frequency + " -> " + message;
                    broadcasts.Add(broadcast);
                }                

                queries = Console.ReadLine();
            }            
            
            Console.WriteLine("Broadcasts:");
            if (broadcasts.Count != 0)
            {
                Console.WriteLine(string.Join($"{Environment.NewLine}", broadcasts));
            }
            else
            {
                Console.WriteLine("None");
            }

            Console.WriteLine("Messages:");
            if (messages.Count != 0)
            {
                Console.WriteLine(string.Join($"{Environment.NewLine}", messages));
            }
            else
            {
                Console.WriteLine("None");
            }
        }

        private static string Reverse(string recipient)
        {
            char[] recipientChar = recipient.ToCharArray();
            Array.Reverse(recipientChar);
            recipient = new String(recipientChar);

            return recipient;
        }

        private static string SwapCapitalAndSmallLetters(string word)
        {
            StringBuilder swaped = new StringBuilder();
            foreach (char letter in word)
            {
                if (Regex.IsMatch(letter.ToString(), "[A-Z]"))
                {
                    swaped.Append((char)(letter + 32));
                }
                else if (Regex.IsMatch(letter.ToString(), "[a-z]"))
                {
                    swaped.Append((char)(letter - 32));
                }
                else
                {
                    swaped.Append(letter);
                }
            }

            return swaped.ToString();
        }
    }
}
