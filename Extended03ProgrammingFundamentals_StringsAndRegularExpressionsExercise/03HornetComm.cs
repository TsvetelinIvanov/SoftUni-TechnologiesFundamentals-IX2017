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

            string query = Console.ReadLine();
            while (query != "Hornet is Green")
            {
                if (Regex.IsMatch(query, messagePattern))
                {
                    Match match = Regex.Match(query, messagePattern);
                    string recipient = match.Groups[1].Value;
                    recipient = Reverse(recipient);
                    string message = match.Groups[2].Value;
                    
                    string privateMessage = recipient + " -> " + message;
                    messages.Add(privateMessage);
                }
                else if (Regex.IsMatch(query, broadcastPattern))
                {
                    Match match = Regex.Match(query, broadcastPattern);
                    string frequency = match.Groups[2].Value;
                    frequency = SwapCapitalAndSmallLetters(frequency);
                    string message = match.Groups[1].Value;
                    
                    string broadcast = frequency + " -> " + message;
                    broadcasts.Add(broadcast);
                }                

                query = Console.ReadLine();
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
            char[] recipientCharacters = recipient.ToCharArray();
            Array.Reverse(recipientCharacters);
            recipient = new String(recipientCharacters);

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
